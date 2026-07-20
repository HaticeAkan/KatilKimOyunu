using KatilKimOyunu.Managers;
using KatilKimOyunu.Models;
using KatilKimOyunu.Services;
using KatilKimOyunu.Views;
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

namespace KatilKimOyunu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CaseService caseService = new CaseService();

            Case gameCase = caseService.LoadCase("Data/case1.json");
            GameManager.Instance.CurrentCase = gameCase;

           
            MessageBox.Show(GameManager.Instance.CurrentCase.Title);
        }

        private void btnCikis_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnYeniOyun_Click(object sender, RoutedEventArgs e)
        {
            DetectiveCenter detectiveCenter = new DetectiveCenter();

            detectiveCenter.Show();

            this.Close();
        }
    }
    
}
