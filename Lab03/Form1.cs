namespace Lab03
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class Form1 : Form
    {
        //SQLConnection nos permite manejar el acceso al servidor
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Declaramos variables para almacenar los valores de los TextBox
            //y definimos una cadena de conexión
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";Database=" + bd + ";";

            //La cadena de conexión cambia en función del estado del CheckBox
            if (chkAutenticacion.Checked)
            {
                str += "Integrated Security=true";
            }
            else
                str += "User Id" + user + ";Password" + pwd + ";";

            //Abrir una conexión con el servidor, usando la cadena de conexión
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }
        }
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Para cerrar la conexión verificamos que no este cerrada
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexión cerrada satisfactoriamente");
                }
                else
                    MessageBox.Show("La conexión ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar la conexión: \n" +
                    ex.ToString());
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            //Intentamos obtener el estado de la conexión, y en caso éste abierta,
            //recuperamos información de la misma
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State +
                        "\bVersión del servidor: " + conn.ServerVersion +
                        "\nBase de datos: " + conn.Database);
                else
                    MessageBox.Show("Estado del servidor: " + conn.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" +
                    ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAutenticacion.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();
        }
    }
}