namespace GerenciadorDeOvni
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.TextBox();
            this.txbAbduzidos = new System.Windows.Forms.TextBox();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnInicial = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(91, 65);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(116, 13);
            this.lblTripulantes.TabIndex = 0;
            this.lblTripulantes.Text = "Máximo de Tripulantes:";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Location = new System.Drawing.Point(213, 62);
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(100, 20);
            this.txbTripulantes.TabIndex = 1;
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Location = new System.Drawing.Point(213, 88);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(100, 20);
            this.txbAbduzidos.TabIndex = 3;
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(91, 91);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(113, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Máximo de Abduzidos:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(91, 117);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(97, 13);
            this.lblPlaneta.TabIndex = 4;
            this.lblPlaneta.Text = "Planeta de Origem:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(213, 115);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(100, 21);
            this.cmbPlanetas.TabIndex = 5;
            // 
            // btnInicial
            // 
            this.btnInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicial.ForeColor = System.Drawing.Color.Firebrick;
            this.btnInicial.Location = new System.Drawing.Point(94, 159);
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Size = new System.Drawing.Size(240, 41);
            this.btnInicial.TabIndex = 6;
            this.btnInicial.Text = "Iniciar";
            this.btnInicial.UseVisualStyleBackColor = true;
            this.btnInicial.Click += new System.EventHandler(this.btnInicial_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(65, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(303, 33);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "UFO MANAGER 5000";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(429, 262);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnInicial);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblTripulantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.TextBox txbTripulantes;
        private System.Windows.Forms.TextBox txbAbduzidos;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnInicial;
        private System.Windows.Forms.Label lblName;
    }
}