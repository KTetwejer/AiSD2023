namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            int result = Fib(x);
            MessageBox.Show(result.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private int Fib(int n)
        {
            int[] wyrazy = new int[n + 1];
            wyrazy[0] = 0;
            wyrazy[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                wyrazy[i] = wyrazy[i - 1] + wyrazy[i - 2];
            }
            return wyrazy[n];
        }
    }
}