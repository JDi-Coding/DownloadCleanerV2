namespace DownloadCleanerV2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_StartCleaning = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_StatusMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartCleaning
            // 
            this.btn_StartCleaning.BackColor = System.Drawing.Color.Azure;
            this.btn_StartCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StartCleaning.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_StartCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartCleaning.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartCleaning.Location = new System.Drawing.Point(12, 404);
            this.btn_StartCleaning.Name = "btn_StartCleaning";
            this.btn_StartCleaning.Size = new System.Drawing.Size(460, 45);
            this.btn_StartCleaning.TabIndex = 0;
            this.btn_StartCleaning.Text = "Start Cleaning";
            this.btn_StartCleaning.UseVisualStyleBackColor = false;
            this.btn_StartCleaning.Click += new System.EventHandler(this.btn_StartCleaning_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(12, 356);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(124, 36);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Status:  ";
            // 
            // lbl_StatusMsg
            // 
            this.lbl_StatusMsg.AutoSize = true;
            this.lbl_StatusMsg.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusMsg.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_StatusMsg.Location = new System.Drawing.Point(127, 356);
            this.lbl_StatusMsg.Name = "lbl_StatusMsg";
            this.lbl_StatusMsg.Size = new System.Drawing.Size(27, 36);
            this.lbl_StatusMsg.TabIndex = 2;
            this.lbl_StatusMsg.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_StatusMsg);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_StartCleaning);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "DownloadCleanerV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartCleaning;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_StatusMsg;
    }
}

