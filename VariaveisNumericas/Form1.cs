namespace VariaveisNumericas
{
    public partial class Form1 : Form
    {
        //Declara��o de vari�veis
        double n1, n2, res; //valores num�ricos com at� 8 casas decimais 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();
            

            //C�lculo
            res = n1 + n2;

            //sa�da
            lblRes.Text = res.ToString("0.00");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();
            
            //C�lculo
            res = n1 * n2;

            //sa�da
            lblRes.Text = res.ToString("0.00");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();
            
            //C�lculo
            res = n1 - n2;

            //sa�da
            lblRes.Text = res.ToString("0.00");

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();

            //C�lculo
            res = n1 / n2;
            lblRes.Text = res.ToString("0.00");
        }
       
        private void lerValores() //M�todo para declarar valores
        {
            n1 = Convert.ToDouble(txtNum1.Text);
            n2 = Convert.ToDouble(txtNum2.Text);
        }

    }
}