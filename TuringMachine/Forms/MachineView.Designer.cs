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
            this.dgvStateGrid = new System.Windows.Forms.DataGridView();
            this.colStateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbStrip = new System.Windows.Forms.TextBox();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
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
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
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
            this.howToUseToolStripMenuItem,
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
            this.panelMachineView.Controls.Add(this.label1);
            this.panelMachineView.Controls.Add(this.txbStrip);
            this.panelMachineView.Controls.Add(this.dgvStateGrid);
            this.panelMachineView.Controls.Add(this.mtsMachineView);
            this.panelMachineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachineView.Location = new System.Drawing.Point(0, 31);
            this.panelMachineView.Name = "panelMachineView";
            this.panelMachineView.Size = new System.Drawing.Size(412, 350);
            this.panelMachineView.TabIndex = 6;
            // 
            // dgvStateGrid
            // 
            this.dgvStateGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvStateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStateId});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStateGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStateGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStateGrid.Location = new System.Drawing.Point(0, 24);
            this.dgvStateGrid.Name = "dgvStateGrid";
            this.dgvStateGrid.RowHeadersVisible = false;
            this.dgvStateGrid.Size = new System.Drawing.Size(412, 265);
            this.dgvStateGrid.TabIndex = 4;
            // 
            // colStateId
            // 
            this.colStateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colStateId.HeaderText = "Estado";
            this.colStateId.Name = "colStateId";
            this.colStateId.ReadOnly = true;
            this.colStateId.Width = 65;
            // 
            // txbStrip
            // 
            this.txbStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStrip.Location = new System.Drawing.Point(0, 320);
            this.txbStrip.Name = "txbStrip";
            this.txbStrip.Size = new System.Drawing.Size(412, 30);
            this.txbStrip.TabIndex = 5;
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Strip:";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateGrid)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symbolToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStateGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateId;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.TextBox txbStrip;
        private System.Windows.Forms.Label label1;
    }
}

