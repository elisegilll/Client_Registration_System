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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }
       
        public class Client
        {
            public int ClientID { get; set; }
            public string Password { get; set; }

            public Client(int clientID, string password)
            {
                ClientID = clientID;
                Password = password;
            }

            public void Delete()
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MKO677AQ\SQLEXPRESS;Initial Catalog=ClientSystem;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Client WHERE ClientID = @ClientID AND Password = @Password", conn);
                    cmd.Parameters.AddWithValue("@ClientID", ClientID);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                }
            }
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

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
           
            int clientID = int.Parse(TxtClientID.Text);
            string password = TxtPassword.Text;

            Client clientToDelete = new Client(clientID, password);
            clientToDelete.Delete();
            Homepage NewHome = new Homepage();
            this.Hide();
            NewHome.Show();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ClientHome ClientHomeNew = new ClientHome();
            this.Hide();
            ClientHomeNew.Show();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}