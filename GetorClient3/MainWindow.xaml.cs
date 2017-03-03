using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace GetorClient3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string cd = "RESENDE";

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Config.Obterlocal();
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            cd = "XANXERE";
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            cd = "PASSO FUNDO";
        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            cd = "PATO BRANCO";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                char a = char.Parse(",");
                string[] notas = textBox1.Text.Split(a);
                StreamWriter escreitor = new StreamWriter(Config.local + "" + DateTime.Now.Second + "" + DateTime.Now.Millisecond + ".ianez");
                escreitor.WriteLine(cd);

                for (int ed = 0; ed < notas.Length; ed++)
                {
                    escreitor.WriteLine(notas[ed]);
                }
                escreitor.Close();
                textBox1.Text = "";
            }
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            cd = "RESENDE";
        }
    }
}
