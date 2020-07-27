namespace HookBong.UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label processListLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.processList = new System.Windows.Forms.ListBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.analysisGrid = new System.Windows.Forms.DataGridView();
            this.VirtualAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatchedData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentProcessLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.maintabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hookedDisass = new System.Windows.Forms.TextBox();
            this.origBytes = new System.Windows.Forms.TextBox();
            this.hookedBytes = new System.Windows.Forms.TextBox();
            this.origDisass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.analyzelabel = new System.Windows.Forms.Label();
            processListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.analysisGrid)).BeginInit();
            this.maintabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processListLabel
            // 
            processListLabel.AutoSize = true;
            processListLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            processListLabel.Location = new System.Drawing.Point(53, 8);
            processListLabel.Name = "processListLabel";
            processListLabel.Size = new System.Drawing.Size(122, 26);
            processListLabel.TabIndex = 1;
            processListLabel.Text = "Process List";
            // 
            // processList
            // 
            this.processList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processList.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processList.FormattingEnabled = true;
            this.processList.HorizontalScrollbar = true;
            this.processList.ItemHeight = 20;
            this.processList.Location = new System.Drawing.Point(13, 70);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(218, 424);
            this.processList.TabIndex = 0;
            this.processList.SelectedIndexChanged += new System.EventHandler(this.processList_SelectedIndexChanged);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.analyzeButton.Enabled = false;
            this.analyzeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeButton.Location = new System.Drawing.Point(13, 501);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(219, 51);
            this.analyzeButton.TabIndex = 2;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // analysisGrid
            // 
            this.analysisGrid.AllowUserToAddRows = false;
            this.analysisGrid.AllowUserToDeleteRows = false;
            this.analysisGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analysisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analysisGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VirtualAddress,
            this.ModuleName,
            this.HookType,
            this.OriginalData,
            this.PatchedData,
            this.AdditionalInfo});
            this.analysisGrid.Location = new System.Drawing.Point(0, 0);
            this.analysisGrid.Name = "analysisGrid";
            this.analysisGrid.ReadOnly = true;
            this.analysisGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.analysisGrid.Size = new System.Drawing.Size(813, 550);
            this.analysisGrid.TabIndex = 3;
            this.analysisGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.analysisGrid_CellContentDoubleClick);
            // 
            // VirtualAddress
            // 
            this.VirtualAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualAddress.DefaultCellStyle = dataGridViewCellStyle7;
            this.VirtualAddress.HeaderText = "Virtual Address";
            this.VirtualAddress.Name = "VirtualAddress";
            this.VirtualAddress.ReadOnly = true;
            this.VirtualAddress.Width = 102;
            // 
            // ModuleName
            // 
            this.ModuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleName.DefaultCellStyle = dataGridViewCellStyle8;
            this.ModuleName.HeaderText = "Module Name";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.ReadOnly = true;
            this.ModuleName.Width = 98;
            // 
            // HookType
            // 
            this.HookType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HookType.DefaultCellStyle = dataGridViewCellStyle9;
            this.HookType.HeaderText = "HookType";
            this.HookType.Name = "HookType";
            this.HookType.ReadOnly = true;
            this.HookType.Width = 82;
            // 
            // OriginalData
            // 
            this.OriginalData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalData.DefaultCellStyle = dataGridViewCellStyle10;
            this.OriginalData.HeaderText = "Original Data";
            this.OriginalData.Name = "OriginalData";
            this.OriginalData.ReadOnly = true;
            // 
            // PatchedData
            // 
            this.PatchedData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchedData.DefaultCellStyle = dataGridViewCellStyle11;
            this.PatchedData.HeaderText = "Patched Data";
            this.PatchedData.Name = "PatchedData";
            this.PatchedData.ReadOnly = true;
            // 
            // AdditionalInfo
            // 
            this.AdditionalInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalInfo.DefaultCellStyle = dataGridViewCellStyle12;
            this.AdditionalInfo.HeaderText = "Additional Information";
            this.AdditionalInfo.Name = "AdditionalInfo";
            this.AdditionalInfo.ReadOnly = true;
            // 
            // currentProcessLabel
            // 
            this.currentProcessLabel.AutoSize = true;
            this.currentProcessLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProcessLabel.Location = new System.Drawing.Point(237, 12);
            this.currentProcessLabel.Name = "currentProcessLabel";
            this.currentProcessLabel.Size = new System.Drawing.Size(192, 22);
            this.currentProcessLabel.TabIndex = 4;
            this.currentProcessLabel.Text = "Current Process: None";
            this.currentProcessLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(12, 558);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(219, 51);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBox.Location = new System.Drawing.Point(13, 44);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(218, 20);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.TextChanged += new System.EventHandler(this.Searchbox_textChanged);
            // 
            // maintabcontrol
            // 
            this.maintabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintabcontrol.Controls.Add(this.tabPage1);
            this.maintabcontrol.Controls.Add(this.tabPage2);
            this.maintabcontrol.Location = new System.Drawing.Point(237, 37);
            this.maintabcontrol.Multiline = true;
            this.maintabcontrol.Name = "maintabcontrol";
            this.maintabcontrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maintabcontrol.SelectedIndex = 0;
            this.maintabcontrol.Size = new System.Drawing.Size(821, 576);
            this.maintabcontrol.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.analysisGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ƒ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "¿";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.hookedDisass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.origBytes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hookedBytes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.origDisass, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // hookedDisass
            // 
            this.hookedDisass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hookedDisass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hookedDisass.Location = new System.Drawing.Point(407, 276);
            this.hookedDisass.Margin = new System.Windows.Forms.Padding(1);
            this.hookedDisass.Multiline = true;
            this.hookedDisass.Name = "hookedDisass";
            this.hookedDisass.ReadOnly = true;
            this.hookedDisass.Size = new System.Drawing.Size(405, 273);
            this.hookedDisass.TabIndex = 3;
            // 
            // origBytes
            // 
            this.origBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.origBytes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.origBytes.Location = new System.Drawing.Point(1, 1);
            this.origBytes.Margin = new System.Windows.Forms.Padding(1);
            this.origBytes.Multiline = true;
            this.origBytes.Name = "origBytes";
            this.origBytes.ReadOnly = true;
            this.origBytes.Size = new System.Drawing.Size(404, 273);
            this.origBytes.TabIndex = 0;
            // 
            // hookedBytes
            // 
            this.hookedBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hookedBytes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hookedBytes.Location = new System.Drawing.Point(407, 1);
            this.hookedBytes.Margin = new System.Windows.Forms.Padding(1);
            this.hookedBytes.Multiline = true;
            this.hookedBytes.Name = "hookedBytes";
            this.hookedBytes.ReadOnly = true;
            this.hookedBytes.Size = new System.Drawing.Size(405, 273);
            this.hookedBytes.TabIndex = 1;
            // 
            // origDisass
            // 
            this.origDisass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.origDisass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.origDisass.Location = new System.Drawing.Point(1, 276);
            this.origDisass.Margin = new System.Windows.Forms.Padding(1);
            this.origDisass.Multiline = true;
            this.origDisass.Name = "origDisass";
            this.origDisass.ReadOnly = true;
            this.origDisass.Size = new System.Drawing.Size(404, 273);
            this.origDisass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter";
            // 
            // backbutton
            // 
            this.backbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backbutton.Enabled = false;
            this.backbutton.Location = new System.Drawing.Point(1002, 13);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(52, 23);
            this.backbutton.TabIndex = 0;
            this.backbutton.Text = "←";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // analyzelabel
            // 
            this.analyzelabel.AutoSize = true;
            this.analyzelabel.Location = new System.Drawing.Point(605, 28);
            this.analyzelabel.Name = "analyzelabel";
            this.analyzelabel.Size = new System.Drawing.Size(140, 13);
            this.analyzelabel.TabIndex = 9;
            this.analyzelabel.Text = "double click to inspect hook";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 617);
            this.Controls.Add(this.analyzelabel);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentProcessLabel);
            this.Controls.Add(this.maintabcontrol);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(processListLabel);
            this.Controls.Add(this.processList);
            this.Name = "MainWindow";
            this.Text = "HookBong";
            ((System.ComponentModel.ISupportInitialize)(this.analysisGrid)).EndInit();
            this.maintabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox processList;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.DataGridView analysisGrid;
        private System.Windows.Forms.Label currentProcessLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn VirtualAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatchedData;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalInfo;
        private System.Windows.Forms.TabControl maintabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox origBytes;
        private System.Windows.Forms.TextBox hookedDisass;
        private System.Windows.Forms.TextBox origDisass;
        private System.Windows.Forms.TextBox hookedBytes;
        private System.Windows.Forms.Label analyzelabel;
    }
}