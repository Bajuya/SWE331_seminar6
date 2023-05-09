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
    public partial class Seminar3 : Form
    {
        public Seminar3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtb_undsen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_urwuu_Click(object sender, EventArgs e)
        {
            string a = txtb_undsen.Text;
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            lbl_urwuu.Text = new string(b);
        }

        private void btn_hashilt_Click(object sender, EventArgs e)
        {
            lbl_hashilt.Text = "\"" + txtb_undsen.Text + "\"";
        }

        private void btn_noyes_Click(object sender, EventArgs e)
        {
            string str = txtb_undsen.Text;
            lbl_noyes.Text = str.Replace("no", "yes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = txtb_undsen.Text;
            string onlabel = "";
            for(int i = 0; i < str.Length; i++)
            {
                onlabel += str[i] + "\n";
            }
            lbl_split.Text = onlabel;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = Int16.Parse(txtb_urgun5.Text);
            richTextBox1.Width = Int16.Parse(txtb_urt5.Text);
            richTextBox1.Visible= true;
            richTextBox1.Text = txtb_text5.Text;
            richTextBox1.Name= txtb_ner5.Text;
        }

        private void txtb_urgun5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_ner5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seminar3_Load(object sender, EventArgs e)
        {

        }
    }
}
