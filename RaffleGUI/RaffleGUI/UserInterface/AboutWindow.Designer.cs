
namespace RaffleGUI.UserInterface
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.gitHubRepoLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gitHubAccountLink = new System.Windows.Forms.LinkLabel();
            this.linkedInLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.closeAboutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gitHubRepoLink
            // 
            this.gitHubRepoLink.AutoSize = true;
            this.gitHubRepoLink.Location = new System.Drawing.Point(125, 62);
            this.gitHubRepoLink.Name = "gitHubRepoLink";
            this.gitHubRepoLink.Size = new System.Drawing.Size(198, 13);
            this.gitHubRepoLink.TabIndex = 0;
            this.gitHubRepoLink.TabStop = true;
            this.gitHubRepoLink.Text = "https://github.com/JuanF2019/raffle-gui";
            this.gitHubRepoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubRepoLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "En el siguiente enlace puede consultar intrucciones detalladas para el uso del pr" +
    "ograma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Juan Fernando Martinez H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estudiante de Química e Ingeniería de Sistemas en la Universidad Icesi";
            // 
            // gitHubAccountLink
            // 
            this.gitHubAccountLink.AutoSize = true;
            this.gitHubAccountLink.Location = new System.Drawing.Point(150, 204);
            this.gitHubAccountLink.Name = "gitHubAccountLink";
            this.gitHubAccountLink.Size = new System.Drawing.Size(153, 13);
            this.gitHubAccountLink.TabIndex = 5;
            this.gitHubAccountLink.TabStop = true;
            this.gitHubAccountLink.Text = "https://github.com/JuanF2019";
            this.gitHubAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubAccountLink_LinkClicked);
            // 
            // linkedInLink
            // 
            this.linkedInLink.AutoSize = true;
            this.linkedInLink.Location = new System.Drawing.Point(92, 175);
            this.linkedInLink.Name = "linkedInLink";
            this.linkedInLink.Size = new System.Drawing.Size(316, 13);
            this.linkedInLink.TabIndex = 6;
            this.linkedInLink.TabStop = true;
            this.linkedInLink.Text = "https://www.linkedin.com/in/juan-fernando-martinez-68b2b9195/";
            this.linkedInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedInLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "LinkedIn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "GitHub";
            // 
            // closeAboutBtn
            // 
            this.closeAboutBtn.Location = new System.Drawing.Point(184, 237);
            this.closeAboutBtn.Name = "closeAboutBtn";
            this.closeAboutBtn.Size = new System.Drawing.Size(75, 23);
            this.closeAboutBtn.TabIndex = 9;
            this.closeAboutBtn.Text = "Cerrar";
            this.closeAboutBtn.UseVisualStyleBackColor = true;
            this.closeAboutBtn.Click += new System.EventHandler(this.closeAboutBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tambien el código si desea consultarlo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "E-mail: juanfermartinez7@gmail.com";
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 272);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.closeAboutBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkedInLink);
            this.Controls.Add(this.gitHubAccountLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gitHubRepoLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca del Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel gitHubRepoLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel gitHubAccountLink;
        private System.Windows.Forms.LinkLabel linkedInLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closeAboutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}