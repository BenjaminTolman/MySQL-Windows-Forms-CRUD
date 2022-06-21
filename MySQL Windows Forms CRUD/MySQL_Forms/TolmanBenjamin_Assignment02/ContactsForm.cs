using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace MySQL_CRUD_Forms
{
    // Please ensure connect.txt has line 1 IP Address and line 2 Port. (This program retrieves that data by line)
    // 127.0.0.1
    // 8889


    public partial class ContactsForm : Form
    {
        private List<ContactData> contacts = new List<ContactData>();
        private string connectionString = "";

        MySqlConnection conn = null;

        int selectedIndex = 0;

        public ContactsForm()
        {
            InitializeComponent();
            HandleClientWindowSize();
            
            CreateConnectionString();
            ConnectSQL();
            GetSQL();
        }

        private void CreateConnectionString()
        {
            // Connect to the connect.txt from VFW.
            try
            {
                StreamReader rdr = new StreamReader(@"C://vfw/connect.txt");
                string ip = "";
                string port = "";
                int count = 0;

                while (!rdr.EndOfStream)
                {
                    if (count == 0) { ip = rdr.ReadLine().ToString(); }
                    if (count == 1) { port = rdr.ReadLine().ToString(); }
                    count++;
                }

                connectionString = $@"server={ip};userid=dbsAdmin;password=password;database=ContactList;port={port};SslMode=none";

            }
            catch
            {
                MessageBox.Show("Could not find \"/C://vfw/connect.txt\"");
                Application.Exit();
            }

        }

        // Opens Connection
        private void ConnectSQL()
        {
            try
            {
                // Open a connection to MySQL 
                conn = new MySqlConnection(connectionString);
                conn.Open();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }

        // Gets the SQL data then puts it into objects for the list for easy manipulation.
        private void GetSQL()
        {
            contacts.Clear();
            listView1.Items.Clear();
            // SQL Statement
            string stm = "SELECT Id, firstname, lastname, phonenumber, email, relation FROM mycontacts;";

            // Data table to hold the data.
            DataTable dataTable = new DataTable();

            // Execute select.
            MySqlDataAdapter adr = new MySqlDataAdapter(stm, conn);

            // Put data into data table.
            adr.SelectCommand.CommandType = CommandType.Text;
            adr.Fill(dataTable);

            int pages = dataTable.Select().Length;
            int count = 0;

            while (count < pages)
            {
                ContactData c = new ContactData();
                int temp = 0;
                Int32.TryParse(dataTable.Rows[count]["Id"].ToString(), out temp);
                c.ID = temp;
                c.FirstName = dataTable.Rows[count]["firstname"].ToString();
                c.LastName = dataTable.Rows[count]["lastname"].ToString();
                c.PhoneNumber = dataTable.Rows[count]["phonenumber"].ToString();
                c.Email = dataTable.Rows[count]["email"].ToString();
                c.Relation = dataTable.Rows[count]["relation"].ToString();

                contacts.Add(c);
                count++;
            }
            
            listView1.Clear();
            foreach (ContactData c in contacts)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.ToString();
                lvi.Tag = c;

                if (c.Relation == "friend") { lvi.ImageIndex = 0; }
                if (c.Relation == "family") { lvi.ImageIndex = 1; }
                if (c.Relation == "business") { lvi.ImageIndex = 2; }
                if (c.Relation == "other") { lvi.ImageIndex = 3; }

                listView1.Items.Add(lvi);
            }
        }

        // Updates the list and refreshes list view.
        private void UpdateListView()
        {
            listView1.Clear();

            foreach (ContactData c in contacts)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.ToString();
                lvi.Tag = c;

                if (c.Relation == "friend") { lvi.ImageIndex = 0; }
                if (c.Relation == "family") { lvi.ImageIndex = 1; }
                if (c.Relation == "business") { lvi.ImageIndex = 2; }
                if (c.Relation == "other") { lvi.ImageIndex = 3; }

                listView1.Items.Add(lvi);
            }
        }

        // Tracks the index of items.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_DeleteContact.Visible = true;
            btn_ViewContact.Visible = true;

            if (listView1.SelectedItems.Count > 0)
            {
                selectedIndex = listView1.SelectedIndices[0];
            }
            
        }

        // Deletes a contact.
        private void btn_DeleteContact_Click(object sender, EventArgs e)
        {
            ContactData c = contacts[selectedIndex];

            string command = $"DELETE FROM mycontacts WHERE Id = {c.ID}";

            SQLUpdate(command);

            contacts.RemoveAt(selectedIndex);
            UpdateListView();
        }

        // Opens the Input form in Add mode.
        private void btn_AddContact_Click(object sender, EventArgs e)
        {
            InputForm i = new InputForm();
            i.FormType(true);

            i.AddedRecord += AddedRecordHandler;

            i.Show();

        }

        // Opens the Input form in Edit mode.
        private void btn_ViewContact_Click(object sender, EventArgs e)
        {
            InputForm i = new InputForm();
            i.FormType(false);

            i.Contact = contacts[selectedIndex];

            i.EditedRecord += EditedRecordHandler;

            i.Show();
        }

        // Edit the contact update database.
        private void EditedRecordHandler(object sender, EventArgs e)
        {
            InputForm i = sender as InputForm;
            ContactData nc = i.Contact;
            ContactData c = contacts[selectedIndex];

            c.FirstName = nc.FirstName;
            c.LastName = nc.LastName;
            c.PhoneNumber = nc.PhoneNumber;
            c.Email = nc.Email;
            c.Relation = nc.Relation;

            //UpdateListView();

            string command = $"UPDATE mycontacts SET FirstName = '{c.FirstName}', LastName = '{c.LastName}', PhoneNumber = '{c.PhoneNumber}', Email = '{c.Email}', Relation = '{c.Relation}' WHERE Id = {c.ID}";
            SQLUpdate(command);

            // Redo list info for contacts.
            GetSQL();
        }

        // Add the contact update database.
        private void AddedRecordHandler(object sender, EventArgs e)
        {
            InputForm i = sender as InputForm;
            ContactData c = i.Contact;

            ListViewItem lvi = new ListViewItem();
            lvi.Text = c.ToString();
            lvi.Tag = c;

            if (c.Relation == "friend") { lvi.ImageIndex = 0; }
            if (c.Relation == "family") { lvi.ImageIndex = 1; }
            if (c.Relation == "business") { lvi.ImageIndex = 2; }
            if (c.Relation == "other") { lvi.ImageIndex = 3; }
            
            string command = $"INSERT INTO mycontacts (FirstName, LastName, PhoneNumber, Email, Relation) Values('{c.FirstName}', '{c.LastName}', '{c.PhoneNumber}', '{c.Email}', '{c.Relation}')";

            SQLUpdate(command);

            // Redo list info for contacts.
            GetSQL();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        // Export a text file.
        private void Print()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".txt";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                using (StreamWriter writer = new StreamWriter(dlg.FileName))
                {

                    writer.WriteLine("Contacts List");
                    writer.WriteLine("-------------");

                    foreach (ContactData c in contacts)
                    {
                        writer.WriteLine("Name  " + c.FirstName.ToString() + " " + c.LastName.ToString());
                        writer.WriteLine("Email " + c.Email.ToString());
                        writer.WriteLine("Phone " + c.PhoneNumber.ToString());
                        writer.WriteLine("-------------");
                    }
                }
            }
        }

        private void SQLUpdate(string command)
        {
            
            MySqlCommand cmd = new MySqlCommand(command, conn);
            cmd.ExecuteNonQuery();
        }


        void HandleClientWindowSize()
        {
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
        }


    }
}
