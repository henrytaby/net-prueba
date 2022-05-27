namespace Prueba.Entidades
{
    class Estudiante
    {
        public string Id{ get; set;}
        public string Nombres{ get; set;}
        public string Apellidos{ get; set;}
        public Estudiante(string Id,string Nombres, string Apellidos)
        {
            this.Id = Id;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
        }
    }
}