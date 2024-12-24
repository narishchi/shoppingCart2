namespace shoppingCart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chbCoffee.Checked) { }
            //get amount
            string strCoffeePrice = tbCoffeePrice.Text;
            //get price
            string strCoffeeQuantity = tbCoffeeQuantity.Text;

            int iCoffeePrice = 1;
            int iCoffeeQuantity = 1;
            try
            {

                //convert string io int
                if (chbCoffee.Checked)
                {
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                }
            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
            }
            //calculate total
            int iTotal = iCoffeePrice * iCoffeeQuantity;

            //dispaly total
            tbTotal.Text = iTotal.ToString();

        }
    }
}
