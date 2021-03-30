using System;
using System.Collections.Generic;

namespace ParentesisBalenceados
{
    public static class Program
    {
        public static bool VerificaParentesis(string txtparentesis)
        {
            bool estaCorreto = true;
            Stack<string> listaParentesisCurvos = new Stack<string>();
            Stack<string> listaParentesisRetos = new Stack<string>();


            for (int i = 0; i < txtparentesis.Length; i++)
            {
                string simbolo = txtparentesis[i].ToString();

                if (simbolo.Equals("("))
                {
                    listaParentesisCurvos.Push(simbolo);

                } else if (simbolo.Equals("["))
                {
                    listaParentesisRetos.Push(simbolo);
                } else
                {
                    if (listaParentesisCurvos.Count == 0 && listaParentesisRetos.Count == 0)
                    {
                        estaCorreto = false;
                    }
                    else if(simbolo.Equals("]") && listaParentesisRetos.Count == 0)
                    {
                        estaCorreto = false;
                    }
                    else if (simbolo.Equals("]") && listaParentesisRetos.Count > 0)
                    {
                        listaParentesisRetos.Pop();
                    }
                    else if (simbolo.Equals(")") && listaParentesisCurvos.Count == 0)
                    {
                        estaCorreto = false;
                    }
                    else if (simbolo.Equals(")") && listaParentesisCurvos.Count > 0)
                    {
                        listaParentesisCurvos.Pop();
                    }
                }
            }

            if (estaCorreto && listaParentesisCurvos.Count == 0 && listaParentesisRetos.Count == 0)
            {
                estaCorreto = true;
            }
            else
            {
                estaCorreto = false;
            }

            return estaCorreto;
        }

        static void Main(string[] args)
        {
            string test = "([])([[]])";

            Console.WriteLine($"A string tem os parentesis corretamente encadeados? {VerificaParentesis(test)}");
        }
    }
}
