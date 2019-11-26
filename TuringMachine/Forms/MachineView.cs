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

        private int StripLenght = 5;

        public MachineView()
        {

            InitializeComponent();

            initializeStateGrid();

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

            Interaction.MsgBox("State Command Format:\n1#/2#/3# \nWhere:\n 1# = Symbol to Write (ex: #/...)\n 2# = Direction to move in [<, >] (ex: #/>/...)\n 3# = New state ID (ex: #/>/2)\nExamples:\n @/</4 == (Write @, Move Left (<), change state to 4).\n A/>/1 == (Write A, Move Right (>), change state to 1). \n State 0 is considered HALT.");

        }

        private void RunToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TuringMachine();

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

            txbStrip.Text = "_";
            txbStrip.Text = txbStrip.Text.PadRight(5, '_');

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

        #region Run TuringMachine.

        private List<State> InitializeStates()
        {

            List<State> StateList = new List<State>();

            //For each state...
            foreach (DataGridViewRow dr in dgvStateGrid.Rows)
            {

                //Check if Row's State Number is null...
                if (dgvStateGrid[0, dr.Index].Value != null)
                {

                    //Creates new state with that row's id...
                    StateList.Add(new State(Convert.ToInt32(dgvStateGrid.Rows[dr.Index].Cells[0].Value.ToString())));

                    IDictionary<char, Parameter> Parameters = new Dictionary<char, Parameter>();

                    //For every Column...
                    for (int index = 1; index < dgvStateGrid.Columns.Count; index++)
                    {

                        //If has any instruction...
                        if (dgvStateGrid[index, dr.Index].Value != null)
                            //Add instructions to new parameter and add it to the Dictionary...
                            Parameters.Add(dgvStateGrid.Columns[index].HeaderText[0], new Parameter(dgvStateGrid[index, dr.Index].Value.ToString().Split('/')));

                    }

                    //Then set that state's dictionary.
                    if (Parameters.Count > 0)
                        StateList[dr.Index].SetDictionary(Parameters);

                }

            }

            return StateList;

        }

        private void TuringMachine()
        {

            List<State> StateList = InitializeStates();

            int CurrentState = 1;

            Head Head = new Head(txbStrip.Text, StripLenght);

            while (CurrentState != 0 && Head.Position >= 0 && Head.Position < Head.Strip.Length)
            {

                Head.Write(StateList[CurrentState - 1].ReadDictionary(Head.Read()).newSymbol);

                Head.Move(StateList[CurrentState - 1].ReadDictionary(Head.Read()).Direction);

                if (Head.Position >= Head.Strip.Length)
                {

                    txbStrip.Text = Head.Strip;
                    Interaction.MsgBox("Error: Head has gone out of the right end of tape. Are you having a Halting Problem?");

                }
                else
                {

                    CurrentState = StateList[CurrentState - 1].ReadDictionary(Head.Read()).newState;
                    txbStrip.Text = Head.Strip;

                }

            }

            if (CurrentState == 0 && Head.Position >= 0)
            {

                Interaction.MsgBox("Sucess: the Machine has completed the task.");

            }
            else if (CurrentState != 0 && Head.Position < 0)
            {

                Interaction.MsgBox("Error: Head has gone out of the left end of tape.");

            }

        }

        #endregion

    }

}
