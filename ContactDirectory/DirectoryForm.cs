using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactDirectory
{
    /// <summary>
    /// Class that represents the Main Form of the application
    /// </summary>
    public partial class DirectoryForm : Form
    {
        /// <summary>
        /// Constructor of the form which will create and initialize all of the controls on the form
        /// </summary>
        public DirectoryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event hander called when the user clicks on the image.
        /// </summary>
        /// <param name="sender">the image (picture box) control</param>
        /// <param name="e">not used</param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnShowAboutBox(object sender, EventArgs e)
        {
            MessageBox.Show("Canyon Aeroad 2012");
        }

        /// <summary>
        /// Event handler for saving a new record
        /// </summary>
        /// <param name="sender">the save button</param>
        /// <param name="e">not used</param>
        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // perform data validation
            this.Validate();

            // ensure any temporary changes are made final
            this.bndContactList.EndEdit();

            // update the database with all changes
            this.taContactsAdapterManager.UpdateAll(this.contactDataSet);
        }

        private void DirectoryForm_Load(object sender, EventArgs e)
        {
            // fill the local data set 
            taContacts.Fill(this.contactDataSet.Contacts);

        }

        private void OnClose(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
    }
}
