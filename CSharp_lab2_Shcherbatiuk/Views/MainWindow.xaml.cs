using System.Windows;
using CSharp_lab2_Shcherbatiuk.ViewModels;

namespace CSharp_lab2_Shcherbatiuk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PersonInfoViewModel();
        }
    }
}
