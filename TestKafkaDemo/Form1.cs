using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestKafka;
using TestKafkaDemo.Models;

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
            topicComboBox.Items.AddRange(GetTopics());
            topicComboBox.SelectedIndex = 0;
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
        
        private void consumeButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                consumeTextBox.Text = string.Empty;
                consumeTextBox.Text = ConsumeMessage(topicComboBox.Text);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(exception.Message.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void produceTextBox_TextChanged(object sender, EventArgs e)
        {
            produceButton.Enabled = produceTextBox.Text.Length > 0;
        }

        private void produceButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var message = produceTextBox.Text;
            _ = ProduceMessage(topicComboBox.Text, message);

            produceTextBox.Text = string.Empty;
            var caption = $"Successfully added to topic {topicComboBox.Text}";
            Cursor.Current = Cursors.Default;

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #region Helper Functions

        private static string ConsumeMessage(string topic)
        {
            return MessageHandler.ConsumeMessage(
                Properties.Resources.KafkaServerUri, topic, Properties.Resources.KafkaGroupId);
        }

        private static async Task ProduceMessage(string topic, string message)
        {
            await MessageHandler.ProduceMessage(Properties.Resources.KafkaServerUri, topic, message);
        }

        private object[] GetTopics()
        {
            var topicConfiguration = File.ReadAllText(Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new Exception("Could not find current directory"),
                Properties.Resources.TopicConfigurationFile));
           return JsonSerializer.Deserialize<TopicList>(topicConfiguration).Topics
                .Select(t => t.Name).ToArray<object>();
        }

        #endregion
    }
}
