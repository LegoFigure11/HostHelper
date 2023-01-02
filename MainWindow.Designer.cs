namespace HostHelper
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.InputSwitchIP = new System.Windows.Forms.TextBox();
            this.Guest1Group = new System.Windows.Forms.GroupBox();
            this.Guest1Status = new System.Windows.Forms.PictureBox();
            this.Guest1Ban = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Guest1NID = new System.Windows.Forms.TextBox();
            this.Guest1ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guest1OT = new System.Windows.Forms.TextBox();
            this.Guest2Group = new System.Windows.Forms.GroupBox();
            this.Guest2Status = new System.Windows.Forms.PictureBox();
            this.Guest2Ban = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Guest2NID = new System.Windows.Forms.TextBox();
            this.Guest2ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Guest2OT = new System.Windows.Forms.TextBox();
            this.Guest3Group = new System.Windows.Forms.GroupBox();
            this.Guest3Status = new System.Windows.Forms.PictureBox();
            this.Guest3Ban = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Guest3NID = new System.Windows.Forms.TextBox();
            this.Guest3ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Guest3OT = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonClearSession = new System.Windows.Forms.Button();
            this.LabelSession = new System.Windows.Forms.Label();
            this.Guest1Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest1Status)).BeginInit();
            this.Guest2Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest2Status)).BeginInit();
            this.Guest3Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest3Status)).BeginInit();
            this.SuspendLayout();
            // 
            // InputSwitchIP
            // 
            this.InputSwitchIP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputSwitchIP.Location = new System.Drawing.Point(12, 12);
            this.InputSwitchIP.Name = "InputSwitchIP";
            this.InputSwitchIP.Size = new System.Drawing.Size(112, 22);
            this.InputSwitchIP.TabIndex = 1;
            this.InputSwitchIP.Text = "192.168.0.0";
            this.InputSwitchIP.TextChanged += new System.EventHandler(this.InputSwitchIP_TextChanged);
            // 
            // Guest1Group
            // 
            this.Guest1Group.Controls.Add(this.Guest1Status);
            this.Guest1Group.Controls.Add(this.Guest1Ban);
            this.Guest1Group.Controls.Add(this.label3);
            this.Guest1Group.Controls.Add(this.Guest1NID);
            this.Guest1Group.Controls.Add(this.Guest1ID);
            this.Guest1Group.Controls.Add(this.label2);
            this.Guest1Group.Controls.Add(this.label1);
            this.Guest1Group.Controls.Add(this.Guest1OT);
            this.Guest1Group.Location = new System.Drawing.Point(130, 12);
            this.Guest1Group.Name = "Guest1Group";
            this.Guest1Group.Size = new System.Drawing.Size(497, 53);
            this.Guest1Group.TabIndex = 2;
            this.Guest1Group.TabStop = false;
            this.Guest1Group.Text = "Guest 1";
            // 
            // Guest1Status
            // 
            this.Guest1Status.Image = global::HostHelper.Properties.Resources.tick;
            this.Guest1Status.Location = new System.Drawing.Point(430, 24);
            this.Guest1Status.Name = "Guest1Status";
            this.Guest1Status.Size = new System.Drawing.Size(20, 20);
            this.Guest1Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guest1Status.TabIndex = 7;
            this.Guest1Status.TabStop = false;
            // 
            // Guest1Ban
            // 
            this.Guest1Ban.Enabled = false;
            this.Guest1Ban.Location = new System.Drawing.Point(455, 22);
            this.Guest1Ban.Name = "Guest1Ban";
            this.Guest1Ban.Size = new System.Drawing.Size(36, 23);
            this.Guest1Ban.TabIndex = 6;
            this.Guest1Ban.Text = "Ban";
            this.Guest1Ban.UseVisualStyleBackColor = true;
            this.Guest1Ban.Click += new System.EventHandler(this.Guest1Ban_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NID:";
            // 
            // Guest1NID
            // 
            this.Guest1NID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guest1NID.Location = new System.Drawing.Point(306, 22);
            this.Guest1NID.Name = "Guest1NID";
            this.Guest1NID.ReadOnly = true;
            this.Guest1NID.Size = new System.Drawing.Size(118, 22);
            this.Guest1NID.TabIndex = 4;
            this.Guest1NID.Text = "0123456789ABCDEF";
            // 
            // Guest1ID
            // 
            this.Guest1ID.Location = new System.Drawing.Point(184, 22);
            this.Guest1ID.Name = "Guest1ID";
            this.Guest1ID.ReadOnly = true;
            this.Guest1ID.Size = new System.Drawing.Size(80, 23);
            this.Guest1ID.TabIndex = 3;
            this.Guest1ID.Text = "(0000)-000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "OT:";
            // 
            // Guest1OT
            // 
            this.Guest1OT.Location = new System.Drawing.Point(36, 22);
            this.Guest1OT.Name = "Guest1OT";
            this.Guest1OT.ReadOnly = true;
            this.Guest1OT.Size = new System.Drawing.Size(115, 23);
            this.Guest1OT.TabIndex = 0;
            this.Guest1OT.Text = "wwwwwwwwwwww";
            // 
            // Guest2Group
            // 
            this.Guest2Group.Controls.Add(this.Guest2Status);
            this.Guest2Group.Controls.Add(this.Guest2Ban);
            this.Guest2Group.Controls.Add(this.label4);
            this.Guest2Group.Controls.Add(this.Guest2NID);
            this.Guest2Group.Controls.Add(this.Guest2ID);
            this.Guest2Group.Controls.Add(this.label5);
            this.Guest2Group.Controls.Add(this.label6);
            this.Guest2Group.Controls.Add(this.Guest2OT);
            this.Guest2Group.Location = new System.Drawing.Point(130, 71);
            this.Guest2Group.Name = "Guest2Group";
            this.Guest2Group.Size = new System.Drawing.Size(497, 53);
            this.Guest2Group.TabIndex = 8;
            this.Guest2Group.TabStop = false;
            this.Guest2Group.Text = "Guest 2";
            // 
            // Guest2Status
            // 
            this.Guest2Status.Image = global::HostHelper.Properties.Resources.tick;
            this.Guest2Status.Location = new System.Drawing.Point(430, 24);
            this.Guest2Status.Name = "Guest2Status";
            this.Guest2Status.Size = new System.Drawing.Size(20, 20);
            this.Guest2Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guest2Status.TabIndex = 7;
            this.Guest2Status.TabStop = false;
            // 
            // Guest2Ban
            // 
            this.Guest2Ban.Enabled = false;
            this.Guest2Ban.Location = new System.Drawing.Point(455, 22);
            this.Guest2Ban.Name = "Guest2Ban";
            this.Guest2Ban.Size = new System.Drawing.Size(36, 23);
            this.Guest2Ban.TabIndex = 6;
            this.Guest2Ban.Text = "Ban";
            this.Guest2Ban.UseVisualStyleBackColor = true;
            this.Guest2Ban.Click += new System.EventHandler(this.Guest2Ban_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "NID:";
            // 
            // Guest2NID
            // 
            this.Guest2NID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guest2NID.Location = new System.Drawing.Point(306, 22);
            this.Guest2NID.Name = "Guest2NID";
            this.Guest2NID.ReadOnly = true;
            this.Guest2NID.Size = new System.Drawing.Size(118, 22);
            this.Guest2NID.TabIndex = 4;
            this.Guest2NID.Text = "0123456789ABCDEF";
            // 
            // Guest2ID
            // 
            this.Guest2ID.Location = new System.Drawing.Point(184, 22);
            this.Guest2ID.Name = "Guest2ID";
            this.Guest2ID.ReadOnly = true;
            this.Guest2ID.Size = new System.Drawing.Size(80, 23);
            this.Guest2ID.TabIndex = 3;
            this.Guest2ID.Text = "(0000)-000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "OT:";
            // 
            // Guest2OT
            // 
            this.Guest2OT.Location = new System.Drawing.Point(36, 22);
            this.Guest2OT.Name = "Guest2OT";
            this.Guest2OT.ReadOnly = true;
            this.Guest2OT.Size = new System.Drawing.Size(115, 23);
            this.Guest2OT.TabIndex = 0;
            this.Guest2OT.Text = "wwwwwwwwwwww";
            // 
            // Guest3Group
            // 
            this.Guest3Group.Controls.Add(this.Guest3Status);
            this.Guest3Group.Controls.Add(this.Guest3Ban);
            this.Guest3Group.Controls.Add(this.label7);
            this.Guest3Group.Controls.Add(this.Guest3NID);
            this.Guest3Group.Controls.Add(this.Guest3ID);
            this.Guest3Group.Controls.Add(this.label8);
            this.Guest3Group.Controls.Add(this.label9);
            this.Guest3Group.Controls.Add(this.Guest3OT);
            this.Guest3Group.Location = new System.Drawing.Point(130, 130);
            this.Guest3Group.Name = "Guest3Group";
            this.Guest3Group.Size = new System.Drawing.Size(497, 53);
            this.Guest3Group.TabIndex = 8;
            this.Guest3Group.TabStop = false;
            this.Guest3Group.Text = "Guest 3";
            // 
            // Guest3Status
            // 
            this.Guest3Status.Image = global::HostHelper.Properties.Resources.tick;
            this.Guest3Status.Location = new System.Drawing.Point(430, 24);
            this.Guest3Status.Name = "Guest3Status";
            this.Guest3Status.Size = new System.Drawing.Size(20, 20);
            this.Guest3Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guest3Status.TabIndex = 7;
            this.Guest3Status.TabStop = false;
            // 
            // Guest3Ban
            // 
            this.Guest3Ban.Enabled = false;
            this.Guest3Ban.Location = new System.Drawing.Point(455, 22);
            this.Guest3Ban.Name = "Guest3Ban";
            this.Guest3Ban.Size = new System.Drawing.Size(36, 23);
            this.Guest3Ban.TabIndex = 6;
            this.Guest3Ban.Text = "Ban";
            this.Guest3Ban.UseVisualStyleBackColor = true;
            this.Guest3Ban.Click += new System.EventHandler(this.Guest3Ban_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "NID:";
            // 
            // Guest3NID
            // 
            this.Guest3NID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guest3NID.Location = new System.Drawing.Point(306, 22);
            this.Guest3NID.Name = "Guest3NID";
            this.Guest3NID.ReadOnly = true;
            this.Guest3NID.Size = new System.Drawing.Size(118, 22);
            this.Guest3NID.TabIndex = 4;
            this.Guest3NID.Text = "0123456789ABCDEF";
            // 
            // Guest3ID
            // 
            this.Guest3ID.Location = new System.Drawing.Point(184, 22);
            this.Guest3ID.Name = "Guest3ID";
            this.Guest3ID.ReadOnly = true;
            this.Guest3ID.Size = new System.Drawing.Size(80, 23);
            this.Guest3ID.TabIndex = 3;
            this.Guest3ID.Text = "(0000)-000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "OT:";
            // 
            // Guest3OT
            // 
            this.Guest3OT.Location = new System.Drawing.Point(36, 22);
            this.Guest3OT.Name = "Guest3OT";
            this.Guest3OT.ReadOnly = true;
            this.Guest3OT.Size = new System.Drawing.Size(115, 23);
            this.Guest3OT.TabIndex = 0;
            this.Guest3OT.Text = "wwwwwwwwwwww";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(12, 40);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(112, 24);
            this.ButtonConnect.TabIndex = 9;
            this.ButtonConnect.Text = "Read";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(12, 70);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(112, 24);
            this.ButtonStop.TabIndex = 10;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonClearSession
            // 
            this.ButtonClearSession.Location = new System.Drawing.Point(12, 160);
            this.ButtonClearSession.Name = "ButtonClearSession";
            this.ButtonClearSession.Size = new System.Drawing.Size(112, 23);
            this.ButtonClearSession.TabIndex = 11;
            this.ButtonClearSession.Text = "Clear Session";
            this.ButtonClearSession.UseVisualStyleBackColor = true;
            this.ButtonClearSession.Click += new System.EventHandler(this.ButtonClearSession_Click);
            // 
            // LabelSession
            // 
            this.LabelSession.AutoSize = true;
            this.LabelSession.Location = new System.Drawing.Point(12, 142);
            this.LabelSession.Name = "LabelSession";
            this.LabelSession.Size = new System.Drawing.Size(99, 15);
            this.LabelSession.TabIndex = 12;
            this.LabelSession.Text = "Session Raiders: 0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 192);
            this.Controls.Add(this.LabelSession);
            this.Controls.Add(this.ButtonClearSession);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.Guest3Group);
            this.Controls.Add(this.Guest2Group);
            this.Controls.Add(this.Guest1Group);
            this.Controls.Add(this.InputSwitchIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "HostHelper";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Guest1Group.ResumeLayout(false);
            this.Guest1Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest1Status)).EndInit();
            this.Guest2Group.ResumeLayout(false);
            this.Guest2Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest2Status)).EndInit();
            this.Guest3Group.ResumeLayout(false);
            this.Guest3Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest3Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputSwitchIP;
        private GroupBox Guest1Group;
        private Label label1;
        private TextBox Guest1OT;
        private Label label3;
        private TextBox Guest1NID;
        private TextBox Guest1ID;
        private Label label2;
        private PictureBox Guest1Status;
        private Button Guest1Ban;
        private GroupBox Guest2Group;
        private PictureBox Guest2Status;
        private Button Guest2Ban;
        private Label label4;
        private TextBox Guest2NID;
        private TextBox Guest2ID;
        private Label label5;
        private Label label6;
        private TextBox Guest2OT;
        private GroupBox Guest3Group;
        private PictureBox Guest3Status;
        private Button Guest3Ban;
        private Label label7;
        private TextBox Guest3NID;
        private TextBox Guest3ID;
        private Label label8;
        private Label label9;
        private TextBox Guest3OT;
        private Button ButtonConnect;
        private Button ButtonStop;
        private Button ButtonClearSession;
        private Label LabelSession;
    }
}