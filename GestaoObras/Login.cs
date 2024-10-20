using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestaoObras
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-ENCAPB3M\SQLEXPRESS;Initial Catalog=GestaoObrasConstrucaoCivil;Integrated Security=True;TrustServerCertificate=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {



        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username, user_password;

            username = textBox_Username.Text;
            user_password = textBox_Password.Text;

            try
            {
                string querry = "SELECT * FROM Login_users WHERE username = '" + textBox_Username.Text + "' AND password = '" + textBox_Password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox_Username.Text;
                    user_password = textBox_Password.Text;

                    //page that needed to be load next
                    Menu menuForm = new Menu();
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Username.Clear();
                    textBox_Password.Clear();

                    textBox_Username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Username.Clear();
            textBox_Password.Clear();

            textBox_Username.Focus();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '*';
        }
    }
}
