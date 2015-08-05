namespace Bikes_Mock_Exam
{
    partial class frmBikes
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mycyclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bikesDataSet3 = new Bikes_Mock_Exam.bikesDataSet3();
            this.mycyclesTableAdapter = new Bikes_Mock_Exam.bikesDataSet3TableAdapters.mycyclesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycyclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikesDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHeader.Location = new System.Drawing.Point(138, 53);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(454, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "THRUXTON MOTORCYCLES-CURRENT STOCK";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.aLLToolStripButton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(107, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "All For Sale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.all_For_Sale1ToolStripButton_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(193, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = ">=500cc  ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this._500grToolStripButton_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(279, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "<= 500cc";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.___500ToolStripButton_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(365, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sold";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.soldToolStripButton_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(661, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(575, 388);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button8.Location = new System.Drawing.Point(21, 460);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Move First";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button9.Location = new System.Drawing.Point(107, 460);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Previous";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button10.Location = new System.Drawing.Point(193, 460);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Next";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button11.Location = new System.Drawing.Point(279, 460);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "Move Last";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button12.Location = new System.Drawing.Point(661, 460);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "Exit";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.dateSoldDataGridViewTextBoxColumn,
            this.soldDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mycyclesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 257);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // engineSizeDataGridViewTextBoxColumn
            // 
            this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "Engine_Size";
            this.engineSizeDataGridViewTextBoxColumn.HeaderText = "Engine_Size";
            this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // dateSoldDataGridViewTextBoxColumn
            // 
            this.dateSoldDataGridViewTextBoxColumn.DataPropertyName = "Date_Sold";
            this.dateSoldDataGridViewTextBoxColumn.HeaderText = "Date_Sold";
            this.dateSoldDataGridViewTextBoxColumn.Name = "dateSoldDataGridViewTextBoxColumn";
            // 
            // soldDataGridViewTextBoxColumn
            // 
            this.soldDataGridViewTextBoxColumn.DataPropertyName = "Sold";
            this.soldDataGridViewTextBoxColumn.HeaderText = "Sold";
            this.soldDataGridViewTextBoxColumn.Name = "soldDataGridViewTextBoxColumn";
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            // 
            // mycyclesBindingSource
            // 
            this.mycyclesBindingSource.DataMember = "mycycles";
            this.mycyclesBindingSource.DataSource = this.bikesDataSet3;
            // 
            // bikesDataSet3
            // 
            this.bikesDataSet3.DataSetName = "bikesDataSet3";
            this.bikesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mycyclesTableAdapter
            // 
            this.mycyclesTableAdapter.ClearBeforeFill = true;
            // 
            // frmBikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmBikes";
            this.Text = "Thruxton";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycyclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikesDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bikesDataSet3 bikesDataSet3;
        private System.Windows.Forms.BindingSource mycyclesBindingSource;
        private bikesDataSet3TableAdapters.mycyclesTableAdapter mycyclesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
    }
}

