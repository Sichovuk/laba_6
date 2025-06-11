namespace laba_5
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowWithForeach = new System.Windows.Forms.ToolStripButton();
            this.gvPhones = new System.Windows.Forms.DataGridView();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasAIDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasTypeCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindSrcPhones = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.tsSeparator1,
            this.btnDel,
            this.btnClear,
            this.tsSeparator2,
            this.btnExit,
            this.btnSaveAsText,
            this.btnSaveAsBinary,
            this.btnOpenFromText,
            this.btnOpenFromBinary,
            this.toolStripSeparator1,
            this.btnShowWithForeach});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1204, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 32);
            this.btnAdd.Text = "Додати запис про телефон";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 32);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(40, 32);
            this.btnDel.Text = "Видалити запис";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 32);
            this.btnClear.Text = "Очистити дані";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 32);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsText.Image")));
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(40, 32);
            this.btnSaveAsText.Text = "Зберегти у текстовому форматі";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsBinary.Image")));
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(40, 32);
            this.btnSaveAsBinary.Text = "Зберегти у бінарному форматі";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromText.Image")));
            this.btnOpenFromText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(40, 32);
            this.btnOpenFromText.Text = "Читання тектового формату";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromBinary.Image")));
            this.btnOpenFromBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(40, 32);
            this.btnOpenFromBinary.Text = "Читання бінарного формату";
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnShowWithForeach
            // 
            this.btnShowWithForeach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowWithForeach.Image = ((System.Drawing.Image)(resources.GetObject("btnShowWithForeach.Image")));
            this.btnShowWithForeach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowWithForeach.Name = "btnShowWithForeach";
            this.btnShowWithForeach.Size = new System.Drawing.Size(40, 32);
            this.btnShowWithForeach.Text = "Перегляд з foreach";
            this.btnShowWithForeach.Click += new System.EventHandler(this.btnShowWithForeach_Click);
            // 
            // gvPhones
            // 
            this.gvPhones.AllowUserToAddRows = false;
            this.gvPhones.AllowUserToDeleteRows = false;
            this.gvPhones.AutoGenerateColumns = false;
            this.gvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.diagonalDataGridViewTextBoxColumn,
            this.coresDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.simQuantityDataGridViewTextBoxColumn,
            this.hasAIDataGridViewCheckBoxColumn,
            this.hasTypeCDataGridViewCheckBoxColumn});
            this.gvPhones.DataSource = this.bindSrcPhones;
            this.gvPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPhones.Location = new System.Drawing.Point(0, 38);
            this.gvPhones.Name = "gvPhones";
            this.gvPhones.ReadOnly = true;
            this.gvPhones.RowHeadersWidth = 72;
            this.gvPhones.RowTemplate.Height = 31;
            this.gvPhones.Size = new System.Drawing.Size(1204, 1090);
            this.gvPhones.TabIndex = 1;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 175;
            // 
            // diagonalDataGridViewTextBoxColumn
            // 
            this.diagonalDataGridViewTextBoxColumn.DataPropertyName = "Diagonal";
            this.diagonalDataGridViewTextBoxColumn.HeaderText = "Diagonal";
            this.diagonalDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.diagonalDataGridViewTextBoxColumn.Name = "diagonalDataGridViewTextBoxColumn";
            this.diagonalDataGridViewTextBoxColumn.ReadOnly = true;
            this.diagonalDataGridViewTextBoxColumn.Width = 175;
            // 
            // coresDataGridViewTextBoxColumn
            // 
            this.coresDataGridViewTextBoxColumn.DataPropertyName = "Cores";
            this.coresDataGridViewTextBoxColumn.HeaderText = "Cores";
            this.coresDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.coresDataGridViewTextBoxColumn.Name = "coresDataGridViewTextBoxColumn";
            this.coresDataGridViewTextBoxColumn.ReadOnly = true;
            this.coresDataGridViewTextBoxColumn.Width = 175;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Width = 175;
            // 
            // simQuantityDataGridViewTextBoxColumn
            // 
            this.simQuantityDataGridViewTextBoxColumn.DataPropertyName = "SimQuantity";
            this.simQuantityDataGridViewTextBoxColumn.HeaderText = "SimQuantity";
            this.simQuantityDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.simQuantityDataGridViewTextBoxColumn.Name = "simQuantityDataGridViewTextBoxColumn";
            this.simQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.simQuantityDataGridViewTextBoxColumn.Width = 175;
            // 
            // hasAIDataGridViewCheckBoxColumn
            // 
            this.hasAIDataGridViewCheckBoxColumn.DataPropertyName = "HasAI";
            this.hasAIDataGridViewCheckBoxColumn.HeaderText = "HasAI";
            this.hasAIDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.hasAIDataGridViewCheckBoxColumn.Name = "hasAIDataGridViewCheckBoxColumn";
            this.hasAIDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hasAIDataGridViewCheckBoxColumn.Width = 175;
            // 
            // hasTypeCDataGridViewCheckBoxColumn
            // 
            this.hasTypeCDataGridViewCheckBoxColumn.DataPropertyName = "HasTypeC";
            this.hasTypeCDataGridViewCheckBoxColumn.HeaderText = "HasTypeC";
            this.hasTypeCDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.hasTypeCDataGridViewCheckBoxColumn.Name = "hasTypeCDataGridViewCheckBoxColumn";
            this.hasTypeCDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hasTypeCDataGridViewCheckBoxColumn.Width = 175;
            // 
            // bindSrcPhones
            // 
            this.bindSrcPhones.DataSource = typeof(laba_5.IPhone);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 1128);
            this.Controls.Add(this.gvPhones);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №5";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcPhones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource bindSrcPhones;
        private System.Windows.Forms.DataGridView gvPhones;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnSaveAsText;
        private System.Windows.Forms.ToolStripButton btnSaveAsBinary;
        private System.Windows.Forms.ToolStripButton btnOpenFromText;
        private System.Windows.Forms.ToolStripButton btnOpenFromBinary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasAIDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasTypeCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripButton btnShowWithForeach;
    }
}

