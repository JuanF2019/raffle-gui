
namespace RaffleGUI.UserInterface
{
    partial class WinnersWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnersWindow));
            this.nextWinBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.winLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextWinBtn
            // 
            this.nextWinBtn.Location = new System.Drawing.Point(58, 146);
            this.nextWinBtn.Name = "nextWinBtn";
            this.nextWinBtn.Size = new System.Drawing.Size(75, 23);
            this.nextWinBtn.TabIndex = 0;
            this.nextWinBtn.Text = "Siguiente Ganador";
            this.nextWinBtn.UseVisualStyleBackColor = true;
            this.nextWinBtn.Click += new System.EventHandler(this.nextWinBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Enabled = false;
            this.finishBtn.Location = new System.Drawing.Point(173, 146);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 1;
            this.finishBtn.Text = "Cerrar";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLbl.Location = new System.Drawing.Point(125, 59);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(49, 33);
            this.winLbl.TabIndex = 2;
            this.winLbl.Text = "##";
            // 
            // WinnersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 204);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.nextWinBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinnersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextWinBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Label winLbl;
    }
}