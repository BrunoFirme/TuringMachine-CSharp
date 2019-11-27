using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuringMachine.Models;
using Microsoft.VisualBasic;
using System.IO;
using System.Threading;

namespace TuringMachine
{
    public partial class MachineView : Form
    {
        public MachineView()
        {

            InitializeComponent();

            initializeStateGrid();

            setStrip();

            mtbHead.Text = "V";
            mtbHead.Text = mtbHead.Text.PadRight(Properties.Settings.Default.StripLenght);


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

        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Interaction.MsgBox("State Command Format: #/#/# \nWhere:\n 1# = Symbol to Write (ex: #)\n 2# = Direction to move in [<, >] (ex: <)\n 3# = New state ID (ex: 2)\nExamples:\n @/</4 == (Write @, Move Left (<), change state to 4).\n A/>/1 == (Write A, Move Right (>), change state to 1). \n\nImportant: State -1 is HALT.");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Interaction.MsgBox("Project by Bruno Firme Crema and Gabriel Fernandes Pereira.\n\nSpecial Thanks to:\nProfessor Sergio Coral for the knowledge necessary to build this code.\nAlan Turing for his imense contribution to humankind.\n\nIcon: Turing Machine by Attilio Baghino from the Noun Project.");

        }

        private void RunToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mtbHead.Text = mtbHead.Text.PadRight(Properties.Settings.Default.StripLenght);
            dgvStateGrid.EndEdit(DataGridViewDataErrorContexts.Commit);
            TuringMachine();

        }

        //Filter whitespace in strip (convert to _)
        private void TxbStrip_TextChanged(object sender, EventArgs e)
        {


            txbStrip.Text = txbStrip.Text.Replace(" ", "_");
            txbStrip.Text = txbStrip.Text.PadRight(Properties.Settings.Default.StripLenght, '_');

        }

        #endregion

        #region Form utilities.

        //Update cycles counter.
        private void updateIterations(int iterations)
        {

            if (iterations < 1)
                lblIterations.Text = "Iterations: " + iterations;
            else
                lblIterations.Text = "Iterations: " + iterations;

        }

        //Update head and strip representation.
        private void updateVisuals(int currentState, Head head)
        {

            lblCurState.Text = "Current State: " + currentState;

            txbStrip.Text = head.Strip;

            mtbHead.Text = " ";
            mtbHead.Text = mtbHead.Text.PadRight(Properties.Settings.Default.StripLenght);
            StringBuilder strBuilder = new StringBuilder(mtbHead.Text);
            strBuilder[head.Position] = 'V';
            mtbHead.Text = strBuilder.ToString();

        }

        //Initialize Strip with StripLenght size.
        private void setStrip()
        {

            txbStrip.Text = ">";
            txbStrip.Text = txbStrip.Text.PadRight(Properties.Settings.Default.StripLenght, '_');

        }

        //Reset symbol columns on States Table.
        private void cleanSymbols()
        {

            for (int index = dgvStateGrid.Columns.Count - 1; index > 0; index--)
            {

                dgvStateGrid.Columns.Remove(dgvStateGrid.Columns[index]);

            }

        }

        // User set Striplenght.
        private void StriplenghtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                Properties.Settings.Default.StripLenght = Convert.ToInt32(Interaction.InputBox("Strip Lenght: ", "New Value", "", 100, 100));
                setStrip();

            }
            catch (FormatException ex)
            {

                Interaction.MsgBox("Valor inválido");

            }

        }

        // User set Delay in iteration.
        private void SetDelayTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                Properties.Settings.Default.IterationDelay = Convert.ToInt32(Interaction.InputBox("Iteration Delay: ", "New Value", "", 100, 100));

            }
            catch (FormatException ex)
            {

                Interaction.MsgBox("Valor inválido");

            }

        }

        //Save State Table 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File|*.txt";
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            dgvStateGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvStateGrid.SelectAll();

            var rowHeaders = dgvStateGrid.RowHeadersVisible;
            dgvStateGrid.RowHeadersVisible = false;

            string content = dgvStateGrid.GetClipboardContent().GetText();

            content.Trim();

            dgvStateGrid.ClearSelection();
            dgvStateGrid.RowHeadersVisible = rowHeaders;

            System.IO.File.WriteAllText(dialog.FileName, content);
            MessageBox.Show(@"State Table Saved Sucessfully.");

        }

        //Load State Table 
        private void LoadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            System.IO.StreamReader file = null;

            Stream Stream = null;

            OpenFileDialog FileBrowser = new OpenFileDialog();

            FileBrowser.Title = "Open Saved File";

            FileBrowser.Filter = "TXT files|*.txt";

            FileBrowser.InitialDirectory = @"C:\Users\bruno\Desktop\TuringMachine-CSharp\TuringMachine\Saved Files";

            if (FileBrowser.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    if ((Stream = FileBrowser.OpenFile()) != null)
                    {

                        using (Stream)
                        {

                            file = new System.IO.StreamReader(FileBrowser.FileName);

                        }

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: File Not Readable." + ex.Message);

                }

                string[] ColumnHeaders = file.ReadLine().Split();

                dgvStateGrid.Rows.Clear();
                dgvStateGrid.Columns.Clear();

                foreach (string c in ColumnHeaders)
                {

                    var newCol = new DataGridViewTextBoxColumn();
                    newCol.HeaderText = c;

                    dgvStateGrid.Columns.Add(newCol);

                }

                string fileRow;

                while ((fileRow = file.ReadLine()) != null)
                {

                    string[] values = fileRow.Split();

                    for (int i = 0; i < (values.Length / ColumnHeaders.Length); i++)
                    {

                        if (values[0] != "")
                            dgvStateGrid.Rows.Add(values);

                    }

                }

                file.Close();

            }

        }

        #endregion

        #region Adding/Removing States/Symbols.

        //Prompt to input new symbol.
        private void SymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string newSymbol = Interaction.InputBox("Symbol: ", "New Symbol", "", 100, 100);

            if (newSymbol.Length > 1 || newSymbol.Length == 0)
                Interaction.MsgBox("Símbolo inválido");
            else
                addSymbolColumn(newSymbol);

        }

        //Add new symbol column.
        private void addSymbolColumn(string newSymbol)
        {

            var newCol = new DataGridViewTextBoxColumn();
            newCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            newCol.HeaderText = newSymbol;
            dgvStateGrid.Columns.Add(newCol);

        }

        //Delete Symbol.
        private void deleteSymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvStateGrid.Columns.Count == 3)
            {

                return;

            }
            else
            {

                int column = dgvStateGrid.Columns.Count - 1;

                dgvStateGrid.Columns.Remove(dgvStateGrid.Columns[column]);

            }

        }

        //Adds new state to the table.
        private void StateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(dgvStateGrid.Rows[dgvStateGrid.Rows.Count - 2].Cells[0].Value as String))
            {

                dgvStateGrid.Rows[dgvStateGrid.Rows.Count - 2].Cells[0].Value = (dgvStateGrid.Rows.Count - 2).ToString();

            }
            else
            {

                dgvStateGrid.Rows.Add((dgvStateGrid.Rows.Count - 1).ToString());

            }


        }

        //Delete latest added state from table.
        private void DeleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvStateGrid.Rows.Count == 2)
            {

                dgvStateGrid.Rows.Clear();
                dgvStateGrid.Rows.Add("0");

            }
            else
            {

                int row = dgvStateGrid.Rows.Count - 2;

                dgvStateGrid.Rows.Remove(dgvStateGrid.Rows[row]);

            }

        }

        #endregion

        #region Initialize/Reset States Table.

        //Reset the States Table (by calling appropriate methods).
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mtbHead.Text = "V";
            mtbHead.Text = mtbHead.Text.PadRight(Properties.Settings.Default.StripLenght, ' ');
            lblCurState.Text = "Current State: ";
            lblIterations.Text = "Iterations: ";
            setStrip();
            cleanSymbols();
            initializeStateGrid();

        }

        //Reset the SymbolList, StateList and State Table Symbol Columns, initializes them again.
        private void initializeStateGrid()
        {

            cleanSymbols();

            dgvStateGrid.Rows.Clear();

            addSymbolColumn(">");
            addSymbolColumn("_");

            dgvStateGrid.Rows.Add("0");

            dgvStateGrid.Rows[0].Cells[1].Value = ">/>/1";
            dgvStateGrid.Rows[0].Cells[2].Value = "_/</0";

        }

        #endregion

        #region Run TuringMachine.

        //Initialize the States in States Table.
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
                    StateList.Add(new State());

                    IDictionary<char, Parameter> Parameters = new Dictionary<char, Parameter>();

                    //For every Column...
                    for (int index = 1; index < dgvStateGrid.Columns.Count; index++)
                    {

                        //If has any instruction...
                        if (dgvStateGrid[index, dr.Index].Value != null && dgvStateGrid[index, dr.Index].Value.ToString() != "")
                            //Add instructions to new parameter and add it to the Dictionary...
                            Parameters.Add(dgvStateGrid.Columns[index].HeaderText[0], 
                                new Parameter(dgvStateGrid[index, dr.Index].Value.ToString().Split('/')));

                    }

                    //Then set that state's dictionary.
                    if (Parameters.Count > 0)
                        StateList[dr.Index].SetDictionary(Parameters);

                }

            }

            return StateList;

        }

        //Compute the Strip based on States Table.
        private void TuringMachine()
        {
         
            int iterations = 0;

            //Initialize States, Head, CurrentState.
            List<State> StateList = InitializeStates();

            //VALIDATION 0: Check if there are parameters to execute in state 0.
            if(StateList[0].Parameters == null)
            {

                Interaction.MsgBox("There are no instructions to start computation.");
                return;

            }
                 

            Head Head = new Head(txbStrip.Text);

            int CurrentState = 0;

            //Run machine until state is HALT (-1).
            while (CurrentState != -1)
            {

                //Update cycle counter.
                updateIterations(iterations += 1);

                try
                {

                    //VALIDATION 1: Check if state has response for the current position.
                    if (StateList[CurrentState].Parameters.ContainsKey(Head.Read()))
                    {

                        //STEP 1: READ AND SAVE THE CURRENT SYMBOL.
                        char readSymbol = Head.Read();

                        //STEP 2: WRITE NEW SYMBOL IN HEAD.STRIP[POSITION].
                        Head.Write(StateList[CurrentState].Parameters[readSymbol].newSymbol);

                        //STEP 3: MOVE HEAD.POSITION.
                        Head.Move(StateList[CurrentState].Parameters[readSymbol].Direction);

                        //VISUAL: Update Visuals
                        updateVisuals(CurrentState, Head);
                        this.Update();
                        Thread.Sleep(Properties.Settings.Default.IterationDelay);

                        //VALIDATION 2: Check if HEAD has gone off right end of tape.
                        if (Head.Position >= Head.Strip.Length)
                        {

                            Interaction.MsgBox("Halt: Head has gone out of the right end of tape. Halting Problem?");
                            CurrentState = -1;


                        }
                        //VALIDATION 3: Check if HEAD has gone off left end of tape.
                        else if (Head.Position < 0)
                        {

                            Interaction.MsgBox("Halt: Head has gone out of the left end of tape. Halting Problem?");
                            CurrentState = -1;

                        }
                        //STEP 4: CHANGE STATE, UPDATE STRIP.
                        else
                        {

                            CurrentState = StateList[CurrentState].Parameters[readSymbol].newState;

                        }

                    }                   
                    else
                    {

                        Interaction.MsgBox("Halt: State " + CurrentState + " does not have rule for symbol " + Head.Read());
                        return;

                    }

                }
                catch (ArgumentOutOfRangeException e)
                {


                    Interaction.MsgBox("Halt: State '" + CurrentState + "' does not have rule for symbol '" + Head.Read() + "'");
                    return;

                }



            }

            //FINAL STEP: MACHINE HAS REACHED HALT STATE, PRINT STRIP AND SUCESS MESSAGE.
            if (CurrentState == -1 && Head.Position >= 0)
            {

                Interaction.MsgBox("Turing Machine: Computation complete.");

            }

        }

        #endregion


    }

}
