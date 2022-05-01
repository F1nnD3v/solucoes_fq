
namespace Solucoes_fq
{
    partial class lab
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
            this.barAddSoluto = new System.Windows.Forms.VScrollBar();
            this.btnSolucao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barAddSoluto
            // 
            this.barAddSoluto.Location = new System.Drawing.Point(303, 177);
            this.barAddSoluto.Name = "barAddSoluto";
            this.barAddSoluto.Size = new System.Drawing.Size(17, 80);
            this.barAddSoluto.TabIndex = 0;
            this.barAddSoluto.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barAddSoluto_Scroll);
            // 
            // btnSolucao
            // 
            this.btnSolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolucao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSolucao.Location = new System.Drawing.Point(468, 247);
            this.btnSolucao.Name = "btnSolucao";
            this.btnSolucao.Size = new System.Drawing.Size(82, 10);
            this.btnSolucao.TabIndex = 1;
            this.btnSolucao.UseVisualStyleBackColor = false;
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSolucao);
            this.Controls.Add(this.barAddSoluto);
            this.Name = "lab";
            this.Text = "lab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar barAddSoluto;
        private System.Windows.Forms.Button btnSolucao;
    }
}