using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = new int[5];
            tab[0] = 2;
            tab[1] = 5;
            tab[2] = 4;
            tab[3] = 7;
            tab[4] = 3;

            sort(tab);

            MessageBox.Show(tab.ToString);
        }

        private static void sort(int[] tab)
        {
            bool cbz = false;
            do
            {
                cbz = false;
                int n = tab.Length;
                int holder;
                for (int i = 0; i < n - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        cbz = true;
                        holder = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = holder;
                    }
                }
            } while (cbz);
        }

        /*private static String tabtoSTR(int[] tab)
        {
            int n = tab.Length;
            String result = "";
            for(int i = 0; i < n; i++)
            {
                result =+ tab[i].ToString + ", ";
            }
            return result;
        }*/
    }
}