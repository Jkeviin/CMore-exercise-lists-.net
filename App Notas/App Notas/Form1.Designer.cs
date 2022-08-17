namespace App_Notas
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
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnresultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lista_nota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnotas
            // 
            this.txtnotas.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnotas.Location = new System.Drawing.Point(192, 59);
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.ShortcutsEnabled = false;
            this.txtnotas.Size = new System.Drawing.Size(35, 26);
            this.txtnotas.TabIndex = 0;
            this.txtnotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotas_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(34, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ShortcutsEnabled = false;
            this.txtnombre.Size = new System.Drawing.Size(122, 23);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // btnagregar
            // 
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(247, 59);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(76, 23);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnresultado
            // 
            this.btnresultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresultado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresultado.Location = new System.Drawing.Point(56, 107);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(100, 23);
            this.btnresultado.TabIndex = 4;
            this.btnresultado.Text = "RESULTADO";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESE SU NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "INGRESE LAS 4 NOTAS:";
            // 
            // txtresultado
            // 
            this.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(56, 161);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ShortcutsEnabled = false;
            this.txtresultado.Size = new System.Drawing.Size(249, 23);
            this.txtresultado.TabIndex = 2;
            this.txtresultado.Text = "Aqui se verá el resultado";
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lista_nota
            // 
            this.lista_nota.AutoSize = true;
            this.lista_nota.BackColor = System.Drawing.SystemColors.Window;
            this.lista_nota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lista_nota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lista_nota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_nota.Location = new System.Drawing.Point(192, 90);
            this.lista_nota.Margin = new System.Windows.Forms.Padding(5);
            this.lista_nota.Name = "lista_nota";
            this.lista_nota.Size = new System.Drawing.Size(2, 16);
            this.lista_nota.TabIndex = 11;
            this.lista_nota.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 246);
            this.Controls.Add(this.lista_nota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtnotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lista_nota;
    }
}

