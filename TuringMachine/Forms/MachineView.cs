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

        private List<State> StateList; 

        private List<char> SymbolList = new List<char>();

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

            private void BtnClose_Click(object sender, EventArgs e) => this.Close();

            private void BtnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        #endregion

        public MachineView()
        {

            InitializeComponent();

            SymbolList.Add('*');
            SymbolList.Add('_');

            initializeStateGrid();

        }

        private void cleanCustomSymbols()
        {

            for (int index = olvStatesGrid.Columns.Count - 1; index > 2; index--)
            {

                olvStatesGrid.Columns.Remove(olvStatesGrid.Columns[index]);

            }

        }

        private void initializeStateGrid()
        {

            SymbolList.Clear();

            StateList = new List<State>();

            cleanCustomSymbols();

            olvStatesGrid.SetObjects(StateList);

            SymbolList.Add('*');
            SymbolList.Add('_');

        }

        private void SymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {

            char newSymbol = Interaction.InputBox("Symbol: ", "New Symbol", "", 100, 100)[0];

            if (SymbolList.Contains(newSymbol) == false && newSymbol != ' ')
                SymbolList.Add(newSymbol);

            else
                Interaction.MsgBox("Invalid Symbol");
          
        }

        private void StateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StateList.Add(new State(StateList.Count + 1));

            olvStatesGrid.SetObjects(StateList);

        }

        private void OlvStatesGrid_CellEditFinishing(object sender, CellEditEventArgs e)
        {



        }
    }
}
