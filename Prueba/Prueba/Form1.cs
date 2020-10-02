using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
          //navegador1.DatosActualizar = dataGridView1;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>(); 
            navegador1.cmp = "codigo_empleado";
            navegador1.txt = textBox1;
            navegador1.tbl = "empleados";
            navegador1.campoEstado = "estado";
            lista.Add(textBox1);
            lista.Add(textBox2);
            lista.Add(comboBox1);
            lista.Add(comboBox2);
            lista.Add(textBox3);
            navegador1.control = lista;
           // navegador1.OpGuardar = 0;
            //elemento de la tabla a modificar
            CamposTabla.Add("codigo_empleado");
            CamposTabla.Add("nombre_completo");
            CamposTabla.Add("puesto");
            CamposTabla.Add("departamento");
            CamposTabla.Add("estado");
            navegador1.Modificar = CamposTabla;
            //hasta aqui lo que se necesita para modificar
            navegador1.DatosActualizar = dataGridView1;
            navegador1.actualizarData();

        //navegador1.DatosActualizar = dataGridView1;
          /*  List<Control> hola = new List<Control>();
            hola.Add(textBox1);
            hola.Add(textBox2);
            hola.Add(textBox3);
            hola.Add(dateTimePicker1);
            navegador1.control = hola;*/

        }

        
    }
}
