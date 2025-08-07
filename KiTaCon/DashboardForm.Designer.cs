namespace KiTaCon
{
    partial class DashboardForm
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
            this.lblWillkommen = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTagesueberblick = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lstAktivitaeten = new System.Windows.Forms.ListView();
            this.tabBerichte = new System.Windows.Forms.TabPage();
            this.lstBerichte = new System.Windows.Forms.ListView();
            this.tabKalender = new System.Windows.Forms.TabPage();
            this.calKalender = new System.Windows.Forms.MonthCalendar();
            this.tabNachrichten = new System.Windows.Forms.TabPage();
            this.btnNachrichtSenden = new System.Windows.Forms.Button();
            this.txtNachrichtEingabe = new System.Windows.Forms.TextBox();
            this.lstNachrichten = new System.Windows.Forms.ListView();
            this.tabGalerie = new System.Windows.Forms.TabPage();
            this.picGalerie = new System.Windows.Forms.PictureBox();
            this.tabAbholung = new System.Windows.Forms.TabPage();
            this.btnAbholungSpeichern = new System.Windows.Forms.Button();
            this.dtpAbholzeit = new System.Windows.Forms.DateTimePicker();
            this.txtAbholerName = new System.Windows.Forms.TextBox();
            this.tabDienstplaene = new System.Windows.Forms.TabPage();
            this.btnDienstplanSpeichern = new System.Windows.Forms.Button();
            this.dtpDienstplanDatum = new System.Windows.Forms.DateTimePicker();
            this.txtSchicht = new System.Windows.Forms.TextBox();
            this.lstDienstplaene = new System.Windows.Forms.ListView();
            this.tabEssensplaene = new System.Windows.Forms.TabPage();
            this.btnEssensplanSpeichern = new System.Windows.Forms.Button();
            this.dtpEssensplanDatum = new System.Windows.Forms.DateTimePicker();
            this.txtSpeise = new System.Windows.Forms.TextBox();
            this.lstEssensplaene = new System.Windows.Forms.ListView();
            this.tabEinstellungen = new System.Windows.Forms.TabPage();
            this.btnEinstellungenSpeichern = new System.Windows.Forms.Button();
            this.txtPasswortEinstellung = new System.Windows.Forms.TextBox();
            this.txtBenutzernameEinstellung = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabTagesueberblick.SuspendLayout();
            this.tabBerichte.SuspendLayout();
            this.tabKalender.SuspendLayout();
            this.tabNachrichten.SuspendLayout();
            this.tabGalerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGalerie)).BeginInit();
            this.tabAbholung.SuspendLayout();
            this.tabDienstplaene.SuspendLayout();
            this.tabEssensplaene.SuspendLayout();
            this.tabEinstellungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWillkommen
            // 
            this.lblWillkommen.AutoSize = true;
            this.lblWillkommen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblWillkommen.Location = new System.Drawing.Point(16, 9);
            this.lblWillkommen.Name = "lblWillkommen";
            this.lblWillkommen.Size = new System.Drawing.Size(124, 24);
            this.lblWillkommen.TabIndex = 0;
            this.lblWillkommen.Text = "Willkommen";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::KiTaCon.Properties.Resources.Logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(933, 9);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(64, 76);
            this.pnlLogo.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTagesueberblick);
            this.tabControl.Controls.Add(this.tabBerichte);
            this.tabControl.Controls.Add(this.tabKalender);
            this.tabControl.Controls.Add(this.tabNachrichten);
            this.tabControl.Controls.Add(this.tabGalerie);
            this.tabControl.Controls.Add(this.tabAbholung);
            this.tabControl.Controls.Add(this.tabDienstplaene);
            this.tabControl.Controls.Add(this.tabEssensplaene);
            this.tabControl.Controls.Add(this.tabEinstellungen);
            this.tabControl.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl.Location = new System.Drawing.Point(-1, 66);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1113, 614);
            this.tabControl.TabIndex = 2;
            // 
            // tabTagesueberblick
            // 
            this.tabTagesueberblick.Controls.Add(this.monthCalendar1);
            this.tabTagesueberblick.Controls.Add(this.lstAktivitaeten);
            this.tabTagesueberblick.Location = new System.Drawing.Point(4, 28);
            this.tabTagesueberblick.Name = "tabTagesueberblick";
            this.tabTagesueberblick.Padding = new System.Windows.Forms.Padding(3);
            this.tabTagesueberblick.Size = new System.Drawing.Size(1105, 582);
            this.tabTagesueberblick.TabIndex = 0;
            this.tabTagesueberblick.Text = "Tagesüberblick";
            this.tabTagesueberblick.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(5, 1);
            this.monthCalendar1.Font = new System.Drawing.Font("Arial", 10F);
            this.monthCalendar1.Location = new System.Drawing.Point(3, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // lstAktivitaeten
            // 
            this.lstAktivitaeten.Font = new System.Drawing.Font("Arial", 10F);
            this.lstAktivitaeten.HideSelection = false;
            this.lstAktivitaeten.Location = new System.Drawing.Point(3, 211);
            this.lstAktivitaeten.Name = "lstAktivitaeten";
            this.lstAktivitaeten.Size = new System.Drawing.Size(1046, 368);
            this.lstAktivitaeten.TabIndex = 0;
            this.lstAktivitaeten.UseCompatibleStateImageBehavior = false;
            this.lstAktivitaeten.View = System.Windows.Forms.View.Details;
            // 
            // tabBerichte
            // 
            this.tabBerichte.Controls.Add(this.lstBerichte);
            this.tabBerichte.Location = new System.Drawing.Point(4, 28);
            this.tabBerichte.Name = "tabBerichte";
            this.tabBerichte.Padding = new System.Windows.Forms.Padding(3);
            this.tabBerichte.Size = new System.Drawing.Size(1105, 582);
            this.tabBerichte.TabIndex = 1;
            this.tabBerichte.Text = "Berichte";
            this.tabBerichte.UseVisualStyleBackColor = true;
            // 
            // lstBerichte
            // 
            this.lstBerichte.Font = new System.Drawing.Font("Arial", 10F);
            this.lstBerichte.HideSelection = false;
            this.lstBerichte.Location = new System.Drawing.Point(10, 10);
            this.lstBerichte.Name = "lstBerichte";
            this.lstBerichte.Size = new System.Drawing.Size(1059, 354);
            this.lstBerichte.TabIndex = 0;
            this.lstBerichte.UseCompatibleStateImageBehavior = false;
            this.lstBerichte.View = System.Windows.Forms.View.Details;
            // 
            // tabKalender
            // 
            this.tabKalender.Controls.Add(this.calKalender);
            this.tabKalender.Location = new System.Drawing.Point(4, 28);
            this.tabKalender.Name = "tabKalender";
            this.tabKalender.Padding = new System.Windows.Forms.Padding(3);
            this.tabKalender.Size = new System.Drawing.Size(1105, 582);
            this.tabKalender.TabIndex = 2;
            this.tabKalender.Text = "Kalender";
            this.tabKalender.UseVisualStyleBackColor = true;
            // 
            // calKalender
            // 
            this.calKalender.CalendarDimensions = new System.Drawing.Size(5, 2);
            this.calKalender.Font = new System.Drawing.Font("Arial", 10F);
            this.calKalender.Location = new System.Drawing.Point(10, 10);
            this.calKalender.Name = "calKalender";
            this.calKalender.TabIndex = 0;
            // 
            // tabNachrichten
            // 
            this.tabNachrichten.Controls.Add(this.btnNachrichtSenden);
            this.tabNachrichten.Controls.Add(this.txtNachrichtEingabe);
            this.tabNachrichten.Controls.Add(this.lstNachrichten);
            this.tabNachrichten.Location = new System.Drawing.Point(4, 28);
            this.tabNachrichten.Name = "tabNachrichten";
            this.tabNachrichten.Size = new System.Drawing.Size(1105, 582);
            this.tabNachrichten.TabIndex = 3;
            this.tabNachrichten.Text = "Nachrichten";
            this.tabNachrichten.UseVisualStyleBackColor = true;
            // 
            // btnNachrichtSenden
            // 
            this.btnNachrichtSenden.Font = new System.Drawing.Font("Arial", 10F);
            this.btnNachrichtSenden.Location = new System.Drawing.Point(471, 375);
            this.btnNachrichtSenden.Name = "btnNachrichtSenden";
            this.btnNachrichtSenden.Size = new System.Drawing.Size(90, 27);
            this.btnNachrichtSenden.TabIndex = 2;
            this.btnNachrichtSenden.Text = "Senden";
            this.btnNachrichtSenden.UseVisualStyleBackColor = true;
            // 
            // txtNachrichtEingabe
            // 
            this.txtNachrichtEingabe.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNachrichtEingabe.Location = new System.Drawing.Point(10, 320);
            this.txtNachrichtEingabe.Name = "txtNachrichtEingabe";
            this.txtNachrichtEingabe.Size = new System.Drawing.Size(1059, 27);
            this.txtNachrichtEingabe.TabIndex = 1;
            // 
            // lstNachrichten
            // 
            this.lstNachrichten.Font = new System.Drawing.Font("Arial", 10F);
            this.lstNachrichten.HideSelection = false;
            this.lstNachrichten.Location = new System.Drawing.Point(10, 10);
            this.lstNachrichten.Name = "lstNachrichten";
            this.lstNachrichten.Size = new System.Drawing.Size(1059, 300);
            this.lstNachrichten.TabIndex = 0;
            this.lstNachrichten.UseCompatibleStateImageBehavior = false;
            this.lstNachrichten.View = System.Windows.Forms.View.Details;
            // 
            // tabGalerie
            // 
            this.tabGalerie.Controls.Add(this.picGalerie);
            this.tabGalerie.Location = new System.Drawing.Point(4, 28);
            this.tabGalerie.Name = "tabGalerie";
            this.tabGalerie.Size = new System.Drawing.Size(1105, 582);
            this.tabGalerie.TabIndex = 4;
            this.tabGalerie.Text = "Galerie";
            this.tabGalerie.UseVisualStyleBackColor = true;
            // 
            // picGalerie
            // 
            this.picGalerie.Location = new System.Drawing.Point(10, 10);
            this.picGalerie.Name = "picGalerie";
            this.picGalerie.Size = new System.Drawing.Size(1059, 354);
            this.picGalerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGalerie.TabIndex = 0;
            this.picGalerie.TabStop = false;
            // 
            // tabAbholung
            // 
            this.tabAbholung.Controls.Add(this.btnAbholungSpeichern);
            this.tabAbholung.Controls.Add(this.dtpAbholzeit);
            this.tabAbholung.Controls.Add(this.txtAbholerName);
            this.tabAbholung.Location = new System.Drawing.Point(4, 28);
            this.tabAbholung.Name = "tabAbholung";
            this.tabAbholung.Size = new System.Drawing.Size(1105, 582);
            this.tabAbholung.TabIndex = 5;
            this.tabAbholung.Text = "Abholung";
            this.tabAbholung.UseVisualStyleBackColor = true;
            // 
            // btnAbholungSpeichern
            // 
            this.btnAbholungSpeichern.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAbholungSpeichern.Location = new System.Drawing.Point(235, 185);
            this.btnAbholungSpeichern.Name = "btnAbholungSpeichern";
            this.btnAbholungSpeichern.Size = new System.Drawing.Size(672, 37);
            this.btnAbholungSpeichern.TabIndex = 2;
            this.btnAbholungSpeichern.Text = "Abholung speichern";
            this.btnAbholungSpeichern.UseVisualStyleBackColor = true;
            // 
            // dtpAbholzeit
            // 
            this.dtpAbholzeit.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpAbholzeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAbholzeit.Location = new System.Drawing.Point(235, 102);
            this.dtpAbholzeit.Name = "dtpAbholzeit";
            this.dtpAbholzeit.Size = new System.Drawing.Size(672, 27);
            this.dtpAbholzeit.TabIndex = 1;
            // 
            // txtAbholerName
            // 
            this.txtAbholerName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAbholerName.Location = new System.Drawing.Point(235, 30);
            this.txtAbholerName.Name = "txtAbholerName";
            this.txtAbholerName.Size = new System.Drawing.Size(672, 27);
            this.txtAbholerName.TabIndex = 0;
            this.txtAbholerName.Text = "Name des Abholers";
            // 
            // tabDienstplaene
            // 
            this.tabDienstplaene.Controls.Add(this.btnDienstplanSpeichern);
            this.tabDienstplaene.Controls.Add(this.dtpDienstplanDatum);
            this.tabDienstplaene.Controls.Add(this.txtSchicht);
            this.tabDienstplaene.Controls.Add(this.lstDienstplaene);
            this.tabDienstplaene.Location = new System.Drawing.Point(4, 28);
            this.tabDienstplaene.Name = "tabDienstplaene";
            this.tabDienstplaene.Size = new System.Drawing.Size(1105, 582);
            this.tabDienstplaene.TabIndex = 6;
            this.tabDienstplaene.Text = "Dienstpläne";
            this.tabDienstplaene.UseVisualStyleBackColor = true;
            // 
            // btnDienstplanSpeichern
            // 
            this.btnDienstplanSpeichern.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDienstplanSpeichern.Location = new System.Drawing.Point(225, 441);
            this.btnDienstplanSpeichern.Name = "btnDienstplanSpeichern";
            this.btnDienstplanSpeichern.Size = new System.Drawing.Size(672, 37);
            this.btnDienstplanSpeichern.TabIndex = 3;
            this.btnDienstplanSpeichern.Text = "Dienstplan speichern";
            this.btnDienstplanSpeichern.UseVisualStyleBackColor = true;
            // 
            // dtpDienstplanDatum
            // 
            this.dtpDienstplanDatum.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpDienstplanDatum.Location = new System.Drawing.Point(10, 360);
            this.dtpDienstplanDatum.Name = "dtpDienstplanDatum";
            this.dtpDienstplanDatum.Size = new System.Drawing.Size(1059, 27);
            this.dtpDienstplanDatum.TabIndex = 2;
            // 
            // txtSchicht
            // 
            this.txtSchicht.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSchicht.Location = new System.Drawing.Point(10, 320);
            this.txtSchicht.Name = "txtSchicht";
            this.txtSchicht.Size = new System.Drawing.Size(1059, 27);
            this.txtSchicht.TabIndex = 1;
            this.txtSchicht.Text = "Schicht";
            // 
            // lstDienstplaene
            // 
            this.lstDienstplaene.Font = new System.Drawing.Font("Arial", 10F);
            this.lstDienstplaene.HideSelection = false;
            this.lstDienstplaene.Location = new System.Drawing.Point(10, 10);
            this.lstDienstplaene.Name = "lstDienstplaene";
            this.lstDienstplaene.Size = new System.Drawing.Size(1059, 300);
            this.lstDienstplaene.TabIndex = 0;
            this.lstDienstplaene.UseCompatibleStateImageBehavior = false;
            this.lstDienstplaene.View = System.Windows.Forms.View.Details;
            // 
            // tabEssensplaene
            // 
            this.tabEssensplaene.Controls.Add(this.btnEssensplanSpeichern);
            this.tabEssensplaene.Controls.Add(this.dtpEssensplanDatum);
            this.tabEssensplaene.Controls.Add(this.txtSpeise);
            this.tabEssensplaene.Controls.Add(this.lstEssensplaene);
            this.tabEssensplaene.Location = new System.Drawing.Point(4, 28);
            this.tabEssensplaene.Name = "tabEssensplaene";
            this.tabEssensplaene.Size = new System.Drawing.Size(1105, 582);
            this.tabEssensplaene.TabIndex = 7;
            this.tabEssensplaene.Text = "Essenspläne";
            this.tabEssensplaene.UseVisualStyleBackColor = true;
            // 
            // btnEssensplanSpeichern
            // 
            this.btnEssensplanSpeichern.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEssensplanSpeichern.Location = new System.Drawing.Point(247, 441);
            this.btnEssensplanSpeichern.Name = "btnEssensplanSpeichern";
            this.btnEssensplanSpeichern.Size = new System.Drawing.Size(672, 37);
            this.btnEssensplanSpeichern.TabIndex = 3;
            this.btnEssensplanSpeichern.Text = "Essensplan speichern";
            this.btnEssensplanSpeichern.UseVisualStyleBackColor = true;
            // 
            // dtpEssensplanDatum
            // 
            this.dtpEssensplanDatum.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpEssensplanDatum.Location = new System.Drawing.Point(10, 360);
            this.dtpEssensplanDatum.Name = "dtpEssensplanDatum";
            this.dtpEssensplanDatum.Size = new System.Drawing.Size(1072, 27);
            this.dtpEssensplanDatum.TabIndex = 2;
            // 
            // txtSpeise
            // 
            this.txtSpeise.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSpeise.Location = new System.Drawing.Point(10, 320);
            this.txtSpeise.Name = "txtSpeise";
            this.txtSpeise.Size = new System.Drawing.Size(1072, 27);
            this.txtSpeise.TabIndex = 1;
            this.txtSpeise.Text = "Speise";
            // 
            // lstEssensplaene
            // 
            this.lstEssensplaene.Font = new System.Drawing.Font("Arial", 10F);
            this.lstEssensplaene.HideSelection = false;
            this.lstEssensplaene.Location = new System.Drawing.Point(10, 10);
            this.lstEssensplaene.Name = "lstEssensplaene";
            this.lstEssensplaene.Size = new System.Drawing.Size(1072, 300);
            this.lstEssensplaene.TabIndex = 0;
            this.lstEssensplaene.UseCompatibleStateImageBehavior = false;
            this.lstEssensplaene.View = System.Windows.Forms.View.Details;
            // 
            // tabEinstellungen
            // 
            this.tabEinstellungen.Controls.Add(this.btnEinstellungenSpeichern);
            this.tabEinstellungen.Controls.Add(this.txtPasswortEinstellung);
            this.tabEinstellungen.Controls.Add(this.txtBenutzernameEinstellung);
            this.tabEinstellungen.Location = new System.Drawing.Point(4, 28);
            this.tabEinstellungen.Name = "tabEinstellungen";
            this.tabEinstellungen.Size = new System.Drawing.Size(1105, 582);
            this.tabEinstellungen.TabIndex = 8;
            this.tabEinstellungen.Text = "Einstellungen";
            this.tabEinstellungen.UseVisualStyleBackColor = true;
            // 
            // btnEinstellungenSpeichern
            // 
            this.btnEinstellungenSpeichern.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEinstellungenSpeichern.Location = new System.Drawing.Point(10, 90);
            this.btnEinstellungenSpeichern.Name = "btnEinstellungenSpeichern";
            this.btnEinstellungenSpeichern.Size = new System.Drawing.Size(672, 37);
            this.btnEinstellungenSpeichern.TabIndex = 2;
            this.btnEinstellungenSpeichern.Text = "Einstellungen speichern";
            this.btnEinstellungenSpeichern.UseVisualStyleBackColor = true;
            // 
            // txtPasswortEinstellung
            // 
            this.txtPasswortEinstellung.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPasswortEinstellung.Location = new System.Drawing.Point(10, 50);
            this.txtPasswortEinstellung.Name = "txtPasswortEinstellung";
            this.txtPasswortEinstellung.Size = new System.Drawing.Size(672, 27);
            this.txtPasswortEinstellung.TabIndex = 1;
            this.txtPasswortEinstellung.Text = "Passwort";
            this.txtPasswortEinstellung.UseSystemPasswordChar = true;
            // 
            // txtBenutzernameEinstellung
            // 
            this.txtBenutzernameEinstellung.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBenutzernameEinstellung.Location = new System.Drawing.Point(10, 10);
            this.txtBenutzernameEinstellung.Name = "txtBenutzernameEinstellung";
            this.txtBenutzernameEinstellung.Size = new System.Drawing.Size(672, 27);
            this.txtBenutzernameEinstellung.TabIndex = 0;
            this.txtBenutzernameEinstellung.Text = "Benutzername";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1111, 746);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblWillkommen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DashboardForm";
            this.Text = "KiTaCon Dashboard";
            this.tabControl.ResumeLayout(false);
            this.tabTagesueberblick.ResumeLayout(false);
            this.tabBerichte.ResumeLayout(false);
            this.tabKalender.ResumeLayout(false);
            this.tabNachrichten.ResumeLayout(false);
            this.tabNachrichten.PerformLayout();
            this.tabGalerie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGalerie)).EndInit();
            this.tabAbholung.ResumeLayout(false);
            this.tabAbholung.PerformLayout();
            this.tabDienstplaene.ResumeLayout(false);
            this.tabDienstplaene.PerformLayout();
            this.tabEssensplaene.ResumeLayout(false);
            this.tabEssensplaene.PerformLayout();
            this.tabEinstellungen.ResumeLayout(false);
            this.tabEinstellungen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MonthCalendar monthCalendar1;

        private System.Windows.Forms.Label lblWillkommen;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTagesueberblick;
        private System.Windows.Forms.TabPage tabBerichte;
        private System.Windows.Forms.TabPage tabKalender;
        private System.Windows.Forms.TabPage tabNachrichten;
        private System.Windows.Forms.TabPage tabGalerie;
        private System.Windows.Forms.TabPage tabAbholung;
        private System.Windows.Forms.TabPage tabDienstplaene;
        private System.Windows.Forms.TabPage tabEssensplaene;
        private System.Windows.Forms.TabPage tabEinstellungen;
        private System.Windows.Forms.ListView lstAktivitaeten;
        private System.Windows.Forms.ListView lstBerichte;
        private System.Windows.Forms.MonthCalendar calKalender;
        private System.Windows.Forms.ListView lstNachrichten;
        private System.Windows.Forms.TextBox txtNachrichtEingabe;
        private System.Windows.Forms.Button btnNachrichtSenden;
        private System.Windows.Forms.PictureBox picGalerie;
        private System.Windows.Forms.TextBox txtAbholerName;
        private System.Windows.Forms.DateTimePicker dtpAbholzeit;
        private System.Windows.Forms.Button btnAbholungSpeichern;
        private System.Windows.Forms.TextBox txtBenutzernameEinstellung;
        private System.Windows.Forms.TextBox txtPasswortEinstellung;
        private System.Windows.Forms.Button btnEinstellungenSpeichern;
        private System.Windows.Forms.ListView lstDienstplaene;
        private System.Windows.Forms.TextBox txtSchicht;
        private System.Windows.Forms.DateTimePicker dtpDienstplanDatum;
        private System.Windows.Forms.Button btnDienstplanSpeichern;
        private System.Windows.Forms.ListView lstEssensplaene;
        private System.Windows.Forms.TextBox txtSpeise;
        private System.Windows.Forms.DateTimePicker dtpEssensplanDatum;
        private System.Windows.Forms.Button btnEssensplanSpeichern;
    }
}