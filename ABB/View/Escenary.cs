using ABB.Controller;
using ABB.Model;
using ABB.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABB.View
{
    public partial class Escenary : Form
    {
        private readonly Form formAnterior;
        private readonly ArbolBinarioController arbolController;
        public Escenary(Form form, Escenario escenario)
        {
            InitializeComponent();
            formAnterior = form;
            arbolController = new ArbolBinarioController();
            ConfiguraEscenario(escenario);
        }

        private void Escenary_Load(object sender, EventArgs e)
        {
            labelR.Visible = false;
            labelRecorrido.Visible = false;
        }

        //Metodo que configura el escenario y los datos de acuero a lo recibido por parametro
        void ConfiguraEscenario(Escenario escenario)
        {
            switch (escenario)
            {
                case Escenario.ESCENARIO_UNO:
                    arbolController.CreateArbol(new List<int> {
            55,53,59,48,54,51,56,63,57,61,70
            });
                    labelEscenario.Text = "Escenario Uno";
                    break;
                case Escenario.ESCENARIO_DOS:
                    arbolController.CreateArbol(new List<int> {
            18,9,25,7,12,2,8,11,23,29,21,24,31
            });
                    labelEscenario.Text = "Escenario Dos";
                    break;
                default:
                    break;
            }
        }

        void ArbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowArbol();
        }
        void ShowArbol()
        {
            //Creacion del Graphics para el control
            Graphics graphics = panelGrafica.CreateGraphics();
            //Limpieza del control
            graphics.Clear(panelGrafica.BackColor);
            //Tupla para el arbol
            Tuple<List<NodoViewModel>, List<Tuple<Point, Point>>> arbol = arbolController.GetArbol(panelGrafica);
            //Lista de nodos
            List<NodoViewModel> nodos = arbol.Item1;
            //Lista de conectores
            List<Tuple<Point, Point>> conectores = arbol.Item2;
            ShowNodosViewModel(graphics, nodos);
            ShowConectores(graphics, new Pen(Color.BlueViolet, 3), conectores);

        }

        //Metodo para mostrar conectores
        void ShowConectores(Graphics graphics, Pen pen, List<Tuple<Point, Point>> conectoresList)
        {
            try
            {
                //Recorrido de la lista de conectores
                foreach (var conector in conectoresList)
                {
                    //Dibuja el conector
                    graphics.DrawLine(pen, conector.Item1, conector.Item2);
                }
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Error al mostrar conectores {ex}");
            }
        }

        //Metodo para mostrar Nodos
        void ShowNodosViewModel(Graphics graphics, List<NodoViewModel> nodoViewModelList)
        {
            try
            {
                //Recorrido de la lista de Nodos
                foreach (NodoViewModel nodo in nodoViewModelList)
                {
                    PintaNodo(graphics, panelGrafica.Font, nodo);
                }
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Error al mostrar nodos {ex}");
            }
        }

        //Metodo para dibujar un Nodo
        void PintaNodo(Graphics graphics, Font font, NodoViewModel nodo)
        {
            //Coordenadas del nodo
            int x = nodo.Point.X;
            int y = nodo.Point.Y;
            //Tamaño del nodo
            int w = nodo.Size.Width;
            int h = nodo.Size.Height;
            //Creacion del rectangulo que representa el nodo
            RectangleF nodoRec = new RectangleF(x, y, w, h);
            //Pinta la Elipse
            graphics.FillEllipse(Brushes.LightGreen, nodoRec);
            //Dibuja el Valor del nodo
            graphics.DrawString(nodo.Text, font, Brushes.Black, x + 4, y + 6);
            //Dibuja el borde
            graphics.DrawEllipse(new Pen(Color.DarkRed, 3), nodoRec);
        }

        //Metodo para mostrar el recorrido recibe el tipo de recorrido
        void ShowRecorrido(TipoRecorrido tipoRecorrido){
            try
            {
                //Creacion del graphics para el control
                Graphics graphics = panelRecorrido.CreateGraphics();
                //Limpieza del panel
                graphics.Clear(panelRecorrido.BackColor);
                List<int> listaNodos = null;
                //Validacion del tipo de recorrido para mostrar el texto y los nodos en el orden especificado
                switch (tipoRecorrido)
                {
                    case TipoRecorrido.PRE_ORDEN:
                        listaNodos = arbolController.RecArbol(TipoRecorrido.PRE_ORDEN);
                        labelRecorrido.Text = "Pre-Orden";
                        break;
                    case TipoRecorrido.IN_ORDEN:
                        listaNodos = arbolController.RecArbol(TipoRecorrido.IN_ORDEN);
                        labelRecorrido.Text = "In-Orden";
                        break;
                    case TipoRecorrido.POST_ORDEN:
                        listaNodos = arbolController.RecArbol(TipoRecorrido.POST_ORDEN);
                        labelRecorrido.Text = "Post-Orden";
                        break;
                    default:
                        break;
                }
                if (listaNodos != null)
                {
                    //Asignacion de las coordenadas iniciales
                    Point posicionInicial = new Point(-40, panelRecorrido.Size.Height - 45);
                    //Recorrido de la lista con los valores de los nodos
                    foreach (int valor in listaNodos)
                    {
                        //Pintado del nodo
                        PintaNodo(graphics,
                            panelRecorrido.Font,
                            new NodoViewModel(valor.ToString(), new Point(posicionInicial.X + 60, posicionInicial.Y)));
                        //Aumento de las coordenadas en el eje x para el prosimo nodo
                        posicionInicial.X += 60;
                    }
                    //Visibilizacion de las etiquetas del tipo de recorrido
                    labelR.Visible = true;
                    labelRecorrido.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Ha ocurrido un error al mostrar el recorrido {ex}");
            }
        }

        void PreOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRecorrido(TipoRecorrido.PRE_ORDEN);
        }

        private void InOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRecorrido(TipoRecorrido.IN_ORDEN);
        }

        void PostOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRecorrido(TipoRecorrido.POST_ORDEN);
        }

        void RegresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir",
                               "¡Advertencia!",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Dispose();
                formAnterior.Show();
            }
        }
    }
}
