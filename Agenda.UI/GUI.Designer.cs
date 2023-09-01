namespace Agenda.UI
{
    partial class GUI
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
            this.lblContatoNovo = new System.Windows.Forms.Label();
            this.txtContatoNovo = new System.Windows.Forms.TextBox();
            this.lblContatoSalvo = new System.Windows.Forms.Label();
            this.textContatoSalvo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContatoNovo
            // 
            this.lblContatoNovo.AutoSize = true;
            this.lblContatoNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblContatoNovo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContatoNovo.Location = new System.Drawing.Point(12, 9);
            this.lblContatoNovo.Name = "lblContatoNovo";
            this.lblContatoNovo.Size = new System.Drawing.Size(75, 15);
            this.lblContatoNovo.TabIndex = 0;
            this.lblContatoNovo.Text = "Contato Novo";
            this.lblContatoNovo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContatoNovo
            // 
            this.txtContatoNovo.Location = new System.Drawing.Point(13, 28);
            this.txtContatoNovo.Name = "txtContatoNovo";
            this.txtContatoNovo.Size = new System.Drawing.Size(264, 20);
            this.txtContatoNovo.TabIndex = 1;
            // 
            // lblContatoSalvo
            // 
            this.lblContatoSalvo.AutoSize = true;
            this.lblContatoSalvo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContatoSalvo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContatoSalvo.Location = new System.Drawing.Point(13, 69);
            this.lblContatoSalvo.Name = "lblContatoSalvo";
            this.lblContatoSalvo.Size = new System.Drawing.Size(76, 15);
            this.lblContatoSalvo.TabIndex = 2;
            this.lblContatoSalvo.Text = "Contato Salvo";
            // 
            // textContatoSalvo
            // 
            this.textContatoSalvo.Location = new System.Drawing.Point(12, 87);
            this.textContatoSalvo.Name = "textContatoSalvo";
            this.textContatoSalvo.Size = new System.Drawing.Size(261, 20);
            this.textContatoSalvo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalvar.Location = new System.Drawing.Point(13, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SAVE";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textContatoSalvo);
            this.Controls.Add(this.lblContatoSalvo);
            this.Controls.Add(this.txtContatoNovo);
            this.Controls.Add(this.lblContatoNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContatoNovo;
        private System.Windows.Forms.TextBox txtContatoNovo;
        private System.Windows.Forms.Label lblContatoSalvo;
        private System.Windows.Forms.TextBox textContatoSalvo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

