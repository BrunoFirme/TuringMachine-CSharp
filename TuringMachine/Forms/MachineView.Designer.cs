namespace TuringMachine
{
    partial class MachineView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineView));
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsMachineView = new System.Windows.Forms.MenuStrip();
            this.newStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeaderMachineView = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMachineView = new System.Windows.Forms.Panel();
            this.olvStatesGrid = new BrightIdeasSoftware.ObjectListView();
            this.olvState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSymbol1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSymbol2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mtsMachineView.SuspendLayout();
            this.panelHeaderMachineView.SuspendLayout();
            this.panelMachineView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvStatesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.parametersToolStripMenuItem.Text = "Parameters";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.resetToolStripMenuItem.Text = "Reset ";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mtsMachineView
            // 
            this.mtsMachineView.AllowMerge = false;
            this.mtsMachineView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.mtsMachineView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtsMachineView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.newStateToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mtsMachineView.Location = new System.Drawing.Point(0, 0);
            this.mtsMachineView.Name = "mtsMachineView";
            this.mtsMachineView.Size = new System.Drawing.Size(412, 24);
            this.mtsMachineView.Stretch = false;
            this.mtsMachineView.TabIndex = 1;
            // 
            // newStateToolStripMenuItem
            // 
            this.newStateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateToolStripMenuItem,
            this.symbolToolStripMenuItem});
            this.newStateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newStateToolStripMenuItem.Name = "newStateToolStripMenuItem";
            this.newStateToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newStateToolStripMenuItem.Text = "New";
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stateToolStripMenuItem.Text = "State";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.StateToolStripMenuItem_Click);
            // 
            // symbolToolStripMenuItem
            // 
            this.symbolToolStripMenuItem.Name = "symbolToolStripMenuItem";
            this.symbolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.symbolToolStripMenuItem.Text = "Symbol";
            this.symbolToolStripMenuItem.Click += new System.EventHandler(this.SymbolToolStripMenuItem_Click);
            // 
            // panelHeaderMachineView
            // 
            this.panelHeaderMachineView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelHeaderMachineView.Controls.Add(this.label4);
            this.panelHeaderMachineView.Controls.Add(this.lblProgramTitle);
            this.panelHeaderMachineView.Controls.Add(this.btnMinimize);
            this.panelHeaderMachineView.Controls.Add(this.btnClose);
            this.panelHeaderMachineView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderMachineView.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderMachineView.Name = "panelHeaderMachineView";
            this.panelHeaderMachineView.Size = new System.Drawing.Size(412, 31);
            this.panelHeaderMachineView.TabIndex = 5;
            this.panelHeaderMachineView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeaderMachineView_MouseDown);
            this.panelHeaderMachineView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeaderMachineView_MouseMove);
            this.panelHeaderMachineView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeaderMachineView_MouseUp);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 2);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgramTitle.Location = new System.Drawing.Point(12, 9);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(177, 13);
            this.lblProgramTitle.TabIndex = 2;
            this.lblProgramTitle.Text = "Turing Machine (C#) by Bruno Firme";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(345, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 23);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(380, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelMachineView
            // 
            this.panelMachineView.Controls.Add(this.olvStatesGrid);
            this.panelMachineView.Controls.Add(this.mtsMachineView);
            this.panelMachineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachineView.Location = new System.Drawing.Point(0, 31);
            this.panelMachineView.Name = "panelMachineView";
            this.panelMachineView.Size = new System.Drawing.Size(412, 350);
            this.panelMachineView.TabIndex = 6;
            // 
            // olvStatesGrid
            // 
            this.olvStatesGrid.AllColumns.Add(this.olvState);
            this.olvStatesGrid.AllColumns.Add(this.olvSymbol1);
            this.olvStatesGrid.AllColumns.Add(this.olvSymbol2);
            this.olvStatesGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.olvStatesGrid.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvStatesGrid.CellEditTabChangesRows = true;
            this.olvStatesGrid.CellEditUseWholeCell = false;
            this.olvStatesGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvState,
            this.olvSymbol1,
            this.olvSymbol2});
            this.olvStatesGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvStatesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvStatesGrid.ForeColor = System.Drawing.Color.White;
            this.olvStatesGrid.HasCollapsibleGroups = false;
            this.olvStatesGrid.HideSelection = false;
            this.olvStatesGrid.Location = new System.Drawing.Point(0, 24);
            this.olvStatesGrid.MultiSelect = false;
            this.olvStatesGrid.Name = "olvStatesGrid";
            this.olvStatesGrid.ShowGroups = false;
            this.olvStatesGrid.Size = new System.Drawing.Size(412, 162);
            this.olvStatesGrid.TabIndex = 2;
            this.olvStatesGrid.UseCompatibleStateImageBehavior = false;
            this.olvStatesGrid.View = System.Windows.Forms.View.Details;
            this.olvStatesGrid.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.OlvStatesGrid_CellEditFinishing);
            // 
            // olvState
            // 
            this.olvState.AspectName = "Id";
            this.olvState.IsEditable = false;
            this.olvState.Text = "Estado";
            // 
            // olvSymbol1
            // 
            this.olvSymbol1.Text = "*";
            // 
            // olvSymbol2
            // 
            this.olvSymbol2.Text = "_";
            // 
            // MachineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(412, 381);
            this.ControlBox = false;
            this.Controls.Add(this.panelMachineView);
            this.Controls.Add(this.panelHeaderMachineView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mtsMachineView;
            this.Name = "MachineView";
            this.Text = "Turing Machine (C#)";
            this.mtsMachineView.ResumeLayout(false);
            this.mtsMachineView.PerformLayout();
            this.panelHeaderMachineView.ResumeLayout(false);
            this.panelHeaderMachineView.PerformLayout();
            this.panelMachineView.ResumeLayout(false);
            this.panelMachineView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvStatesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mtsMachineView;
        private System.Windows.Forms.Panel panelHeaderMachineView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMachineView;
        private System.Windows.Forms.ToolStripMenuItem newStateToolStripMenuItem;
        private BrightIdeasSoftware.ObjectListView olvStatesGrid;
        private BrightIdeasSoftware.OLVColumn olvState;
        private BrightIdeasSoftware.OLVColumn olvSymbol1;
        private BrightIdeasSoftware.OLVColumn olvSymbol2;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symbolToolStripMenuItem;
    }
}

