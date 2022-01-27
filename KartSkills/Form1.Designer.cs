
namespace KartSkills
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNameMarathon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbRegistrGonshik = new System.Windows.Forms.PictureBox();
            this.pbRegistrSponsor = new System.Windows.Forms.PictureBox();
            this.pbOSobitii = new System.Windows.Forms.PictureBox();
            this.pbVhod = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrGonshik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrSponsor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOSobitii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVhod)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.labelNameMarathon);
            this.panelHeader.Location = new System.Drawing.Point(0, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(799, 87);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Москва, Россия 20 июня 2017";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNameMarathon
            // 
            this.labelNameMarathon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameMarathon.AutoSize = true;
            this.labelNameMarathon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameMarathon.Location = new System.Drawing.Point(303, 8);
            this.labelNameMarathon.Name = "labelNameMarathon";
            this.labelNameMarathon.Size = new System.Drawing.Size(217, 37);
            this.labelNameMarathon.TabIndex = 0;
            this.labelNameMarathon.Text = "Kart Skills 2017";
            this.labelNameMarathon.Click += new System.EventHandler(this.labelNameMarathon_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Time);
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 87);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(214, 29);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(34, 15);
            this.Time.TabIndex = 0;
            this.Time.Text = "День";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbRegistrGonshik
            // 
            this.pbRegistrGonshik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRegistrGonshik.BackgroundImage")));
            this.pbRegistrGonshik.Image = ((System.Drawing.Image)(resources.GetObject("pbRegistrGonshik.Image")));
            this.pbRegistrGonshik.Location = new System.Drawing.Point(133, 173);
            this.pbRegistrGonshik.Name = "pbRegistrGonshik";
            this.pbRegistrGonshik.Size = new System.Drawing.Size(124, 105);
            this.pbRegistrGonshik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegistrGonshik.TabIndex = 4;
            this.pbRegistrGonshik.TabStop = false;
            // 
            // pbRegistrSponsor
            // 
            this.pbRegistrSponsor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRegistrSponsor.BackgroundImage")));
            this.pbRegistrSponsor.Image = ((System.Drawing.Image)(resources.GetObject("pbRegistrSponsor.Image")));
            this.pbRegistrSponsor.Location = new System.Drawing.Point(277, 173);
            this.pbRegistrSponsor.Name = "pbRegistrSponsor";
            this.pbRegistrSponsor.Size = new System.Drawing.Size(124, 105);
            this.pbRegistrSponsor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegistrSponsor.TabIndex = 5;
            this.pbRegistrSponsor.TabStop = false;
            // 
            // pbOSobitii
            // 
            this.pbOSobitii.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOSobitii.BackgroundImage")));
            this.pbOSobitii.Image = ((System.Drawing.Image)(resources.GetObject("pbOSobitii.Image")));
            this.pbOSobitii.Location = new System.Drawing.Point(423, 173);
            this.pbOSobitii.Name = "pbOSobitii";
            this.pbOSobitii.Size = new System.Drawing.Size(124, 105);
            this.pbOSobitii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOSobitii.TabIndex = 6;
            this.pbOSobitii.TabStop = false;
            // 
            // pbVhod
            // 
            this.pbVhod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbVhod.BackgroundImage")));
            this.pbVhod.Image = ((System.Drawing.Image)(resources.GetObject("pbVhod.Image")));
            this.pbVhod.Location = new System.Drawing.Point(568, 173);
            this.pbVhod.Name = "pbVhod";
            this.pbVhod.Size = new System.Drawing.Size(124, 105);
            this.pbVhod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVhod.TabIndex = 7;
            this.pbVhod.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Регистрация гонщика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Регистрация спонсора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "О событии";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вход в систему";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbVhod);
            this.Controls.Add(this.pbOSobitii);
            this.Controls.Add(this.pbRegistrSponsor);
            this.Controls.Add(this.pbRegistrGonshik);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrGonshik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrSponsor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOSobitii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVhod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNameMarathon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbRegistrGonshik;
        private System.Windows.Forms.PictureBox pbRegistrSponsor;
        private System.Windows.Forms.PictureBox pbOSobitii;
        private System.Windows.Forms.PictureBox pbVhod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

