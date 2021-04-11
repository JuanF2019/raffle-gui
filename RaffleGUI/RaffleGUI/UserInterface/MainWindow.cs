using RaffleGUI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RaffleGUI.UserInterface
{
    public partial class MainWindow : Form
    {
        private RaffleManager raffleManager;
        private List<int> currentWinners;
        private DataTable winnersHistory;

        public MainWindow()
        {
            raffleManager = new RaffleManager();
            InitializeComponent();
            playNumsDataGridView.DataSource = raffleManager.PlayNums;
            winnersHistory = raffleManager.WinnersHistory;
            winHisDataGridView.DataSource = winnersHistory;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int winnersNum = Convert.ToInt32(winnersNumTxtBox.Text);

            if (winnersNum <= raffleManager.PlayNums.Rows.Count)
            {
                currentWinners = raffleManager.ThrowWinners(winnersNum);

                WinnersWindow wWin = new WinnersWindow(currentWinners);
                wWin.ShowDialog();

                String winnersString = "";

                foreach (int winner in currentWinners)
                {
                    winnersString += winner + "  ";
                }

                DataRow newWinners = winnersHistory.NewRow();
                newWinners["Ronda"] = raffleManager.Round;
                newWinners["Ganadores"] = winnersString;
                winnersHistory.Rows.Add(newWinners);
            }
            else
            {
                MessageBox.Show("Hay más ganadores que numeros jugando, por favor agregue más números", "Error al seleccionar ganadores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int from = Convert.ToInt32(fromRangeTxtBox.Text);
                int to = Convert.ToInt32(toRangeTxtBox.Text);

                if (from <= to)
                {
                    int addedNumbers = raffleManager.AddNumber(from, to);

                    MessageBox.Show("Se han añadido un total de " + addedNumbers + " de " + (to - from + 1) + " números", "Números Añadidos Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Verifique el rango, el valor desde el cual empieza el rango debe ser menor a en el que termina", "Error al agregar números", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor verique la escritura de los números y que no falta ninguno", "Error al añadir rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delRangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int from = Convert.ToInt32(fromRangeTxtBox.Text);
                int to = Convert.ToInt32(toRangeTxtBox.Text);

                if (from <= to)
                {
                    int deletedNumbers = raffleManager.DeleteNumber(from, to);

                    MessageBox.Show("Se han eliminado un total de " + deletedNumbers + " de " + (to - from + 1) + " números", "Números Eliminados Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Verifique el rango, el valor desde el cual empieza el rango debe ser menor a en el que termina", "Error al eliminar numeros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor verique la escritura de los números y que no falte ninguno", "Error al eliminar rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(numTxtBox.Text);
                bool added = raffleManager.AddNumber(num);

                if (added)
                {
                    MessageBox.Show("Se ha añadido exitosamente el número " + num, "Número Añadido Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El número " + num + " ya existe en los números que estan jugando", "Número Ya Existe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor verique la escritura del número", "Error al añadir un número", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delNumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(numTxtBox.Text);
                bool deleted = raffleManager.DeleteNumber(num);

                if (deleted)
                {
                    MessageBox.Show("Se ha eliminado exitosamente el número " + num, "Número Eliminado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El número " + num + " no existe en los números que están jugando", "Número No Existe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor verique la escritura del número", "Error al eliminar un número", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void sDespiertoLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sDespiertoLinkLbl.LinkVisited = true;
            System.Diagnostics.Process.Start(sDespiertoLinkLbl.Text);
        }
    }
}
