
namespace McDonalds
{
    public partial class MainPage : ContentPage
    {
        double[] liste = new double[10];
        Double KmeterLiter = 0;
        Double Kmeter = 0;
        Double OliePris= 0;
        Double BeregnetKørePris=0;
        string Burgur;
        string[] BurgurSplit;
        Double BurgurRegning = 0;
        Double DrikkeRegning = 0;
        Double GroftRegning = 0;
        Double KyllingRegning = 0;
        Double CoinRegning = 0;
        Double SidesRegning = 0;
        Double KaffeRegning = 0;
        Double IsRegning = 0;
        Double Regningen = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void næste_Clicked(object sender, EventArgs e)
        {
            Regningen = BurgurRegning + DrikkeRegning + GroftRegning + KyllingRegning + CoinRegning + SidesRegning + KaffeRegning + IsRegning;
            BeregnetKørePris = ((Kmeter / KmeterLiter) * OliePris);
            BilRegning.Text = String.Empty;
            Tester.Text = (Regningen).ToString();
            if (!Double.IsNaN(BeregnetKørePris) && !Double.IsInfinity(BeregnetKørePris))
            {
                BilRegning.Text = BeregnetKørePris.ToString();
                Tester.Text = (BeregnetKørePris + Regningen).ToString();
            }
            MadRegning.Text = Regningen.ToString();
        }
        private void KmL_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(KmL.Text, out _))
            {
                KmeterLiter = Convert.ToDouble(KmL.Text);
            }
        }

        private void Distance_TextChanged(object sender, TextChangedEventArgs e)
        {
            //double.TryParse(Distance.Text, out Kmeter));
            if (double.TryParse(Distance.Text, out Kmeter))
            {
                //Kmeter = Convert.ToDouble(Distance.Text);
            } 
        }

        private void Brandstofspris_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(Brandstofspris.Text, out _)) //Er det et tal. AKA dobbelt
            {
                OliePris = Convert.ToDouble(Brandstofspris.Text);
            }
        }

        private void Burgere_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            Burgur = picker.Items[selectedIndex];
            BurgurSplit = Burgur.Split(' ');
            //Tester.Text = picker.Items[selectedIndex];
            BurgurRegning = Convert.ToDouble(BurgurSplit[1]);
            /* 
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String ;
            String[] Split;
             = picker.Items[selectedIndex];
            Split = Drikke.Split(' ');
            Regning = Convert.ToDouble(Split[1]);
             */
        }

        private void KyllingogFisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String Kylling;
            String[] KyllingSplit;
            Kylling = picker.Items[selectedIndex];
            KyllingSplit = Kylling.Split(' ');
            KyllingRegning = Convert.ToDouble(KyllingSplit[1]);
        }

        private void Coinoffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String Coin;
            String[] CoinSplit;
            Coin = picker.Items[selectedIndex];
            CoinSplit = Coin.Split(' ');
            CoinRegning = Convert.ToDouble(CoinSplit[1]);
        }

        private void SidesogDips_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String Sides;
            String[] SidesSplit;
            Sides = picker.Items[selectedIndex];
            SidesSplit = Sides.Split(' ');
            SidesRegning = Convert.ToDouble(SidesSplit[1]);
        }

        private void Koldedrikke_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String Drikke;
            String[] DrikkeSplit;
            Drikke = picker.Items[selectedIndex];
            DrikkeSplit = Drikke.Split(' ');
            DrikkeRegning = Convert.ToDouble(DrikkeSplit[1]);
        }

        private void GrøntogGroft_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String Groft;
            String[] GroftSplit;
            Groft = picker.Items[selectedIndex];
            GroftSplit = Groft.Split(' ');
            GroftRegning = Convert.ToDouble(GroftSplit[1]);
        }

        private void KaffeogKage_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var picker = (Picker)sender;
            String[] KaffeSplit;
            KaffeSplit = (picker.Items[picker.SelectedIndex]).Split(' ');
            KaffeRegning = Convert.ToDouble(KaffeSplit[1]);*/
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String Kaffe;
            String[] KaffeSplit;
            Kaffe = picker.Items[selectedIndex];
            KaffeSplit = Kaffe.Split(' ');
            KaffeRegning = Convert.ToDouble(KaffeSplit[1]);
        }

        private void Is_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            String Is;
            String[] IsSplit;
            Is = picker.Items[selectedIndex];
            IsSplit = Is.Split(' ');
            IsRegning = Convert.ToDouble(IsSplit[1]);
        }
    }
}