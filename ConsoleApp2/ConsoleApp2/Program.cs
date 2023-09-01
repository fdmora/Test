using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[] space = new char[] { ' ' };
            string[] ops = Console.ReadLine().Split(space);
            int output = solution.Ca1Points(ops);
            Console.Write(output.ToString());
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int Ca1Points(string[] ops)
        {

     
            List<int> lista = new List<int>();
            string valor1 = ops[0];
            string valor2 = ops[1];
            lista.Add(int.Parse(valor1));
            lista.Add(int.Parse(valor2));

            for (int i = 2; i < ops.Length; i++)
            {
                string valortemp = ops[i];

                if (valortemp == "+")
                {
                    int temp = lista[lista.Count - 1] + lista[lista.Count - 2];
                    lista.Add(temp);
                }

                if (valortemp == "C")
                {
                    int indice = lista.Count - 1;
                    lista.RemoveAt(indice);
                }

                if (valortemp == "D")
                {
                    int temp = lista[lista.Count - 1] * 2;
                    lista.Add(temp);
                }
                if     (valortemp != "D" && valortemp != "+" && valortemp != "C")
                {
                    string valor3 = ops[i];
                    lista.Add(int.Parse(valor3));
                }


            }

            int resultado = 0;
            foreach (int a in lista)
            {
                resultado = resultado + a;
            }
            return resultado;            
      
             //return int.Parse(ops[e]);
        }
    }


}

