namespace Archivos_de_texto_y_archivos_binarios
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtInfoBMP = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rtbFemenimo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lstTodos = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGenerarXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(156, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(113, 30);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir BMP";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtInfoBMP
            // 
            this.txtInfoBMP.Location = new System.Drawing.Point(33, 49);
            this.txtInfoBMP.Name = "txtInfoBMP";
            this.txtInfoBMP.Size = new System.Drawing.Size(355, 116);
            this.txtInfoBMP.TabIndex = 1;
            this.txtInfoBMP.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-9, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "_________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de cuenta:";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(156, 247);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(232, 26);
            this.txtNumCuenta.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 279);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(156, 311);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(232, 26);
            this.txtPaterno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido paterno:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(156, 343);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(232, 26);
            this.txtTelefono.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono:";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(156, 382);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(40, 24);
            this.rbtMasculino.TabIndex = 11;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "M";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rtbFemenimo
            // 
            this.rtbFemenimo.AutoSize = true;
            this.rtbFemenimo.Location = new System.Drawing.Point(286, 382);
            this.rtbFemenimo.Name = "rtbFemenimo";
            this.rtbFemenimo.Size = new System.Drawing.Size(37, 24);
            this.rtbFemenimo.TabIndex = 12;
            this.rtbFemenimo.TabStop = true;
            this.rtbFemenimo.Text = "F";
            this.rtbFemenimo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Género:";
            // 
            // lstTodos
            // 
            this.lstTodos.FormattingEnabled = true;
            this.lstTodos.ItemHeight = 20;
            this.lstTodos.Location = new System.Drawing.Point(10, 422);
            this.lstTodos.Name = "lstTodos";
            this.lstTodos.Size = new System.Drawing.Size(259, 224);
            this.lstTodos.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(286, 422);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGenerarXML
            // 
            this.btnGenerarXML.Location = new System.Drawing.Point(286, 567);
            this.btnGenerarXML.Name = "btnGenerarXML";
            this.btnGenerarXML.Size = new System.Drawing.Size(117, 79);
            this.btnGenerarXML.TabIndex = 16;
            this.btnGenerarXML.Text = "Generar XML";
            this.btnGenerarXML.UseVisualStyleBackColor = true;
            this.btnGenerarXML.Click += new System.EventHandler(this.btnGenerarXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 672);
            this.Controls.Add(this.btnGenerarXML);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstTodos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbFemenimo);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfoBMP);
            this.Controls.Add(this.btnAbrir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.RichTextBox txtInfoBMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rtbFemenimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstTodos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGenerarXML;
    }
}

