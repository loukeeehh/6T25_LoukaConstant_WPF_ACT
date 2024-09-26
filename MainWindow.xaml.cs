using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace _6T25_LoukaConstant_ACT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        methodesDuProjet mesOutils = new methodesDuProjet();
        
        public MainWindow()
        {
            InitializeComponent();
            txtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            appuiBtn.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            appuiBtn.MouseEnter += new MouseEventHandler(AppuiBtn_MouseEnter);
            mesOutils = new methodesDuProjet();
            

        }
        

        private void AppuiBtn_MouseEnter(object sender, MouseEventArgs e)
        {

            appuiBtn.Visibility = Visibility.Visible;
            appuiBtn.Background = Brushes.Red;

            double a;
            double b;
            double c;
            string message;

            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
            {
                mesOutils.ResoudTrinome(a,b,c,out message);

            }
            else
            {
                Console.WriteLine("Traitement impossible !");
            }


        }

        private bool EstEntier(string texteUser) //fonction evenementielle
        {
            //variable pour stocker le résultat
            int nombre;

            bool estUnEntier = int.TryParse(texteUser, out nombre);

            return estUnEntier;
        }


        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && EstEntier(e.Text))
            {
               e.Handled = true;
            }

            if (((TextBox)sender).Text.IndexOf(e.Text) > -1) //Text.IndexOf(e.Text) : renvoie la position du caractère e.Text(le caractère qui vient d’être tapé) dans le contenu de la zone de texte. S’il ne s’y trouve pas, renvoie -1.
            {
                e.Handled = true;
            }

            
        }

        

        

    }
}
