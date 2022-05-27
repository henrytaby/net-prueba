namespace Prueba.Entidades
{
    class Docente
    {
        public string Id{ get; set;}
        public string NombreCompleto{ get; set;}
        public string Especialidad{ get; set;}
        public Docente(string Id,string NombreCompleto, string Especialidad)
        {
            this.Id = Id;
            this.NombreCompleto = NombreCompleto;
            this.Especialidad = Especialidad;
        }
    }
}