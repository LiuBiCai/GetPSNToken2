namespace GetPSNToken
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPSNToken = new System.Windows.Forms.TextBox();
            this.textBoxPSNPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnGetPsnToken = new System.Windows.Forms.Button();
            this.textBoxEmailPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Token";
            // 
            // textBoxPSNToken
            // 
            this.textBoxPSNToken.Location = new System.Drawing.Point(68, 45);
            this.textBoxPSNToken.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPSNToken.Name = "textBoxPSNToken";
            this.textBoxPSNToken.Size = new System.Drawing.Size(279, 22);
            this.textBoxPSNToken.TabIndex = 15;
            // 
            // textBoxPSNPass
            // 
            this.textBoxPSNPass.Location = new System.Drawing.Point(269, 7);
            this.textBoxPSNPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPSNPass.Name = "textBoxPSNPass";
            this.textBoxPSNPass.Size = new System.Drawing.Size(78, 22);
            this.textBoxPSNPass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "PSN Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(68, 7);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 22);
            this.textBoxEmail.TabIndex = 11;
            // 
            // btnGetPsnToken
            // 
            this.btnGetPsnToken.Location = new System.Drawing.Point(199, 75);
            this.btnGetPsnToken.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetPsnToken.Name = "btnGetPsnToken";
            this.btnGetPsnToken.Size = new System.Drawing.Size(148, 28);
            this.btnGetPsnToken.TabIndex = 10;
            this.btnGetPsnToken.Text = "Get PSN Token";
            this.btnGetPsnToken.UseVisualStyleBackColor = true;
            this.btnGetPsnToken.Click += new System.EventHandler(this.btnGetPsnToken_Click);
            // 
            // textBoxEmailPass
            // 
            this.textBoxEmailPass.Location = new System.Drawing.Point(98, 78);
            this.textBoxEmailPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmailPass.Name = "textBoxEmailPass";
            this.textBoxEmailPass.Size = new System.Drawing.Size(78, 22);
            this.textBoxEmailPass.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email Pass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 112);
            this.Controls.Add(this.textBoxEmailPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPSNToken);
            this.Controls.Add(this.textBoxPSNPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.btnGetPsnToken);
            this.Name = "Form1";
            this.Text = "Get PSN Token 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPSNToken;
        private System.Windows.Forms.TextBox textBoxPSNPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnGetPsnToken;
        private System.Windows.Forms.TextBox textBoxEmailPass;
        private System.Windows.Forms.Label label4;
    }
}

