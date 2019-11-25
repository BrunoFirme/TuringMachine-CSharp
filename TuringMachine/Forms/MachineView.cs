using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using TuringMachine.Models;
using Microsoft.VisualBasic;

namespace TuringMachine
{
    public partial class MachineView : Form
    {

        private int StripLenght = 50;

        public MachineView()
        {

            InitializeComponent();

            initializeStateGrid();

            InitializeTuringMachine();

            setStrip();

        }

        #region Basic form functionality.

            #region (Snippet) Move screen around 

            private bool mouseDown;
            private Point lastLocation;

            private void panelHeaderMachineView_MouseDown(object sender, MouseEventArgs e)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }

            private void panelHeaderMachineView_MouseMove(object sender, MouseEventArgs e)
            {
                if (mouseDown)
                {
                    this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                    this.Update();
                }
            }

            private void panelHeaderMachineView_MouseUp(object sender, MouseEventArgs e)
            {
                mouseDown = false;
            }

        #endregion

            private void BtnClose_Click(object sender, EventArgs e) 
            {              
                
                this.Close();

            }

            private void BtnMinimize_Click(object sender, EventArgs e)
            {

                this.WindowState = FormWindowState.Minimized;

            }

            //Basic Howto.
            private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
            {

                Interaction.MsgBox("State Command Format:\n1#/2#/3# \nWhere:\n 1# = Symbol to Write (ex: #/...)\n 2# = Direction to move in [<, >] (ex: #/>/...)\n 3# = New state ID (ex: #/>/2)\nExamples:\n @/</4 == (Write @, Move Left (<), change state to 4).\n A/>/1 == (Write A, Move Right (>), change state to 1)."); 

            }
            
        #endregion

        #region Adding States/Symbols.

        //Prompt to input new symbol.
        private void SymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string newSymbol = Interaction.InputBox("Symbol: ", "New Symbol", "", 100, 100);

            if (newSymbol.Length > 1)
                Interaction.MsgBox("Símbolo inválido");
            else
                addSymbolColumn(newSymbol);

        }

        //Add new symbol column.
        private void addSymbolColumn(string newSymbol)
        {

            var newCol = new DataGridViewTextBoxColumn();
            newCol.HeaderText = newSymbol;
            dgvStateGrid.Columns.Add(newCol);

        }

        //Adds new state to the table.
        private void StateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dgvStateGrid.Rows.Add((dgvStateGrid.Rows.Count).ToString());

        }

        #endregion

        #region Initialize/Reset States Table.

        private void setStrip()
        {

            txbStrip.Text = ">";
            txbStrip.Text = txbStrip.Text.PadRight(50, '_');

        }

        //Reset the States Table (by calling appropriate methods).
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            setStrip();
            cleanSymbols();
            initializeStateGrid();

        }

        //Reset the SymbolList, StateList and State Table Symbol Columns, initializes them again.
        private void initializeStateGrid()
        {

            cleanSymbols();
            dgvStateGrid.Rows.Clear();
            dgvStateGrid.Rows.Add("1");

            addSymbolColumn("*");
            addSymbolColumn("_");

        }

        //Removes added symbol columns from States Table.
        private void cleanSymbols()
        {

            for (int index = dgvStateGrid.Columns.Count - 1; index > 0; index--)
            {

                dgvStateGrid.Columns.Remove(dgvStateGrid.Columns[index]);

            }

        }

        #endregion

        private void InitializeTuringMachine()
        {

            Head Head = new Head(txbStrip.Text, StripLenght);



        }

    }

}
