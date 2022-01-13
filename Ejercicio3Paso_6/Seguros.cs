using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3Paso_6
{
    class Seguros
    {
        private int edad;
        private string nombre;
        private int genero;
        private int registro;
        private int totalAccidente;
        private int menorAccid;
        private int año;
        private double menoresMas;
        private int femenino;
        private int masculino;
        private int totalZona;
        private int totalMas;

        public void TotalZona() //metodo para verificar donde esta registrado el carro
        {
            if (registro == 2)
            {
                totalZona += 1;
            }
        }

        public int getTotalZona()
        {
            return totalZona;
        }

        public void TotalGenero() // metodo para saber si el genero es masculino o femenino 
        {
            if (genero == 2)
            {
                masculino += 1;
            }
            if (genero == 1)
            {
                femenino += 1;
            }
            if (genero == 1 || genero == 2)
            {
                totalAccidente = totalAccidente + 1; // contador pasa saber el total de accidentes registrados
            }
            if (genero == 2) 
            {
                totalMas = totalMas + 1; // contador de personas accidentadas del genero masculino
            }
        }

        public void CalcularMenorM() // metodo para calcular el porcentaje de conductores masculinos entre 12 y 30 años
        {
            if ((genero == 2) && (edad >= 12  && edad <= 30))
            {
                menoresMas += 1;
            }
        }

        public void Calcularmenor30() // metodo para calcular el porcentaje de conductores menores de 30 años
        {
            if (edad < 30)
            {
                menorAccid += 1;
            }
        }
        // se cran metodos get para que me retornen los resultados de los contadores creados anteriormente
        public double getMenoresMas()
        {
            return menoresMas;
        }
        public int getMenorAccid()
        {
            return menorAccid;
        }
         public int getTotalAccidente()
        {
            return totalAccidente;
        }  
        public int getFemenino()
        {
            return femenino;
        }
        public int getMasculino()
        {
            return masculino;
        }
        public int getTotalMas()
        {
            return totalMas;
        }

        // se crean los get y los set 
        public void setGenero(int g)
        {
            genero = g;
        }
        public int getGenero()
        {
            return genero;
        }
        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setRegistro(int r)
        {
            registro = r;
        }
        public int getRegistro()
        {
            return registro;
        }

        public void setAño(int a)
        {
            año = a;
        }
        public int getAño()
        {
            return año;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }
        public string getNombre()
        {
            return nombre;
        }

        public int CalcularEdad(int año) // metodo para calcular la edad mediante el año ingresado
        {
            edad = DateTime.Today.Year - año; // obtiene la fecha actual y resta el año de nacimineto 
            return edad;
        }
    }
}
