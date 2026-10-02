using System.Data;

namespace formulario_tabla
{
    public partial class Form1 : Form
    {
        public DataTable datos = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cargarCategorias()
        {
            datos.Columns.Add("Categoria", typeof(string));
            datos.Columns.Add("Equipos", typeof(List<string>));

            datos.Rows.Add("Categoria 1", new List<string> { });
        }

        private void cargarEquipos()
        {
            datos
        }

        private void cargarTabla()
        {

        }
    }
}
