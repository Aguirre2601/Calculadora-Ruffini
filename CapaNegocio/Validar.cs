using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Validar
    {
        string PolinomioCadena;
        string valores = "x-+^,0123456789"; //valores permitidos 

        public string PoliValida //propiedad
        {
           //  get { return this.PolinomioCadena; }
             set { this.PolinomioCadena = value; }
        }
        /*Una función pública: ValidarAlgo, donde será llamada desde la capa diseño para realizar 
        todas las verificaciones que correspondan, devuelve una lista de errores surgidos, esta 
        lista estará vacía si no surgió ningún error.*/

        public List<Error> ValidarAlgo() 
        {
           List<Error> Lista = new List<Error>(); //lista de la clase Error, que nosotros creamos
           if (PolinomioCadena.Length == 0)
           {
               Error e = new Error();
               e.Control = "txtPolinomio";
               e.Mensaje = "Debe Ingresar un Polinomio.";
               Lista.Add(e);
           }
           else if (!SoloPermitidos(PolinomioCadena.ToLower())) // .ToLower vuelve a la cadena string en todo minuscula
           {
               Error e = new Error();
               e.Control = "txtPolinomio";
               e.Mensaje = "Letras y/o signos no validos.";
               Lista.Add(e);
           }
           else if (!NoRepetido(PolinomioCadena))
           {
               Error e = new Error();
               e.Control = "txtPolinomio";
               e.Mensaje = "Valores repetidos no permitidos.";
               Lista.Add(e);
           }
           else if (!puntos(PolinomioCadena))
           {
               Error e = new Error();
               e.Control = "txtPolinomio";
               e.Mensaje = "Polinomio no valido. Puntos en exceso.";
               Lista.Add(e);
           }
           else if (!Errores(PolinomioCadena))
           {
               Error e = new Error();
               e.Control = "txtPolinomio";
               e.Mensaje = "Fromato de Polinomio no valido.";
               Lista.Add(e);
           }
            return Lista;
         }


        private bool SoloPermitidos(string Cadena) 
         {
           bool OK = true;
           for (int i = 0; i < Cadena.Length; i++)
              {
                if (valores.IndexOf(Cadena[i]) == -1)// se utiliza para verificar si un carácter específico no está presente en una cadena. 
                OK = false;//Si el valor es -1, significa que el carácter Cadena[i] no se encuentra en la cadena Valores.
              }
           return OK;
         }

        private bool NoRepetido(string Cadena)
        {
            bool OK = true;
            if (Cadena.Contains(",,")) OK = false;
            else if (Cadena.Contains("//")) OK = false;
            else if (Cadena.Contains("^^")) OK = false;
            else if (Cadena.Contains("++")) OK = false;
            else if (Cadena.Contains("--")) OK = false;
            else if (Cadena.Contains("xx")) OK = false;
            return OK;
        }

        private bool puntos(string Cadena) //para que no pueda poner 1.0.2 en un mismo numero
        {
            bool OK=true;
            char[] delimitadores = { '+', '-', 'x', '^' };
            // Dividir la cadena usando los delimitadores
            string[] partes = Cadena.Split(delimitadores);
            List <string> valores = new List<string>();
            foreach (string parte in partes)
            {   // Agregar solo las subcadenas no vacías a la lista
                if (!string.IsNullOrWhiteSpace(parte)) valores.Add(parte);
            }
            foreach (string valor in valores)
            { //Count es un método de extensión de LINQ que se usa para contar
              //los elementos de una secuencia que cumplen una condición especificada.
                int cantidadDePuntos = valor.Count(c => c == ','); 
                //Es una expresión lambda que define una función anónima. Aquí, c representa cada 
                //carácter en la cadena valor, y la expresión lambda devuelve true si el carácter 
                //es un punto ('.'), y false en caso contrario.
                if (cantidadDePuntos >= 2) OK=false; //la cadena tiene mas de dos puntos 
            }
            return OK;
        }

        private bool Errores(string Cadena)
        {
            bool OK = true;
            List<string> subcadena = new List<string> { "x,", "-,", "+,", "^,", "/,", ",x", ",-", ",+", ",^", ",/", "x1", "x2", "x3", "x4", "x5", "x6", "x7", "x8", "x9", "x0"};
            foreach (string cadenita in subcadena)
            {
                if (Cadena.Contains(cadenita)) OK = false;
            }
            return OK;
        }


    }
}
