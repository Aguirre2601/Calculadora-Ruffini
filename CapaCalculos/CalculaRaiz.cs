using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaNegocio;


namespace CapaCalculos
{
    public class CalculaRaiz
    {
        string PolinomioCadena;
        List<string> numeros = new List<string>();
        List<double> ListRaices = new List<double>();
        double coef_expo5 =0;
        double coef_expo4 = 0;
        double coef_expo3 = 0;
        double coef_expo2 = 0;
        double coef_expo1 = 0;
        double coef_sin_expo = 0;


        public string  CalculaElPolinomio 
        {
            get { return this.PolinomioCadena; }
            set { this.PolinomioCadena = value;}
        }

        public List<double>  Calculador()
        {
            List<double> ListDivisores = new List<double>();
            List<double> ListCoeficientes= new List<double>(); 
            SepararTerminos();
            Coef_Expo(ListCoeficientes);
            var coeficientesActuales = new List<double>(ListCoeficientes);
            if (coef_expo3 != 0|| coef_expo4 !=0 || coef_expo5!=0)
            {
                if (coef_expo5 != 0)
                {
                    EncontrarDivisores(coef_sin_expo, coef_expo5, ref ListDivisores);
                    Calculadora(ref ListDivisores, ref coeficientesActuales);
                }
                else if (coef_expo4 != 0)
                {
                    EncontrarDivisores(coef_sin_expo, coef_expo4, ref ListDivisores);
                    Calculadora(ref ListDivisores, ref coeficientesActuales);
                }
                else if (coef_expo3 != 0)
                {
                    EncontrarDivisores(coef_sin_expo, coef_expo3, ref ListDivisores);
                    Calculadora(ref ListDivisores, ref coeficientesActuales);
                }
            }else if (coef_expo2 != 0) ResolverCuadratica(coef_expo2,coef_expo1,coef_sin_expo);
            else if (coef_expo1 != 0 && coef_sin_expo!=0 )  ListRaices.Add(-coef_sin_expo / coef_expo1); 
            else if (coef_expo1!=0 && coef_sin_expo==0)  ListRaices.Add(0);
            ListRaices = ListRaices.Distinct().ToList();
            RecortarDecimales(ref ListRaices);
            return (ListRaices);
        }   
        private void  SepararTerminos ()
        {
            string[] parteSinMas = PolinomioCadena.Split('+');
            foreach (string i in parteSinMas)
            {
                int comienzo = 0;
                while (comienzo < i.Length)
                {
                    int otroIndice = i.IndexOf('-', comienzo + 1);
                    if (otroIndice == -1)
                    {
                        numeros.Add(i.Substring(comienzo));
                        break;
                    }
                    numeros.Add(i.Substring(comienzo, otroIndice - comienzo));
                    comienzo = otroIndice;
                }
            }
        }

        private void RecortarDecimales(ref List<double> ListRaices)
        {
            for (int i = 0; i < ListRaices.Count; i++)
            {
                ListRaices[i] = Math.Round(ListRaices[i], 2);
            }
        }
    

        private double separar_coef_expo (string b, string expo)
         {
            int comienzo = 0;
            string subcadena = b.Substring(comienzo, b.IndexOf(expo));
            double coef = double.Parse(subcadena);
            return coef;
         }

       
        private void EncontrarDivisores(double coef_Sin_Expo, double coef_mayor_expo, ref List<double> ListDivisores)
        {
             if (coef_Sin_Expo == 0)
            {
                if (coef_mayor_expo.Equals(coef_expo3))
                {
                    ListRaices.Add(0);
                    ResolverCuadratica(coef_expo3,coef_expo2,coef_expo1);
                }
                else
                {
                    ListRaices.Add(0);
                    NroSinResto(coef_expo1, coef_mayor_expo, ref ListDivisores);
                }
            }
            else
            {
                NroSinResto(coef_Sin_Expo, coef_mayor_expo, ref ListDivisores);
            }
        }
        private void NroSinResto (double coef, double coef_mayor_expo, ref List<double> ListDivisores)
        {
            double TN = Math.Truncate(coef) / Math.Truncate(coef_mayor_expo);
            TN = Math.Abs(TN);
            for (int i = ((int)TN); i >= (TN * (-1)); i--)
            {
                if (i == 0) { continue; }
                if (TN % i == 0) { ListDivisores.Add(i); }
            }
        }

        public void Calculadora(ref List<double> ListDivisores, ref List <double> coeficientesActuales)
        {
            for (int r = 0; r < ListDivisores.Count(); r++)
            {
                if (coeficientesActuales[0] != 0) //coeficiente con expo 5 = nroX^5
                {
                    double resultado = coeficientesActuales[0];
                    EsRaiz(1, resultado, coeficientesActuales.Count, ref ListDivisores, r, ref coeficientesActuales);
                }
                else if (coeficientesActuales[1] != 0)//nroX^4
                {
                    double resultado = coeficientesActuales[1];
                    EsRaiz(2, resultado, coeficientesActuales.Count-1, ref ListDivisores, r, ref coeficientesActuales);
                 } else if (coeficientesActuales[2] != 0)//nroX^3
                {
                    double resultado = coeficientesActuales[2];
                    EsRaiz(3, resultado, coeficientesActuales.Count-2, ref ListDivisores, r, ref coeficientesActuales);
                 }
            }
        }
        private void EsRaiz( int p, double resultado, int vueltas, ref List <double> ListDivisores, int r, ref List <double> coeficientesActuales)
        { 
            for (int i = p; i <vueltas ; i++)
            {
                resultado = resultado * ListDivisores[r] + coeficientesActuales[i];
            }
            if (Math.Abs(resultado) < 1e-6) ListRaices.Add(ListDivisores[r]); //Saca las raices
        }

        private void ResolverCuadratica(double a, double b, double c)
        {
            double nroDeRaiz = b * b - 4 * a * c;
            if (nroDeRaiz > 0)
            {double raizCalculada = Math.Sqrt(nroDeRaiz);
                ListRaices.Add((-b + raizCalculada) / (2 * a));
                ListRaices.Add((-b - raizCalculada) / (2 * a));
            }
        }
       private void Coef_Expo( List<double> listaCoeficiente)
        {
            foreach (string b in numeros)
            {
                if (b.Contains("x^5")) coef_expo5 += separar_coef_expo(b, "x^5");
                if (b.Contains("x^4")) coef_expo4 += separar_coef_expo(b, "x^4");   
                if (b.Contains("x^3")) coef_expo3 += separar_coef_expo(b, "x^3"); 
                if (b.Contains("x^2")) coef_expo2 += separar_coef_expo(b, "x^2");   
                if (b.Contains("x^1")) coef_expo1 += separar_coef_expo(b, "x");  
                if (b.Contains("x") == false)
                {
                    double coef = double.Parse(b);
                    coef_sin_expo += coef;
                }
            }
            listaCoeficiente.AddRange(new[]{coef_expo5, coef_expo4, coef_expo3, coef_expo2, coef_expo1, coef_sin_expo});
        }
 











    }
}
