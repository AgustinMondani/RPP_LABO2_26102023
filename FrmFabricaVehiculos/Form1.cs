using Entidades;
namespace FrmFabricaVehiculos
{
    public partial class Form1 : Form
    {
        private Fabrica fabrica;
        public Form1()
        {
            
            InitializeComponent();
            cmbTipo.Items.Add("Automovil");
            cmbTipo.Items.Add("Camioneta");
            cmbTipo.Items.Add("Moto");

            fabrica = new Fabrica(15);
            fabrica += new Camioneta(EPropulsion.Electrica, true);

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}