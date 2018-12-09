namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picWebCam
            // 
            this.picWebCam.BackColor = System.Drawing.Color.White;
            this.picWebCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picWebCam.Location = new System.Drawing.Point(12, 22);
            this.picWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(581, 400);
            this.picWebCam.TabIndex = 0;
            this.picWebCam.TabStop = false;
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.Location = new System.Drawing.Point(608, 22);
            this.picImagem.Margin = new System.Windows.Forms.Padding(4);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(581, 400);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.Location = new System.Drawing.Point(12, 436);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(581, 55);
            this.btnCaptura.TabIndex = 2;
            this.btnCaptura.Text = "Capturar Imagem";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(608, 436);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(581, 55);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar Imagem";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 511);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.picWebCam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturando Imagem da WebCam";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Button btnSalvar;
    }
}

