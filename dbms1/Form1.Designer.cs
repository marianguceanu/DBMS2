namespace dbms1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.classGridView = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsofexpreqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fightingGymDBDataSet = new dbms1.FightingGymDBDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fightingGymDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new dbms1.FightingGymDBDataSetTableAdapters.ClassTableAdapter();
            this.materialsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightingGymDBDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fightingGymDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // classGridView
            // 
            this.classGridView.AutoGenerateColumns = false;
            this.classGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.yearsofexpreqDataGridViewTextBoxColumn,
            this.tidDataGridViewTextBoxColumn,
            this.classnameDataGridViewTextBoxColumn});
            this.classGridView.DataSource = this.classBindingSource;
            this.classGridView.Location = new System.Drawing.Point(12, 28);
            this.classGridView.Name = "classGridView";
            this.classGridView.Size = new System.Drawing.Size(240, 150);
            this.classGridView.TabIndex = 0;
            this.classGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classGridView_CellClick);
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "cid";
            this.cidDataGridViewTextBoxColumn.HeaderText = "cid";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearsofexpreqDataGridViewTextBoxColumn
            // 
            this.yearsofexpreqDataGridViewTextBoxColumn.DataPropertyName = "years_of_exp_req";
            this.yearsofexpreqDataGridViewTextBoxColumn.HeaderText = "years_of_exp_req";
            this.yearsofexpreqDataGridViewTextBoxColumn.Name = "yearsofexpreqDataGridViewTextBoxColumn";
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "tid";
            this.tidDataGridViewTextBoxColumn.HeaderText = "tid";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "class_name";
            this.classnameDataGridViewTextBoxColumn.HeaderText = "class_name";
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.fightingGymDBDataSet;
            // 
            // fightingGymDBDataSet
            // 
            this.fightingGymDBDataSet.DataSetName = "FightingGymDBDataSet";
            this.fightingGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fightingGymDBDataSetBindingSource
            // 
            this.fightingGymDBDataSetBindingSource.DataSource = this.fightingGymDBDataSet;
            this.fightingGymDBDataSetBindingSource.Position = 0;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // materialsGrid
            // 
            this.materialsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsGrid.Location = new System.Drawing.Point(356, 27);
            this.materialsGrid.Name = "materialsGrid";
            this.materialsGrid.Size = new System.Drawing.Size(240, 150);
            this.materialsGrid.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialsGrid);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.classGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightingGymDBDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fightingGymDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView classGridView;
        private System.Windows.Forms.BindingSource fightingGymDBDataSetBindingSource;
        private FightingGymDBDataSet fightingGymDBDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private FightingGymDBDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsofexpreqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView materialsGrid;
    }
}

