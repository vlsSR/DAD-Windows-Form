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
            dataGrid.Location = new Point(138, 110);
            dataGrid.Margin = new Padding(3, 2, 3, 2);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(265, 130);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(107, 57);
            cbCategoria.Margin = new Padding(3, 2, 3, 2);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(133, 23);
            cbCategoria.TabIndex = 1;
            cbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(138, 29);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += label1_Click;
            // 
            // lblEquipos
            // 
            lblEquipos.AutoSize = true;
            lblEquipos.Location = new Point(334, 29);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(49, 15);
            lblEquipos.TabIndex = 4;
            lblEquipos.Text = "Equipos";
            lblEquipos.Click += label1_Click_1;
            // 
            // cbEquipos
            // 
            cbEquipos.FormattingEnabled = true;
            cbEquipos.Location = new Point(298, 57);
            cbEquipos.Margin = new Padding(3, 2, 3, 2);
            cbEquipos.Name = "cbEquipos";
            cbEquipos.Size = new Size(133, 23);
            cbEquipos.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(519, 172);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnAdd);
            Controls.Add(lblEquipos);
            Controls.Add(cbEquipos);
            Controls.Add(lblCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(dataGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private ComboBox cbCategoria;
        private Label lblCategoria;
        private Label lblEquipos;
        private ComboBox cbEquipos;
        private Button btnAdd;
    }
}
