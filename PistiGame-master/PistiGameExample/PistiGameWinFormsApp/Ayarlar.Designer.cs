namespace PistiGameWinFormsApp
{
    partial class Ayarlar
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
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.btnDegis = new System.Windows.Forms.Button();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureUpDown = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(229, 209);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(125, 22);
            this.txtName2.TabIndex = 0;
            // 
            // btnDegis
            // 
            this.btnDegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDegis.Location = new System.Drawing.Point(239, 308);
            this.btnDegis.Name = "btnDegis";
            this.btnDegis.Size = new System.Drawing.Size(269, 53);
            this.btnDegis.TabIndex = 1;
            this.btnDegis.Text = "Save Settings";
            this.btnDegis.UseVisualStyleBackColor = false;
            this.btnDegis.Click += new System.EventHandler(this.btnDegis_Click);
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(229, 104);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(125, 22);
            this.txtName1.TabIndex = 2;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(405, 104);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPoint.Size = new System.Drawing.Size(125, 22);
            this.txtPoint.TabIndex = 3;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(246, 85);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(96, 16);
            this.Player1.TabIndex = 4;
            this.Player1.Text = "Player 1 Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 2 Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Winning Point";
            // 
            // pictureUpDown
            // 
            this.pictureUpDown.Location = new System.Drawing.Point(405, 209);
            this.pictureUpDown.Name = "pictureUpDown";
            this.pictureUpDown.Size = new System.Drawing.Size(120, 22);
            this.pictureUpDown.TabIndex = 7;
            this.pictureUpDown.Text = "domainUpDown1";
            this.pictureUpDown.SelectedItemChanged += new System.EventHandler(this.pictureUpDown_SelectedItemChanged);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.btnDegis);
            this.Controls.Add(this.txtName2);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Button btnDegis;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown pictureUpDown;
    }
}