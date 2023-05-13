using System.Drawing;

namespace ABB.Model
{
    //Clase para la vista de un Nodo
    internal class NodoViewModel
    {
        public string Text { get; set; }
        public Size Size { get => new Size(40, 40); }
        public Point Point { get; set; }

        public NodoViewModel(string text, Point point)
        {
            Text = text;
            Point = point;
        }
    }
}
