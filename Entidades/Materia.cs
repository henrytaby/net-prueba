namespace Prueba.Entidades
{
    class Materia
    {
        public string Codigo{ get; set;}
        public string Nombre{ get; set;}
        public Materia(string codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }
    }
}