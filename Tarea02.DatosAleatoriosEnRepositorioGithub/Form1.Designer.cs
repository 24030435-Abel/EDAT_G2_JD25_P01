namespace EmployeeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.CheckBox chkSeguro;
        private System.Windows.Forms.Button btnGenerar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.chkSeguro = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gbDatosEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.lblNumero);
            this.gbDatosEmpleado.Controls.Add(this.txtNumero);
            this.gbDatosEmpleado.Controls.Add(this.lblNombre);
            this.gbDatosEmpleado.Controls.Add(this.txtNombre);
            this.gbDatosEmpleado.Controls.Add(this.lblFecha);
            this.gbDatosEmpleado.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosEmpleado.Controls.Add(this.rbMasculino);
            this.gbDatosEmpleado.Controls.Add(this.rbFemenino);
            this.gbDatosEmpleado.Controls.Add(this.lblGrupo);
            this.gbDatosEmpleado.Controls.Add(this.cbGrupo);
            this.gbDatosEmpleado.Controls.Add(this.lblSueldo);
            this.gbDatosEmpleado.Controls.Add(this.txtSueldo);
            this.gbDatosEmpleado.Controls.Add(this.chkSeguro);
            this.gbDatosEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(560, 320);
            this.gbDatosEmpleado.TabIndex = 0;
            this.gbDatosEmpleado.TabStop = false;
            this.gbDatosEmpleado.Text = "Datos del empleado";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(420, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(130, 102);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(110, 140);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(110, 163);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 7;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(20, 200);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 8;
            this.lblGrupo.Text = "Grupo";
            // 
            // cbGrupo
            // 
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(110, 196);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(120, 21);
            this.cbGrupo.TabIndex = 9;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(20, 235);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(39, 13);
            this.lblSueldo.TabIndex = 10;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(110, 231);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(120, 20);
            this.txtSueldo.TabIndex = 11;
            // 
            // chkSeguro
            // 
            this.chkSeguro.AutoSize = true;
            this.chkSeguro.Location = new System.Drawing.Point(20, 270);
            this.chkSeguro.Name = "chkSeguro";
            this.chkSeguro.Size = new System.Drawing.Size(96, 17);
            this.chkSeguro.TabIndex = 12;
            this.chkSeguro.Text = "Seguro médico";
            this.chkSeguro.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 345);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(560, 40);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar datos aleatorios";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gbDatosEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Empleado con datos aleatorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatosEmpleado.ResumeLayout(false);
            this.gbDatosEmpleado.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
