namespace MySQL_CRUD_Forms
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_Id = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Phone2 = new System.Windows.Forms.TextBox();
            this.txt_Phone3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_Other = new System.Windows.Forms.RadioButton();
            this.rdo_Business = new System.Windows.Forms.RadioButton();
            this.rdo_Family = new System.Windows.Forms.RadioButton();
            this.rdo_Friend = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Phone1 = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.btn_AddContactInputForm = new System.Windows.Forms.Button();
            this.btn_UpdateContactInputForm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_Id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Phone2);
            this.groupBox1.Controls.Add(this.txt_Phone3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Phone1);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.txt_FirstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Data";
            // 
            // num_Id
            // 
            this.num_Id.Location = new System.Drawing.Point(130, 34);
            this.num_Id.Name = "num_Id";
            this.num_Id.ReadOnly = true;
            this.num_Id.Size = new System.Drawing.Size(144, 26);
            this.num_Id.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Id Number";
            // 
            // txt_Phone2
            // 
            this.txt_Phone2.Location = new System.Drawing.Point(176, 189);
            this.txt_Phone2.Name = "txt_Phone2";
            this.txt_Phone2.Size = new System.Drawing.Size(39, 26);
            this.txt_Phone2.TabIndex = 25;
            // 
            // txt_Phone3
            // 
            this.txt_Phone3.Location = new System.Drawing.Point(221, 189);
            this.txt_Phone3.Name = "txt_Phone3";
            this.txt_Phone3.Size = new System.Drawing.Size(52, 26);
            this.txt_Phone3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "xxxx";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_Other);
            this.groupBox2.Controls.Add(this.rdo_Business);
            this.groupBox2.Controls.Add(this.rdo_Family);
            this.groupBox2.Controls.Add(this.rdo_Friend);
            this.groupBox2.Location = new System.Drawing.Point(27, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relationship";
            // 
            // rdo_Other
            // 
            this.rdo_Other.AutoSize = true;
            this.rdo_Other.Checked = true;
            this.rdo_Other.Location = new System.Drawing.Point(127, 53);
            this.rdo_Other.Name = "rdo_Other";
            this.rdo_Other.Size = new System.Drawing.Size(67, 24);
            this.rdo_Other.TabIndex = 12;
            this.rdo_Other.TabStop = true;
            this.rdo_Other.Text = "Other";
            this.rdo_Other.UseVisualStyleBackColor = true;
            // 
            // rdo_Business
            // 
            this.rdo_Business.AutoSize = true;
            this.rdo_Business.Location = new System.Drawing.Point(12, 53);
            this.rdo_Business.Name = "rdo_Business";
            this.rdo_Business.Size = new System.Drawing.Size(92, 24);
            this.rdo_Business.TabIndex = 11;
            this.rdo_Business.Text = "Business";
            this.rdo_Business.UseVisualStyleBackColor = true;
            // 
            // rdo_Family
            // 
            this.rdo_Family.AutoSize = true;
            this.rdo_Family.Location = new System.Drawing.Point(127, 30);
            this.rdo_Family.Name = "rdo_Family";
            this.rdo_Family.Size = new System.Drawing.Size(72, 24);
            this.rdo_Family.TabIndex = 10;
            this.rdo_Family.Text = "Family";
            this.rdo_Family.UseVisualStyleBackColor = true;
            // 
            // rdo_Friend
            // 
            this.rdo_Friend.AutoSize = true;
            this.rdo_Friend.Location = new System.Drawing.Point(12, 30);
            this.rdo_Friend.Name = "rdo_Friend";
            this.rdo_Friend.Size = new System.Drawing.Size(72, 24);
            this.rdo_Friend.TabIndex = 9;
            this.rdo_Friend.Text = "Friend";
            this.rdo_Friend.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "xxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "xxx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "First Name";
            // 
            // txt_Phone1
            // 
            this.txt_Phone1.Location = new System.Drawing.Point(130, 189);
            this.txt_Phone1.Name = "txt_Phone1";
            this.txt_Phone1.Size = new System.Drawing.Size(39, 26);
            this.txt_Phone1.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(130, 138);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(143, 26);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(130, 103);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(143, 26);
            this.txt_LastName.TabIndex = 2;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(130, 68);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(143, 26);
            this.txt_FirstName.TabIndex = 1;
            // 
            // btn_AddContactInputForm
            // 
            this.btn_AddContactInputForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddContactInputForm.Location = new System.Drawing.Point(115, 485);
            this.btn_AddContactInputForm.Name = "btn_AddContactInputForm";
            this.btn_AddContactInputForm.Size = new System.Drawing.Size(149, 46);
            this.btn_AddContactInputForm.TabIndex = 1;
            this.btn_AddContactInputForm.Text = "Add Contact";
            this.btn_AddContactInputForm.UseVisualStyleBackColor = true;
            this.btn_AddContactInputForm.Visible = false;
            this.btn_AddContactInputForm.Click += new System.EventHandler(this.btn_AddContactInputForm_Click);
            // 
            // btn_UpdateContactInputForm
            // 
            this.btn_UpdateContactInputForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateContactInputForm.Location = new System.Drawing.Point(115, 485);
            this.btn_UpdateContactInputForm.Name = "btn_UpdateContactInputForm";
            this.btn_UpdateContactInputForm.Size = new System.Drawing.Size(149, 46);
            this.btn_UpdateContactInputForm.TabIndex = 2;
            this.btn_UpdateContactInputForm.Text = "Update Contact";
            this.btn_UpdateContactInputForm.UseVisualStyleBackColor = true;
            this.btn_UpdateContactInputForm.Visible = false;
            this.btn_UpdateContactInputForm.Click += new System.EventHandler(this.btn_UpdateContactInputForm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::MySQL_CRUD_Forms.Properties.Resources.iPhone7Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 664);
            this.Controls.Add(this.btn_UpdateContactInputForm);
            this.Controls.Add(this.btn_AddContactInputForm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Id)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_Other;
        private System.Windows.Forms.RadioButton rdo_Business;
        private System.Windows.Forms.RadioButton rdo_Family;
        private System.Windows.Forms.RadioButton rdo_Friend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Phone1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_Phone2;
        private System.Windows.Forms.TextBox txt_Phone3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddContactInputForm;
        private System.Windows.Forms.Button btn_UpdateContactInputForm;
        private System.Windows.Forms.NumericUpDown num_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}