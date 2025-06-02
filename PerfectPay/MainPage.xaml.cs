namespace PerfectPay
{
    public partial class MainPage : ContentPage
    {
        decimal bill;
        int tip;
        int noPerson = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {

        }

        private void txtBill_Completed(object sender, EventArgs e)
        {
            bill = decimal.Parse(txtBill.Text);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            //total tip
            var totalTip =
                (bill * tip) / 100;

            //tip by person
            var tipByperson = (totalTip / noPerson);
            lblTipByPerson.Text = $"{tipByperson:C}";

            //subtotal
            var subtotal = (bill / noPerson);
            lblSubtotal.Text = $"{subtotal:C}";

            //total
            var totalByPerson =
                (bill + totalTip) / noPerson;
            lblTotal.Text = $"{totalByPerson:C}";
        }

        private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tip = (int)sldTip.Value;
            lblTip.Text = $"Tip:{tip}%";
            CalculateTotal();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btn = (Button)sender;
                var percentage =
                    int.Parse(btn.Text.Replace("%", ""));
                sldTip.Value = percentage;
            }
        }

        private void btnMinus_Clicked(object sender, EventArgs e)
        {
            if (noPerson > 1)
            {
                noPerson--;
            }
            lblNoPersons.Text = noPerson.ToString();
            CalculateTotal();
        }

        private void btnPlus_Clicked(object sender, EventArgs e)
        {
            noPerson++;
            lblNoPersons.Text = noPerson.ToString();
            CalculateTotal();
        }
    }
}
