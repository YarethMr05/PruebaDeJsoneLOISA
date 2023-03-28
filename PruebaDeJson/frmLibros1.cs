using System.Text.Json;

namespace PruebaDeJson
{
    public partial class frmLibros1 : Form
    {
        List<Registro> datos = new List<Registro>();
        public frmLibros1()
        {
            InitializeComponent();
        }
        string ISBN = "";
        string Titulo = "";
        string Autor = "";
        string Editorial = "";
        int Paginas = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Da valores de los texbox a las variables
            ISBN = txtISBN.Text;
            Titulo = txtTitulo.Text;
            Autor = txtAutor.Text;
            Editorial = txtEditorial.Text;
            Paginas = int.Parse(txtPagina.Text);

            // guarda los valores en las variables de la clase registro
            datos.Add(new Registro { ISBN1 = ISBN, Titulo1 = Titulo, Autor1 = Autor, Editorial1 = Editorial, Pagina1 = Paginas });

            txtAutor.Clear();
            txtEditorial.Clear();
            txtISBN.Clear();
            txtPagina.Clear();
            txtTitulo.Clear();
            txtISBN.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText("RegistroDeLIbros.json", json);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}