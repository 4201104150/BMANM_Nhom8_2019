namespace BTCaiDat
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEncMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExponent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModulus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkShowData = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pubgKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pubgKey02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openKeyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveKeyFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtEncMsg);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtD);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtExponent);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtModulus);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chkShowData);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1163, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loadform_click);
            // 
            // txtEncMsg
            // 
            this.txtEncMsg.BackColor = System.Drawing.SystemColors.Window;
            this.txtEncMsg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEncMsg.Location = new System.Drawing.Point(719, 368);
            this.txtEncMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncMsg.Multiline = true;
            this.txtEncMsg.Name = "txtEncMsg";
            this.txtEncMsg.Size = new System.Drawing.Size(420, 161);
            this.txtEncMsg.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(715, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Bảng mã ";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMessage.Location = new System.Drawing.Point(28, 368);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(420, 161);
            this.txtMessage.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(27, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bảng rõ";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.SystemColors.Window;
            this.txtD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtD.Location = new System.Drawing.Point(719, 141);
            this.txtD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(420, 161);
            this.txtD.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(694, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Private Key";
            // 
            // txtExponent
            // 
            this.txtExponent.BackColor = System.Drawing.SystemColors.Window;
            this.txtExponent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtExponent.Location = new System.Drawing.Point(513, 248);
            this.txtExponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExponent.Name = "txtExponent";
            this.txtExponent.ReadOnly = true;
            this.txtExponent.Size = new System.Drawing.Size(138, 30);
            this.txtExponent.TabIndex = 16;
            this.txtExponent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(541, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Exponent";
            // 
            // txtModulus
            // 
            this.txtModulus.BackColor = System.Drawing.SystemColors.Window;
            this.txtModulus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtModulus.Location = new System.Drawing.Point(28, 141);
            this.txtModulus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModulus.Multiline = true;
            this.txtModulus.Name = "txtModulus";
            this.txtModulus.ReadOnly = true;
            this.txtModulus.Size = new System.Drawing.Size(420, 161);
            this.txtModulus.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Public Key";
            // 
            // chkShowData
            // 
            this.chkShowData.AutoSize = true;
            this.chkShowData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkShowData.Location = new System.Drawing.Point(134, 66);
            this.chkShowData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowData.Name = "chkShowData";
            this.chkShowData.Size = new System.Drawing.Size(71, 26);
            this.chkShowData.TabIndex = 12;
            this.chkShowData.Text = "Hiện";
            this.chkShowData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key Data";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pubgKeyToolStripMenuItem,
            this.pubgKey02ToolStripMenuItem,
            this.loadPrivateKeyToolStripMenuItem,
            this.privateEncryptionToolStripMenuItem,
            this.publicDecryptionToolStripMenuItem,
            this.publicEncryptionToolStripMenuItem,
            this.privateDecryptionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pubgKeyToolStripMenuItem
            // 
            this.pubgKeyToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubgKeyToolStripMenuItem.Name = "pubgKeyToolStripMenuItem";
            this.pubgKeyToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.pubgKeyToolStripMenuItem.Text = "Create Key Pairs";
            this.pubgKeyToolStripMenuItem.Click += new System.EventHandler(this.createKeyToolStripMenuItem_Click);
            // 
            // pubgKey02ToolStripMenuItem
            // 
            this.pubgKey02ToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubgKey02ToolStripMenuItem.Name = "pubgKey02ToolStripMenuItem";
            this.pubgKey02ToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.pubgKey02ToolStripMenuItem.Text = "Load Public Key";
            this.pubgKey02ToolStripMenuItem.Click += new System.EventHandler(this.loadKeyToolStripMenuItem_Click);
            // 
            // loadPrivateKeyToolStripMenuItem
            // 
            this.loadPrivateKeyToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPrivateKeyToolStripMenuItem.Name = "loadPrivateKeyToolStripMenuItem";
            this.loadPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.loadPrivateKeyToolStripMenuItem.Text = "Load Private Key";
            this.loadPrivateKeyToolStripMenuItem.Click += new System.EventHandler(this.loadKeyToolStripMenuItem_Click);
            // 
            // privateEncryptionToolStripMenuItem
            // 
            this.privateEncryptionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateEncryptionToolStripMenuItem.Name = "privateEncryptionToolStripMenuItem";
            this.privateEncryptionToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.privateEncryptionToolStripMenuItem.Text = "Private Encryption";
            this.privateEncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // publicDecryptionToolStripMenuItem
            // 
            this.publicDecryptionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicDecryptionToolStripMenuItem.Name = "publicDecryptionToolStripMenuItem";
            this.publicDecryptionToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.publicDecryptionToolStripMenuItem.Text = "Public Decryption";
            this.publicDecryptionToolStripMenuItem.Click += new System.EventHandler(this.DecryptionToolStripMenuItem_Click);
            // 
            // publicEncryptionToolStripMenuItem
            // 
            this.publicEncryptionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicEncryptionToolStripMenuItem.Name = "publicEncryptionToolStripMenuItem";
            this.publicEncryptionToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.publicEncryptionToolStripMenuItem.Text = "Public Encryption";
            this.publicEncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // privateDecryptionToolStripMenuItem
            // 
            this.privateDecryptionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateDecryptionToolStripMenuItem.Name = "privateDecryptionToolStripMenuItem";
            this.privateDecryptionToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.privateDecryptionToolStripMenuItem.Text = "Private Decryption";
            this.privateDecryptionToolStripMenuItem.Click += new System.EventHandler(this.DecryptionToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1195, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vegener";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openKeyFileDialog
            // 
            this.openKeyFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 608);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Mã Hóa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pubgKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pubgKey02ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEncMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModulus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShowData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem loadPrivateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicDecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateDecryptionToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openKeyFileDialog;
        private System.Windows.Forms.SaveFileDialog saveKeyFileDialog;
        private System.Windows.Forms.Button button1;
    }
}

