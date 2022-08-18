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
    /// Interação lógica para TELA2.xam
    /// </summary>
    public partial class TELA2 : UserControl
    {
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        public TELA2()
        {
            InitializeComponent();
        }



        private void funcionariok(object sender, RoutedEventArgs e)
        {
            Funcionario novo = new Funcionario();


            string nomefuncionario = "";
            nomefuncionario = cadas.Text;
            bool existe = false;


            for (int i = 0; i < main.listafuncionario.Count; i++)
                //System.Console.WriteLine(listaFuncionario[i].Nome);
                if (cadas.Text.Equals(main.listafuncionario[i].Nome))

                {

                    existe = true;
                    main.listafuncionario.Remove(main.listafuncionario[i]);
                    MessageBox.Show("Funcionario removido!");

                }
            if (!existe)

                MessageBox.Show("O nome do funcionário não está na lista");


        }
    }
}





// string NomeFuncionario;
// NomeFuncionario = Console.ReadLine();
