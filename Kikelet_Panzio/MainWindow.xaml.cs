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

namespace Kikelet_Panzio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++)
            {
                CbxRooms.Items.Add(i);
            }
            for (int i = 1;i <= 4; i++)
            {
                CbxPeople.Items.Add(i);
            }

            

        }

        private void MniReg_Click(object sender, RoutedEventArgs e)
        {
            Register registerWindow = new Register();
            registerWindow.ShowDialog();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {

            DtgDatas.Items.Add(ugyfelek);
            DtgDatas.Items.Refresh();
        }


        private void MniStats_Click(object sender, RoutedEventArgs e)
        {
            Stats statsWindow = new Stats();
            statsWindow.ShowDialog();
        }
    }
}
