using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronComposite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Componente cs1 = new ComponenteSimple() { Codigo = 1, Nombre = "c1" };
        Componente cs2 = new ComponenteSimple() { Codigo = 2, Nombre = "c2" };
        Componente cs3 = new ComponenteSimple() { Codigo = 3, Nombre = "c3" };
        Componente cs4 = new ComponenteSimple() { Codigo = 4, Nombre = "c4" };

        private void Form1_Load(object sender, EventArgs e)
        {
            Componente componenteCompuesto = new ComponenteCompuesto();
            componenteCompuesto.AgregarHijo(cs1);
            componenteCompuesto.AgregarHijo(cs2);

            Componente componenteCompuesto2 = new ComponenteCompuesto();
            componenteCompuesto2.AgregarHijo(componenteCompuesto);
            componenteCompuesto2.AgregarHijo(cs3);
            componenteCompuesto2.AgregarHijo(cs4);  
        }
    }
}
