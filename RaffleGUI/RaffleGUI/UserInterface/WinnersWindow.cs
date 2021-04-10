using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaffleGUI.UserInterface
{
    public partial class WinnersWindow : Form
    {
        private readonly List<int> winners;
        private int index;
        public WinnersWindow(List<int> winners)
        {           
            InitializeComponent();
            this.winners = winners;
            winLbl.Text = winners[0].ToString();
            index = 1;                                  
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextWinBtn_Click(object sender, EventArgs e)
        {           

            if (index == winners.Count-1)
            {
                nextWinBtn.Enabled = false;
                finishBtn.Enabled = true;
            }

            winLbl.Text = winners[index].ToString();
            index++;
        }
    }
}
