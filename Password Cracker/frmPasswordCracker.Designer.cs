namespace Password_Cracker
{
    partial class frmPasswordCracker
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
            this.lblMd5Hash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnCrack = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMd5Hash
            // 
            this.lblMd5Hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMd5Hash.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMd5Hash.Location = new System.Drawing.Point(99, 73);
            this.lblMd5Hash.Name = "lblMd5Hash";
            this.lblMd5Hash.Size = new System.Drawing.Size(92, 52);
            this.lblMd5Hash.TabIndex = 3;
            this.lblMd5Hash.Text = "MD5 Hash";
            this.lblMd5Hash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHash
            // 
            this.txtHash.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash.Location = new System.Drawing.Point(102, 128);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(363, 22);
            this.txtHash.TabIndex = 0;
            // 
            // btnCrack
            // 
            this.btnCrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCrack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrack.Location = new System.Drawing.Point(492, 99);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(120, 76);
            this.btnCrack.TabIndex = 1;
            this.btnCrack.Text = "Crack";
            this.btnCrack.UseVisualStyleBackColor = false;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // lbError
            // 
            this.lbError.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.FormattingEnabled = true;
            this.lbError.ItemHeight = 18;
            this.lbError.Location = new System.Drawing.Point(102, 167);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(363, 94);
            this.lbError.TabIndex = 2;
            // 
            // frmPasswordCracker
            // 
            this.AcceptButton = this.btnCrack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnCrack);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.lblMd5Hash);
            this.Name = "frmPasswordCracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Cracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMd5Hash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.ListBox lbError;
    }
}

