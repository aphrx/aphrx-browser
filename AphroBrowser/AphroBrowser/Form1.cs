using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AphroBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NavigateToPage("google.ca");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            MessageBox.Show("Created by Aphro" + Environment.NewLine + Environment.NewLine + "Version 0.1.4", "About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPage(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

        private void NavigateToPage(string a)
        {
            webBrowser1.Navigate(a);

            button1.Enabled = false;
            textBox1.Enabled = false;

            if((a.Contains(".ca")||a.Contains(".com")) == false)
            {
                webBrowser1.Navigate("https://www.google.ca/search?q=" + a);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage(textBox1.Text);
            }
        }

        private void websitesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void googlecomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToPage("google.ca");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
