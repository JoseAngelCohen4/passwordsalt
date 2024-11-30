namespace PasswordSalt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TxtUsuario = new TextBox();
            TxtContrasena = new TextBox();
            BtnGuardar = new Button();
            label3 = new Label();
            label4 = new Label();
            TxtUsuarioGuardado = new TextBox();
            TxtContrasenaGuardado = new TextBox();
            label5 = new Label();
            TxtSaltGuardado = new TextBox();
            BtnValidar = new Button();
            label7 = new Label();
            TxtContrasenaValidar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 0;
            label2.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(88, 31);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(700, 23);
            TxtUsuario.TabIndex = 1;
            // 
            // TxtContrasena
            // 
            TxtContrasena.Location = new Point(88, 73);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.PasswordChar = '*';
            TxtContrasena.Size = new Size(700, 23);
            TxtContrasena.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(59, 139);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 233);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 0;
            label4.Text = "Contraseña:";
            // 
            // TxtUsuarioGuardado
            // 
            TxtUsuarioGuardado.Location = new Point(88, 188);
            TxtUsuarioGuardado.Name = "TxtUsuarioGuardado";
            TxtUsuarioGuardado.Size = new Size(700, 23);
            TxtUsuarioGuardado.TabIndex = 3;
            // 
            // TxtContrasenaGuardado
            // 
            TxtContrasenaGuardado.Location = new Point(88, 230);
            TxtContrasenaGuardado.Name = "TxtContrasenaGuardado";
            TxtContrasenaGuardado.Size = new Size(700, 23);
            TxtContrasenaGuardado.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 276);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 0;
            label5.Text = "Salt";
            // 
            // TxtSaltGuardado
            // 
            TxtSaltGuardado.Location = new Point(88, 273);
            TxtSaltGuardado.Name = "TxtSaltGuardado";
            TxtSaltGuardado.Size = new Size(700, 23);
            TxtSaltGuardado.TabIndex = 5;
            // 
            // BtnValidar
            // 
            BtnValidar.Location = new Point(59, 387);
            BtnValidar.Name = "BtnValidar";
            BtnValidar.Size = new Size(75, 23);
            BtnValidar.TabIndex = 6;
            BtnValidar.Text = "Validar";
            BtnValidar.UseVisualStyleBackColor = true;
            BtnValidar.Click += BtnValidar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 350);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 0;
            label7.Text = "Contraseña:";
            // 
            // TxtContrasenaValidar
            // 
            TxtContrasenaValidar.Location = new Point(88, 347);
            TxtContrasenaValidar.Name = "TxtContrasenaValidar";
            TxtContrasenaValidar.Size = new Size(700, 23);
            TxtContrasenaValidar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnValidar);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtSaltGuardado);
            Controls.Add(TxtContrasenaGuardado);
            Controls.Add(TxtUsuarioGuardado);
            Controls.Add(label5);
            Controls.Add(TxtContrasenaValidar);
            Controls.Add(TxtContrasena);
            Controls.Add(label4);
            Controls.Add(TxtUsuario);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtUsuario;
        private TextBox TxtContrasena;
        private Button BtnGuardar;
        private Label label3;
        private Label label4;
        private TextBox TxtUsuarioGuardado;
        private TextBox TxtContrasenaGuardado;
        private Label label5;
        private TextBox TxtSaltGuardado;
        private Button BtnValidar;
        private Label label7;
        private TextBox TxtContrasenaValidar;
    }
}
