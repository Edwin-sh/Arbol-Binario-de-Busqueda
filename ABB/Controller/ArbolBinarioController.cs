using ABB.Model;
using ABB.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABB.Controller
{
    internal class ArbolBinarioController
    {
        private ArbolBinario arbolBinario;
        public ArbolBinarioController()
        {
            CreateArbol();
        }

        //Crea un arbol vacio
        private void CreateArbol()
        {
            arbolBinario = new ArbolBinario();
        }

        //Crea un arbol a partir de una lista de numeros
        public void CreateArbol(List<int> lista)
        {
            arbolBinario = new ArbolBinario();
            foreach (int i in lista)
            {
                InsertarNodo(i);
            }
        }

        //Inserta nuevo nodo con un numero
        public void InsertarNodo(int dato)
        {
            arbolBinario.Raiz = InsertarNodo(arbolBinario.Raiz, dato);
        }

        //Valida si el nuevo dato debe crear un raiz o insertarlo a la derecha o izquierda del nodo hijo
        Nodo InsertarNodo(Nodo raiz, int dato)
        {
            if (raiz == null)
            {
                raiz = new Nodo(dato);
                return raiz;
            }

            if (dato < raiz.Dato)
            {
                raiz.Izquierda = InsertarNodo(raiz.Izquierda, dato);
            }
            else if (dato > raiz.Dato)
            {
                raiz.Derecha = InsertarNodo(raiz.Derecha, dato);
            }
            return raiz;
        }

        //Recorre el arbol de acuerdo al tipo de recorrido
        public List<int> RecArbol(TipoRecorrido tipoRecorrido)
        {
            try
            {
                switch (tipoRecorrido)
                {
                    case TipoRecorrido.PRE_ORDEN:
                        return PreOrden(arbolBinario.Raiz);
                    case TipoRecorrido.IN_ORDEN:
                        return InOrden(arbolBinario.Raiz);
                    case TipoRecorrido.POST_ORDEN:
                        return PostOrden(arbolBinario.Raiz);
                    default:
                        return null;
                }

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Ocurrió un error al recorrer el arbol en Pre-Orden {ex}");
                return null;
            }
        }

        //Retorna lista con el recorrido PreOrden
        List<int> PreOrden(Nodo raiz)
        {
           List<int> lista = new List<int>();
            //Iterador para el nivel
            int iterador = 0;
            PreOrdenRec(raiz, lista, iterador);
            return lista;
        }
        void PreOrdenRec(Nodo raiz, List<int> lista, int nivel)
        {
            //Logica para recorrer en PreOrden
            if (raiz != null)
            {
                nivel++;
                lista.Add(raiz.Dato);
                PreOrdenRec(raiz.Izquierda, lista, nivel);
                PreOrdenRec(raiz.Derecha, lista, nivel);
            }
        }

        //Retorna lista con el recorrido InOrden
        List<int> InOrden(Nodo raiz)
        {
            List<int> lista = new List<int>();
            //Iterador para el nivel
            int iterador = 0;
            InOrdenRec(raiz, lista, iterador);
            return lista;
        }
        void InOrdenRec(Nodo raiz, List<int> lista, int nivel)
        {
            //Logica para recorrer InOrden
            if (raiz != null)
            {
                nivel++;
                InOrdenRec(raiz.Izquierda, lista, nivel);
                lista.Add(raiz.Dato);
                InOrdenRec(raiz.Derecha, lista, nivel);
            }
        }

        //Retorna lista con el recorrido PostOrden
        List<int> PostOrden(Nodo raiz)
        {
            List<int> lista = new List<int>();
            //Iterador para el nivel
            int iterador = 0;
            PostOrdenRec(raiz, lista, iterador);
            return lista;
        }
        void PostOrdenRec(Nodo raiz, List<int> lista, int nivel)
        {
            //Logica para recorrer en PostOrden
            if (raiz != null)
            {
                nivel++;
                PostOrdenRec(raiz.Izquierda, lista, nivel);
                PostOrdenRec(raiz.Derecha, lista, nivel);
                lista.Add(raiz.Dato);
            }
        }

        //Retorna una tupla con las listas de los nodos y los conectores
        public Tuple<List<NodoViewModel>, List<Tuple<Point, Point>>> GetArbol(Control control)
        {
            if (arbolBinario.Raiz != null)
            {
                int iterador = 0;
                //Crea el punto inicial en el centro del panel contenedor
                Point puntoInicial = new Point((control.Size.Width / 2) - 20, 0);
                List<NodoViewModel> nodoViewModelList = new List<NodoViewModel>();
                List<Tuple<Point, Point>> conectoresList = new List<Tuple<Point, Point>>();
                //Lama al metodo pasando los parametros
                CreateNodosViewModel(arbolBinario.Raiz, iterador, nodoViewModelList, control.Size.Width, puntoInicial, 0, conectoresList);
                return Tuple.Create(nodoViewModelList, conectoresList);
            }
            else
            {
                Utils.ShowErrorMessage("Arbol vacío");
                return null;
            }
        }

        void CreateNodosViewModel(Nodo raiz, int nivel, List<NodoViewModel> lista, int anchoControl, Point posicionInicial, int polariodad, List<Tuple<Point, Point>> conectoresList)
        {
            try
            {
                if (raiz != null)
                {
                    //Iteracion del nivel del Nodo
                    nivel++;
                    //Calculo de la diferencia respecto al centro del nodo en el eje x del nivel anterior
                    int diferencia = anchoControl / ((int)Math.Pow(2, nivel));
                    //Calculo de la posicion final de acuerdo al nivel, diferencia por respecto al centro anterior y si va a la derecha o izquierda
                    Point posicionFinal = new Point((posicionInicial.X) + (diferencia * polariodad), nivel == 1 ? 10 : (nivel * 75) - 40);
                    //Adicion del nodo a la lista
                    lista.Add(new NodoViewModel(raiz.Dato.ToString(), posicionFinal)
                        );
                    if (nivel > 1)
                    {
                        try
                        {
                            //Invocacion del metodo para crear conector de acuerdo a la posicion actual y la del nodo anterior
                            CreateConectores(
                           new Point(posicionFinal.X + 20, posicionFinal.Y - 2),
                           new Point(posicionInicial.X + 20, posicionInicial.Y + 42),
                           conectoresList);
                        }
                        catch (Exception ex)
                        {
                            Utils.ShowErrorMessage($"Error al crear conectores {ex}");
                        }
                       
                    }
                    //Logica para seguir recorriendo el arbol, en este caso en PreOrden
                    CreateNodosViewModel(raiz.Izquierda, nivel, lista, anchoControl, posicionFinal, -1, conectoresList);
                    CreateNodosViewModel(raiz.Derecha, nivel, lista, anchoControl, posicionFinal, 1, conectoresList);
                }
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Error al crear vista nodos {ex}");
            }
        }

        //Metodo para crear conectores y posicion
        void CreateConectores(Point inicio, Point final, List<Tuple<Point, Point>> conectoresList)
        {
            //Adicion del conector a la lista
            conectoresList.Add(Tuple.Create(inicio, final));
        }
    }

    //Clase enumerada para el tipo de recorrido
    public enum TipoRecorrido
    {
        PRE_ORDEN, IN_ORDEN, POST_ORDEN
    }
}
