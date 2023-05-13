namespace ABB
{
    internal class Nodo
    {
        public int Dato { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(int item)
        {
            Dato = item;
            Izquierda = Derecha = null;
        }
    }
}
