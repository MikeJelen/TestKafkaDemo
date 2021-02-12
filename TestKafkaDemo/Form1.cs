using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestKafkaDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = Environment.UserName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gitBashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.GitBashInstructions);
        }

        private void kafkaInstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.KafkaInstructions);
        }

        private void installationInstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.InstallationInstructions);
        }
    }
}
