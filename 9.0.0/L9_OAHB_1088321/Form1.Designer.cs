
namespace L9_OAHB_1088321
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_disp = new System.Windows.Forms.Label();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_dispo = new System.Windows.Forms.TextBox();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_datos = new System.Windows.Forms.Label();
            this.lbl_resmodelo = new System.Windows.Forms.Label();
            this.lbl_resprecio = new System.Windows.Forms.Label();
            this.lbl_resmarca = new System.Windows.Forms.Label();
            this.lbl_resdescuento = new System.Windows.Forms.Label();
            this.lbl_rescambio = new System.Windows.Forms.Label();
            this.lbl_resdisponible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOMOVIL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(20, 71);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_modelo.TabIndex = 1;
            this.lbl_modelo.Text = "Modelo";
            this.lbl_modelo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(20, 138);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_precio.TabIndex = 2;
            this.lbl_precio.Text = "Precio";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(20, 102);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 3;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(20, 168);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 4;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(183, 71);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 5;
            this.lbl_marca.Text = "Marca";
            // 
            // lbl_disp
            // 
            this.lbl_disp.AutoSize = true;
            this.lbl_disp.Location = new System.Drawing.Point(183, 138);
            this.lbl_disp.Name = "lbl_disp";
            this.lbl_disp.Size = new System.Drawing.Size(56, 13);
            this.lbl_disp.TabIndex = 6;
            this.lbl_disp.Text = "Disponible";
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Location = new System.Drawing.Point(325, 71);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(91, 13);
            this.lbl_cambio.TabIndex = 7;
            this.lbl_cambio.Text = "Tipo cambio dolar";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(325, 138);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(102, 13);
            this.lbl_desc.TabIndex = 8;
            this.lbl_desc.Text = "Descuento aplicado";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(186, 102);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(100, 20);
            this.txt_marca.TabIndex = 9;
            // 
            // txt_dispo
            // 
            this.txt_dispo.Location = new System.Drawing.Point(186, 168);
            this.txt_dispo.Name = "txt_dispo";
            this.txt_dispo.Size = new System.Drawing.Size(100, 20);
            this.txt_dispo.TabIndex = 10;
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(328, 102);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(100, 20);
            this.txt_cambio.TabIndex = 11;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(328, 168);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(100, 20);
            this.txt_desc.TabIndex = 12;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(111, 216);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(211, 216);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_datos
            // 
            this.lbl_datos.AutoSize = true;
            this.lbl_datos.Location = new System.Drawing.Point(538, 28);
            this.lbl_datos.Name = "lbl_datos";
            this.lbl_datos.Size = new System.Drawing.Size(89, 13);
            this.lbl_datos.TabIndex = 15;
            this.lbl_datos.Text = "Datos ingresados";
            // 
            // lbl_resmodelo
            // 
            this.lbl_resmodelo.AutoSize = true;
            this.lbl_resmodelo.Location = new System.Drawing.Point(538, 76);
            this.lbl_resmodelo.Name = "lbl_resmodelo";
            this.lbl_resmodelo.Size = new System.Drawing.Size(0, 13);
            this.lbl_resmodelo.TabIndex = 16;
            // 
            // lbl_resprecio
            // 
            this.lbl_resprecio.AutoSize = true;
            this.lbl_resprecio.Location = new System.Drawing.Point(538, 105);
            this.lbl_resprecio.Name = "lbl_resprecio";
            this.lbl_resprecio.Size = new System.Drawing.Size(0, 13);
            this.lbl_resprecio.TabIndex = 17;
            // 
            // lbl_resmarca
            // 
            this.lbl_resmarca.AutoSize = true;
            this.lbl_resmarca.Location = new System.Drawing.Point(538, 135);
            this.lbl_resmarca.Name = "lbl_resmarca";
            this.lbl_resmarca.Size = new System.Drawing.Size(0, 13);
            this.lbl_resmarca.TabIndex = 18;
            // 
            // lbl_resdescuento
            // 
            this.lbl_resdescuento.AutoSize = true;
            this.lbl_resdescuento.Location = new System.Drawing.Point(538, 226);
            this.lbl_resdescuento.Name = "lbl_resdescuento";
            this.lbl_resdescuento.Size = new System.Drawing.Size(0, 13);
            this.lbl_resdescuento.TabIndex = 21;
            // 
            // lbl_rescambio
            // 
            this.lbl_rescambio.AutoSize = true;
            this.lbl_rescambio.Location = new System.Drawing.Point(538, 188);
            this.lbl_rescambio.Name = "lbl_rescambio";
            this.lbl_rescambio.Size = new System.Drawing.Size(0, 13);
            this.lbl_rescambio.TabIndex = 20;
            // 
            // lbl_resdisponible
            // 
            this.lbl_resdisponible.AutoSize = true;
            this.lbl_resdisponible.Location = new System.Drawing.Point(538, 161);
            this.lbl_resdisponible.Name = "lbl_resdisponible";
            this.lbl_resdisponible.Size = new System.Drawing.Size(0, 13);
            this.lbl_resdisponible.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 263);
            this.Controls.Add(this.lbl_resdescuento);
            this.Controls.Add(this.lbl_rescambio);
            this.Controls.Add(this.lbl_resdisponible);
            this.Controls.Add(this.lbl_resmarca);
            this.Controls.Add(this.lbl_resprecio);
            this.Controls.Add(this.lbl_resmodelo);
            this.Controls.Add(this.lbl_datos);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.txt_dispo);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_cambio);
            this.Controls.Add(this.lbl_disp);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_disp;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_dispo;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_datos;
        private System.Windows.Forms.Label lbl_resmodelo;
        private System.Windows.Forms.Label lbl_resprecio;
        private System.Windows.Forms.Label lbl_resmarca;
        private System.Windows.Forms.Label lbl_resdescuento;
        private System.Windows.Forms.Label lbl_rescambio;
        private System.Windows.Forms.Label lbl_resdisponible;
    }
}

