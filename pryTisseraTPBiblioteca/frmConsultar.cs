using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryTisseraTPBiblioteca
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

            
        }

        private void lblResEditorial_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int f, c = 0;
            string[,] matLibro = new string[21, 5];
            
            if (File.Exists("./LIBRO.txt") == true)
            {
                StreamReader srTodos = new StreamReader("./LIBRO.txt");
                while (!srTodos.EndOfStream)
                {
                    string[] vecLibro = srTodos.ReadLine().Split(',');

                }
            }
        }
    }
}
