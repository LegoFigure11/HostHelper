namespace HostHelper.Subforms
{
    partial class ListManager
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
            this.EntryList = new System.Windows.Forms.ListBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OT = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonBan = new System.Windows.Forms.Button();
            this.ButtonRemoveAll = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryList
            // 
            this.EntryList.FormattingEnabled = true;
            this.EntryList.ItemHeight = 15;
            this.EntryList.Location = new System.Drawing.Point(136, 24);
            this.EntryList.Name = "EntryList";
            this.EntryList.Size = new System.Drawing.Size(136, 244);
            this.EntryList.TabIndex = 0;
            this.EntryList.SelectedIndexChanged += new System.EventHandler(this.EntryList_SelectedIndexChanged);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(136, 6);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(44, 15);
            this.LabelTotal.TabIndex = 1;
            this.LabelTotal.Text = "Total: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "OT:";
            // 
            // OT
            // 
            this.OT.Location = new System.Drawing.Point(12, 42);
            this.OT.Name = "OT";
            this.OT.ReadOnly = true;
            this.OT.Size = new System.Drawing.Size(118, 23);
            this.OT.TabIndex = 3;
            this.OT.Text = "wwwwwwwwwwww";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(12, 86);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(118, 23);
            this.ID.TabIndex = 5;
            this.ID.Text = "wwwwwwwwwwww";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "NID:";
            // 
            // NID
            // 
            this.NID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NID.Location = new System.Drawing.Point(12, 130);
            this.NID.Name = "NID";
            this.NID.ReadOnly = true;
            this.NID.Size = new System.Drawing.Size(118, 22);
            this.NID.TabIndex = 7;
            this.NID.Text = "0123456789ABCDEF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonRemove);
            this.groupBox1.Controls.Add(this.ButtonBan);
            this.groupBox1.Controls.Add(this.ButtonRemoveAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 110);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(6, 22);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(106, 23);
            this.ButtonRemove.TabIndex = 1;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonBan
            // 
            this.ButtonBan.Location = new System.Drawing.Point(6, 51);
            this.ButtonBan.Name = "ButtonBan";
            this.ButtonBan.Size = new System.Drawing.Size(106, 23);
            this.ButtonBan.TabIndex = 2;
            this.ButtonBan.Text = "Ban";
            this.ButtonBan.UseVisualStyleBackColor = true;
            this.ButtonBan.Click += new System.EventHandler(this.ButtonBan_Click);
            // 
            // ButtonRemoveAll
            // 
            this.ButtonRemoveAll.Location = new System.Drawing.Point(6, 80);
            this.ButtonRemoveAll.Name = "ButtonRemoveAll";
            this.ButtonRemoveAll.Size = new System.Drawing.Size(106, 23);
            this.ButtonRemoveAll.TabIndex = 3;
            this.ButtonRemoveAll.Text = "Remove All";
            this.ButtonRemoveAll.UseVisualStyleBackColor = true;
            this.ButtonRemoveAll.Click += new System.EventHandler(this.ButtonRemoveAll_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(12, 274);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(260, 23);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save Changes";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 303);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.EntryList);
            this.Name = "ListManager";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox EntryList;
        private Label LabelTotal;
        private Label label1;
        private TextBox OT;
        private TextBox ID;
        private Label label2;
        private Label label3;
        private TextBox NID;
        private GroupBox groupBox1;
        private Button ButtonRemove;
        private Button ButtonBan;
        private Button ButtonRemoveAll;
        private Button ButtonSave;
    }
}