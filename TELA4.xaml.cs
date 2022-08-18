using System;
using modelo;
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
    /// Interação lógica para TELA4.xam
    /// </summary>
    public partial class TELA4 : UserControl
    {
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        public TELA4()
        {
            InitializeComponent();
        }

        private void verlista(object sender, RoutedEventArgs e)
        {
            foreach (Funcionario item in main.listafuncionario)


            {

             


               

            }

        }
    }
}
