using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotarCurro
{
    public partial class Form1 : Form
    {
        string directory = Environment.GetEnvironmentVariable("homedrive") + "\\" + Environment.GetEnvironmentVariable("homepath") + "\\configCurro.txt";
        string dni;
        string IP_SERVER;
        int port;
        IPEndPoint ie;
        Socket server;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        bool valido = true;
        bool datos = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarConexion()
        {
            try
            {
                sr.Close();
                sw.Close();
                ns.Close();
                server.Close();
            }
            catch { }
        }

        private void conectar()
        {
            try
            {
                txtInfo.Clear();
                ie = new IPEndPoint(IPAddress.Parse(IP_SERVER), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ie);
                    ns = new NetworkStream(server);
                    sr = new StreamReader(ns);
                    sw = new StreamWriter(ns);
                    try
                    {
                        sw.WriteLine("user " + dni);
                        sw.Flush();
                        sr.ReadLine();
                    }
                    catch (IOException)
                    {
                        txtInfo.AppendText("Sin conexion con el servidor");
                    }
                }
                catch (SocketException ee)
                {
                    txtInfo.AppendText(String.Format("Error connection: {0}\nError code: {1}({2})", ee.Message, (SocketError)ee.ErrorCode, ee.ErrorCode));
                }
            }
            catch (ArgumentNullException)
            {
                txtInfo.AppendText("Introduce los datos primero");
            }
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            bool acabado = false;
            conectar();
            if (datos)
            {
                try
                {
                    sw.WriteLine("add");
                    sw.Flush();
                    while (!acabado)
                    {
                        string cadena = sr.ReadLine();
                        if (cadena != null)
                        {
                            txtInfo.AppendText(cadena);
                            txtInfo.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            acabado = true; ;
                        }
                    }
                }
                catch (IOException)
                {
                    txtInfo.AppendText("Sin conexion con el servidor");
                }
                acabado = false;
                conectar();
                try
                {
                    sw.WriteLine("list");
                    sw.Flush();
                    while (!acabado)
                    {
                        string cadena = sr.ReadLine();
                        if (cadena != null)
                        {
                            txtInfo.AppendText(cadena);
                            txtInfo.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            acabado = true; ;
                        }
                    }
                }
                catch (IOException)
                {
                    txtInfo.AppendText("Sin conexion con el servidor");
                }
            }
        }


        private void btCambiarDni_Click(object sender, EventArgs e)
        {
            valido = false;
            txtInfo.Clear();
            try
            {
                string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
                string dniAValidar = txtDni.Text;
                if (dniAValidar.Length == 9)
                {
                    dniAValidar = dniAValidar.ToUpper();
                    int num = Convert.ToInt32(dniAValidar.Substring(0, 8));
                    int resto = num % 23;
                    if (letras[resto] == dniAValidar[8])
                    {
                        dni = dniAValidar;
                        valido = true;
                    }
                    else
                    {
                        txtInfo.AppendText("DNI Invalido");
                    }
                }
                else
                {
                    txtInfo.AppendText("DNI Invalido");
                }
            }
            catch
            {
                txtInfo.AppendText("DNI Invalido");
                txtDni.Text = dni;
            }
            try
            {
                IPAddress.Parse(txtIP.Text);
                Convert.ToInt32(txtPuerto.Text);
                IP_SERVER = txtIP.Text;
                port = Convert.ToInt32(txtPuerto.Text);
            }
            catch
            {
                valido = false;
                txtIP.Text = IP_SERVER;
                txtPuerto.Text = port + "";
                txtInfo.AppendText(Environment.NewLine);
                txtInfo.AppendText("Error en IP o Puerto");
            }
            if (valido)
            {
                txtInfo.AppendText("Datos modificados");
                datos = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(directory))
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(directory, FileMode.Open)))
                {
                    try
                    {
                        dni = reader.ReadString();
                        IP_SERVER = reader.ReadString();
                        port = reader.ReadInt32();
                        txtDni.Text = dni;
                        txtIP.Text = IP_SERVER;
                        txtPuerto.Text = port + "";
                        datos = true;
                    }
                    catch { }
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            btCambiarDni.PerformClick();
            txtInfo.Clear();
            if (valido)
            {
                using (BinaryWriter writer = new BinaryWriter(new FileStream(directory, FileMode.Create)))
                {
                    try
                    {
                        writer.Write(dni);
                        writer.Write(IP_SERVER);
                        writer.Write(port);
                        txtInfo.AppendText("Datos Guardados");
                    }
                    catch { }
                }
            }
            else
            {
                txtInfo.AppendText("Datos Invalidos");
            }
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            bool acabado = false;
            conectar();
            if (datos)
            {
                conectar();
                try
                {
                    sw.WriteLine("list");
                    sw.Flush();
                    while (!acabado)
                    {
                        string cadena = sr.ReadLine();
                        if (cadena != null)
                        {
                            txtInfo.AppendText(cadena);
                            txtInfo.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            acabado = true; ;
                        }
                    }
                }
                catch (IOException)
                {
                    txtInfo.AppendText("Sin conexion con el servidor");
                }
            }
        }
    }
}
