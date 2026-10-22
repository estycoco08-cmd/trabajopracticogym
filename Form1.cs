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
        const int EDAD_MENOR = 18;
        const int EDAD_MAYOR = 65;
        const int MESES_MIN = 1;
        const int MESES_MAX = 12;
        const decimal DESC_MENOR = 0.25m;
        const decimal DESC_MAYOR = 0.30m;
        const decimal DESC_ESTUDIANTE = 0.15m;
        const decimal AJUSTE_EFECTIVO = -0.10m;
        const decimal RECARGO_3_CUOTAS = 0.10m;
        const decimal RECARGO_6_CUOTAS = 0.20m;

        public frminscripcion()
        {
            InitializeComponent();

            txtEdad.KeyPress += SoloDigitos_KeyPress;
            txtMeses.KeyPress += SoloDigitos_KeyPress;
            txtNombre.KeyPress += txtNombre_KeyPress;

            txtNombre.TextChanged += Datos_TextChanged;
            txtEdad.TextChanged += Datos_TextChanged;
            txtMeses.TextChanged += Datos_TextChanged;

            rBtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
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

        private void SoloDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void Datos_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
                btnCalcular.Enabled = true;
            else
                btnCalcular.Enabled = false;
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
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

            if (meses < MESES_MIN || meses > MESES_MAX)
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
                    horario = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    horario = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    horario = "Noche (18 a 23 h)";
                    break;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            decimal subtotal = precioMensual * meses;

            decimal porcDescuento = 0;
            if (edad < EDAD_MENOR)
            {
                porcDescuento = DESC_MENOR;
            }
            else
            {
                if (edad >= EDAD_MAYOR)
                {
                    porcDescuento = DESC_MAYOR;
                }
                else if (chkEstudiante.Checked)
                {
                    porcDescuento = DESC_ESTUDIANTE;
                }
            }

            decimal importeConDescuento = subtotal * (1 - porcDescuento);

            decimal porcAjuste = 0;
            int cuotasElegidas = 1;

            if (rbtEfectivo.Checked)
            {
                porcAjuste = AJUSTE_EFECTIVO;
            }
            else
            {
                if (cboCuotas.SelectedItem != null)
                {
                    cuotasElegidas = int.Parse(cboCuotas.SelectedItem.ToString());
                }

                if (cuotasElegidas == 1)
                {
                    porcAjuste = 0m;
                }
                else if (cuotasElegidas == 3)
                {
                    porcAjuste = RECARGO_3_CUOTAS;
                }
                else if (cuotasElegidas == 6)
                {
                    porcAjuste = RECARGO_6_CUOTAS;
                }
            }

            decimal totalFinal = importeConDescuento * (1 + porcAjuste);

            string categoria = (edad < EDAD_MENOR) ? "Menor" : "Mayor";
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



