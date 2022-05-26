namespace Prueba.Entidades
{
    class Universidad
    {
        public string Nombre {get;set;}
        public string Pais {get;set;}
        public string Ciudad {get;set;}

        public Materia[] Materias {get;set;}

        
        public Universidad(string nombre)
        {
            this.Nombre = nombre;
            this.Pais = "Bolivia";
            this.Ciudad = "Cochabmba";

            //this.Materia[0] = new Materia("100","Programación I");
        }

        public override string ToString(){
            return $"Nombre: {Nombre} \n Pais: {Pais}";
        }
    }
}