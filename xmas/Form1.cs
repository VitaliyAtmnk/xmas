namespace xmas
{
    public partial class Form1 : Form
    {
        private decimal _totalPrice;
        private decimal _totalCount;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPridat_Click(object sender, EventArgs e)
        {
            if(txtNazev.Text.Trim() != "")
            {
                decimal tempTotal = numCena.Value * numPocet.Value;
                string line = $"{txtNazev.Text} - {numPocet.Value} ks x {numCena.Value} = {tempTotal}";

                _totalPrice += tempTotal;
                _totalCount += numPocet.Value;


                lblCelkemCena.Text = "Celková cena " + _totalPrice + " Kè.";
                lblCelkemPolozek.Text = "Celkem položek " + _totalCount + " Ks.";
            }
            else
            {
                MessageBox.Show("Zadej dárek pro Ježíška!!!");
            }
        }

        private void btnShrnuti_Click(object sender, EventArgs e)
        {

        }

        private void btnSmazatVse_Click(object sender, EventArgs e)
        {

        }
    }
}
