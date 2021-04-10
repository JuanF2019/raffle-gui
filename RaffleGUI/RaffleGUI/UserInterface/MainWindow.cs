using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaffleGUI.Model;

namespace RaffleGUI.UserInterface
{
    public partial class MainWindow : Form
    {
        private RaffleManager raffleManager;
        public MainWindow()
        {
            raffleManager = new RaffleManager();
            InitializeComponent();
            playNumsDataGridView.DataSource = raffleManager.PlayNums;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int winnersNum = Convert.ToInt32(winnersNumTxtBox.Text);

            List<int> winners = raffleManager.ThrowWinners(winnersNum);

            WinnersWindow wWin = new WinnersWindow(winners);
            wWin.Show();
            

        }

        private void addRangeBtn_Click(object sender, EventArgs e)
        {            
            int from = Convert.ToInt32(fromRangeTxtBox.Text);
            int to = Convert.ToInt32(toRangeTxtBox.Text);
            raffleManager.AddNumber(from,to);

        }

        private void delRangeBtn_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(fromRangeTxtBox.Text);
            int to = Convert.ToInt32(toRangeTxtBox.Text);
            raffleManager.DeleteNumber(from, to);
        }

        private void addNumBtn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numTxtBox.Text);
            raffleManager.AddNumber(num);
        }

        private void delNumBtn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numTxtBox.Text);
            raffleManager.DeleteNumber(num);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("About clicked: No form specified");
        }
    }
}
