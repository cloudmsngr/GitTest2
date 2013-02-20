using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Novell.Directory.Ldap;
using System.Collections;
using Novell.Directory.Ldap.Utilclass;
using System.Security.Cryptography;
using System.Web;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        LdapConnection Connection = new LdapConnection();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");

            MessageBox.Show("hi1");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
    