namespace Automated_help_system_for_a_computer_game_store
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастноеОграничениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годИзданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.издательствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Automated_help_system_for_a_computer_game_store.DatabaseDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.productsTableAdapter = new Automated_help_system_for_a_computer_game_store.DatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.publisherTableAdapter = new Automated_help_system_for_a_computer_game_store.DatabaseDataSetTableAdapters.PublisherTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.жанрыDataGridViewTextBoxColumn,
            this.возрастноеОграничениеDataGridViewTextBoxColumn,
            this.годИзданияDataGridViewTextBoxColumn,
            this.издательствоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(215, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 426);
            this.dataGridView1.TabIndex = 29;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // жанрыDataGridViewTextBoxColumn
            // 
            this.жанрыDataGridViewTextBoxColumn.DataPropertyName = "Жанры";
            this.жанрыDataGridViewTextBoxColumn.HeaderText = "Жанры";
            this.жанрыDataGridViewTextBoxColumn.Name = "жанрыDataGridViewTextBoxColumn";
            this.жанрыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // возрастноеОграничениеDataGridViewTextBoxColumn
            // 
            this.возрастноеОграничениеDataGridViewTextBoxColumn.DataPropertyName = "Возрастное ограничение";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.HeaderText = "Возрастное ограничение";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.Name = "возрастноеОграничениеDataGridViewTextBoxColumn";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годИзданияDataGridViewTextBoxColumn
            // 
            this.годИзданияDataGridViewTextBoxColumn.DataPropertyName = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.HeaderText = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.Name = "годИзданияDataGridViewTextBoxColumn";
            this.годИзданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // издательствоDataGridViewTextBoxColumn
            // 
            this.издательствоDataGridViewTextBoxColumn.DataPropertyName = "Издательство";
            this.издательствоDataGridViewTextBoxColumn.HeaderText = "Издательство";
            this.издательствоDataGridViewTextBoxColumn.Name = "издательствоDataGridViewTextBoxColumn";
            this.издательствоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Год издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Возрастное ограничение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Жанры";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.publisherBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Название";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.databaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 30;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 328);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 20);
            this.textBox4.TabIndex = 31;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Цена";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 79);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(158, 79);
            this.checkedListBox1.TabIndex = 34;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Товар";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Products_FormClosing);
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастноеОграничениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годИзданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn издательствоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private DatabaseDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
    }
}