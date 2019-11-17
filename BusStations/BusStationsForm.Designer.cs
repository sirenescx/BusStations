namespace BusStations
{
    partial class BusStationsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusStationsForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceExistingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToExistingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoSortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAlphabeticalOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SBAONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SBAOOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAscendingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SBAOFNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SBAOFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roadFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(945, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.openToolStripMenuItem.Text = "Open file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsNewFileToolStripMenuItem,
            this.replaceExistingFileToolStripMenuItem,
            this.addToExistingFileToolStripMenuItem});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.saveFileToolStripMenuItem.Text = "Save file";
            // 
            // saveAsNewFileToolStripMenuItem
            // 
            this.saveAsNewFileToolStripMenuItem.Name = "saveAsNewFileToolStripMenuItem";
            this.saveAsNewFileToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.saveAsNewFileToolStripMenuItem.Text = "Save as new file";
            this.saveAsNewFileToolStripMenuItem.Click += new System.EventHandler(this.SaveAsNewFileToolStripMenuItem_Click);
            // 
            // replaceExistingFileToolStripMenuItem
            // 
            this.replaceExistingFileToolStripMenuItem.Name = "replaceExistingFileToolStripMenuItem";
            this.replaceExistingFileToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.replaceExistingFileToolStripMenuItem.Text = "Replace existing file";
            this.replaceExistingFileToolStripMenuItem.Click += new System.EventHandler(this.ReplaceExistingFileToolStripMenuItem_Click);
            // 
            // addToExistingFileToolStripMenuItem
            // 
            this.addToExistingFileToolStripMenuItem.Name = "addToExistingFileToolStripMenuItem";
            this.addToExistingFileToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.addToExistingFileToolStripMenuItem.Text = "Add to existing file";
            this.addToExistingFileToolStripMenuItem.Click += new System.EventHandler(this.AddToExistingFileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAmountToolStripMenuItem,
            this.undoSortingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeAmountToolStripMenuItem
            // 
            this.changeAmountToolStripMenuItem.Name = "changeAmountToolStripMenuItem";
            this.changeAmountToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.changeAmountToolStripMenuItem.Text = "Change amount of displayed elements";
            this.changeAmountToolStripMenuItem.Click += new System.EventHandler(this.ChangeAmountToolStripMenuItem_Click);
            // 
            // undoSortingToolStripMenuItem
            // 
            this.undoSortingToolStripMenuItem.Name = "undoSortingToolStripMenuItem";
            this.undoSortingToolStripMenuItem.Size = new System.Drawing.Size(339, 26);
            this.undoSortingToolStripMenuItem.Text = "Undo sorting/filter";
            this.undoSortingToolStripMenuItem.Click += new System.EventHandler(this.UndoSortingToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byAlphabeticalOrderToolStripMenuItem,
            this.byAscendingOrderToolStripMenuItem,
            this.byAmountToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // byAlphabeticalOrderToolStripMenuItem
            // 
            this.byAlphabeticalOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SBAONToolStripMenuItem,
            this.SBAOOToolStripMenuItem});
            this.byAlphabeticalOrderToolStripMenuItem.Name = "byAlphabeticalOrderToolStripMenuItem";
            this.byAlphabeticalOrderToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.byAlphabeticalOrderToolStripMenuItem.Text = "By alphabetical order";
            // 
            // SBAONToolStripMenuItem
            // 
            this.SBAONToolStripMenuItem.Name = "SBAONToolStripMenuItem";
            this.SBAONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.SBAONToolStripMenuItem.Text = "Name";
            this.SBAONToolStripMenuItem.Click += new System.EventHandler(this.SortByAscendingNameToolStripMenuItem_Click);
            // 
            // SBAOOToolStripMenuItem
            // 
            this.SBAOOToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SBAOOToolStripMenuItem.Name = "SBAOOToolStripMenuItem";
            this.SBAOOToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.SBAOOToolStripMenuItem.Text = "Owner";
            this.SBAOOToolStripMenuItem.Click += new System.EventHandler(this.SortByAscendingOwnerToolStripMenuItem_Click);
            // 
            // byAscendingOrderToolStripMenuItem
            // 
            this.byAscendingOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SBAOFNToolStripMenuItem,
            this.SBAOFOToolStripMenuItem});
            this.byAscendingOrderToolStripMenuItem.Name = "byAscendingOrderToolStripMenuItem";
            this.byAscendingOrderToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.byAscendingOrderToolStripMenuItem.Text = "By ascending order";
            // 
            // SBAOFNToolStripMenuItem
            // 
            this.SBAOFNToolStripMenuItem.Name = "SBAOFNToolStripMenuItem";
            this.SBAOFNToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.SBAOFNToolStripMenuItem.Text = "Name";
            this.SBAOFNToolStripMenuItem.Click += new System.EventHandler(this.SortByAscendingFlowNameToolStripMenuItem_Click);
            // 
            // SBAOFOToolStripMenuItem
            // 
            this.SBAOFOToolStripMenuItem.Name = "SBAOFOToolStripMenuItem";
            this.SBAOFOToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.SBAOFOToolStripMenuItem.Text = "Owner";
            this.SBAOFOToolStripMenuItem.Click += new System.EventHandler(this.SortByAscendingFlowOwnerToolStripMenuItem_Click);
            // 
            // byAmountToolStripMenuItem
            // 
            this.byAmountToolStripMenuItem.Name = "byAmountToolStripMenuItem";
            this.byAmountToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.byAmountToolStripMenuItem.Text = "By amount";
            this.byAmountToolStripMenuItem.Click += new System.EventHandler(this.ByAmountToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowFilterToolStripMenuItem,
            this.roadFilterToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // flowFilterToolStripMenuItem
            // 
            this.flowFilterToolStripMenuItem.Name = "flowFilterToolStripMenuItem";
            this.flowFilterToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.flowFilterToolStripMenuItem.Text = "Flow";
            this.flowFilterToolStripMenuItem.Click += new System.EventHandler(this.FlowFilterToolStripMenuItem_Click);
            // 
            // roadFilterToolStripMenuItem
            // 
            this.roadFilterToolStripMenuItem.Name = "roadFilterToolStripMenuItem";
            this.roadFilterToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.roadFilterToolStripMenuItem.Text = "Road";
            this.roadFilterToolStripMenuItem.Click += new System.EventHandler(this.RoadFilterToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(3, 74);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightPink;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(939, 394);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RegistrationDate";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Location";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Owner";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Flow";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "MaintenanceTime";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Road";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.toolStrip, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(945, 471);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripButton,
            this.AddToolStripButton,
            this.DeleteToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(945, 71);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditToolStripButton.Image = global::BusStations.Properties.Resources.icons8_edit_64;
            this.EditToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.EditToolStripButton.Text = "Edit file";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolStripButton.Image = global::BusStations.Properties.Resources.icons8_add_64;
            this.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.AddToolStripButton.Text = "Add to file";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = global::BusStations.Properties.Resources.icons8_cancel_64;
            this.DeleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.DeleteToolStripButton.Text = "Delete element";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // BusStationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(945, 499);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "BusStationsForm";
            this.Text = "Bus Stations";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byAlphabeticalOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SBAONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SBAOOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byAscendingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SBAOFNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SBAOFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAmountToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ToolStripMenuItem flowFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roadFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoSortingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceExistingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToExistingFileToolStripMenuItem;
    }
}

