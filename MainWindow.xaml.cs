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

namespace ExpressWpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void delegateMemu();

        void WorkMenu(delegateMemu parDelegate)
        {
            #region
            ClearMe();
            try
            {
                parDelegate();
                textBox1.Text = Papa.info;
            }
            catch (Exception ex) { textBox1.Text = ex.Message; }

            #endregion
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearMe()
        {
            #region
            textBox1.Text = "";
            Papa.info = "";
            #endregion
        }
        private void RefresFromAccess_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = RefreshAll.MainRefreshAll;
            WorkMenu(myDelegatemenu);
            #endregion
        }

       

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            ClearMe();
        }

        //otbor________________________________

        private void ButtonOtborInputDep_Click(object sender, RoutedEventArgs e)
        {
            #region
            var input = textBox1.Text;
            OtborDepFromTo.MainOtborDepFromTo(input);
            //ClearMe();
            textBox1.Text = Papa.info;
            #endregion
        }

        private void ButtonOtborDepList_Click(object sender, RoutedEventArgs e)
        {
            #region
            var input = textBox1.Text;
            OtborDepList.MainOtborDepList(input);
            //ClearMe();
            textBox1.Text = Papa.info;
            #endregion
        }

        private void ButtonOtborTermList_Click(object sender, RoutedEventArgs e)
        {
            #region
            var input = textBox1.Text;
            OtborTermList.MainOtborTermList(input);
            //ClearMe();
            textBox1.Text = Papa.info;
            #endregion
        }

        //some___________________________________________

        private void ButtonTerm_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Term.MainTerm;
            WorkMenu(myDelegatemenu);
            #endregion
        }


        private void ButtonHrDep_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = HrDep.MainHrDep;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonHrDepAb_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = HrDepAb.MainHrDepAb;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonNatasha_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Natasha.MainNatasha;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonSite_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = SiteNew.MainSiteNew;
            WorkMenu(myDelegatemenu);
            #endregion
        }


        //monitor_______________________________________

        private void ButtonRasklad_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Rasklad.MainRasklad;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonAccBack_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = AccBack.MainAccBack;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonGetRp_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = GetRp.MainGetRp;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonMonitor_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Monitor.MainMonitor;
            WorkMenu(myDelegatemenu);
            #endregion
        }


        //people________________________________________

        private void ButtonPriem_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Priem.MainPriem;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonOtpusk_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Otpusk.MainOtpusk;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonPerevod_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Perevod.MainPerevod;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonPostAll_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = PostAll.MainPostAll;
            WorkMenu(myDelegatemenu);
            #endregion
        }


        //kabinet________________________________________

        private void ButtonRro_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Rro.MainRro;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonPereezd_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Pereezd.MainPereezd;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonOtmena_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Otmena.MainOtmena;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonKnigi_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Knigi.MainKnigi;
            WorkMenu(myDelegatemenu);
            #endregion
        }

        private void ButtonPrro_Click(object sender, RoutedEventArgs e)
        {
            #region
            delegateMemu myDelegatemenu;
            myDelegatemenu = Prro.MainPrro;
            WorkMenu(myDelegatemenu);
            #endregion
        }

    }
}
