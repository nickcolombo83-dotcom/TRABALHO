namespace Trabalho_Bimestral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int num = 1; num <= 400; num++)
            {
                listBox1.Items.Add($"Raiz de {num} = {Math.Sqrt(num):F2}");
            }
        }
    }
}
