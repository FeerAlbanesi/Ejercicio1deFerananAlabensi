using System;

namespace Ejercicio1

{
	class ejercicio1deFernanAlbanesi
	{

		static void Main(string[] args)
		{
            try
            {
                double dolar;
                double euro;
                double peso;
                Console.Write("ingrese la cantidad de pesos a convertir ");
                peso = Double.Parse(Console.ReadLine());
                dolar = peso / 230;
                euro = dolar / 1.17;
                if (peso < 1)
                {
                    Console.WriteLine("La cantintidas de pesos ingresada no es valida");
                }
                else
                {
                    Console.WriteLine(peso + " Pesos es igual a " + dolar + " Dolares y " + euro + " Euros");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Lo ingresado no es un numero");
            }
		}

	}

}

