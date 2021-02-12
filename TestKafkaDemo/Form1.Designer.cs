namespace TestKafkaDemo
{
    partial class Form1
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
            this.topicLabel = new System.Windows.Forms.Label();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.actionTabControl = new System.Windows.Forms.TabControl();
            this.tabProduce = new System.Windows.Forms.TabPage();
            this.produceButton = new System.Windows.Forms.Button();
            this.produceTextBox = new System.Windows.Forms.TextBox();
            this.tabConsume = new System.Windows.Forms.TabPage();
            this.consumeButton = new System.Windows.Forms.Button();
            this.consumeTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.userNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitBashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installationInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafkaInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.actionTabControl.SuspendLayout();
            this.tabProduce.SuspendLayout();
            this.tabConsume.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Location = new System.Drawing.Point(6, 53);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(43, 17);
            this.topicLabel.TabIndex = 0;
            this.topicLabel.Text = "Topic";
            // 
            // topicComboBox
            // 
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Location = new System.Drawing.Point(55, 53);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(419, 24);
            this.topicComboBox.TabIndex = 1;
            // 
            // actionTabControl
            // 
            this.actionTabControl.Controls.Add(this.tabProduce);
            this.actionTabControl.Controls.Add(this.tabConsume);
            this.actionTabControl.Location = new System.Drawing.Point(0, 95);
            this.actionTabControl.Name = "actionTabControl";
            this.actionTabControl.SelectedIndex = 0;
            this.actionTabControl.Size = new System.Drawing.Size(783, 227);
            this.actionTabControl.TabIndex = 2;
            // 
            // tabProduce
            // 
            this.tabProduce.Controls.Add(this.produceButton);
            this.tabProduce.Controls.Add(this.produceTextBox);
            this.tabProduce.Location = new System.Drawing.Point(4, 25);
            this.tabProduce.Name = "tabProduce";
            this.tabProduce.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduce.Size = new System.Drawing.Size(775, 198);
            this.tabProduce.TabIndex = 0;
            this.tabProduce.Text = "Create Message";
            this.tabProduce.UseVisualStyleBackColor = true;
            // 
            // produceButton
            // 
            this.produceButton.Location = new System.Drawing.Point(640, 155);
            this.produceButton.Name = "produceButton";
            this.produceButton.Size = new System.Drawing.Size(112, 23);
            this.produceButton.TabIndex = 1;
            this.produceButton.Text = "Post";
            this.produceButton.UseVisualStyleBackColor = true;
            // 
            // produceTextBox
            // 
            this.produceTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.produceTextBox.Location = new System.Drawing.Point(9, 7);
            this.produceTextBox.Multiline = true;
            this.produceTextBox.Name = "produceTextBox";
            this.produceTextBox.Size = new System.Drawing.Size(743, 141);
            this.produceTextBox.TabIndex = 0;
            // 
            // tabConsume
            // 
            this.tabConsume.Controls.Add(this.consumeButton);
            this.tabConsume.Controls.Add(this.consumeTextBox);
            this.tabConsume.Location = new System.Drawing.Point(4, 25);
            this.tabConsume.Name = "tabConsume";
            this.tabConsume.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsume.Size = new System.Drawing.Size(775, 198);
            this.tabConsume.TabIndex = 1;
            this.tabConsume.Text = "Get Message";
            this.tabConsume.UseVisualStyleBackColor = true;
            // 
            // consumeButton
            // 
            this.consumeButton.Location = new System.Drawing.Point(647, 162);
            this.consumeButton.Name = "consumeButton";
            this.consumeButton.Size = new System.Drawing.Size(112, 23);
            this.consumeButton.TabIndex = 3;
            this.consumeButton.Text = "Get";
            this.consumeButton.UseVisualStyleBackColor = true;
            // 
            // consumeTextBox
            // 
            this.consumeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.consumeTextBox.Location = new System.Drawing.Point(16, 14);
            this.consumeTextBox.Multiline = true;
            this.consumeTextBox.Name = "consumeTextBox";
            this.consumeTextBox.Size = new System.Drawing.Size(743, 141);
            this.consumeTextBox.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // userNameLabel
            // 
            this.userNameLabel.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(42, 20);
            this.userNameLabel.Text = "label";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topicListToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // topicListToolStripMenuItem
            // 
            this.topicListToolStripMenuItem.Name = "topicListToolStripMenuItem";
            this.topicListToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.topicListToolStripMenuItem.Text = "Topic List";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitBashToolStripMenuItem,
            this.installationInstructionsToolStripMenuItem,
            this.kafkaInstructionsToolStripMenuItem,
            this.toolStripSeparator2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gitBashToolStripMenuItem
            // 
            this.gitBashToolStripMenuItem.Name = "gitBashToolStripMenuItem";
            this.gitBashToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.gitBashToolStripMenuItem.Text = "Git Bash Instructions";
            this.gitBashToolStripMenuItem.Click += new System.EventHandler(this.gitBashToolStripMenuItem_Click);
            // 
            // installationInstructionsToolStripMenuItem
            // 
            this.installationInstructionsToolStripMenuItem.Name = "installationInstructionsToolStripMenuItem";
            this.installationInstructionsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.installationInstructionsToolStripMenuItem.Text = "Installation Instructions";
            this.installationInstructionsToolStripMenuItem.Click += new System.EventHandler(this.installationInstructionsToolStripMenuItem_Click);
            // 
            // kafkaInstructionsToolStripMenuItem
            // 
            this.kafkaInstructionsToolStripMenuItem.Name = "kafkaInstructionsToolStripMenuItem";
            this.kafkaInstructionsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.kafkaInstructionsToolStripMenuItem.Text = "Kafka Instructions";
            this.kafkaInstructionsToolStripMenuItem.Click += new System.EventHandler(this.kafkaInstructionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 348);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.actionTabControl);
            this.Controls.Add(this.topicComboBox);
            this.Controls.Add(this.topicLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KafkaDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.actionTabControl.ResumeLayout(false);
            this.tabProduce.ResumeLayout(false);
            this.tabProduce.PerformLayout();
            this.tabConsume.ResumeLayout(false);
            this.tabConsume.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.TabControl actionTabControl;
        private System.Windows.Forms.TabPage tabProduce;
        private System.Windows.Forms.TabPage tabConsume;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel userNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kafkaInstructionsToolStripMenuItem;
        private System.Windows.Forms.Button produceButton;
        private System.Windows.Forms.TextBox produceTextBox;
        private System.Windows.Forms.Button consumeButton;
        private System.Windows.Forms.TextBox consumeTextBox;
        private System.Windows.Forms.ToolStripMenuItem gitBashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem installationInstructionsToolStripMenuItem;
    }
}

