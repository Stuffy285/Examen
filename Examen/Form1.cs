using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Examen
{
    public partial class Form1 : Form
    {
        
        Queue<Poligonos> pila_Polipoli;
        public Form1()
        {
            InitializeComponent();
            
            pila_Polipoli = new Queue<Poligonos>();

        }

        private void txt_triangulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_triangulo_Click(object sender, EventArgs e)
        {
            
            pila_Polipoli.Enqueue(
               
                            new Poligonos(
                                int.Parse(txt_triangulo.Text),
                                int.Parse(txt_triangulo_2.Text)
                                )); 
        }

        private void agregar_rectangulo_Click(object sender, EventArgs e)
        {
            pila_Polipoli.Enqueue(
                new Poligonos(
                    int.Parse(txt_rectagulo.Text),
                    int.Parse(txt_rectangulo_2.Text)
                    ));          
        }

        private void agregar_pararelogramo_Click(object sender, EventArgs e)
        {
            pila_Polipoli.Enqueue(
                            new Poligonos(
                                int.Parse(txt_paralelogramo.Text),
                                int.Parse(txt_paralelogramo_2.Text)
                                ));          
        }
        public class Poligonos
        {
            public int Rectangulo, rec2;
            public Poligonos(int Rectangulo, int rec2)
            {
                this.Rectangulo = Rectangulo;
                this.rec2 = rec2;
                


            }
            public override string ToString()
            {
                return $"Datos: {Rectangulo} {rec2}";
                
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            lbl_mostrar_pila.Text = "";
            foreach (Poligonos elemento in pila_Polipoli)
            {
                
                lbl_mostrar_pila.Text += elemento + "\n\n";
            }
        }
    }
}

//FALTA LO DE LA CLASE NOMBRE PERO ESA NO SUPE COMO INTEGRARLA Y CALCULAR SU AREA YA QUE NO VIMOs SOBRE ESO EN CLASE TAN PROFUNDO 
