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
        int i;
        int f = 0;
        string[,] matLibro = new string[21, 5];
        public frmConsultar()
        {
            InitializeComponent();
            

            if (File.Exists("./LIBRO.txt") == true)
            {
                
                StreamReader srTodos = new StreamReader("./LIBRO.txt");
                
                while (!srTodos.EndOfStream)
                {
                    string[] vecLibro = srTodos.ReadLine().Split(',');

                    StreamReader srEditorial = new StreamReader("./EDITORIAL.txt");
                    while (!srEditorial.EndOfStream)
                    {
                        
                        string[] vecEditorial = srEditorial.ReadLine().Split(',');
                        if (vecEditorial[0] == vecLibro[2])
                        {
                            vecLibro[2] = vecEditorial[1];
                            break;
                        }
                    }
                    srEditorial.Close();

                    StreamReader srDistribuidor = new StreamReader("./DISTRIBUIDORA.txt");
                    while (!srDistribuidor.EndOfStream)
                    {
                        string[] vecDistribuidor = srDistribuidor.ReadLine().Split(',');
                        if (vecDistribuidor[0] == vecLibro[4])
                        {
                            vecLibro[4] = vecDistribuidor[1];
                            break;
                        }
                    }
                    srDistribuidor.Close();

                    matLibro[f, 0] = vecLibro[0];
                    matLibro[f, 1] = vecLibro[1];  
                    matLibro[f, 2] = vecLibro[2];
                    matLibro[f, 3] = vecLibro[3];
                    matLibro[f, 4] = vecLibro[4];
                    f++;
                }
                srTodos.Close();
                
            }
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

            
        }

        private void lblResEditorial_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            StreamReader srTodos = new StreamReader("./LIBRO.txt");
            StreamReader srEditorial = new StreamReader("./EDITORIAL.txt");

            int i = 0;
            while (!srTodos.EndOfStream && !srEditorial.EndOfStream)
            {
                if (i < 21)
                {
                    grlLibros.Rows.Add(matLibro[i, 0],
                    matLibro[i, 1],
                    matLibro[i, 2],
                    matLibro[i, 3],
                    matLibro[i, 4]);
                    i++;
                }
                else
                {
                    break;
                }
                
            }
            srTodos.Close();
            srEditorial.Close();

                
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (i < 21)
            {
                lblResCodigo.Text = matLibro[i, 0];
                lblResLibro.Text = matLibro[i, 1];
                lblResEditorial.Text = matLibro[i, 2];
                lblResAutor.Text = matLibro[i, 3];
                lblResDistribuidor.Text = matLibro[i, 4];
                i++;
            }
            else
            {
                i = 0;
                lblResCodigo.Text = matLibro[i, 0];
                lblResLibro.Text = matLibro[i, 1];
                lblResEditorial.Text = matLibro[i, 2];
                lblResAutor.Text = matLibro[i, 3];
                lblResDistribuidor.Text = matLibro[i, 4];
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (i >= 0)
            {
                lblResCodigo.Text = matLibro[i, 0];
                lblResLibro.Text = matLibro[i, 1];
                lblResEditorial.Text = matLibro[i, 2];
                lblResAutor.Text = matLibro[i, 3];
                lblResDistribuidor.Text = matLibro[i, 4];
                i--;
            }
            else
            {
                i = 20;
                lblResCodigo.Text = matLibro[i, 0];
                lblResLibro.Text = matLibro[i, 1];
                lblResEditorial.Text = matLibro[i, 2];
                lblResAutor.Text = matLibro[i, 3];
                lblResDistribuidor.Text = matLibro[i, 4];
            }
        }
    }
}
