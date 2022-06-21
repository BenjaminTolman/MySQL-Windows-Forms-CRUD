using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_CRUD_Forms
{
    public partial class InputForm : Form
    {
        public EventHandler AddedRecord;
        public EventHandler EditedRecord;

        public InputForm()
        {
            InitializeComponent();
            HandleClientWindowSize();
        }

        public ContactData Contact
        {
            get
            {
                ContactData c = new ContactData();

                c.FirstName = txt_FirstName.Text;
                c.LastName = txt_LastName.Text;
                c.Email = txt_Email.Text;

                string phone = (txt_Phone1.Text + txt_Phone2.Text + txt_Phone3.Text);
                c.PhoneNumber = phone;

                if (rdo_Friend.Checked) { c.Relation = "friend"; }
                if (rdo_Family.Checked) { c.Relation = "family"; }
                if (rdo_Business.Checked) { c.Relation = "business"; }
                if (rdo_Other.Checked) { c.Relation = "other"; }

                return c;
            }


            set
            {
                num_Id.Value = value.ID;
                txt_FirstName.Text = value.FirstName;
                txt_LastName.Text = value.LastName;
                txt_Email.Text = value.Email;

                int counter = 0;
                int phoneCounter = 0;
                string phone = value.PhoneNumber;
                string[] temp3 = new string[] { "0", "0", "0" };
                string[] temp4 = new string[] { "0", "0", "0" , "0"};

                while (counter < 3)
                {
                    temp3[counter] = phone[phoneCounter].ToString();
                    counter++;
                    phoneCounter++;
                }
                txt_Phone1.Text = String.Concat(temp3);
                counter = 0;

                while (counter < 3)
                {
                    temp3[counter] = phone[phoneCounter].ToString();
                    counter++;
                    phoneCounter++;
                }
                txt_Phone2.Text = String.Concat(temp3);
                counter = 0;

                while (counter < 4)
                {
                    temp4[counter] = phone[phoneCounter].ToString();
                    counter++;
                    phoneCounter++;
                }
                txt_Phone3.Text = String.Concat(temp4);

                if (value.Relation == "friend") { rdo_Friend.Checked = true; }
                if (value.Relation == "family") { rdo_Family.Checked = true; }
                if (value.Relation == "business") { rdo_Business.Checked = true; }
                if (value.Relation == "other") { rdo_Other.Checked = true; }
            }

        }

        public void FormType(bool add)
        {
            if (add) { btn_AddContactInputForm.Visible = true; }
            else { btn_UpdateContactInputForm.Visible = true; }
        }

        // TODO this validates the blocks for an add or update click to be successful.
        private bool ValidateData()
        {

            if (!Validation.GetString(txt_FirstName.Text, "First Name"))
            {
                return false;
            }
            if (!Validation.GetString(txt_LastName.Text, "Last Name"))
            {
                return false;
            }
            if (!Validation.GetEmail(txt_Email.Text, "Email"))
            {
                return false;
            }

            if (txt_Phone1.Text.Count() != 3 || txt_Phone2.Text.Count() != 3 || txt_Phone3.Text.Count() != 4) 
            {
                MessageBox.Show("Phone Number must be in valid format.");
                return false;
            }

            string phoneNumber = (txt_Phone1.Text + txt_Phone2.Text + txt_Phone3.Text);
            if (!Validation.GetPhoneNumber(phoneNumber, "Phone Number"))
            {
                return false;
            }
            else
            {
                return true;
            }
          
        }
        
        private void btn_AddContactInputForm_Click(object sender, EventArgs e)
        {
            //TODO if validation = true, good.. if not message Box
            if(ValidateData())
            {
                if (AddedRecord != null)
                {
                    AddedRecord(this, new EventArgs());
                }

                this.Close();
            }

            

        }

        private void btn_UpdateContactInputForm_Click(object sender, EventArgs e)
        {
            if (EditedRecord != null)
            {
                EditedRecord(this, new EventArgs());
            }

            this.Close();
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
