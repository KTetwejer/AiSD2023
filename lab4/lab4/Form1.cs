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
            var w1 = new Wezel(5);
            var w2 = new Wezel(1);
            var w3 = new Wezel(2);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            var w4 = new Wezel(3);
            var w5 = new Wezel(8);
            w2.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            var w6 = new Wezel(4);
            w3.dzieci.Add(w6);

            A(w1);
        }
        void A(Wezel w)
        {
            MessageBox.Show(w.wartosc.ToString());
            foreach(var dziecko in w.dzieci)
            {
                A(dziecko);
            }
        }
    }
}