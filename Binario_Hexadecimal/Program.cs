using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binario_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string Nbinario = "";

                Console.WriteLine("Ingresa el numero binario si caracteres");
                Nbinario = Console.ReadLine();

                int TDigitos = Nbinario.Count();
                int[] vector = new int[TDigitos];
                int numero = 0;

                foreach (var Digito in Nbinario)
                {
                    if (Digito != '0' && Digito != '1')
                    {
                        Console.WriteLine("la cadena ingresada no esta en su formato binario");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        vector[numero] = int.Parse(Digito.ToString());
                        numero++;
                    }
                }

                int numero2 = 0;
                int[] vectorInverso = new int[TDigitos];

                for (int i = TDigitos; i > 0; i--)
                {
                    vectorInverso[numero2] = vector[i - 1];
                    numero2++;
                }

                double suma = 0;

                for (int i = 0; i < TDigitos; i++)
                {
                    suma += vectorInverso[i] * Math.Pow(2, i);
                }

                double num;
                string hexadecimal = "";

                while (suma > 1)
                {
                    num = suma % 16;
                    if (num == 10)
                        hexadecimal = 'A' + hexadecimal;
                    else if (num == 11)
                        hexadecimal = 'B' + hexadecimal;
                    else if (num == 12)
                        hexadecimal = 'C' + hexadecimal;
                    else if (num == 14)
                        hexadecimal = 'D' + hexadecimal;
                    else if (num == 15)
                        hexadecimal = 'E' + hexadecimal;
                    else
                        hexadecimal += num.ToString();

                    suma = suma / 16;
                }

                int numHexa = 0;

                foreach (var item in hexadecimal)
                {
                    if (item == '.')
                        break;

                    numHexa++;
                }

                char[] CadenaHexdcml = new char[numHexa];
                int cont = 0;

                foreach (var item in hexadecimal)
                {
                    if (item != '.')
                    {
                        CadenaHexdcml[cont] = item;
                        cont++;
                    }
                    else
                    {
                        break;
                    }

                }

                char[] CadenaHexdcmlInvertida = new char[numHexa];
                cont = 0;
                Console.WriteLine("EL numero en hexadecimal es:");

                for (int i = numHexa; i > 0; i--)
                {
                    CadenaHexdcmlInvertida[cont] += CadenaHexdcml[i - 1];
                    Console.Write("{0}", CadenaHexdcmlInvertida[cont]);
                    cont++;
                }
                Console.Read();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: {0}", ex);
                Console.Read();

            }

        }
    }
}
