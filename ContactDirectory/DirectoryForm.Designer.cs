namespace ContactDirectory
{
    partial class DirectoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryForm));
            System.Windows.Forms.Label lblContactId;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblCompany;
            System.Windows.Forms.Label lblTelephone;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblClient;
            System.Windows.Forms.Label lblLastCall;
            this._imgBike = new System.Windows.Forms.PictureBox();
            this.contactDataSet = new ContactDirectory.ContactDBDataSet();
            this.bndContactList = new System.Windows.Forms.BindingSource(this.components);
            this.taContacts = new ContactDirectory.ContactDBDataSetTableAdapters.ContactsTableAdapter();
            this.taContactsAdapterManager = new ContactDirectory.ContactDBDataSetTableAdapters.TableAdapterManager();
            this.bndNavContactList = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtContactId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ckbtnClient = new System.Windows.Forms.CheckBox();
            this.dtLastCall = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            lblContactId = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblCompany = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblLastCall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._imgBike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndNavContactList)).BeginInit();
            this.bndNavContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // _imgBike
            // 
            this._imgBike.Image = global::ContactDirectory.Properties.Resources.Canyon_Aeroad;
            this._imgBike.Location = new System.Drawing.Point(303, 47);
            this._imgBike.Name = "_imgBike";
            this._imgBike.Size = new System.Drawing.Size(148, 93);
            this._imgBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imgBike.TabIndex = 0;
            this._imgBike.TabStop = false;
            this._imgBike.Click += new System.EventHandler(this.OnShowAboutBox);
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDBDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bndContactList
            // 
            this.bndContactList.DataMember = "Contacts";
            this.bndContactList.DataSource = this.contactDataSet;
            // 
            // taContacts
            // 
            this.taContacts.ClearBeforeFill = true;
            // 
            // taContactsAdapterManager
            // 
            this.taContactsAdapterManager.BackupDataSetBeforeUpdate = false;
            this.taContactsAdapterManager.ContactsTableAdapter = this.taContacts;
            this.taContactsAdapterManager.UpdateOrder = ContactDirectory.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bndNavContactList
            // 
            this.bndNavContactList.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndNavContactList.BindingSource = this.bndContactList;
            this.bndNavContactList.CountItem = this.bindingNavigatorCountItem;
            this.bndNavContactList.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndNavContactList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactsBindingNavigatorSaveItem});
            this.bndNavContactList.Location = new System.Drawing.Point(0, 0);
            this.bndNavContactList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndNavContactList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndNavContactList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndNavContactList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndNavContactList.Name = "bndNavContactList";
            this.bndNavContactList.PositionItem = this.bindingNavigatorPositionItem;
            this.bndNavContactList.Size = new System.Drawing.Size(472, 25);
            this.bndNavContactList.TabIndex = 1;
            this.bndNavContactList.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contactsBindingNavigatorSaveItem
            // 
            this.contactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsBindingNavigatorSaveItem.Image")));
            this.contactsBindingNavigatorSaveItem.Name = "contactsBindingNavigatorSaveItem";
            this.contactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contactsBindingNavigatorSaveItem.Text = "Save Data";
            this.contactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsBindingNavigatorSaveItem_Click);
            // 
            // lblContactId
            // 
            lblContactId.AutoSize = true;
            lblContactId.Location = new System.Drawing.Point(12, 47);
            lblContactId.Name = "lblContactId";
            lblContactId.Size = new System.Drawing.Size(59, 13);
            lblContactId.TabIndex = 2;
            lblContactId.Text = "Contact Id:";
            // 
            // txtContactId
            // 
            this.txtContactId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndContactList, "ContactId", true));
            this.txtContactId.Location = new System.Drawing.Point(79, 44);
            this.txtContactId.Name = "txtContactId";
            this.txtContactId.Size = new System.Drawing.Size(200, 20);
            this.txtContactId.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(12, 73);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(38, 13);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndContactList, "Name", true));
            this.txtName.Location = new System.Drawing.Point(79, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new System.Drawing.Point(12, 99);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new System.Drawing.Size(54, 13);
            lblCompany.TabIndex = 6;
            lblCompany.Text = "Company:";
            // 
            // txtCompany
            // 
            this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndContactList, "Company", true));
            this.txtCompany.Location = new System.Drawing.Point(79, 96);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(200, 20);
            this.txtCompany.TabIndex = 7;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new System.Drawing.Point(10, 125);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(61, 13);
            lblTelephone.TabIndex = 8;
            lblTelephone.Text = "Telephone:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndContactList, "Telephone", true));
            this.txtTelephone.Location = new System.Drawing.Point(79, 122);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(200, 20);
            this.txtTelephone.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(12, 151);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndContactList, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(79, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new System.Drawing.Point(12, 179);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(36, 13);
            lblClient.TabIndex = 12;
            lblClient.Text = "Client:";
            // 
            // ckbtnClient
            // 
            this.ckbtnClient.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bndContactList, "Client", true));
            this.ckbtnClient.Location = new System.Drawing.Point(79, 174);
            this.ckbtnClient.Name = "ckbtnClient";
            this.ckbtnClient.Size = new System.Drawing.Size(200, 24);
            this.ckbtnClient.TabIndex = 13;
            this.ckbtnClient.UseVisualStyleBackColor = true;
            // 
            // lblLastCall
            // 
            lblLastCall.AutoSize = true;
            lblLastCall.Location = new System.Drawing.Point(12, 208);
            lblLastCall.Name = "lblLastCall";
            lblLastCall.Size = new System.Drawing.Size(50, 13);
            lblLastCall.TabIndex = 14;
            lblLastCall.Text = "Last Call:";
            // 
            // dtLastCall
            // 
            this.dtLastCall.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bndContactList, "LastCall", true));
            this.dtLastCall.Location = new System.Drawing.Point(79, 204);
            this.dtLastCall.Name = "dtLastCall";
            this.dtLastCall.Size = new System.Drawing.Size(200, 20);
            this.dtLastCall.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(303, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClose);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 249);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(lblContactId);
            this.Controls.Add(this.txtContactId);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblCompany);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(lblTelephone);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(lblClient);
            this.Controls.Add(this.ckbtnClient);
            this.Controls.Add(lblLastCall);
            this.Controls.Add(this.dtLastCall);
            this.Controls.Add(this.bndNavContactList);
            this.Controls.Add(this._imgBike);
            this.Name = "DirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Directory";
            this.Load += new System.EventHandler(this.DirectoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imgBike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndNavContactList)).EndInit();
            this.bndNavContactList.ResumeLayout(false);
            this.bndNavContactList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _imgBike;
        private ContactDBDataSet contactDataSet;
        private System.Windows.Forms.BindingSource bndContactList;
        private ContactDBDataSetTableAdapters.ContactsTableAdapter taContacts;
        private ContactDBDataSetTableAdapters.TableAdapterManager taContactsAdapterManager;
        private System.Windows.Forms.BindingNavigator bndNavContactList;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtContactId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox ckbtnClient;
        private System.Windows.Forms.DateTimePicker dtLastCall;
        private System.Windows.Forms.Button btnClose;
    }
}

