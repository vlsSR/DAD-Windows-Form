using System.Data;

namespace formulario_tabla
{
    public partial class Form1 : Form
    {
        private DataTable datos;
        private string[] categorias = { "Futbol", "Baloncesto", "Tenis" };
        private string[] equipos = { "Madrid", "Albacete", "Las Palmas" };
        public Form1()
        {
            InitializeComponent();
            cargarCategorias();
            
            datos = new DataTable();
            datos.Columns.Add("Categoria", typeof(string));
            datos.Columns.Add("Equipo", typeof(string));

            dataGrid.DataSource = datos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEquipos();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void cargarCategorias()
        {
            cbCategoria.Items.Clear();
            cbCategoria.Items.AddRange(categorias);
        }

        private void cargarEquipos()
        {
            cbEquipos.Items.Clear();
            cbEquipos.Items.AddRange(equipos);
        }

        private void cargarTabla()
        {
            string equipo = cbEquipos.Text;
            string categoria = cbCategoria.Text;

            if (!string.IsNullOrEmpty(equipo) && !string.IsNullOrEmpty(categoria))
            {
                datos.Rows.Add(categoria, equipo);
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }
    }
}
