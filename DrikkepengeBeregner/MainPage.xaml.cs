using System.Diagnostics;

namespace DrikkepengeBeregner
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Double Sliderrr = 0;
        Double beløbet = 0;
        double procent = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Sliding_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Debug.WriteLine(Sliding.Value);
            Sliderrr = Sliding.Value;
            string stringgg = (Sliderrr.ToString("0"));
             //   string.Format("{0:f0}, {1:c}", Sliderrr,1233);
            
            procent = ((Convert.ToDouble(stringgg)/100)+1);
            
            //lab.Text = Sliderrr.ToString();
            lab.Text = stringgg;
        }

        private void entryyy_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            if (double.TryParse(entryyy.Text, out _))
            {
                beløbet = Convert.ToDouble(entryyy.Text);
            }
            

        }

        private void Beregn_Pressed(object sender, EventArgs e)
        {
            string beregnettt= string.Format("{0:f2}", (beløbet * procent));
            slutbeløb.Text = beregnettt;
        }

        private void entryyy_Completed(object sender, EventArgs e)
        {
            Beregn_Pressed(sender, e);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new NavPage());
        }
    }
}