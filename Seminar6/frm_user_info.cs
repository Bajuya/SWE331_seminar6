using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class frm_user_info : Form
    {
        public frm_user_info()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView2.SelectedNode.Text == "Хэрэглэгч")
            {
                panel1.Controls.Clear();
/*                frm_user_info frm = new frm_user_info();
             
                panel1.Controls.Add(frm);*/
                panel1.Visible = true;

            }

            if (treeView2.SelectedNode.Text == "Бүтээгдэхүүн")
            {
                panel1.Controls.Clear();
                panel1.Visible = true;

            }
        }

        private void treeView2_BeforeSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView2.SelectedNode.Index.ToString());
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
