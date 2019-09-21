using Reserva_de_Vuelos.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_de_Vuelos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        public void CDatos(BusquedaVueloBL busquedaVueloBL, CategoriaBL categoriaBL)
        {

            listaVueloBindingSource.DataSource = busquedaVueloBL.ListaVuelo;

            
            listaCategoriaBindingSource.DataSource = categoriaBL.ListaCategoria;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void listaVueloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            var archivo = openFileDialog1.FileName;

            if (archivo != "")
            {
                var fileInfo = new FileInfo(archivo);
                var fileStream = fileInfo.OpenRead();

                pictureBox1.Image = Image.FromStream(fileStream);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
