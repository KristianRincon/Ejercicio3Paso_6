//Nombre del Estudiante: Kristian Rincón
//Grupo: 213022_102
//Programa: Ingeniereia de Sistemas
//Problema seleccionado: Problema 3
//Codigo Fuente: autoria propia
//Los metodos creados fueron TotalZona; TotalGenero; CalculoMenorM; CalculoMenor30; CalcularEdad y los metodos get y set 
//Las estructuras de repeticion creadas son un ciclo for y el ciclo do while -- Las estructuras de control creadas fueron los condicionales if
using System;

/*Problema 3: Una oficina de seguros ha reunido datos concernientes a todoslos accidentes de tránsito ocurridos en el área metropolitana 
de Bogotá en el último año. Por cada conductor involucrado en un accidente se toman los siguientes datos: año de nacimiento, 
sexo (1: Femenino, 2: Masculino) y registro del carro (1: Bogotá, 2: Otras ciudades). Desarrollar una solución básica de programación que calcule:

• El porcentaje de conductores menores de 30 años.
• Porcentaje de conductores del sexo masculino y femenino.
• Porcentaje de conductores masculinos con edades entre 12 y 30 años.
• Porcentaje de conductores cuyos carros están registrados fuera de Bogotá.*/

namespace Ejercicio3Paso_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Seguros mi_Seguros = new Seguros(); // Declaración e instanciamiento de la clase

            Console.WriteLine("----------- BIENVENIDO A LA OFICINA DE SEGUROS ------------");
            string n;
            int a, e, r, g;
            Console.WriteLine("Ingrese la cantidad de involucrados en el accidente");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= k; i++) // ciclo for para la cantidad de registros a ingresar
            {
                Console.WriteLine("Ingrese el nombre del implicado " + i);
                n = Console.ReadLine();
                mi_Seguros.setNombre(n);
                Console.WriteLine("Ingrese el año de nacimiento del implicado");
                a = Convert.ToInt32(Console.ReadLine());
                mi_Seguros.setAño(a); //mediante el set se envia el año a la clase
                e = mi_Seguros.CalcularEdad(mi_Seguros.getAño()); // con el get se obtiene el resultado de la edad
                Console.WriteLine("La edad de " + n + " es: " + e);
                mi_Seguros.setEdad(e);
                
                do // estructuras de repeticion do while para verificar que se ingresa una opcion valida en este caso 1 0 2
                { 
                        Console.WriteLine("Selecciona el Genero ");
                        Console.WriteLine("1 = Femenimo" + "\n" +
                        "2 = Masculino");
                        g = Convert.ToInt32(Console.ReadLine());
                    if (g != 1 && g != 2)
                    {
                        Console.WriteLine("Valor no valido");
                    }
                        mi_Seguros.setGenero(g);  // mediante el set se envia el valor del genero ingresado a la clase
                        mi_Seguros.TotalGenero(); // se invocan los metodos
                    mi_Seguros.Calcularmenor30(); 
                    mi_Seguros.CalcularMenorM();
                } while (g != 1 && g != 2);
                do
                {
                    Console.WriteLine("Seleccione el lugar de registro del vehiculo");
                    Console.WriteLine("1 = Bogota" + "\n" +
                        "2 = Otra Ciudad");
                    r = Convert.ToInt32(Console.ReadLine());
                    if (r != 1 && r != 2)
                    {
                        Console.WriteLine("Valor no valido");
                    }
                    mi_Seguros.setRegistro(r); //mediante el set se encia el valor de registro ingresado a la clase
                    mi_Seguros.TotalZona(); //se invoca el metodo TotalZona
                } while (r != 1 && r != 2);
                
            }           
            int Total = mi_Seguros.getTotalAccidente();
            Console.WriteLine("La cantidad de accidentes son: " + Total);
            int TotalMas = mi_Seguros.getTotalMas();

            // se calculan los porcentajes invocando el get de los cantadores creados en la clase
            double femenino = mi_Seguros.getFemenino();
            Console.WriteLine("EL porcentaje de genero femenino involucrado en el accidente es: " + ((femenino * 100)/Total) +"%");
            double masculino = mi_Seguros.getMasculino();
            Console.WriteLine("EL porcentaje de genero masculino involucrado en el accidente es: " + ((masculino * 100) / Total) + "%");
            double menores = mi_Seguros.getMenoresMas();
            Console.WriteLine("El porcentaje de masculinos entre los 12 y 30 años es " + ((menores * 100) / TotalMas) + "%");
            double menores30 = mi_Seguros.getMenorAccid();
            Console.WriteLine("El porcentaje de accidentados menores de 30 años es: " + ((menores30 * 100) / Total) + "%");
            int zona = mi_Seguros.getTotalZona();
            Console.WriteLine("El porcentaje de vehiculos accidentados y matriculados fuera de Bogota es: " + ((zona * 100) / Total) + "%");          
        }   
    }
}
