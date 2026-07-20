using System;
using KatilKimOyunu.Managers;
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
using System.Windows.Shapes;

namespace KatilKimOyunu.Views
{
    /// <summary>
    /// Interaction logic for DetectiveCenter.xaml
    /// </summary>
    public partial class DetectiveCenter : Window
    {
        public DetectiveCenter()
        {
            InitializeComponent();

            txtCaseTitle.Text = GameManager.Instance.CurrentCase.Title;

            txtVictim.Text = "Mağdur: " +
                             GameManager.Instance.CurrentCase.Victim.Name;

            txtProgress.Text = "Bulunan Delil: 0";
        
    }
    }
}
