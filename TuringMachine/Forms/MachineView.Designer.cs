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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSymbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.striplenghtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDelayTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsMachineView = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeaderMachineView = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMachineView = new System.Windows.Forms.Panel();
            this.lblCurState = new System.Windows.Forms.Label();
            this.mtbHead = new System.Windows.Forms.MaskedTextBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.txbStrip = new System.Windows.Forms.MaskedTextBox();
            this.dgvStateGrid = new System.Windows.Forms.DataGridView();
            this.colStateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtsMachineView.SuspendLayout();
            this.panelHeaderMachineView.SuspendLayout();
            this.panelMachineView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.runToolStripMenuItem.Text = "Compute";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem1,
            this.deleteRowToolStripMenuItem,
            this.deleteSymbolToolStripMenuItem,
            this.striplenghtToolStripMenuItem,
            this.setDelayTimeToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.optionsToolStripMenuItem.Text = "Edit";
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete State";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.DeleteRowToolStripMenuItem_Click);
            // 
            // deleteSymbolToolStripMenuItem
            // 
            this.deleteSymbolToolStripMenuItem.Name = "deleteSymbolToolStripMenuItem";
            this.deleteSymbolToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteSymbolToolStripMenuItem.Text = "Delete Symbol";
            this.deleteSymbolToolStripMenuItem.Click += new System.EventHandler(this.deleteSymbolToolStripMenuItem_Click);
            // 
            // striplenghtToolStripMenuItem
            // 
            this.striplenghtToolStripMenuItem.Name = "striplenghtToolStripMenuItem";
            this.striplenghtToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.striplenghtToolStripMenuItem.Text = "Set Strip Lenght";
            this.striplenghtToolStripMenuItem.Click += new System.EventHandler(this.StriplenghtToolStripMenuItem_Click);
            // 
            // setDelayTimeToolStripMenuItem
            // 
            this.setDelayTimeToolStripMenuItem.Name = "setDelayTimeToolStripMenuItem";
            this.setDelayTimeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.setDelayTimeToolStripMenuItem.Text = "Set Iteration Delay";
            this.setDelayTimeToolStripMenuItem.Click += new System.EventHandler(this.SetDelayTimeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.InstructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // mtsMachineView
            // 
            this.mtsMachineView.AllowMerge = false;
            this.mtsMachineView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.mtsMachineView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtsMachineView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newStateToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mtsMachineView.Location = new System.Drawing.Point(0, 0);
            this.mtsMachineView.Name = "mtsMachineView";
            this.mtsMachineView.Size = new System.Drawing.Size(885, 24);
            this.mtsMachineView.Stretch = false;
            this.mtsMachineView.TabIndex = 1;
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.LoadToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.stateToolStripMenuItem.Text = "State";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.StateToolStripMenuItem_Click);
            // 
            // symbolToolStripMenuItem
            // 
            this.symbolToolStripMenuItem.Name = "symbolToolStripMenuItem";
            this.symbolToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            this.panelHeaderMachineView.Size = new System.Drawing.Size(885, 31);
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
            this.label4.Size = new System.Drawing.Size(885, 2);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProgramTitle.Location = new System.Drawing.Point(12, 9);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(275, 13);
            this.lblProgramTitle.TabIndex = 2;
            this.lblProgramTitle.Text = "Turing Machine (C#) by Bruno Firme e Gabriel Fernandes";
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
            this.btnMinimize.Location = new System.Drawing.Point(818, 3);
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
            this.btnClose.Location = new System.Drawing.Point(853, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelMachineView
            // 
            this.panelMachineView.Controls.Add(this.lblCurState);
            this.panelMachineView.Controls.Add(this.mtbHead);
            this.panelMachineView.Controls.Add(this.lblIterations);
            this.panelMachineView.Controls.Add(this.txbStrip);
            this.panelMachineView.Controls.Add(this.dgvStateGrid);
            this.panelMachineView.Controls.Add(this.mtsMachineView);
            this.panelMachineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachineView.Location = new System.Drawing.Point(0, 31);
            this.panelMachineView.Name = "panelMachineView";
            this.panelMachineView.Size = new System.Drawing.Size(885, 490);
            this.panelMachineView.TabIndex = 6;
            // 
            // lblCurState
            // 
            this.lblCurState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCurState.ForeColor = System.Drawing.Color.White;
            this.lblCurState.Location = new System.Drawing.Point(996, 4);
            this.lblCurState.Name = "lblCurState";
            this.lblCurState.Size = new System.Drawing.Size(106, 17);
            this.lblCurState.TabIndex = 10;
            this.lblCurState.Text = "Current State:";
            // 
            // mtbHead
            // 
            this.mtbHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtbHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbHead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtbHead.Enabled = false;
            this.mtbHead.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mtbHead.ForeColor = System.Drawing.Color.White;
            this.mtbHead.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbHead.Location = new System.Drawing.Point(0, 430);
            this.mtbHead.Name = "mtbHead";
            this.mtbHead.Size = new System.Drawing.Size(885, 30);
            this.mtbHead.TabIndex = 9;
            this.mtbHead.Text = "V";
            // 
            // lblIterations
            // 
            this.lblIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIterations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIterations.ForeColor = System.Drawing.Color.White;
            this.lblIterations.Location = new System.Drawing.Point(1108, 4);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(106, 17);
            this.lblIterations.TabIndex = 8;
            this.lblIterations.Text = "Iterations:";
            // 
            // txbStrip
            // 
            this.txbStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbStrip.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.txbStrip.ForeColor = System.Drawing.Color.Black;
            this.txbStrip.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txbStrip.Location = new System.Drawing.Point(0, 460);
            this.txbStrip.Name = "txbStrip";
            this.txbStrip.Size = new System.Drawing.Size(885, 30);
            this.txbStrip.TabIndex = 7;
            this.txbStrip.Text = ">";
            this.txbStrip.TextChanged += new System.EventHandler(this.TxbStrip_TextChanged);
            // 
            // dgvStateGrid
            // 
            this.dgvStateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStateGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvStateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStateId});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStateGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStateGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvStateGrid.Location = new System.Drawing.Point(0, 24);
            this.dgvStateGrid.Name = "dgvStateGrid";
            this.dgvStateGrid.RowHeadersVisible = false;
            this.dgvStateGrid.Size = new System.Drawing.Size(885, 466);
            this.dgvStateGrid.TabIndex = 4;
            // 
            // colStateId
            // 
            this.colStateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colStateId.HeaderText = "State";
            this.colStateId.Name = "colStateId";
            this.colStateId.ReadOnly = true;
            this.colStateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStateId.Width = 38;
            // 
            // MachineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(885, 521);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mtsMachineView;
        private System.Windows.Forms.Panel panelHeaderMachineView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMachineView;
        private System.Windows.Forms.ToolStripMenuItem newStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symbolToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStateGrid;
        private System.Windows.Forms.MaskedTextBox txbStrip;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem striplenghtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSymbolToolStripMenuItem;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.MaskedTextBox mtbHead;
        private System.Windows.Forms.ToolStripMenuItem setDelayTimeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateId;
        private System.Windows.Forms.Label lblCurState;
    }
}

