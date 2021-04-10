
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
            this.nextWinBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.winLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextWinBtn
            // 
            this.nextWinBtn.Location = new System.Drawing.Point(286, 293);
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
            this.finishBtn.Location = new System.Drawing.Point(448, 293);
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
            this.winLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLbl.Location = new System.Drawing.Point(387, 198);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(30, 24);
            this.winLbl.TabIndex = 2;
            this.winLbl.Text = "##";
            // 
            // WinnersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.nextWinBtn);
            this.Name = "WinnersWindow";
            this.Text = "Winners";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextWinBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Label winLbl;
    }
}