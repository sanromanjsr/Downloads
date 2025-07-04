namespace clase_13_06
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
            this.btnSmartTv = new System.Windows.Forms.Button();
            this.btnTablet = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnSonido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReproduciendo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSmartTv
            // 
            this.btnSmartTv.Location = new System.Drawing.Point(39, 42);
            this.btnSmartTv.Name = "btnSmartTv";
            this.btnSmartTv.Size = new System.Drawing.Size(320, 111);
            this.btnSmartTv.TabIndex = 0;
            this.btnSmartTv.Text = "Crear SmartTv";
            this.btnSmartTv.UseVisualStyleBackColor = true;
            this.btnSmartTv.Click += new System.EventHandler(this.btnSmartTv_Click);
            // 
            // btnTablet
            // 
            this.btnTablet.Location = new System.Drawing.Point(569, 42);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(307, 111);
            this.btnTablet.TabIndex = 1;
            this.btnTablet.Text = "Crear Tablet";
            this.btnTablet.UseVisualStyleBackColor = true;
            this.btnTablet.Click += new System.EventHandler(this.btnTablet_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(171, 195);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(246, 48);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(488, 195);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(246, 48);
            this.btnEncender.TabIndex = 3;
            this.btnEncender.Text = "ENCENDER";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "REPRODUCIR:";
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(293, 326);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(441, 22);
            this.txtInformacion.TabIndex = 5;
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(171, 401);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(246, 78);
            this.btnVideo.TabIndex = 6;
            this.btnVideo.Text = "VIDEO";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnSonido
            // 
            this.btnSonido.Location = new System.Drawing.Point(488, 401);
            this.btnSonido.Name = "btnSonido";
            this.btnSonido.Size = new System.Drawing.Size(246, 78);
            this.btnSonido.TabIndex = 7;
            this.btnSonido.Text = "SONIDO";
            this.btnSonido.UseVisualStyleBackColor = true;
            this.btnSonido.Click += new System.EventHandler(this.btnSonido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ESTADO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(430, 286);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 16);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Apagado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "REPRODUCIENDO:";
            // 
            // lblReproduciendo
            // 
            this.lblReproduciendo.AutoSize = true;
            this.lblReproduciendo.Location = new System.Drawing.Point(462, 540);
            this.lblReproduciendo.Name = "lblReproduciendo";
            this.lblReproduciendo.Size = new System.Drawing.Size(11, 16);
            this.lblReproduciendo.TabIndex = 11;
            this.lblReproduciendo.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 599);
            this.Controls.Add(this.lblReproduciendo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSonido);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnTablet);
            this.Controls.Add(this.btnSmartTv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmartTv;
        private System.Windows.Forms.Button btnTablet;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnSonido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReproduciendo;
    }
}

