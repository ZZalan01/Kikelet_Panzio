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
        internal static List<string> mentettAdatok = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            CbxName.Items.Add("Tóthné Nagy Etelka");
            CbxName.Items.Add("Kis Géza");
            CbxName.Items.Add("Erős Pista");
            CbxName.Items.Add("Édes Anna");
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
            //Regisztrációs Ablak
            Register registerWindow = new Register();
            registerWindow.ShowDialog();
            CbxName.Items.Refresh();
            CbxName.Items.Add(ugyfelek[0].Username);
           
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            string CbxNameValue = CbxName.SelectedItem?.ToString() ?? "N/A";
            string CbxPeopleValue = CbxPeople.SelectedItem?.ToString() ?? "N/A";
            string CbxRoomsValue = CbxRooms.SelectedItem?.ToString() ?? "N/A";
            string DtpArrivalValue = DtpArrival.SelectedDate?.ToString("yyyy-MM-dd") ?? "N/A";
            string DtpDepartureValue = DtpDeparture.SelectedDate?.ToString("yyyy-MM-dd") ?? "N/A";
            string TbxPriceValue = TbxPrice.Text;

            mentettAdatok.Add($"ComboBox1: {CbxPeopleValue}");
            mentettAdatok.Add($"ComboBox2: {CbxPeopleValue}");
            mentettAdatok.Add($"ComboBox3: {CbxRoomsValue}");
            mentettAdatok.Add($"DatePicker1: {DtpArrivalValue}");
            mentettAdatok.Add($"DatePicker2: {DtpDepartureValue}");
            mentettAdatok.Add($"TextBox: {TbxPriceValue}");

            MessageBox.Show("Adatok mentve!");



            DtgDatas.ItemsSource = ugyfelek;
            DtgDatas.Items.Refresh();
        }


        private void MniStats_Click(object sender, RoutedEventArgs e)
        {
            //Statisztika Ablak
            Stats statsWindow = new Stats();
            statsWindow.ShowDialog();
        }
    }
}
