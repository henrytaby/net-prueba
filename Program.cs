using Prueba.Entidades;

namespace Prueba
{
    class Program{
        static void Main(string[] args)
        {
            var u = new Universidad("Universidad UCATEC");

            var materia1 = new Materia("100","Lenguajes de Programación");
            var materia2 = new Materia("101","Auditoria de Sistemas");

            u.Materias = new Materia[]{materia1,materia2};
            
            Console.WriteLine("Universidad: "+ u.Nombre);
            Console.WriteLine(u.ToString());
            Console.WriteLine(materia1);
            Console.WriteLine(u.Materias.Length);


            foreach(Materia mat in u.Materias)
            {
                Console.WriteLine($"Codigo: {mat.Codigo} - {mat.Nombre} ");
            }

            //-------------------
            // Creación de materia
            //-------------------
            
            //var M = new Materia("100","Programación I");
            //Console.WriteLine("Materia "+ M.nombre);
        }
    }
}