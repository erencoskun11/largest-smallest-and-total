using System;
using System.Windows.Forms;

namespace denemeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void EKLE_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[listBox1.Items.Count];
            for(int i = 0; i < listBox1.Items.Count; i++) 
            {
                dizi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(dizi);
            label4.Text = dizi[listBox1.Items.Count-1].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dizi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(dizi);
            label5.Text = dizi[0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum=0;
            int[] dizi = new int[listBox1.Items.Count];
            for ( int i = 0;i < listBox1.Items.Count;i++)
            {
                dizi[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            for( int i = 0;i<dizi.Length ; i++ ) 
            {
               sum += dizi[i];
            }
            label6.Text = sum.ToString();



        }
    }
}
