namespace KiTaCon
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtBenutzername = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.txtRegistrierungsname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRegistrierungsPasswort = new System.Windows.Forms.TextBox();
            this.txtPasswortWiederholen = new System.Windows.Forms.TextBox();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.cboRolle = new System.Windows.Forms.ComboBox();
            this.cboKita = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBenutzername
            // 
            this.txtBenutzername.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBenutzername.Location = new System.Drawing.Point(58, 68);
            this.txtBenutzername.Margin = new System.Windows.Forms.Padding(4);
            this.txtBenutzername.Name = "txtBenutzername";
            this.txtBenutzername.Size = new System.Drawing.Size(265, 27);
            this.txtBenutzername.TabIndex = 0;
            this.txtBenutzername.Text = "Benutzername";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPasswort.Location = new System.Drawing.Point(58, 113);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(265, 27);
            this.txtPasswort.TabIndex = 1;
            this.txtPasswort.Text = "Passwort";
            this.txtPasswort.UseSystemPasswordChar = true;
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAnmelden.Location = new System.Drawing.Point(58, 163);
            this.btnAnmelden.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(265, 37);
            this.btnAnmelden.TabIndex = 2;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::KiTaCon.Properties.Resources.Logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(141, 247);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(101, 113);
            this.pnlLogo.TabIndex = 3;
            // 
            // txtRegistrierungsname
            // 
            this.txtRegistrierungsname.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRegistrierungsname.Location = new System.Drawing.Point(58, 388);
            this.txtRegistrierungsname.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrierungsname.Name = "txtRegistrierungsname";
            this.txtRegistrierungsname.Size = new System.Drawing.Size(265, 27);
            this.txtRegistrierungsname.TabIndex = 4;
            this.txtRegistrierungsname.Text = "Benutzername";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail.Location = new System.Drawing.Point(58, 423);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email";
            // 
            // txtRegistrierungsPasswort
            // 
            this.txtRegistrierungsPasswort.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRegistrierungsPasswort.Location = new System.Drawing.Point(58, 458);
            this.txtRegistrierungsPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrierungsPasswort.Name = "txtRegistrierungsPasswort";
            this.txtRegistrierungsPasswort.Size = new System.Drawing.Size(265, 27);
            this.txtRegistrierungsPasswort.TabIndex = 6;
            this.txtRegistrierungsPasswort.Text = "Passwort";
            this.txtRegistrierungsPasswort.UseSystemPasswordChar = true;
            // 
            // txtPasswortWiederholen
            // 
            this.txtPasswortWiederholen.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPasswortWiederholen.Location = new System.Drawing.Point(58, 493);
            this.txtPasswortWiederholen.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswortWiederholen.Name = "txtPasswortWiederholen";
            this.txtPasswortWiederholen.Size = new System.Drawing.Size(265, 27);
            this.txtPasswortWiederholen.TabIndex = 7;
            this.txtPasswortWiederholen.Text = "Passwort wiederholen";
            this.txtPasswortWiederholen.UseSystemPasswordChar = true;
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.Font = new System.Drawing.Font("Arial", 10F);
            this.btnRegistrieren.Location = new System.Drawing.Point(58, 645);
            this.btnRegistrieren.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(265, 37);
            this.btnRegistrieren.TabIndex = 8;
            this.btnRegistrieren.Text = "Registrieren";
            this.btnRegistrieren.UseVisualStyleBackColor = true;
            // 
            // cboRolle
            // 
            this.cboRolle.Font = new System.Drawing.Font("Arial", 10F);
            this.cboRolle.FormattingEnabled = true;
            this.cboRolle.Items.AddRange(new object[] { "Eltern", "Erzieher" });
            this.cboRolle.Location = new System.Drawing.Point(58, 542);
            this.cboRolle.Name = "cboRolle";
            this.cboRolle.Size = new System.Drawing.Size(265, 27);
            this.cboRolle.TabIndex = 9;
            this.cboRolle.Text = "Rolle auswählen";
            // 
            // cboKita
            // 
            this.cboKita.Font = new System.Drawing.Font("Arial", 10F);
            this.cboKita.FormattingEnabled = true;
            this.cboKita.Location = new System.Drawing.Point(58, 591);
            this.cboKita.Name = "cboKita";
            this.cboKita.Size = new System.Drawing.Size(265, 27);
            this.cboKita.TabIndex = 10;
            this.cboKita.Text = "Kita auswählen";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 720);
            this.Controls.Add(this.cboKita);
            this.Controls.Add(this.cboRolle);
            this.Controls.Add(this.btnRegistrieren);
            this.Controls.Add(this.txtPasswortWiederholen);
            this.Controls.Add(this.txtRegistrierungsPasswort);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRegistrierungsname);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtBenutzername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "KiTaCon Anmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBenutzername;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.TextBox txtRegistrierungsname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRegistrierungsPasswort;
        private System.Windows.Forms.TextBox txtPasswortWiederholen;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.ComboBox cboRolle;
        private System.Windows.Forms.ComboBox cboKita;
    }
}