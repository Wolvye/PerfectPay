namespace PerfectPay
{
    public partial class MainPage : ContentPage
    {
        decimal bill;
        int tip;
        int noPerson=1;

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
            

        }
    }
}
