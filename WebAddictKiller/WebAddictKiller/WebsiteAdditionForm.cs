using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebAddictKiller
{
    public partial class WebsiteAdditionForm : Form
    {
        public string url;

        public WebsiteAdditionForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            url = urlTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
