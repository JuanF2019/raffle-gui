using System;
using System.Windows.Forms;

namespace RaffleGUI.UserInterface
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gitHubRepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gitHubRepoLink.LinkVisited = true;
            System.Diagnostics.Process.Start(gitHubRepoLink.Text);
        }

        private void linkedInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkedInLink.LinkVisited = true;
            System.Diagnostics.Process.Start(linkedInLink.Text);
        }

        private void gitHubAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gitHubAccountLink.LinkVisited = true;
            System.Diagnostics.Process.Start(gitHubAccountLink.Text);
        }
    }
}
