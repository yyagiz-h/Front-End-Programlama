using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        double [] sayi=new double [1000];
        int k = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("BİR SAYI GİRİN");
                return;
            }
            sayi[k]= Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add((k + 1).ToString() + ". sayı=" + sayi[k].ToString());
            k += 1;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam= 0 , ort= 0 ;
            for (int i = 0; i < k; i++)
            {
                toplam = sayi[i];
            }
            ort = toplam / Convert.ToDouble(k);
            this.Text = toplam.ToString();
            this.Text = String.Format("toplam={0} ve ortalama={1}",toplam,ort);

        }
    }
}
