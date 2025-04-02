using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Forms_project
{
    public partial class AdminPage : Form
    {
        private ClientManager clientManager;

        public AdminPage()
        {
            InitializeComponent();
            clientManager = new ClientManager();
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            DataTable clientData = clientManager.GetAllClients();
            DtaGridClient.DataSource = clientData;

            string filePath = "client_db.txt";
            clientManager.ExportToTextFile(clientData, filePath);

            MessageBox.Show("Saved to file!");
        }

        private void CmboBxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = CmboBxSortBy.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(columnName))
            {
                DataTable sortedData = clientManager.SortBy(columnName);
                DtaGridClient.DataSource = sortedData;
            }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            CmboBxSortBy.SelectedItem = null;
            CmboBxSortBy.SelectedText = "Sort by:";

            DataTable clientData = clientManager.GetAllClients();
            DtaGridClient.DataSource = clientData;
        }

        private void BtnSearchClientID_Click(object sender, EventArgs e)
        {
            string clientId = TxtEnterClientID.Text;
            DataTable searchResult = clientManager.SearchByClientID(clientId);
            DtaGridClient.DataSource = searchResult;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Homepage homepageNew = new Homepage();
            this.Close();
            homepageNew.Show();
        }

        private void TxtEnterClientID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DtaGridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }

    public class ClientManager
    {
        private SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MKO677AQ\SQLEXPRESS;Initial Catalog=ClientSystem;Integrated Security=True");

        public DataTable GetAllClients()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ClientID, Password, Name, Address, PhoneNumber, Email FROM Client", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        public void ExportToTextFile(DataTable dataTable, string filePath)
        {
            using (TextWriter writer = new StreamWriter(filePath))
            {
                int i, j = 0;
                for (i = 0; i < dataTable.Rows.Count - 1; i++)
                {
                    for (j = 0; j < dataTable.Columns.Count; j++)
                    {
                        writer.Write($"{dataTable.Rows[i][j].ToString()}");
                        writer.Write(", ");
                    }
                    writer.WriteLine(" ");
                }
            }
        }

        public DataTable SortBy(string columnName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Client", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            DataView dv = new DataView(dt);
            dv.Sort = columnName;

            con.Close();

            return dv.ToTable();
        }

        public DataTable SearchByClientID(string clientId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Client WHERE ClientID = '{clientId}'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }
    }
}