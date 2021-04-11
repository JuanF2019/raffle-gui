
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainWindowTabs = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sDespiertoLinkLbl = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.editTab = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toRangeLbl = new System.Windows.Forms.Label();
            this.fromRangeLbl = new System.Windows.Forms.Label();
            this.toRangeTxtBox = new System.Windows.Forms.TextBox();
            this.fromRangeTxtBox = new System.Windows.Forms.TextBox();
            this.numTxtBox = new System.Windows.Forms.TextBox();
            this.numLbl = new System.Windows.Forms.Label();
            this.delNumBtn = new System.Windows.Forms.Button();
            this.addNumBtn = new System.Windows.Forms.Button();
            this.delRangeBtn = new System.Windows.Forms.Button();
            this.addRangeBtn = new System.Windows.Forms.Button();
            this.playTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.winnersNumTxtBox = new System.Windows.Forms.TextBox();
            this.winnerSelLbl = new System.Windows.Forms.Label();
            this.winHisDataGridView = new System.Windows.Forms.DataGridView();
            this.winnersHisLbl = new System.Windows.Forms.Label();
            this.playNumsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainWindowTabs.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.editTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.playTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winHisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playNumsDataGridView)).BeginInit();
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
            this.welcomeTab.Controls.Add(this.pictureBox3);
            this.welcomeTab.Controls.Add(this.pictureBox2);
            this.welcomeTab.Controls.Add(this.pictureBox1);
            this.welcomeTab.Controls.Add(this.label4);
            this.welcomeTab.Controls.Add(this.sDespiertoLinkLbl);
            this.welcomeTab.Controls.Add(this.label3);
            this.welcomeTab.Controls.Add(this.label2);
            this.welcomeTab.Controls.Add(this.label1);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RaffleGUI.Properties.Resources.WhatsApp_Image_2021_04_06_at_7_38_43_PM__1_;
            this.pictureBox3.Location = new System.Drawing.Point(438, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RaffleGUI.Properties.Resources.WhatsApp_Image_2021_04_06_at_7_38_44_PM;
            this.pictureBox2.Location = new System.Drawing.Point(3, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RaffleGUI.Properties.Resources.WhatsApp_Image_2021_04_06_at_7_38_43_PM;
            this.pictureBox1.Location = new System.Drawing.Point(267, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "En el siguiente enlace puede consultar más información acerca de la fundación";
            // 
            // sDespiertoLinkLbl
            // 
            this.sDespiertoLinkLbl.AutoSize = true;
            this.sDespiertoLinkLbl.Location = new System.Drawing.Point(239, 303);
            this.sDespiertoLinkLbl.Name = "sDespiertoLinkLbl";
            this.sDespiertoLinkLbl.Size = new System.Drawing.Size(184, 13);
            this.sDespiertoLinkLbl.TabIndex = 5;
            this.sDespiertoLinkLbl.TabStop = true;
            this.sDespiertoLinkLbl.Text = "http://www.sdespierto.org/home.html";
            this.sDespiertoLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sDespiertoLinkLbl_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Está destinado principalmente para la rifa por los sueños de la organización Soña" +
    "r Despierto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puede editar los números en la pestaña \"Editar Números\" y seleccionar ganadores e" +
    "n la pestaña \"Jugar\".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(285, 370);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 1;
            this.aboutBtn.Text = "Acerca de";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(152, 210);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(356, 13);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Bienvenido. El programa le permite gestionar una rifa basada en números. ";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editTab
            // 
            this.editTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editTab.Controls.Add(this.pictureBox4);
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
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RaffleGUI.Properties.Resources.WhatsApp_Image_2021_04_06_at_7_38_43_PM;
            this.pictureBox4.Location = new System.Drawing.Point(525, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // toRangeLbl
            // 
            this.toRangeLbl.AutoSize = true;
            this.toRangeLbl.Location = new System.Drawing.Point(187, 149);
            this.toRangeLbl.Name = "toRangeLbl";
            this.toRangeLbl.Size = new System.Drawing.Size(38, 13);
            this.toRangeLbl.TabIndex = 9;
            this.toRangeLbl.Text = "Hasta:";
            // 
            // fromRangeLbl
            // 
            this.fromRangeLbl.AutoSize = true;
            this.fromRangeLbl.Location = new System.Drawing.Point(34, 149);
            this.fromRangeLbl.Name = "fromRangeLbl";
            this.fromRangeLbl.Size = new System.Drawing.Size(41, 13);
            this.fromRangeLbl.TabIndex = 8;
            this.fromRangeLbl.Text = "Desde:";
            // 
            // toRangeTxtBox
            // 
            this.toRangeTxtBox.Location = new System.Drawing.Point(231, 146);
            this.toRangeTxtBox.Name = "toRangeTxtBox";
            this.toRangeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.toRangeTxtBox.TabIndex = 7;
            // 
            // fromRangeTxtBox
            // 
            this.fromRangeTxtBox.Location = new System.Drawing.Point(81, 146);
            this.fromRangeTxtBox.Name = "fromRangeTxtBox";
            this.fromRangeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.fromRangeTxtBox.TabIndex = 6;
            // 
            // numTxtBox
            // 
            this.numTxtBox.Location = new System.Drawing.Point(231, 213);
            this.numTxtBox.Name = "numTxtBox";
            this.numTxtBox.Size = new System.Drawing.Size(100, 20);
            this.numTxtBox.TabIndex = 5;
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Location = new System.Drawing.Point(139, 216);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(86, 13);
            this.numLbl.TabIndex = 4;
            this.numLbl.Text = "Número Puntual:";
            // 
            // delNumBtn
            // 
            this.delNumBtn.Location = new System.Drawing.Point(484, 216);
            this.delNumBtn.Name = "delNumBtn";
            this.delNumBtn.Size = new System.Drawing.Size(93, 23);
            this.delNumBtn.TabIndex = 3;
            this.delNumBtn.Text = "Eliminar Número";
            this.delNumBtn.UseVisualStyleBackColor = true;
            this.delNumBtn.Click += new System.EventHandler(this.delNumBtn_Click);
            // 
            // addNumBtn
            // 
            this.addNumBtn.Location = new System.Drawing.Point(372, 216);
            this.addNumBtn.Name = "addNumBtn";
            this.addNumBtn.Size = new System.Drawing.Size(93, 23);
            this.addNumBtn.TabIndex = 2;
            this.addNumBtn.Text = "Añadir Número";
            this.addNumBtn.UseVisualStyleBackColor = true;
            this.addNumBtn.Click += new System.EventHandler(this.addNumBtn_Click);
            // 
            // delRangeBtn
            // 
            this.delRangeBtn.Location = new System.Drawing.Point(484, 144);
            this.delRangeBtn.Name = "delRangeBtn";
            this.delRangeBtn.Size = new System.Drawing.Size(93, 23);
            this.delRangeBtn.TabIndex = 1;
            this.delRangeBtn.Text = "Eliminar Rango";
            this.delRangeBtn.UseVisualStyleBackColor = true;
            this.delRangeBtn.Click += new System.EventHandler(this.delRangeBtn_Click);
            // 
            // addRangeBtn
            // 
            this.addRangeBtn.Location = new System.Drawing.Point(372, 144);
            this.addRangeBtn.Name = "addRangeBtn";
            this.addRangeBtn.Size = new System.Drawing.Size(92, 23);
            this.addRangeBtn.TabIndex = 0;
            this.addRangeBtn.Text = "Añadir Rango";
            this.addRangeBtn.UseVisualStyleBackColor = true;
            this.addRangeBtn.Click += new System.EventHandler(this.addRangeBtn_Click);
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox5);
            this.splitContainer2.Panel1.Controls.Add(this.playButton);
            this.splitContainer2.Panel1.Controls.Add(this.winnersNumTxtBox);
            this.splitContainer2.Panel1.Controls.Add(this.winnerSelLbl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.winHisDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.winnersHisLbl);
            this.splitContainer2.Size = new System.Drawing.Size(640, 424);
            this.splitContainer2.SplitterDistance = 212;
            this.splitContainer2.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RaffleGUI.Properties.Resources.WhatsApp_Image_2021_04_06_at_7_38_43_PM;
            this.pictureBox5.Location = new System.Drawing.Point(525, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
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
            // winnersNumTxtBox
            // 
            this.winnersNumTxtBox.Location = new System.Drawing.Point(267, 76);
            this.winnersNumTxtBox.Name = "winnersNumTxtBox";
            this.winnersNumTxtBox.Size = new System.Drawing.Size(100, 20);
            this.winnersNumTxtBox.TabIndex = 2;
            // 
            // winnerSelLbl
            // 
            this.winnerSelLbl.AutoSize = true;
            this.winnerSelLbl.Location = new System.Drawing.Point(8, 14);
            this.winnerSelLbl.Name = "winnerSelLbl";
            this.winnerSelLbl.Size = new System.Drawing.Size(124, 13);
            this.winnerSelLbl.TabIndex = 1;
            this.winnerSelLbl.Text = "Selección de Ganadores";
            // 
            // winHisDataGridView
            // 
            this.winHisDataGridView.AllowUserToAddRows = false;
            this.winHisDataGridView.AllowUserToDeleteRows = false;
            this.winHisDataGridView.AllowUserToOrderColumns = true;
            this.winHisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.winHisDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.winHisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.winHisDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.winHisDataGridView.Location = new System.Drawing.Point(0, 35);
            this.winHisDataGridView.Name = "winHisDataGridView";
            this.winHisDataGridView.ReadOnly = true;
            this.winHisDataGridView.RowHeadersVisible = false;
            this.winHisDataGridView.Size = new System.Drawing.Size(640, 173);
            this.winHisDataGridView.TabIndex = 1;
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
            // playNumsDataGridView
            // 
            this.playNumsDataGridView.AllowUserToAddRows = false;
            this.playNumsDataGridView.AllowUserToDeleteRows = false;
            this.playNumsDataGridView.AllowUserToOrderColumns = true;
            this.playNumsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playNumsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playNumsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.playNumsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playNumsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.playNumsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.playNumsDataGridView.Name = "playNumsDataGridView";
            this.playNumsDataGridView.ReadOnly = true;
            this.playNumsDataGridView.RowHeadersVisible = false;
            this.playNumsDataGridView.Size = new System.Drawing.Size(148, 450);
            this.playNumsDataGridView.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rifa por los sueños";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mainWindowTabs.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.playTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winHisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playNumsDataGridView)).EndInit();
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
        private System.Windows.Forms.Label winnerSelLbl;
        private System.Windows.Forms.DataGridView winHisDataGridView;
        private System.Windows.Forms.Label winnersHisLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel sDespiertoLinkLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

