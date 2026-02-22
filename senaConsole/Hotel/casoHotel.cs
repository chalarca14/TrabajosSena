using System.Numerics;

namespace senaConsole.Hotel
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
    }

    internal class CasoHotel
    {
        public static void CalculosHotel()
        {
            double individual = 2500;
            double doble = 4600;
            double familiar = 5200;
            double iva = 0.16;
            double totalPagar = 0;
            double ganancias = 0;
            double ivaG = 0;

            Console.WriteLine("************** Bienbenidos al Hotel Chalarca **************\n");

            Console.Write("Cuantas personas se van a hospedar: ");
            int huespedes = int.TryParse(Console.ReadLine(), out huespedes) && huespedes > 0 ? huespedes : 1;


            while (huespedes > 0)
            {
            List<Persona> personas = new List<Persona>();
                for (int i = 0; i < huespedes; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Persona # {i + 1}");
                    Persona nuevaPersona = new Persona();
                    Console.Write("Nombre: ");
                    nuevaPersona.Nombre = Console.ReadLine() ?? "";

                    Console.Write("Edad: ");
                    nuevaPersona.Edad = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Sexo (M/F): ");
                    nuevaPersona.Sexo = Console.ReadLine() ?? "";

                    // qui se agrega a la lista la persona 

                    personas.Add(nuevaPersona);


                }
                Console.Write("Cuantos dias se van a hospedar:  ");
                int dias = int.TryParse(Console.ReadLine(), out dias) && dias > 0 ? dias : 1;


                double tarifa;
                double descuento;

                if (huespedes >= 3)
                {
                    tarifa = familiar;
                    descuento = 0.15;
                }
                else if (huespedes >= 2)
                {
                    tarifa = doble;
                    descuento = 0.09;
                }
                else
                {
                    tarifa = individual;
                    descuento = 0.05;
                }

                double total = dias * tarifa;
                double totalConIva = total * iva + total;
                totalPagar = totalConIva - (totalConIva * descuento);

                // Acumular en `ganancias` inmediatamente después de calcular `totalPagar`
                ganancias += totalPagar;
                ivaG += totalConIva - total;

                // Mostrar datos
                Console.WriteLine("\n--- LISTA DE PERSONAS ---");

                int contador = 1;
                foreach (var persona in personas)
                {
                    Console.WriteLine($"\n" +
                        $"Persona # {contador}\n" +
                        $"Nombre: {persona.Nombre}\n" +
                        $"Edad: {persona.Edad}\n" +
                        $"Sexo: {persona.Sexo}");
                    contador++;
                }


                Console.WriteLine("\n********************* Tarifas *********************");

                Console.WriteLine($"\nSu precio sin iva es de {total}\n" +
                $"su total con iva es {totalConIva} \n" +
                $"y su total a pagar es de {totalPagar}");
                Console.WriteLine("\n********************* Fin *********************\n");

                Console.Write("Digite cuantas personas se van a hospedar o presione 0 para salir\n");

                Console.Write("Cuantas personas se van a hospedar: ");
                if (!int.TryParse(Console.ReadLine(), out huespedes) || huespedes == 0)
                    break;
            }

            // Ahora `ganancias` contiene la suma de todos los `totalPagar` acumulados
            // Puede mostrarse o usarse según sea necesario:
            Console.WriteLine($"\nGanancias acumuladas: {ganancias}");
            Console.WriteLine($"el total de iva a entregar {ivaG}");
        }
    }

}
