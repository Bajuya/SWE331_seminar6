using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Seminar6
{
    public partial class login_frm : Form
    {
        public int user;
        public login_frm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=Lab;Integrated Security=True"); 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_frm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Regex text = new Regex("^[a-zA-Z0-9]{1,}");
            if (text.IsMatch(username.Text))
            {
                if (text.IsMatch(password.Text))
                {

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Users where username = '" + username.Text + "' AND password = '" + password.Text + "' ;";

                    try
                    {
                        SqlDataReader rdr = cmd.ExecuteReader();
                        rdr.Read();
                        user = (int)rdr["user_id"];
                        if (user > 0)
                        {
                            MessageBox.Show("Амжилттай нэвтэрлээ :)");
                            frm_user_info scren = new frm_user_info();
                            scren.Show();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Таны мэдээлэл алдаатай байна!!!");
                    }

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Та нэвтрэх нэрээ оруулна уу");
            }
        }
    }
}
