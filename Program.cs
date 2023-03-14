using System;

namespace TPFinal_HuallpaQuispe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int numero, mayor = 0, cantImpares = 0, menor = 0;
            bool ban = false;

            Console.WriteLine("INGRESE UN NRO: ");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
                mayor = numero;
            
            while(numero!= 0){
                // PAR
                if(numero % 2 == 0){
                    if(numero > mayor)
                        mayor = numero;
                }else // IMPAR
                    cantImpares++;
                
                // MENOR PRIMO
                if(primo(numero)){
                    if(!ban){
                        menor = numero;
                        ban = true;
                    }else if(numero < menor)
                        menor = numero;
                }
                
                Console.WriteLine("INGRESE OTRO NRO: ");
                numero = int.Parse(Console.ReadLine());
            }

            if(mayor == 0)
                Console.WriteLine("NO SE INGRESÓ NINGUN NRO PAR..");
            else    
                Console.WriteLine("EL MAYOR DE LOS NROS PARES ES: " + mayor);
            
            Console.WriteLine("LA CANTIDAD DE NROS IMPARES ES: " + cantImpares);

            Console.WriteLine("EL MENOR DE LOS NUMERO PRIMOS FUE: " + menor);
        }


        //FUNCION PRIMO
        static bool primo(int N){
            int cont = 0;

            for (int x = 1; x <= N; x++)
            {
                if(N % x == 0)
                    cont++;
            }
            if(cont == 2)
                return true;
            else
                return false;
        }
    }
}
