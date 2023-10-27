namespace FrmFabricaVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            cmbTipo = new ComboBox();
            btnEliminar = new Button();
            btnFarbicar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(568, 424);
            listBox1.TabIndex = 0;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(587, 13);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(201, 23);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(616, 358);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 60);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnFarbicar
            // 
            btnFarbicar.Location = new Point(616, 275);
            btnFarbicar.Name = "btnFarbicar";
            btnFarbicar.Size = new Size(156, 60);
            btnFarbicar.TabIndex = 4;
            btnFarbicar.Text = "Farbicar";
            btnFarbicar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFarbicar);
            Controls.Add(btnEliminar);
            Controls.Add(cmbTipo);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farbica De Vehiculos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ComboBox cmbTipo;
        private Button btnEliminar;
        private Button btnFarbicar;
    }
}