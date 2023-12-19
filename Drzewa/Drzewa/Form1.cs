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
            var w1 = new Wêze³(1);
            var w2 = new Wêze³(2);
            var w3 = new Wêze³(3);
            var w4 = new Wêze³(4);
            var w5 = new Wêze³(5);
            var w6 = new Wêze³(8);

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
            var w1 = new Wêze³(1);
            var w2 = new Wêze³(2);
            var w3 = new Wêze³(3);
            var w4 = new Wêze³(4);
            var w5 = new Wêze³(5);
            var w6 = new Wêze³(8);

            w5.Add(w1);
            w5.Add(w2);
            w1.Add(w3);
            w1.Add(w6);
            w2.Add(w2);
            w3.Add(w4);


            var odwiedzone = new List<Wêze³>();
            C(w5, odwiedzone);

            //var odwiedzoneBFS = new List<Wêze³>();
            //odwiedzoneBFS.Add(w5);
            //BFS(odwiedzoneBFS);
        }

        void A(Wêze³ w) //DFS
        {
            MessageBox.Show(w.wartoœæ.ToString());
            foreach(var dziecko in w.dzieci)
            {
                A(dziecko);
            }

        }
        void B(Wêze³ w) //moje w³asne :3c (¿eby sprawdzic strukturê drzewa)
        {
            MessageBox.Show(w.wartoœæ.ToString());
            for(int i = 0; i < w.dzieci.Count(); i++)
            {
                B(w.dzieci[i]);
                if(i+1 != w.dzieci.Count())
                {
                    MessageBox.Show(w.wartoœæ.ToString());
                }
            }
            //PD!!!! zrobiæ wêze³2 z s¹siadami, gdzie graf mo¿e zawieraæ cykle,
            //graf jest skierowany (w1.sasiedzi.Add(w2) to nie to samo co w1.sasiedzi.Add(w2)),
            //wykonaæ BFS'a na takim grafie (ta funkcja A) 5,1,3,4,2,8 (mo¿na raz odwiedzic wêze³)

        }
        void C(Wêze³ w, List<Wêze³> odwiedzone) //DFS
        {
            odwiedzone.Add(w);
            MessageBox.Show(w.wartoœæ.ToString());
            foreach (var dziecko in w.dzieci)
            {
                if (!odwiedzone.Contains(dziecko))
                {
                    C(dziecko, odwiedzone);
                }
            }

        }

        void BFS(List<Wêze³> odwiedzone)
        {
            for (int i = 0; i < odwiedzone.Count; i++)
            {
                var w = odwiedzone[i];
                MessageBox.Show(w.wartoœæ.ToString());
                foreach (var s¹siad in w.dzieci)
                {
                    if (!odwiedzone.Contains(s¹siad))
                    {
                        odwiedzone.Add(s¹siad);
                    }
                }
            }
        }



    }
}