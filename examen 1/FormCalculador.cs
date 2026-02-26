namespace examen_1
{
    public partial class FormCalculador : Form
    {
        public FormCalculador()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sueldo = Convert.ToDecimal(txb_SueldoMensual.Text);
                if (sueldo <= 0)
                {
                    MessageBox.Show("Ingrese un sueldo mayor que 0.");
                    return;
                }
                decimal isr = CalcularISR(sueldo);
                decimal sueldoNeto = sueldo - isr;
                txb_ISR.Text = $"ISR: {isr:C}";
                txb_SueldoNeto.Text = $"Sueldo Neto: {sueldoNeto:C}";
            }
            catch
            { MessageBox.Show("Ingrese un número válido." "sistema", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private decimal CalcularISR(decimal sueldo)
        {
            var rangos = new[] {
            new {Inf=0.01m, Sup=746.04m, Cuota=0.00m, Porc=0.0192m},
            new {Inf=746.05m, Sup=6332.05m, Cuota=14.32m, Porc=0.0640m},
            new {Inf=6332.06m, Sup=11128.01m, Cuota=371.83m, Porc=0.1088m},
            new {Inf=11128.02m, Sup=12935.82m, Cuota=893.63m, Porc=0.1600m},
            new {Inf=12935.82m, Sup=15487.71m, Cuota=13186.26m, Porc=0.1792m},
            new {Inf=15487.72m, Sup=31236.49m, Cuota=1972.12m, Porc=0.2136m},
            new {Inf= 31236.50m, Sup=49233.00m, Cuota=5850.76m, Porc=0.2352m},
            new {Inf= 49233.01m, Sup=93993.90m, Cuota=10837.02m, Porc=0.30m},
            new {Inf= 93993.91m, Sup=125325.20m, Cuota=26177.04m, Porc=0.32m},
            new {Inf=125325.21m, Sup=375975.61m, Cuota=38243.68m, Porc=0.34m},
            new {Inf=375975.62m, Sup=999999m, Cuota=142119.38m, Porc=0.35m} };

            foreach (var r in rangos)
            {
                if (sueldo >= r.Inf && sueldo <= r.Sup)
                {
                    return r.Cuota + (sueldo - r.Inf) * r.Porc;
                }
            }
            return 0;
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
