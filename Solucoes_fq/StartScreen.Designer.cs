
namespace Solucoes_fq
{
    partial class StartScreen
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
            this.btnComeçar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFormula = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComeçar
            // 
            this.btnComeçar.BackColor = System.Drawing.Color.Transparent;
            this.btnComeçar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComeçar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComeçar.ForeColor = System.Drawing.Color.White;
            this.btnComeçar.Location = new System.Drawing.Point(12, 151);
            this.btnComeçar.Name = "btnComeçar";
            this.btnComeçar.Size = new System.Drawing.Size(120, 47);
            this.btnComeçar.TabIndex = 0;
            this.btnComeçar.Text = "Começar";
            this.btnComeçar.UseVisualStyleBackColor = false;
            this.btnComeçar.Click += new System.EventHandler(this.btnComeçar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(23, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Soluções";
            // 
            // btnFormula
            // 
            this.btnFormula.BackColor = System.Drawing.Color.Transparent;
            this.btnFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormula.ForeColor = System.Drawing.Color.White;
            this.btnFormula.Location = new System.Drawing.Point(12, 217);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.Size = new System.Drawing.Size(120, 47);
            this.btnFormula.TabIndex = 2;
            this.btnFormula.Text = "Fórmula";
            this.btnFormula.UseVisualStyleBackColor = false;
            this.btnFormula.Click += new System.EventHandler(this.btnFormula_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(12, 289);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 47);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Solucoes_fq.Properties.Resources.IUPAC_feature_image_1400x600;
            this.ClientSize = new System.Drawing.Size(755, 516);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFormula);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnComeçar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soluções";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComeçar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFormula;
        private System.Windows.Forms.Button btnSair;
    }
}

