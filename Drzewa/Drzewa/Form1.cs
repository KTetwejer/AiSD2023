namespace Drzewa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new W�ze�(1);
            var w2 = new W�ze�(2);
            var w3 = new W�ze�(3);
            var w4 = new W�ze�(4);
            var w5 = new W�ze�(5);
            var w6 = new W�ze�(8);

            w5.dzieci.Add(w1);
            w5.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w6);
            w2.dzieci.Add(w4);

            A(w5);
            //B(w5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var w1 = new W�ze�(1);
            var w2 = new W�ze�(2);
            var w3 = new W�ze�(3);
            var w4 = new W�ze�(4);
            var w5 = new W�ze�(5);
            var w6 = new W�ze�(8);

            w5.Add(w1);
            w5.Add(w2);
            w1.Add(w3);
            w1.Add(w6);
            w2.Add(w2);
            w3.Add(w4);


            var odwiedzone = new List<W�ze�>();
            C(w5, odwiedzone);

            //var odwiedzoneBFS = new List<W�ze�>();
            //odwiedzoneBFS.Add(w5);
            //BFS(odwiedzoneBFS);
        }

        void A(W�ze� w) //DFS
        {
            MessageBox.Show(w.warto��.ToString());
            foreach(var dziecko in w.dzieci)
            {
                A(dziecko);
            }

        }
        void B(W�ze� w) //moje w�asne :3c (�eby sprawdzic struktur� drzewa)
        {
            MessageBox.Show(w.warto��.ToString());
            for(int i = 0; i < w.dzieci.Count(); i++)
            {
                B(w.dzieci[i]);
                if(i+1 != w.dzieci.Count())
                {
                    MessageBox.Show(w.warto��.ToString());
                }
            }
            //PD!!!! zrobi� w�ze�2 z s�siadami, gdzie graf mo�e zawiera� cykle,
            //graf jest skierowany (w1.sasiedzi.Add(w2) to nie to samo co w1.sasiedzi.Add(w2)),
            //wykona� BFS'a na takim grafie (ta funkcja A) 5,1,3,4,2,8 (mo�na raz odwiedzic w�ze�)

        }
        void C(W�ze� w, List<W�ze�> odwiedzone) //DFS
        {
            odwiedzone.Add(w);
            MessageBox.Show(w.warto��.ToString());
            foreach (var dziecko in w.dzieci)
            {
                if (!odwiedzone.Contains(dziecko))
                {
                    C(dziecko, odwiedzone);
                }
            }

        }

        void BFS(List<W�ze�> odwiedzone)
        {
            for (int i = 0; i < odwiedzone.Count; i++)
            {
                var w = odwiedzone[i];
                MessageBox.Show(w.warto��.ToString());
                foreach (var s�siad in w.dzieci)
                {
                    if (!odwiedzone.Contains(s�siad))
                    {
                        odwiedzone.Add(s�siad);
                    }
                }
            }
        }



    }
}