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

namespace Forms_project
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        public class User
        {
            public string ClientID { get; private set; }
            public string Password { get; private set; }

            public User(string clientID, string password)
            {
                ClientID = clientID;
                Password = password;
            }

            public void Login()
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MKO677AQ\SQLEXPRESS;Initial Catalog=ClientSystem;Integrated Security=True"))
                    {
                        conn.Open();
                        string get_user = "SELECT * FROM Client WHERE ClientID = @ClientID AND Password = @Password";
                        SqlDataAdapter da = new SqlDataAdapter(get_user, conn);

                       
                        da.SelectCommand.Parameters.AddWithValue("@ClientID", ClientID);
                        da.SelectCommand.Parameters.AddWithValue("@Password", Password);

                        DataTable tb = new DataTable();
                        da.Fill(tb);

                        if (tb.Rows.Count > 0 && ClientID != "1" && Password != "admin")
                        {
                            ClientHome clientPage = new ClientHome();
                            clientPage.Show();
                        }
                        else if (tb.Rows.Count > 0 && ClientID == "1" && Password == "admin")
                        {
                            AdminPage adminPage = new AdminPage();
                            adminPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid login: " + ex.Message);
                }
            }

           
        }
        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void ChkBxShowPass_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkBxShowPass.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
    }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string clientID = TxtClientID.Text;
            string password = TxtPassword.Text;

            User user = new User(clientID, password);
            user.Login();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUser CreateUserPage = new CreateUser();
            this.Hide();
            CreateUserPage.Show();
        }

    }
}