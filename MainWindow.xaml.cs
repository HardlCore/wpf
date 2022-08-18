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
using modelo;
namespace FrontEndd

/// <summary>
/// Interação lógica para MainWindow.xam
/// </summary>
/// 



{ public partial class MainWindow : Window
{

    public List<Funcionario> listafuncionario = new List<Funcionario>();


    int op = 0;



    public MainWindow()
    {
        InitializeComponent();

    }



    private void AlterarTela(object sender, SelectionChangedEventArgs e)



    {

        op = Cadastrar1.SelectedIndex;
        if (op >= 0) ;
        switch (op)
        {
            case 0: //cadastrar 
                {
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new TELA1());
                    break;

                }
            case 1: //remover
                {
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new TELA2());
                    break;
                }
            case 2: //pesquisar
                {
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new TELA3());

                    break;
                }

                case 3: //Ver funcionarios
                   
                    {

                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new TELA4());
                        break;

                    }
                case 4: //sair do programa
                    
                    {
                        this.Close();
                        break;
                    }
                    


            }





        }


} }





