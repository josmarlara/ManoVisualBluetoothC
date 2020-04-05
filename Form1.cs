using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManoVisualBluetooth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM8";
            serialPort1.BaudRate = 9600;
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Uno_Click(object sender, EventArgs e)
        {
            
                    serialPort1.Write("1");
                    
              
        }

        private void Dos_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }

        private void Cuatro_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5");
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void Paz_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void Saludo_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }
    }
}
