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

namespace TunNikMethodInClass
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InValid val = new InValid();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            string log = tbLogin.Text;
            string pass = tbPass.Password;
            string conpass = tbRepPass.Text;
            string em = tbEmail.Text;
            string conem = tbRepEmail.Text;
            
            if (val.Validation(name, log, pass, conpass, em, conem))
            {
                MessageBox.Show("Поздравляю с регистрацией!");
            }
            else 
            {
                MessageBox.Show("Не все поля верно заполнены!");
            }
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
