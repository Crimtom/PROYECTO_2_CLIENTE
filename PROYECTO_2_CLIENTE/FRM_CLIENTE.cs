using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace PROYECTO_2_CLIENTE
{
    public partial class FRM_CLIENTE : Form
    {
        TcpClient client;
        NetworkStream stream;

        public FRM_CLIENTE()
        {
            InitializeComponent();
        }

        private void FRM_CLIENTE_Load(object sender, EventArgs e)
        {

        }

        private void BT_CONECTAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null)
                {
                    client = new TcpClient();
                    client.Connect(IPAddress.Parse("127.0.0.1"), 30000);
                    stream = client.GetStream();
                    MessageBox.Show("Conexión realizada correctamente.", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya está conectado al servidor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar realizar la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_ENVIAR_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = TXT_INFO.Text.Trim();

                using (TcpClient client = new TcpClient())
                {
                    client.Connect(IPAddress.Parse("127.0.0.1"), 30000);

                    NetworkStream stream = client.GetStream();

                    //  Envía el valor de la cédula
                    byte[] envio = Encoding.ASCII.GetBytes(cedula);
                    stream.Write(envio, 0, envio.Length);

                    //  Lee la respuesta del servidor
                    byte[] buffer = new byte[1024];
                    int leidos = stream.Read(buffer, 0, buffer.Length);

                    string respuesta = Encoding.ASCII
                        .GetString(buffer, 0, leidos)
                        .Replace("\0", "")
                        .Trim();

                    // Presenta la respuesta en un MessageBox y en el TextBox
                    MessageBox.Show(InterpretarRespuesta(respuesta), "Respuesta del Servidor");
                    TXT_INFO.Text = respuesta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar realizar comunicación con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_DESCONECTAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    client.Close();
                    stream = null;
                    MessageBox.Show("Se ha realizado la desconexión correctamente.", "Desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar desconectarse del servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Función para interpretar la respuesta del servidor
        private string InterpretarRespuesta(string r)
        {
            r = r.Trim();

            if (r.StartsWith("1"))
            {
                string nombre = r.Substring(1, 30).Trim();
                string mesa = r.Substring(31, 6).Trim();
                string centro = r.Substring(37).Trim();

                return $"NOMBRE: {nombre}\r\nMESA: {mesa}\r\nCENTRO: {centro}";
            }
            if (r.StartsWith("2"))
                return "Persona fallecida";
            if (r.StartsWith("3"))
                return "Cédula no existe";
            if (r.StartsWith("4"))
                return "Formato inválido";

            return "Respuesta desconocida";
        }

        private void TXT_CLIENTE_TextChanged(object sender, EventArgs e)
        {
            string chars_permitidos = "0123456789.";
            if (client == null && stream == null)
            {
                //  Recorre cada caracter para verificar que sea una dirección válida
                foreach (char c in TXT_CLIENTE.Text)
                {
                    if (!chars_permitidos.Contains(c.ToString()))
                    {
                        MessageBox.Show("Solo se permiten números y puntos (.) en la dirección IP.", " inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_CLIENTE.Text = "";
                        break;
                    }
                }
            }
        }
    }
}
