namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new W�ze�(5);
            var w2 = new W�ze�(1);
            var w3 = new W�ze�(2);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            var w4 = new W�ze�(3);
            var w5 = new W�ze�(8);
            w2.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            var w6 = new W�ze�(4);
            w3.dzieci.Add(w6);

            A(w1);
        }
        void A(W�ze� w)
        {
            MessageBox.Show(w.warto��.ToString());
            foreach(var dziecko in w.dzieci)
            {
                A(dziecko);
            }
        }
    }
}