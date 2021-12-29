namespace VariaveisNumericas
{
    public partial class Form1 : Form
    {
        //Declaração de variáveis
        double n1, n2, res; //valores numéricos com até 8 casas decimais 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();
            

            //Cálculo
            res = n1 + n2;

            //saída
            lblRes.Text = res.ToString("0.00");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();
            
            //Cálculo
            res = n1 * n2;

            //saída
            lblRes.Text = res.ToString("0.00");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();
            
            //Cálculo
            res = n1 - n2;

            //saída
            lblRes.Text = res.ToString("0.00");

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Leitura dos valores 
            lerValores();

            //Cálculo
            res = n1 / n2;
            lblRes.Text = res.ToString("0.00");
        }
       
        private void lerValores() //Método para declarar valores
        {
            n1 = Convert.ToDouble(txtNum1.Text);
            n2 = Convert.ToDouble(txtNum2.Text);
        }

    }
}