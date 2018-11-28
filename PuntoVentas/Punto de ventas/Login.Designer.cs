namespace Punto_de_ventas
{
    partial class Login
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
            this.tbx_usuario = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_pass = new System.Windows.Forms.TextBox();
            this.button_BuscarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_usuario
            // 
            this.tbx_usuario.Location = new System.Drawing.Point(13, 91);
            this.tbx_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_usuario.Multiline = true;
            this.tbx_usuario.Name = "tbx_usuario";
            this.tbx_usuario.Size = new System.Drawing.Size(231, 30);
            this.tbx_usuario.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.SteelBlue;
            this.label22.Location = new System.Drawing.Point(13, 9);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(231, 39);
            this.label22.TabIndex = 12;
            this.label22.Text = "Iniciar sesión";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Teal;
            this.label47.Location = new System.Drawing.Point(92, 67);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(67, 20);
            this.label47.TabIndex = 33;
            this.label47.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(80, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Contraseña";
            // 
            // tbx_pass
            // 
            this.tbx_pass.Location = new System.Drawing.Point(13, 149);
            this.tbx_pass.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_pass.Multiline = true;
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.PasswordChar = '*';
            this.tbx_pass.Size = new System.Drawing.Size(231, 30);
            this.tbx_pass.TabIndex = 34;
            // 
            // button_BuscarProducto
            // 
            this.button_BuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuscarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_BuscarProducto.Location = new System.Drawing.Point(57, 187);
            this.button_BuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.button_BuscarProducto.Name = "button_BuscarProducto";
            this.button_BuscarProducto.Size = new System.Drawing.Size(141, 28);
            this.button_BuscarProducto.TabIndex = 36;
            this.button_BuscarProducto.Text = "Iniciar Sesión";
            this.button_BuscarProducto.UseVisualStyleBackColor = true;
            this.button_BuscarProducto.Click += new System.EventHandler(this.button_BuscarProducto_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 224);
            this.Controls.Add(this.button_BuscarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_pass);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.tbx_usuario);
            this.Controls.Add(this.label22);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_usuario;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_pass;
        private System.Windows.Forms.Button button_BuscarProducto;
    }
}