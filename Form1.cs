namespace trabajopractico
{
    public partial class frminscripcion : Form
    {
            public struct SOCIO
            {
                public string Nombre;
                public int Edad;
                public string Categoria;
                public string Plan;
                public string Horario;
                public int Meses;
                public string FormaPago;
                public decimal Total;
                public decimal ValorCuota;
            }

            const decimal PRECIO_MUSCULACION = 15000m;
            const decimal PRECIO_FUNCIONAL = 18000m;
            const decimal PRECIO_NATACION = 22000m;
            const decimal PRECIO_CASILLERO = 3000m;
            const int EDAD_MINIMA = 14;

        public frminscripcion()
        {
            InitializeComponent();
        }
        private void EstadoInicial()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtMeses.Text = "1";

            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;

            rbtEfectivo.Checked = true;

            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;

            btnCalcular.Enabled = false;

            txtNombre.Focus();
        }

        private void frminscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("El socio debe tener al menos " + EDAD_MINIMA + " años.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            decimal precioMensual = 0;
            string planElegido = cboPlan.SelectedItem.ToString();

            switch (planElegido)
            {
                case "Musculacion":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natacion":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Plan inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string horario = "";
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "08:00 a 12:00 hs";
                    break;
                case 1:
                    horario = "12:00 a 16:00 hs";
                    break;
                case 2:
                    horario = "16:00 a 20:00 hs";
                    break;
                case 3:
                    horario = "20:00 a 00:00 hs";
                    break;
            }

            
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            decimal subtotal = precioMensual * meses;

           
            decimal porcDescuento = 0;
            if (edad < 18)
            {
                porcDescuento = 0.25m; // 25%
            }
            else
            {
                if (edad >= 65)
                {
                    porcDescuento = 0.30m; // 30%
                }
                else if (chkEstudiante.Checked)
                {
                    porcDescuento = 0.15m; // 15%
                }
            }

            decimal importeConDescuento = subtotal * (1 - porcDescuento);

            
            decimal porcAjuste = 0;
            int cuotasElegidas = 1;

            if (rbtEfectivo.Checked)
            {
                porcAjuste = -0.10m; // -10% descuento por efectivo
            }
            else
            {
                if (cboCuotas.SelectedItem != null)
                {
                    cuotasElegidas = int.Parse(cboCuotas.SelectedItem.ToString());
                }

                if (cuotasElegidas == 1)
                {
                    porcAjuste = 0m; // 0% recargo
                }
                else if (cuotasElegidas == 3)
                {
                    porcAjuste = 0.10m; // 10% recargo
                }
                else if (cuotasElegidas == 6)
                {
                    porcAjuste = 0.20m; // 20% recargo
                }
            }

            decimal totalFinal = importeConDescuento * (1 + porcAjuste);

            
            string categoria = (edad < 18) ? "Menor" : "Mayor";
            string textoFormaPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta en " + cuotasElegidas + " cuotas";
            decimal valorCuota = rbtEfectivo.Checked ? totalFinal : (totalFinal / cuotasElegidas);

           
            SOCIO nuevoSocio;
            nuevoSocio.Nombre = txtNombre.Text;
            nuevoSocio.Edad = edad;
            nuevoSocio.Categoria = categoria;
            nuevoSocio.Plan = planElegido;
            nuevoSocio.Horario = horario;
            nuevoSocio.Meses = meses;
            nuevoSocio.FormaPago = textoFormaPago;
            nuevoSocio.Total = totalFinal;
            nuevoSocio.ValorCuota = valorCuota;

            string resumen = "RESUMEN DE INSCRIPCIÓN\n\n" +
                             "Socio: " + nuevoSocio.Nombre + "\n" +
                             "Edad: " + nuevoSocio.Edad + " (" + nuevoSocio.Categoria + ")\n" +
                             "Plan: " + nuevoSocio.Plan + "\n" +
                             "Horario: " + nuevoSocio.Horario + "\n" +
                             "Meses: " + nuevoSocio.Meses + "\n" +
                             "Forma de Pago: " + nuevoSocio.FormaPago + "\n\n" +
                             "TOTAL A PAGAR: " + nuevoSocio.Total.ToString("C") + "\n" +
                             "Valor por cuota: " + nuevoSocio.ValorCuota.ToString("C");

            MessageBox.Show(resumen, "Inscripción Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoInicial();
        }
    }
    }

 
