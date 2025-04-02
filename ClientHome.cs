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
    public partial class ClientHome : Form
    {
        public ClientHome()
        {
            InitializeComponent();
        }
        public class Client
        {
            public int ClientID { get; set; }
            public string Password { get; set; }
            public bool Software { get; set; }
            public bool LaptopsPC { get; set; }
            public bool Games { get; set; }
            public bool OfficeTools { get; set; }
            public bool Accessories { get; set; }

            public Client(int clientID, string password)
            {
                ClientID = clientID;
                Password = password;
            }

            public void UpdateProductSelection()
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MKO677AQ\SQLEXPRESS;Initial Catalog=ClientSystem;Integrated Security=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Client SET Software=@Software, " +
                            "LaptopsPC=@LaptopsPC, Games=@Games, OfficeTools=@OfficeTools, Accessories=" +
                            "@Accessories WHERE ClientID = @ClientID AND Password = @Password", con);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Software", Software);
                        cmd.Parameters.AddWithValue("@LaptopsPC", LaptopsPC);
                        cmd.Parameters.AddWithValue("@Games", Games);
                        cmd.Parameters.AddWithValue("@OfficeTools", OfficeTools);
                        cmd.Parameters.AddWithValue("@Accessories", Accessories);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thank you for selecting our products!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product selection: " + ex.Message);
                }
            }
        }

        private void ClientHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Homepage HomeNew = new Homepage();
            this.Close();
            HomeNew.Show();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser DeleteNew = new DeleteUser();
            this.Hide();
            DeleteNew.Show();
        }

        private void BtnSelectProducts_Click(object sender, EventArgs e)
        {
           

            int clientID = int.Parse(TxtClientID.Text);
            string password = TxtPassword.Text;

            Client client = new Client(clientID, password);
            client.Software = ChkSoftware.Checked;
            client.LaptopsPC = ChkLaptopPc.Checked;
            client.Games = ChkGames.Checked;
            client.OfficeTools = ChkOfficeTools.Checked;
            client.Accessories = ChkAccessories.Checked;

            client.UpdateProductSelection();
        }

        private void ChkShowPass_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkShowPass.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}