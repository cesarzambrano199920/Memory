
namespace Memory
{
    partial class Respuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Respuesta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.picBien1 = new System.Windows.Forms.PictureBox();
            this.picMal2 = new System.Windows.Forms.PictureBox();
            this.picBien2 = new System.Windows.Forms.PictureBox();
            this.picMal1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBien1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMal1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 2;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(436, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(75, 41);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "--";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(517, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 41);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(30, 159);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(538, 54);
            this.txtRespuesta.TabIndex = 1;
            this.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespuesta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Respuesta";
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.Silver;
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprobar.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.Location = new System.Drawing.Point(186, 248);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(227, 56);
            this.btnComprobar.TabIndex = 3;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // picBien1
            // 
            this.picBien1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBien1.BackgroundImage")));
            this.picBien1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBien1.Location = new System.Drawing.Point(30, 234);
            this.picBien1.Name = "picBien1";
            this.picBien1.Size = new System.Drawing.Size(100, 100);
            this.picBien1.TabIndex = 4;
            this.picBien1.TabStop = false;
            this.picBien1.Visible = false;
            // 
            // picMal2
            // 
            this.picMal2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMal2.BackgroundImage")));
            this.picMal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMal2.Location = new System.Drawing.Point(30, 234);
            this.picMal2.Name = "picMal2";
            this.picMal2.Size = new System.Drawing.Size(100, 100);
            this.picMal2.TabIndex = 5;
            this.picMal2.TabStop = false;
            this.picMal2.Visible = false;
            // 
            // picBien2
            // 
            this.picBien2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBien2.BackgroundImage")));
            this.picBien2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBien2.Location = new System.Drawing.Point(468, 234);
            this.picBien2.Name = "picBien2";
            this.picBien2.Size = new System.Drawing.Size(100, 100);
            this.picBien2.TabIndex = 6;
            this.picBien2.TabStop = false;
            this.picBien2.Visible = false;
            // 
            // picMal1
            // 
            this.picMal1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMal1.BackgroundImage")));
            this.picMal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMal1.Location = new System.Drawing.Point(468, 234);
            this.picMal1.Name = "picMal1";
            this.picMal1.Size = new System.Drawing.Size(100, 100);
            this.picMal1.TabIndex = 7;
            this.picMal1.TabStop = false;
            this.picMal1.Visible = false;
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.picMal1);
            this.Controls.Add(this.picBien2);
            this.Controls.Add(this.picMal2);
            this.Controls.Add(this.picBien1);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Respuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respuesta";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBien1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMal1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.PictureBox picBien1;
        private System.Windows.Forms.PictureBox picMal2;
        private System.Windows.Forms.PictureBox picBien2;
        private System.Windows.Forms.PictureBox picMal1;
    }
}