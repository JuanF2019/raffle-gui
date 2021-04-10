
namespace RaffleGUI.UserInterface
{
    partial class MainWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainWindowTabs = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.editTab = new System.Windows.Forms.TabPage();
            this.playTab = new System.Windows.Forms.TabPage();
            this.playNumsDataGridView = new System.Windows.Forms.DataGridView();
            this.winnersHisLbl = new System.Windows.Forms.Label();
            this.WinnerSelLbl = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.hisWinDataGridView = new System.Windows.Forms.DataGridView();
            this.winnersNumTxtBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.addRangeBtn = new System.Windows.Forms.Button();
            this.delRangeBtn = new System.Windows.Forms.Button();
            this.addNumBtn = new System.Windows.Forms.Button();
            this.delNumBtn = new System.Windows.Forms.Button();
            this.numLbl = new System.Windows.Forms.Label();
            this.numTxtBox = new System.Windows.Forms.TextBox();
            this.fromRangeTxtBox = new System.Windows.Forms.TextBox();
            this.toRangeTxtBox = new System.Windows.Forms.TextBox();
            this.fromRangeLbl = new System.Windows.Forms.Label();
            this.toRangeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainWindowTabs.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.editTab.SuspendLayout();
            this.playTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playNumsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hisWinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainWindowTabs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.playNumsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 648;
            this.splitContainer1.TabIndex = 0;
            // 
            // mainWindowTabs
            // 
            this.mainWindowTabs.Controls.Add(this.welcomeTab);
            this.mainWindowTabs.Controls.Add(this.editTab);
            this.mainWindowTabs.Controls.Add(this.playTab);
            this.mainWindowTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowTabs.Location = new System.Drawing.Point(0, 0);
            this.mainWindowTabs.Name = "mainWindowTabs";
            this.mainWindowTabs.SelectedIndex = 0;
            this.mainWindowTabs.Size = new System.Drawing.Size(648, 450);
            this.mainWindowTabs.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.aboutBtn);
            this.welcomeTab.Controls.Add(this.welcomeLbl);
            this.welcomeTab.Location = new System.Drawing.Point(4, 22);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(640, 424);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Tag = "";
            this.welcomeTab.Text = "Inicio";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(3, 193);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(832, 13);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Bienvenido. El programa le permite gestionar una rifa basada en numeros. Puede ed" +
    "itar los numeros en la pestaña \"Editar Numeros\" y seleccioar ganadroes en la pes" +
    "taña jugar";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editTab
            // 
            this.editTab.Controls.Add(this.toRangeLbl);
            this.editTab.Controls.Add(this.fromRangeLbl);
            this.editTab.Controls.Add(this.toRangeTxtBox);
            this.editTab.Controls.Add(this.fromRangeTxtBox);
            this.editTab.Controls.Add(this.numTxtBox);
            this.editTab.Controls.Add(this.numLbl);
            this.editTab.Controls.Add(this.delNumBtn);
            this.editTab.Controls.Add(this.addNumBtn);
            this.editTab.Controls.Add(this.delRangeBtn);
            this.editTab.Controls.Add(this.addRangeBtn);
            this.editTab.Location = new System.Drawing.Point(4, 22);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(640, 424);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Editar Numeros";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // playTab
            // 
            this.playTab.Controls.Add(this.splitContainer2);
            this.playTab.Location = new System.Drawing.Point(4, 22);
            this.playTab.Name = "playTab";
            this.playTab.Size = new System.Drawing.Size(640, 424);
            this.playTab.TabIndex = 2;
            this.playTab.Text = "Jugar";
            this.playTab.UseVisualStyleBackColor = true;
            // 
            // playNumsDataGridView
            // 
            this.playNumsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playNumsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playNumsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.playNumsDataGridView.Name = "playNumsDataGridView";
            this.playNumsDataGridView.Size = new System.Drawing.Size(148, 450);
            this.playNumsDataGridView.TabIndex = 0;
            // 
            // winnersHisLbl
            // 
            this.winnersHisLbl.AutoSize = true;
            this.winnersHisLbl.Location = new System.Drawing.Point(8, 10);
            this.winnersHisLbl.Name = "winnersHisLbl";
            this.winnersHisLbl.Size = new System.Drawing.Size(114, 13);
            this.winnersHisLbl.TabIndex = 0;
            this.winnersHisLbl.Text = "Historial de Ganadores";
            // 
            // WinnerSelLbl
            // 
            this.WinnerSelLbl.AutoSize = true;
            this.WinnerSelLbl.Location = new System.Drawing.Point(8, 14);
            this.WinnerSelLbl.Name = "WinnerSelLbl";
            this.WinnerSelLbl.Size = new System.Drawing.Size(124, 13);
            this.WinnerSelLbl.TabIndex = 1;
            this.WinnerSelLbl.Text = "Seleccion de Ganadores";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.playButton);
            this.splitContainer2.Panel1.Controls.Add(this.winnersNumTxtBox);
            this.splitContainer2.Panel1.Controls.Add(this.WinnerSelLbl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.hisWinDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.winnersHisLbl);
            this.splitContainer2.Size = new System.Drawing.Size(640, 424);
            this.splitContainer2.SplitterDistance = 212;
            this.splitContainer2.TabIndex = 2;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(325, 263);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 1;
            this.aboutBtn.Text = "Acerca de";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // hisWinDataGridView
            // 
            this.hisWinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hisWinDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hisWinDataGridView.Location = new System.Drawing.Point(0, 35);
            this.hisWinDataGridView.Name = "hisWinDataGridView";
            this.hisWinDataGridView.Size = new System.Drawing.Size(640, 173);
            this.hisWinDataGridView.TabIndex = 1;
            // 
            // winnersNumTxtBox
            // 
            this.winnersNumTxtBox.Location = new System.Drawing.Point(267, 76);
            this.winnersNumTxtBox.Name = "winnersNumTxtBox";
            this.winnersNumTxtBox.Size = new System.Drawing.Size(100, 20);
            this.winnersNumTxtBox.TabIndex = 2;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(278, 121);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Jugar";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // addRangeBtn
            // 
            this.addRangeBtn.Location = new System.Drawing.Point(397, 126);
            this.addRangeBtn.Name = "addRangeBtn";
            this.addRangeBtn.Size = new System.Drawing.Size(92, 23);
            this.addRangeBtn.TabIndex = 0;
            this.addRangeBtn.Text = "Añadir Rango";
            this.addRangeBtn.UseVisualStyleBackColor = true;
            this.addRangeBtn.Click += new System.EventHandler(this.addRangeBtn_Click);
            // 
            // delRangeBtn
            // 
            this.delRangeBtn.Location = new System.Drawing.Point(495, 125);
            this.delRangeBtn.Name = "delRangeBtn";
            this.delRangeBtn.Size = new System.Drawing.Size(93, 23);
            this.delRangeBtn.TabIndex = 1;
            this.delRangeBtn.Text = "Eliminar Rango";
            this.delRangeBtn.UseVisualStyleBackColor = true;
            this.delRangeBtn.Click += new System.EventHandler(this.delRangeBtn_Click);
            // 
            // addNumBtn
            // 
            this.addNumBtn.Location = new System.Drawing.Point(396, 184);
            this.addNumBtn.Name = "addNumBtn";
            this.addNumBtn.Size = new System.Drawing.Size(93, 23);
            this.addNumBtn.TabIndex = 2;
            this.addNumBtn.Text = "Añadir Número";
            this.addNumBtn.UseVisualStyleBackColor = true;
            this.addNumBtn.Click += new System.EventHandler(this.addNumBtn_Click);
            // 
            // delNumBtn
            // 
            this.delNumBtn.Location = new System.Drawing.Point(495, 186);
            this.delNumBtn.Name = "delNumBtn";
            this.delNumBtn.Size = new System.Drawing.Size(93, 23);
            this.delNumBtn.TabIndex = 3;
            this.delNumBtn.Text = "Eliminar Numero";
            this.delNumBtn.UseVisualStyleBackColor = true;
            this.delNumBtn.Click += new System.EventHandler(this.delNumBtn_Click);
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Location = new System.Drawing.Point(140, 189);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(86, 13);
            this.numLbl.TabIndex = 4;
            this.numLbl.Text = "Número Puntual:";
            // 
            // numTxtBox
            // 
            this.numTxtBox.Location = new System.Drawing.Point(229, 186);
            this.numTxtBox.Name = "numTxtBox";
            this.numTxtBox.Size = new System.Drawing.Size(100, 20);
            this.numTxtBox.TabIndex = 5;
            // 
            // fromRangeTxtBox
            // 
            this.fromRangeTxtBox.Location = new System.Drawing.Point(96, 125);
            this.fromRangeTxtBox.Name = "fromRangeTxtBox";
            this.fromRangeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.fromRangeTxtBox.TabIndex = 6;
            // 
            // toRangeTxtBox
            // 
            this.toRangeTxtBox.Location = new System.Drawing.Point(267, 126);
            this.toRangeTxtBox.Name = "toRangeTxtBox";
            this.toRangeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.toRangeTxtBox.TabIndex = 7;
            // 
            // fromRangeLbl
            // 
            this.fromRangeLbl.AutoSize = true;
            this.fromRangeLbl.Location = new System.Drawing.Point(49, 128);
            this.fromRangeLbl.Name = "fromRangeLbl";
            this.fromRangeLbl.Size = new System.Drawing.Size(41, 13);
            this.fromRangeLbl.TabIndex = 8;
            this.fromRangeLbl.Text = "Desde:";
            // 
            // toRangeLbl
            // 
            this.toRangeLbl.AutoSize = true;
            this.toRangeLbl.Location = new System.Drawing.Point(226, 130);
            this.toRangeLbl.Name = "toRangeLbl";
            this.toRangeLbl.Size = new System.Drawing.Size(38, 13);
            this.toRangeLbl.TabIndex = 9;
            this.toRangeLbl.Text = "Hasta:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Text = "Rifa por los sueños";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mainWindowTabs.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            this.playTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playNumsDataGridView)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hisWinDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl mainWindowTabs;
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.DataGridView playNumsDataGridView;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.TabPage playTab;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Label toRangeLbl;
        private System.Windows.Forms.Label fromRangeLbl;
        private System.Windows.Forms.TextBox toRangeTxtBox;
        private System.Windows.Forms.TextBox fromRangeTxtBox;
        private System.Windows.Forms.TextBox numTxtBox;
        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.Button delNumBtn;
        private System.Windows.Forms.Button addNumBtn;
        private System.Windows.Forms.Button delRangeBtn;
        private System.Windows.Forms.Button addRangeBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox winnersNumTxtBox;
        private System.Windows.Forms.Label WinnerSelLbl;
        private System.Windows.Forms.DataGridView hisWinDataGridView;
        private System.Windows.Forms.Label winnersHisLbl;
    }
}

