namespace TEST_BMMANG
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
            this.btn_openfile = new System.Windows.Forms.Button();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.btn_Decode = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(85, 257);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(75, 23);
            this.btn_openfile.TabIndex = 1;
            this.btn_openfile.Text = "Open File";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // btn_Encode
            // 
            this.btn_Encode.Location = new System.Drawing.Point(189, 351);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(75, 23);
            this.btn_Encode.TabIndex = 2;
            this.btn_Encode.Text = "Encode";
            this.btn_Encode.UseVisualStyleBackColor = true;
            this.btn_Encode.Click += new System.EventHandler(this.btn_Encode_Click);
            // 
            // btn_Decode
            // 
            this.btn_Decode.Location = new System.Drawing.Point(287, 351);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(75, 23);
            this.btn_Decode.TabIndex = 3;
            this.btn_Decode.Text = "Decode";
            this.btn_Decode.UseVisualStyleBackColor = true;
            this.btn_Decode.Click += new System.EventHandler(this.btn_Decode_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(189, 259);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(173, 20);
            this.txt_FilePath.TabIndex = 4;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(189, 304);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(173, 20);
            this.txt_message.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.btn_Decode);
            this.Controls.Add(this.btn_Encode);
            this.Controls.Add(this.btn_openfile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.Button btn_Decode;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

