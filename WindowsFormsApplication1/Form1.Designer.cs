namespace WindowsFormsApplication1
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
            this.checkNotification = new System.Windows.Forms.CheckBox();
            this.checkData = new System.Windows.Forms.CheckBox();
            this.send = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.groupBoxNotification = new System.Windows.Forms.GroupBox();
            this.comboBadge = new System.Windows.Forms.ComboBox();
            this.comboSound = new System.Windows.Forms.ComboBox();
            this.body = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTypeOfMessage = new System.Windows.Forms.GroupBox();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.message = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboPlatform = new System.Windows.Forms.ComboBox();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.platform = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.checkDelay = new System.Windows.Forms.CheckBox();
            this.checkAvailablity = new System.Windows.Forms.CheckBox();
            this.timeToLive = new System.Windows.Forms.TextBox();
            this.collapsKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNotification.SuspendLayout();
            this.groupBoxTypeOfMessage.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkNotification
            // 
            this.checkNotification.AutoSize = true;
            this.checkNotification.Location = new System.Drawing.Point(20, 28);
            this.checkNotification.Name = "checkNotification";
            this.checkNotification.Size = new System.Drawing.Size(79, 17);
            this.checkNotification.TabIndex = 4;
            this.checkNotification.Text = "Notification";
            this.checkNotification.UseVisualStyleBackColor = true;
            this.checkNotification.CheckedChanged += new System.EventHandler(this.checkNotification_CheckedChanged);
            this.checkNotification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkData_MouseClick);
            // 
            // checkData
            // 
            this.checkData.AutoSize = true;
            this.checkData.Location = new System.Drawing.Point(105, 28);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(49, 17);
            this.checkData.TabIndex = 5;
            this.checkData.Text = "Data";
            this.checkData.UseVisualStyleBackColor = true;
            this.checkData.CheckedChanged += new System.EventHandler(this.checkData_CheckedChanged);
            this.checkData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkData_MouseClick);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(510, 327);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 6;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(429, 327);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(75, 23);
            this.cancle.TabIndex = 7;
            this.cancle.Text = "Cancle";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxNotification
            // 
            this.groupBoxNotification.Controls.Add(this.comboBadge);
            this.groupBoxNotification.Controls.Add(this.comboSound);
            this.groupBoxNotification.Controls.Add(this.body);
            this.groupBoxNotification.Controls.Add(this.title);
            this.groupBoxNotification.Controls.Add(this.label6);
            this.groupBoxNotification.Controls.Add(this.label5);
            this.groupBoxNotification.Controls.Add(this.label4);
            this.groupBoxNotification.Controls.Add(this.label3);
            this.groupBoxNotification.Enabled = false;
            this.groupBoxNotification.Location = new System.Drawing.Point(12, 160);
            this.groupBoxNotification.Name = "groupBoxNotification";
            this.groupBoxNotification.Size = new System.Drawing.Size(275, 138);
            this.groupBoxNotification.TabIndex = 8;
            this.groupBoxNotification.TabStop = false;
            this.groupBoxNotification.Text = "Notification";
            // 
            // comboBadge
            // 
            this.comboBadge.FormattingEnabled = true;
            this.comboBadge.Items.AddRange(new object[] {
            "1"});
            this.comboBadge.Location = new System.Drawing.Point(67, 105);
            this.comboBadge.Name = "comboBadge";
            this.comboBadge.Size = new System.Drawing.Size(202, 21);
            this.comboBadge.TabIndex = 7;
            this.comboBadge.Text = "0";
            this.comboBadge.SelectedIndexChanged += new System.EventHandler(this.comboBadge_SelectedIndexChanged);
            // 
            // comboSound
            // 
            this.comboSound.FormattingEnabled = true;
            this.comboSound.Items.AddRange(new object[] {
            "Default"});
            this.comboSound.Location = new System.Drawing.Point(67, 78);
            this.comboSound.Name = "comboSound";
            this.comboSound.Size = new System.Drawing.Size(202, 21);
            this.comboSound.TabIndex = 6;
            this.comboSound.Text = "Default";
            this.comboSound.SelectedIndexChanged += new System.EventHandler(this.comboSound_SelectedIndexChanged);
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(67, 53);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(202, 20);
            this.body.TabIndex = 5;
            this.body.Text = "Notification Message";
            this.body.TextChanged += new System.EventHandler(this.body_TextChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(67, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(202, 20);
            this.title.TabIndex = 4;
            this.title.Text = "Buzy Beez";
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            this.title.Enter += new System.EventHandler(this.title_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Badge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sound";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            // 
            // groupBoxTypeOfMessage
            // 
            this.groupBoxTypeOfMessage.Controls.Add(this.checkNotification);
            this.groupBoxTypeOfMessage.Controls.Add(this.checkData);
            this.groupBoxTypeOfMessage.Location = new System.Drawing.Point(12, 99);
            this.groupBoxTypeOfMessage.Name = "groupBoxTypeOfMessage";
            this.groupBoxTypeOfMessage.Size = new System.Drawing.Size(275, 55);
            this.groupBoxTypeOfMessage.TabIndex = 9;
            this.groupBoxTypeOfMessage.TabStop = false;
            this.groupBoxTypeOfMessage.Text = "Type of Message";
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.message);
            this.groupBoxMessage.Enabled = false;
            this.groupBoxMessage.Location = new System.Drawing.Point(293, 160);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(292, 143);
            this.groupBoxMessage.TabIndex = 10;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Message";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(6, 19);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(280, 118);
            this.message.TabIndex = 0;
            this.message.Text = "Type your message here.";
            this.message.TextChanged += new System.EventHandler(this.dataMessage_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboPlatform);
            this.groupBox4.Controls.Add(this.comboUser);
            this.groupBox4.Controls.Add(this.platform);
            this.groupBox4.Controls.Add(this.user);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 81);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Audience";
            // 
            // comboPlatform
            // 
            this.comboPlatform.FormattingEnabled = true;
            this.comboPlatform.Items.AddRange(new object[] {
            "Android",
            "iOS"});
            this.comboPlatform.Location = new System.Drawing.Point(67, 48);
            this.comboPlatform.Name = "comboPlatform";
            this.comboPlatform.Size = new System.Drawing.Size(202, 21);
            this.comboPlatform.TabIndex = 3;
            this.comboPlatform.Text = "iOS";
            this.comboPlatform.SelectedIndexChanged += new System.EventHandler(this.comboPlatform_SelectedIndexChanged);
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Items.AddRange(new object[] {
            "All Users"});
            this.comboUser.Location = new System.Drawing.Point(67, 20);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(202, 21);
            this.comboUser.TabIndex = 2;
            this.comboUser.Text = "All Users";
            this.comboUser.SelectedIndexChanged += new System.EventHandler(this.comboUser_SelectedIndexChanged);
            // 
            // platform
            // 
            this.platform.AutoSize = true;
            this.platform.Location = new System.Drawing.Point(10, 51);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(45, 13);
            this.platform.TabIndex = 1;
            this.platform.Text = "Platform";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(10, 23);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(29, 13);
            this.user.TabIndex = 0;
            this.user.Text = "User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboPriority);
            this.groupBox1.Controls.Add(this.checkDelay);
            this.groupBox1.Controls.Add(this.checkAvailablity);
            this.groupBox1.Controls.Add(this.timeToLive);
            this.groupBox1.Controls.Add(this.collapsKey);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(293, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 142);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FCM Property";
            // 
            // comboPriority
            // 
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Items.AddRange(new object[] {
            "High",
            "Low"});
            this.comboPriority.Location = new System.Drawing.Point(102, 48);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(184, 21);
            this.comboPriority.TabIndex = 10;
            this.comboPriority.Text = "High";
            // 
            // checkDelay
            // 
            this.checkDelay.AutoSize = true;
            this.checkDelay.Checked = true;
            this.checkDelay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDelay.Location = new System.Drawing.Point(233, 115);
            this.checkDelay.Name = "checkDelay";
            this.checkDelay.Size = new System.Drawing.Size(53, 17);
            this.checkDelay.TabIndex = 9;
            this.checkDelay.Text = "Delay";
            this.checkDelay.UseVisualStyleBackColor = true;
            // 
            // checkAvailablity
            // 
            this.checkAvailablity.AutoSize = true;
            this.checkAvailablity.Checked = true;
            this.checkAvailablity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAvailablity.Location = new System.Drawing.Point(102, 115);
            this.checkAvailablity.Name = "checkAvailablity";
            this.checkAvailablity.Size = new System.Drawing.Size(73, 17);
            this.checkAvailablity.TabIndex = 8;
            this.checkAvailablity.Text = "Availablity";
            this.checkAvailablity.UseVisualStyleBackColor = true;
            // 
            // timeToLive
            // 
            this.timeToLive.Location = new System.Drawing.Point(102, 74);
            this.timeToLive.Name = "timeToLive";
            this.timeToLive.Size = new System.Drawing.Size(184, 20);
            this.timeToLive.TabIndex = 7;
            this.timeToLive.Text = "2419200";
            // 
            // collapsKey
            // 
            this.collapsKey.Location = new System.Drawing.Point(102, 20);
            this.collapsKey.Name = "collapsKey";
            this.collapsKey.Size = new System.Drawing.Size(184, 20);
            this.collapsKey.TabIndex = 5;
            this.collapsKey.Text = "Jobs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Time to Live";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Collaps Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.groupBoxTypeOfMessage);
            this.Controls.Add(this.groupBoxNotification);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.send);
            this.Name = "Form1";
            this.Text = "FCM Cloud Messaging";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNotification.ResumeLayout(false);
            this.groupBoxNotification.PerformLayout();
            this.groupBoxTypeOfMessage.ResumeLayout(false);
            this.groupBoxTypeOfMessage.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkNotification;
        private System.Windows.Forms.CheckBox checkData;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.GroupBox groupBoxNotification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBadge;
        private System.Windows.Forms.ComboBox comboSound;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.GroupBox groupBoxTypeOfMessage;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label platform;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.ComboBox comboPlatform;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox collapsKey;
        private System.Windows.Forms.TextBox timeToLive;
        private System.Windows.Forms.CheckBox checkDelay;
        private System.Windows.Forms.CheckBox checkAvailablity;
        private System.Windows.Forms.ComboBox comboPriority;
    }
}

