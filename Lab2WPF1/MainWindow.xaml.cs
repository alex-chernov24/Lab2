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
using Lab2WPF.Classes;
using Lab2WPF;

namespace Lab2WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btStartCalculte(object sender, RoutedEventArgs e)
        {
            try
            {
                DataGridWindows Win = new DataGridWindows(Convert.ToInt32(tbCountRowAndColumn.Text), cmbTyping.SelectedIndex);
                Win.Show();
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }
    }
}