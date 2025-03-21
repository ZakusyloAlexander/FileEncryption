namespace FileEncryption
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ChooseFIleEncoding = new System.Windows.Forms.Button();
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.btn_encoding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choose File";
            // 
            // btn_ChooseFIleEncoding
            // 
            this.btn_ChooseFIleEncoding.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ChooseFIleEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChooseFIleEncoding.Location = new System.Drawing.Point(168, 116);
            this.btn_ChooseFIleEncoding.Name = "btn_ChooseFIleEncoding";
            this.btn_ChooseFIleEncoding.Size = new System.Drawing.Size(54, 30);
            this.btn_ChooseFIleEncoding.TabIndex = 10;
            this.btn_ChooseFIleEncoding.Text = "...";
            this.btn_ChooseFIleEncoding.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ChooseFIleEncoding.UseVisualStyleBackColor = false;
            this.btn_ChooseFIleEncoding.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FilePath.Location = new System.Drawing.Point(12, 116);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(150, 30);
            this.tb_FilePath.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Key";
            // 
            // tb_Key
            // 
            this.tb_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Key.Location = new System.Drawing.Point(12, 188);
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.Size = new System.Drawing.Size(210, 30);
            this.tb_Key.TabIndex = 7;
            // 
            // btn_encoding
            // 
            this.btn_encoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_encoding.Location = new System.Drawing.Point(12, 228);
            this.btn_encoding.Name = "btn_encoding";
            this.btn_encoding.Size = new System.Drawing.Size(210, 65);
            this.btn_encoding.TabIndex = 6;
            this.btn_encoding.Text = "Encoding/Decoding";
            this.btn_encoding.UseVisualStyleBackColor = true;
            this.btn_encoding.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 65);
            this.label1.TabIndex = 13;
            this.label1.Text = "EncodingDecoding";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ChooseFIleEncoding);
            this.Controls.Add(this.tb_FilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Key);
            this.Controls.Add(this.btn_encoding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ChooseFIleEncoding;
        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.Button btn_encoding;
        private System.Windows.Forms.Label label1;
    }
}

