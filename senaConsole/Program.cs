using senaConsole.Hotel;

namespace senaConsole
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            CasoHotel.CalculosHotel();
        }

        public static void Listas() //************************ listas ***************************
        {
            string[] nombres = { "Ana", "Maria", "Jose", "Andres" };
            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre.ToUpper());
            }
        }

        public static void LlenarListas() //************************ llenar listas ***************************
        {
            // ************************ lista string ***************************
            List<string> apellidos = new List<string>();
            //la calse  objeto       crea   constructor

            // ************************ llenar lista *****************************
            apellidos.Capacity = 5; // caracteristicas , en programacion propiedad o
                                    // atributo "no tiene ()" cumplen la funcion de una variabe , se le puede asignar un valor

            // ***************************************** Diferencia ****************************************

            //apellidos.Add(); ************** // acciones en programacion , metodos o funciones tiene "()"
            apellidos.Add("Sanchez");
            apellidos.Add("Chalarca");
            apellidos.Add("Rodrigues");

            foreach (var apellido in apellidos)
            {
                Console.WriteLine(apellido);
            }
            //************************ lista int ***************************
            List<int> anios = new List<int>();
            //la calse  objeto  crea   constructor 

            anios.Capacity = 5;
            anios.Add(2021);
            anios.Add(2022);
            anios.Add(2023);
            anios.Add(2024);

            foreach (var anio in anios)
            {

                Console.WriteLine(anio);
            }
        }

        public static void Diccionario() //************************ diccionario ***************************
        {
            // Diccionario sintaxis
            /* Dictionary<tipo de dato key , value > nombre_diccionario = new Dictionary <tipo datp key , value> ()*/
            //{
            //    { "key " , "value "},
            //    { "key " , "value "},
            //    { "key " , "value "},
            //    { "key " , "value "}
            //};
            Dictionary<int, string> frutas = new Dictionary<int, string>()
            {
                { 1, "cebolla"},
                { 2, "mango"},
                { 3, "mamoncillo"},
                { 4, "recogete"},
            };
            foreach (var fruta in frutas)
            {
                Console.WriteLine($"{fruta.Key} = {fruta.Value}");
            }
        }
        public static void RegistroProductos() // aplicamos todo lo aprendido en este ejemplo 
        {
            Dictionary<string, double> gastos = new Dictionary<string, double>();

            Console.WriteLine("digite el nombre del producto : ");
            string nombreGasto = Console.ReadLine() ?? "";

            while (nombreGasto != "*")
            {
                Console.WriteLine("Digite el valor del producto : ");
                double gasto = Convert.ToDouble(Console.ReadLine());

                gastos.Add(nombreGasto, gasto);

                Console.WriteLine("digite el nombre del producto o (*) para salir : ");
                nombreGasto = Console.ReadLine() ?? "";

            }
            

            foreach (var producto in gastos)
            {
                Console.WriteLine(producto);
            }

            double maximo = gastos.Values.Max();
            double minimo = gastos.Values.Min();
            double promedio = gastos.Values.Average();
            double suma = gastos.Values.Sum();

            Console.WriteLine("****************************************************");
            Console.WriteLine($"Total:  {suma}");
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Mínimo:  {minimo}");
            Console.WriteLine($"Promedio: {promedio:F2}");

            
        }
    }
}
