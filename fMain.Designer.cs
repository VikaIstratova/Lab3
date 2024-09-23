namespace Lab3
{
    partial class fMain
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
            this.tbPlaneInfo = new System.Windows.Forms.TextBox();
            this.btnAddPlane = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPlaneInfo
            // 
            this.tbPlaneInfo.Location = new System.Drawing.Point(46, 60);
            this.tbPlaneInfo.Multiline = true;
            this.tbPlaneInfo.Name = "tbPlaneInfo";
            this.tbPlaneInfo.ReadOnly = true;
            this.tbPlaneInfo.Size = new System.Drawing.Size(600, 319);
            this.tbPlaneInfo.TabIndex = 0;
            this.tbPlaneInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddPlane
            // 
            this.btnAddPlane.Location = new System.Drawing.Point(689, 60);
            this.btnAddPlane.Name = "btnAddPlane";
            this.btnAddPlane.Size = new System.Drawing.Size(138, 42);
            this.btnAddPlane.TabIndex = 1;
            this.btnAddPlane.Text = " Додати літак";
            this.btnAddPlane.UseVisualStyleBackColor = true;
            this.btnAddPlane.Click += new System.EventHandler(this.btnAddPlane_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(689, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPlane);
            this.Controls.Add(this.tbPlaneInfo);
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlaneInfo;
        private System.Windows.Forms.Button btnAddPlane;
        private System.Windows.Forms.Button btnClose;
    }
}

