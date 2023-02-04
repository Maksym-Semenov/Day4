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

namespace ToDoApplication
{    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] tasks = new string[3];
        public MainWindow()
        {
            InitializeComponent();
            tasks[0] = "Купити молоко";
            tasks[1] = "Вивчити C#";
            tasks[2] = "Створити резюме";

            ToDoListBox.ItemsSource = tasks;
        }
    }
}
