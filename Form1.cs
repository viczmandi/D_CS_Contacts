using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
            setComboBox();
        }

        public void setComboBox()
        {
            typeComboBox.Items.Add(Type.Home.ToString());
            typeComboBox.Items.Add(Type.Workplace.ToString());
            typeComboBox.Items.Add(Type.Mobile.ToString());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TelephoneDirectory.contactList.Add(new Person(nameBox.Text, addressBox.Text, int.Parse(ageBox.Text), long.Parse(mobileBox.Text), typeComboBox.Text));
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            typeComboBox.Items.Clear();
            foreach (var contact in TelephoneDirectory.contactList)
            {
                listBox.Items.Add(contact);
            }
        }
    }
}
