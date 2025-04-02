using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Forms_project
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

       

        public class Client
        {
            public int ClientID { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

            public Client(int clientID, string password, string name, string address, string phoneNumber, string email)
            {
                ClientID = clientID;
                Password = password;
                Name = name;
                Address = address;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public void Register()
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MKO677AQ\SQLEXPRESS;Initial Catalog=ClientSystem;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Client (ClientID, Password, Name, Address, PhoneNumber, Email) VALUES (@ClientID, @Password, @Name, @Address, @PhoneNumber, @Email)", con);
                    cmd.Parameters.AddWithValue("@ClientID", ClientID);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client successfully registered");

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

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(TxtClientID.Text);
            string password = TxtPassword.Text;
            string name = TxtName.Text;
            string address = RichTextAddress.Text;
            string phoneNumber = TxtPhoneNo.Text;
            string email = TxtEmail.Text;

            Client newClient = new Client(clientID, password, name, address, phoneNumber, email);
            newClient.Register();

            Homepage HomePageNew = new Homepage();
            this.Hide();
            HomePageNew.Show();

        }
         
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Homepage Homepagenew = new Homepage();
            this.Hide();
            Homepagenew.Show();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}