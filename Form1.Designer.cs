namespace ManoVisualBluetooth
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.uno = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.paz = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.Saludo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(98, 72);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(75, 23);
            this.uno.TabIndex = 0;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.Uno_Click);
            // 
            // dos
            // 
            this.dos.Location = new System.Drawing.Point(213, 72);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(75, 23);
            this.dos.TabIndex = 1;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.Dos_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(334, 72);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(75, 23);
            this.tres.TabIndex = 3;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.Tres_Click);
            // 
            // cuatro
            // 
            this.cuatro.Location = new System.Drawing.Point(458, 72);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(75, 23);
            this.cuatro.TabIndex = 4;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.Cuatro_Click);
            // 
            // abrir
            // 
            this.abrir.Location = new System.Drawing.Point(98, 155);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(75, 38);
            this.abrir.TabIndex = 5;
            this.abrir.Text = "Abrir mano";
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(213, 155);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 38);
            this.cerrar.TabIndex = 6;
            this.cerrar.Text = "Cerrar Mano";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // paz
            // 
            this.paz.Location = new System.Drawing.Point(313, 155);
            this.paz.Name = "paz";
            this.paz.Size = new System.Drawing.Size(75, 38);
            this.paz.TabIndex = 7;
            this.paz.Text = "Paz y amor";
            this.paz.UseVisualStyleBackColor = true;
            this.paz.Click += new System.EventHandler(this.Paz_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(418, 155);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 38);
            this.ok.TabIndex = 8;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Saludo
            // 
            this.Saludo.Location = new System.Drawing.Point(536, 155);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(75, 38);
            this.Saludo.TabIndex = 9;
            this.Saludo.Text = "Saludo";
            this.Saludo.UseVisualStyleBackColor = true;
            this.Saludo.Click += new System.EventHandler(this.Saludo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ManoVisualBluetooth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Saludo);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.paz);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Name = "Form1";
            this.Text = "Tutosoftware";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button paz;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button Saludo;
        private System.Windows.Forms.Label label1;
    }
}

