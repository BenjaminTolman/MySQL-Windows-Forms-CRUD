namespace MySQL_CRUD_Forms
{
    partial class ContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddContact = new System.Windows.Forms.Button();
            this.btn_DeleteContact = new System.Windows.Forms.Button();
            this.btn_ViewContact = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(44, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 252);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Friends.png");
            this.imageList1.Images.SetKeyName(1, "Family.png");
            this.imageList1.Images.SetKeyName(2, "Business.png");
            this.imageList1.Images.SetKeyName(3, "Other.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(44, 103);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(54, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // btn_AddContact
            // 
            this.btn_AddContact.Location = new System.Drawing.Point(44, 425);
            this.btn_AddContact.Name = "btn_AddContact";
            this.btn_AddContact.Size = new System.Drawing.Size(90, 50);
            this.btn_AddContact.TabIndex = 2;
            this.btn_AddContact.Text = "Add Contact";
            this.btn_AddContact.UseVisualStyleBackColor = true;
            this.btn_AddContact.Click += new System.EventHandler(this.btn_AddContact_Click);
            // 
            // btn_DeleteContact
            // 
            this.btn_DeleteContact.Location = new System.Drawing.Point(262, 425);
            this.btn_DeleteContact.Name = "btn_DeleteContact";
            this.btn_DeleteContact.Size = new System.Drawing.Size(90, 50);
            this.btn_DeleteContact.TabIndex = 3;
            this.btn_DeleteContact.Text = "Delete Contact";
            this.btn_DeleteContact.UseVisualStyleBackColor = true;
            this.btn_DeleteContact.Visible = false;
            this.btn_DeleteContact.Click += new System.EventHandler(this.btn_DeleteContact_Click);
            // 
            // btn_ViewContact
            // 
            this.btn_ViewContact.Location = new System.Drawing.Point(135, 425);
            this.btn_ViewContact.Name = "btn_ViewContact";
            this.btn_ViewContact.Size = new System.Drawing.Size(126, 50);
            this.btn_ViewContact.TabIndex = 4;
            this.btn_ViewContact.Text = "View / Update Contact";
            this.btn_ViewContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ViewContact.UseVisualStyleBackColor = true;
            this.btn_ViewContact.Visible = false;
            this.btn_ViewContact.Click += new System.EventHandler(this.btn_ViewContact_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::MySQL_CRUD_Forms.Properties.Resources.iPhone7Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 664);
            this.Controls.Add(this.btn_ViewContact);
            this.Controls.Add(this.btn_DeleteContact);
            this.Controls.Add(this.btn_AddContact);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContactsForm";
            this.Text = "Contacts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddContact;
        private System.Windows.Forms.Button btn_DeleteContact;
        private System.Windows.Forms.Button btn_ViewContact;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}

