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
        bool bandera = false;
        string[,] matLibro = new string[21, 5];
        public frmConsultar()
        {
            InitializeComponent();
            

            if (File.Exists("LIBRO.txt") == true) // Preguntamos si el archivo existe
            {
                
                StreamReader srTodos = new StreamReader("LIBRO.txt"); // Generamos la lectura del archivo principal
                
                while (!srTodos.EndOfStream)
                {
                    string[] vecLibro = srTodos.ReadLine().Split(',');

                    // Buscamos el código de editorial en su archivo y extraemos el nombre
                    StreamReader srEditorial = new StreamReader("EDITORIAL.txt");
                    while (!srEditorial.EndOfStream)
                    {
                        
                        string[] vecEditorial = srEditorial.ReadLine().Split(',');
                        if (vecEditorial[0] == vecLibro[2])
                        {
                            vecLibro[2] = vecEditorial[1];
                            break; // Una vez encontrado, salimos del while
                        }
                    }
                    srEditorial.Close();

                    // Buscamos el código de distribuidor en su archivo y extraemos el nombre
                    StreamReader srDistribuidor = new StreamReader("DISTRIBUIDORA.txt");
                    while (!srDistribuidor.EndOfStream)
                    {
                        string[] vecDistribuidor = srDistribuidor.ReadLine().Split(',');
                        if (vecDistribuidor[0] == vecLibro[4])
                        {
                            vecLibro[4] = vecDistribuidor[1];
                            break; // Una vez encontrado, salimos del while
                        }
                    }
                    srDistribuidor.Close();

                    // Cargamos en la matríz los datos obtenidos
                    matLibro[f, 0] = vecLibro[0];
                    matLibro[f, 1] = vecLibro[1];  
                    matLibro[f, 2] = vecLibro[2];
                    matLibro[f, 3] = vecLibro[3];
                    matLibro[f, 4] = vecLibro[4];
                    f++;
                }
                srTodos.Close();
                
            }
            else // Si no existe el archivo avisamos
            {
                MessageBox.Show("Los archivos no se encuentran cargados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            StreamReader srTodos = new StreamReader("LIBRO.txt");

            int i = 0;
            while (!srTodos.EndOfStream)
            {

                if (bandera != true) // Evitamos que se repita la consulta en la grilla
                {
                    if (i < 21) // Nos aseguramos que se mantenga en los rangos de la matríz, a trabajar...
                    {
                        // Cargamos en la grilla los datos de la matríz
                        grlLibros.Rows.Add(matLibro[i, 0],
                        matLibro[i, 1],
                        matLibro[i, 2],
                        matLibro[i, 3],
                        matLibro[i, 4]);
                        i++;
                    }
                    else
                    {
                        bandera = true;
                        break; // Una vez llegado al límite de la matríz, salimos del while
                    }
                }
                else
                {
                    MessageBox.Show("Ya se han mostrdo todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                
                
            }
            srTodos.Close();
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
            else // Vuelve al inicio
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
            else // Vuelve al final
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
