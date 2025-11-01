namespace pryVargasSP2EjercicioPorResolver
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Declaración variables
        int vCantidadDias = 0;
        int vDistancia = 0;
        double vTotal = 0;
        double vDescuento = 0;
        int Indice = 0;

        public struct Datos 
        {
            public int CantidadDias;
            public int Distancia;
            public double Total;
            public double Descuento;
        }

        //Declaración de  array
        public Datos[] vecDatos = new Datos[100]; 

        private void mtbDistancia_TextChanged(object sender, EventArgs e)
        {
            //validamos mtbDistancia para habilitar el nudCantidadDias
            if (mtbDistancia.Text != "")
            {
                nudCantidadDias.Enabled = true;
            }
            else
            {
                nudCantidadDias.Enabled = false;
            }
        }

        private void nudCantidadDias_ValueChanged(object sender, EventArgs e)
        {
            //validamos que nudCantidad días tenga un valor para habilitar el btnCalcular
            if (nudCantidadDias.Value > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //limpia controles
            mtbDistancia.Text = "";
            nudCantidadDias.Value = 1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //otorgamos un valor a las variables
            vCantidadDias = Convert.ToInt32(nudCantidadDias.Value);
            vDistancia = Convert.ToInt32(mtbDistancia.Text);

            //multiplicamos distancia por 2 para tener el recorrido total ida y vuelta
            vDistancia = vDistancia * 2;

            if (vCantidadDias >= 7 && vDistancia >= 100)
            {
                vTotal = vDistancia * 5;
                vDescuento = (vTotal * 0.5);
                vTotal = vTotal - vDescuento;
                MessageBox.Show("El valor total del boleto es de " + "$" + vTotal, "Precio final");
            }
            else
            {
                vTotal = vDistancia * 5;
                MessageBox.Show("El valor total del boleto es de " + "$" + vTotal, "Precio final");
            }

            if (Indice < 100)
            {
                //Grabamos datos en el array
                vecDatos[Indice].Distancia = vDistancia;
                vecDatos[Indice].CantidadDias = vCantidadDias;
                vecDatos[Indice].Total = vTotal;
                vecDatos[Indice].Descuento = vDescuento;
                Indice++;
            }
            else
            {
                MessageBox.Show("El array se encuentra lleno", "Array lleno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCalcular.Enabled = false;
            }

            //limpiamos los controles
            mtbDistancia.Text = "";
            nudCantidadDias.Value = 1;
            vCantidadDias = 0;
            vTotal = 0;
            vDistancia = 0;
            vDescuento = 0;

        }
    }
}
