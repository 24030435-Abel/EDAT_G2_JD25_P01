using System;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cbGrupo.Items.Count == 0)
            {
                cbGrupo.Items.AddRange(new object[] { "A", "B", "C", "D" });
                cbGrupo.SelectedIndex = 0;
            }

            dtpFechaNacimiento.Format = DateTimePickerFormat.Long;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = rnd.Next(1000, 10000).ToString();

            string[] nombres = { "Luis", "María", "Carlos", "Ana", "Jorge", "Sofía", "Miguel", "Valeria" };
            string[] apellidos = { "Gómez", "López", "Martínez", "Hernández", "Pérez", "Sánchez", "Ramírez" };
            txtNombre.Text = nombres[rnd.Next(nombres.Length)] + " " + apellidos[rnd.Next(apellidos.Length)];

            int edad = rnd.Next(18, 61);
            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-edad).AddDays(rnd.Next(0, 365));

            bool masculino = rnd.Next(2) == 0;
            rbMasculino.Checked = masculino;
            rbFemenino.Checked = !masculino;

            if (cbGrupo.Items.Count > 0)
                cbGrupo.SelectedIndex = rnd.Next(cbGrupo.Items.Count);

            int sueldo = rnd.Next(5000, 25001);
            txtSueldo.Text = sueldo.ToString("N0");

            chkSeguro.Checked = rnd.Next(2) == 0;
        }
    }
}
