using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FrontEndd
{
    /// <summary>
    /// Interação lógica para TELA3.xam
    /// </summary>
    public partial class TELA3 : UserControl
    {

        MainWindow main = (MainWindow)Application.Current.MainWindow;



        public TELA3()
        {
            InitializeComponent();
        }


        private void Pesquisa(object sender, RoutedEventArgs e)
        {


            
            
            bool existe = false;

            for (int i = 0; i < main.listafuncionario.Count; i++)

                //{
                //System.Console.WriteLine(listaFuncionario[i].Nome);
                if (main.listafuncionario[i].Nome.Equals(pesquisarbox.Text)) 
                {

                    existe = true;

                    pesquisarblock.Text = main.listafuncionario[i].Nome;
                    passagemblock.Text = main.listafuncionario[i].ValorPassagem.ToString();






                }
         

            if (!existe)
            {

                    MessageBox.Show("Não há funcionario com esse nome");
                      
            }


           
        }
        public void ImprimeValores(string nomeFuncionario, double valorPassagem)
        {
            //declacrando variaveis de controle/
            int nota200 = 0, nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0, moeda1 = 0, moeda50 = 0, moeda25 = 0, moeda10 = 0, moeda5 = 0, moeda01 = 0;
            int restoPassagem = 0;
            double valor = valorPassagem;

            //separando a parte inteira da decimal
            restoPassagem = (int)Math.Round((valorPassagem - (int)valorPassagem) * 100);
            valorPassagem = (int)valorPassagem;


            //calculando as cedulas
            while (valorPassagem >= 200)
            {
                nota200++;
                valorPassagem = valorPassagem - 200;

            }
            while (valorPassagem >= 100)
            {
                nota100++;
                valorPassagem = valorPassagem - 100;

            }
            while (valorPassagem >= 50)
            {
                nota50++;
                valorPassagem = valorPassagem - 50;

            }

            while (valorPassagem >= 20)
            {
                nota20++;
                valorPassagem = valorPassagem - 20;

            }

            while (valorPassagem >= 10)
            {
                nota10++;
                valorPassagem = valorPassagem - 10;

            }

            while (valorPassagem >= 5)
            {
                nota5++;
                valorPassagem = valorPassagem - 5;
                ;
            }

            while (valorPassagem >= 2)
            {
                nota2++;
                valorPassagem = valorPassagem - 2;

            }

            //calculando moedas
            while (valorPassagem == 1)
            {
                moeda1++;
                valorPassagem = valorPassagem - 1;

            }

            while (restoPassagem >= 50)
            {
                moeda50++;
                restoPassagem = restoPassagem - 50;

            }

            while (restoPassagem >= 25)
            {
                moeda25++;
                restoPassagem = restoPassagem - 25;

            }

            while (restoPassagem >= 10)
            {
                moeda10++;
                restoPassagem = restoPassagem - 10;

            }

            while (restoPassagem >= 5)
            {
                moeda5++;
                restoPassagem = restoPassagem - 5;

            }

            while (restoPassagem >= 1)
            {
                moeda01++;
                restoPassagem = restoPassagem - 1;

            }

            Console.WriteLine("\n\n=========Dados Funcionario=========");
            Console.WriteLine($"Funcionario {nomeFuncionario}");
            Console.WriteLine($"Valor da passagem R${valor}");
            Console.WriteLine($"Quantidade de notas e moedas");
            if (nota200 >= 1)
            {
                Console.WriteLine($"{nota200} notas de R$200,00");
            }
            if (nota100 >= 1)
            {
                Console.WriteLine($"{nota100} notas de R$100,00");
            }
            if (nota50 >= 1)
            {
                Console.WriteLine($"{nota50} notas de R$50,00");

            }
            if (nota20 >= 1)
            {
                Console.WriteLine($"{nota20} notas de R$20,00");
            }
            if (nota10 >= 1)
            {
                Console.WriteLine($"{nota10} notas de R$10,00");
            }
            if (nota5 >= 1)
            {
                Console.WriteLine($"{nota5} notas de R$5,00");
            }
            if (nota2 >= 1)
            {
                Console.WriteLine($"{nota2} notas de R$2,00");
            }
            if (moeda1 >= 1)
            {
                Console.WriteLine($"{moeda1} moeda de R$1,00");
            }
            if (moeda50 >= 1)
            {
                Console.WriteLine($"{moeda50} moeda de R$0,50");
            }
            if (moeda25 >= 1)
            {
                Console.WriteLine($"{moeda25} moeda de R$0,25");
            }
            if (moeda10 >= 1)
            {
                Console.WriteLine($"{moeda10} moeda de R$0,10");
            }
            if (moeda5 >= 1)
            {
                Console.WriteLine($"{moeda5} moeda de R$0,05");
            }
            if (moeda01 >= 1)
            {
                Console.WriteLine($"{moeda01} moeda de R$0,01");
            }

            Console.WriteLine("\n\n");
        }
    }
}

