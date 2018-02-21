using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Archivos_de_texto_y_archivos_binarios
{
    public partial class Form1 : Form
    {
        List<Contacto> contactos = new List<Contacto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos BMP|*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
                validarBMP(abrir.FileName);
        }

        private void validarBMP(string fileName)
        {
            FileStream archivo = new FileStream(fileName, FileMode.Open);
            BinaryReader lector = new BinaryReader(archivo);

            char B = lector.ReadChar();
            char M = lector.ReadChar();

            if( B != 'B' || M != 'M' )
            {
                MessageBox.Show("El archivo seleccionado no es BMP, intenta con otro");
                return;
            }

            //Tamanio en KB
            int tamanio = lector.ReadInt32();

            archivo.Seek((long)18, SeekOrigin.Begin);
            int ancho = lector.ReadInt32();
            int altura = lector.ReadInt32();

            //Tamaño de cada punto o bits por pixel
            archivo.Seek((long)28, SeekOrigin.Begin);
            int bitsPorPixel = lector.ReadInt16();

            txtInfoBMP.Text = "Tamño del archivo: " + tamanio + " KB" + System.Environment.NewLine +
                "Alto: " + altura + " px" + System.Environment.NewLine +
                "Ancho: " + ancho + " px" + System.Environment.NewLine +
                "Bits por pixel: " + bitsPorPixel + " bits " + System.Environment.NewLine;

            lector.Close();
            archivo.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int numeroCuenta = Convert.ToInt32(txtNumCuenta.Text);
            char genero = rbtMasculino.Checked ? 'M' : 'F';

            Contacto contacto = new Contacto(numeroCuenta, txtNombre.Text, txtPaterno.Text, txtTelefono.Text, genero);

            contactos.Add(contacto);
            lstTodos.Items.Add(contacto);
            txtTelefono.Text = "";
            txtPaterno.Text = "";
            txtNombre.Text = "";
            txtNumCuenta.Text = "";
            txtNumCuenta.Focus();
        }

        private void btnGenerarXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            if(guardar.ShowDialog() == DialogResult.OK )
            {
                builtXML(guardar.FileName + ".xml");
                //Abrir el archivo XML generado
                System.Diagnostics.Process.Start(guardar.FileName + ".xml");
            }
        }

        private void builtXML(string fileName)
        {
            FileStream archivo = new FileStream(fileName, FileMode.Create);
            StreamWriter escritor = new StreamWriter(archivo);

            escritor.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");

            escritor.WriteLine("<todos>");

            foreach (Contacto contacto in contactos)
            {
                escritor.WriteLine("<contacto>");
                    escritor.WriteLine("    <numeroCuenta>" +contacto.numeroCuenta + "</numeroCuenta>");
                    escritor.WriteLine("    <nombre>" +contacto.nombre + "</nombre>");
                    escritor.WriteLine("    <paterno>" +contacto.apellidoPaterno + "</paterno>");
                    escritor.WriteLine("    <telefono>" +contacto.telefono+ "</telefono>");
                    escritor.WriteLine("    <genero>" +contacto.genero + "</genero>");
                escritor.WriteLine("</contacto>");
            }
            escritor.WriteLine("</todos>");

            escritor.Close();
            archivo.Close();
        }
    }
}
