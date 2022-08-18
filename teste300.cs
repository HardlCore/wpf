using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace modelo 
{
    public class Funcionario
   
        {
            public string nome = " ";
            public double valorPassagem = 0;
            double tudo = 0;

            public Funcionario(string nome, double valorPassagem)
            {
                this.nome = nome;
                this.valorPassagem = valorPassagem;
            }

            public Funcionario()
            {

            }

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public double ValorPassagem
            {
                get { return valorPassagem; }
                set { valorPassagem = value; }
            }

            public string toString()
            {
                return
                "\nFuncionario: " + nome + "\nValor Passagem: " + valorPassagem + "\n";
            }

        internal static void ImprimeValores(string nome, double valorPassagem)
        {
            throw new NotImplementedException();
        }
    }
    }


