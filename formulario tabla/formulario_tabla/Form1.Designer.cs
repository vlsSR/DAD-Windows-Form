namespace formulario_tabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGrid = new DataGridView();
            Categoria = new DataGridViewTextBoxColumn();
            Equipos = new DataGridViewTextBoxColumn();
            cbCategoria = new ComboBox();
            lblCategoria = new Label();
            lblEquipos = new Label();
            cbEquipos = new ComboBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Categoria, Equipos });
            dataGrid.Location = new Point(158, 147);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(303, 174);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 125;
            // 
            // Equipos
            // 
            Equipos.HeaderText = "Equipos";
            Equipos.MinimumWidth = 6;
            Equipos.Name = "Equipos";
            Equipos.Width = 125;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(122, 76);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(151, 28);
            cbCategoria.TabIndex = 1;
            cbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(158, 39);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += label1_Click;
            // 
            // lblEquipos
            // 
            lblEquipos.AutoSize = true;
            lblEquipos.Location = new Point(382, 39);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(62, 20);
            lblEquipos.TabIndex = 4;
            lblEquipos.Text = "Equipos";
            lblEquipos.Click += label1_Click_1;
            // 
            // cbEquipos
            // 
            cbEquipos.FormattingEnabled = true;
            cbEquipos.Location = new Point(340, 76);
            cbEquipos.Name = "cbEquipos";
            cbEquipos.Size = new Size(151, 28);
            cbEquipos.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(593, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(lblEquipos);
            Controls.Add(cbEquipos);
            Controls.Add(lblCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(dataGrid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Equipos;
        private ComboBox cbCategoria;
        private Label lblCategoria;
        private Label lblEquipos;
        private ComboBox cbEquipos;
        private Button btnAdd;
    }
}
