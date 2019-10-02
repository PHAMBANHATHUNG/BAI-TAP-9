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
using AppOOP;

namespace AppOOP
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

        private void TxbNhap_Click(object sender, RoutedEventArgs e)
        {
            Student student1 = new Student("Minh");
            student1.Talk();
            Student student2 = new Student();
            student2.StudentName = "Dung";
            student2.Talk();
        }
    }
}
