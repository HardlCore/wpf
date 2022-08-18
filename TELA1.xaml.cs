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
using System.Globalization;
using FrontEndd;
using modelo;



namespace FrontEndd
{

    /// <summary>
    /// Interação lógica para TELA1.xam
    /// </summary>
    public partial class TELA1 : UserControl
    {
        MainWindow main = (MainWindow)Application.Current.MainWindow;

    
      

     
        public TELA1()
        {
            InitializeComponent();
        }
      

      

        private void cadastrarr(object sender, RoutedEventArgs e)
        {
            if (!NomeDoFuncionario.Text.Equals("") || ValorDaPassagem.Text.Equals(""))
            {

                //List<Funcionario> listaFuncionario = new List<Funcionario>();

                Funcionario novo = new Funcionario();
                novo.Nome = NomeDoFuncionario.Text;
                double passagemfun;
                double.TryParse(ValorDaPassagem.Text, out passagemfun);
                novo.ValorPassagem = passagemfun;               
                main.listafuncionario.Add(novo);
                
                
                

               
                MessageBox.Show("Usuario Cadastrado");
              
            


            }
        }

    
    }
}
