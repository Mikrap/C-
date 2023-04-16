namespace project_statistics
{
    partial class Form7
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
            this.button1 = new System.Windows.Forms.Button();
            this.отчетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datebaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datebaseDataSet = new project_statistics.datebaseDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчетыTableAdapter = new project_statistics.datebaseDataSetTableAdapters.ОтчетыTableAdapter();
            this.сотрудникиTableAdapter = new project_statistics.datebaseDataSetTableAdapters.сотрудникиTableAdapter();
            this.datebaseDataSet1 = new project_statistics.datebaseDataSet1();
            this.отчетыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.отчетыTableAdapter1 = new project_statistics.datebaseDataSet1TableAdapters.ОтчетыTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерОтчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.отчетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // отчетыBindingSource
            // 
            this.отчетыBindingSource.DataMember = "Отчеты";
            this.отчетыBindingSource.DataSource = this.datebaseDataSetBindingSource;
            // 
            // datebaseDataSetBindingSource
            // 
            this.datebaseDataSetBindingSource.DataSource = this.datebaseDataSet;
            this.datebaseDataSetBindingSource.Position = 0;
            // 
            // datebaseDataSet
            // 
            this.datebaseDataSet.DataSetName = "datebaseDataSet";
            this.datebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "сотрудники";
            this.сотрудникиBindingSource.DataSource = this.datebaseDataSetBindingSource;
            // 
            // отчетыTableAdapter
            // 
            this.отчетыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // datebaseDataSet1
            // 
            this.datebaseDataSet1.DataSetName = "datebaseDataSet1";
            this.datebaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отчетыBindingSource1
            // 
            this.отчетыBindingSource1.DataMember = "Отчеты";
            this.отчетыBindingSource1.DataSource = this.datebaseDataSet1;
            // 
            // отчетыTableAdapter1
            // 
            this.отчетыTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.номерОтчетаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.отчетыBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(301, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // номерОтчетаDataGridViewTextBoxColumn
            // 
            this.номерОтчетаDataGridViewTextBoxColumn.DataPropertyName = "Номер Отчета";
            this.номерОтчетаDataGridViewTextBoxColumn.HeaderText = "Номер Отчета";
            this.номерОтчетаDataGridViewTextBoxColumn.Name = "номерОтчетаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.отчетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource datebaseDataSetBindingSource;
        private datebaseDataSet datebaseDataSet;
        private System.Windows.Forms.BindingSource отчетыBindingSource;
        private datebaseDataSetTableAdapters.ОтчетыTableAdapter отчетыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private datebaseDataSetTableAdapters.сотрудникиTableAdapter сотрудникиTableAdapter;
        private datebaseDataSet1 datebaseDataSet1;
        private System.Windows.Forms.BindingSource отчетыBindingSource1;
        private datebaseDataSet1TableAdapters.ОтчетыTableAdapter отчетыTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОтчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
    }
}