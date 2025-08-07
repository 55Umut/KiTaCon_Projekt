using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;

namespace KiTaCon
{
    public partial class DashboardForm : Form
    {
        private User _user;

        public DashboardForm(User user)
        {
            InitializeComponent();
            _user = user;
            lblWillkommen.Text = $"Willkommen, {_user.Benutzername}";
            InitialisiereTabs();
            btnNachrichtSenden.Click += BtnNachrichtSenden_Click;
            btnAbholungSpeichern.Click += BtnAbholungSpeichern_Click;
            btnEinstellungenSpeichern.Click += BtnEinstellungenSpeichern_Click;
            btnDienstplanSpeichern.Click += BtnDienstplanSpeichern_Click;
            btnEssensplanSpeichern.Click += BtnEssensplanSpeichern_Click;
        }

        private void InitialisiereTabs()
        {
            lstAktivitaeten.Columns.Add("Zeit", 150);
            lstAktivitaeten.Columns.Add("Beschreibung", 500);
            lstBerichte.Columns.Add("Datum", 150);
            lstBerichte.Columns.Add("Bericht", 500);
            lstNachrichten.Columns.Add("Absender", 150);
            lstNachrichten.Columns.Add("Nachricht", 500);
            lstDienstplaene.Columns.Add("Datum", 150);
            lstDienstplaene.Columns.Add("Schicht", 500);
            lstEssensplaene.Columns.Add("Datum", 150);
            lstEssensplaene.Columns.Add("Speise", 500);
            LadeAktivitaeten();
            LadeBerichte();
            calKalender.DateSelected += (s, e) => LadeEreignisse(e.Start);
            LadeNachrichten();
            LadeGalerie();
            LadeDienstplaene();
            LadeEssensplaene();
            dtpAbholzeit.Value = DateTime.Now;
            txtBenutzernameEinstellung.Text = _user.Benutzername;
            if (_user.Rolle != "Erzieher")
            {
                tabControl.TabPages.Remove(tabDienstplaene);
            }
        }

        private void LadeAktivitaeten()
        {
            lstAktivitaeten.Items.Clear();
            string query = _user.Rolle == "Eltern"
                ? "SELECT a.* FROM aktivitaeten a JOIN kinder k ON a.kind_id = k.id WHERE k.eltern_id = @userId AND k.kita_id = @kitaId"
                : "SELECT a.* FROM aktivitaeten a JOIN kinder k ON a.kind_id = k.id WHERE k.kita_id = @kitaId";
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@userId", _user.Id),
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["zeit"].ToString());
                        item.SubItems.Add(reader["beschreibung"].ToString());
                        lstAktivitaeten.Items.Add(item);
                    }
                }
            }
        }

        private void LadeBerichte()
        {
            lstBerichte.Items.Clear();
            string query = _user.Rolle == "Eltern"
                ? "SELECT e.* FROM entwicklungsberichte e JOIN kinder k ON e.kind_id = k.id WHERE k.eltern_id = @userId AND k.kita_id = @kitaId"
                : "SELECT e.* FROM entwicklungsberichte e JOIN kinder k ON e.kind_id = k.id WHERE k.kita_id = @kitaId";
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@userId", _user.Id),
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["datum"].ToString());
                        item.SubItems.Add(reader["bericht"].ToString());
                        lstBerichte.Items.Add(item);
                    }
                }
            }
        }

        private void LadeEreignisse(DateTime date)
        {
            string query = "SELECT * FROM ereignisse WHERE DATE(datum) = @datum";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@datum", date.Date)))
            {
                if (reader != null && reader.Read())
                {
                    MessageBox.Show($"Ereignis: {reader["titel"]}\n{reader["beschreibung"]}", "Kalender");
                }
            }
        }

        private void LadeNachrichten()
        {
            lstNachrichten.Items.Clear();
            string query = "SELECT n.*, u.benutzername FROM nachrichten n JOIN users u ON n.absender_id = u.id WHERE n.empfanger_id = @userId AND u.kita_id = @kitaId";
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@userId", _user.Id),
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["benutzername"].ToString());
                        item.SubItems.Add(reader["nachricht"].ToString());
                        lstNachrichten.Items.Add(item);
                    }
                }
            }
        }

        private void LadeGalerie()
        {
            string query = _user.Rolle == "Eltern"
                ? "SELECT f.* FROM fotos f JOIN kinder k ON f.kind_id = k.id WHERE k.eltern_id = @userId AND k.kita_id = @kitaId"
                : "SELECT f.* FROM fotos f JOIN kinder k ON f.kind_id = k.id WHERE k.kita_id = @kitaId";
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@userId", _user.Id),
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null && reader.Read())
                {
                    string path = reader["dateipfad"].ToString();
                    if (File.Exists(path))
                    {
                        picGalerie.Image = Image.FromFile(path);
                    }
                }
            }
        }

        private void LadeDienstplaene()
        {
            lstDienstplaene.Items.Clear();
            string query = "SELECT * FROM dienstplaene WHERE erzieher_id = @userId AND kita_id = @kitaId";
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@userId", _user.Id),
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["datum"].ToString());
                        item.SubItems.Add(reader["schicht"].ToString());
                        lstDienstplaene.Items.Add(item);
                    }
                }
            }
        }

        private void LadeEssensplaene()
        {
            lstEssensplaene.Items.Clear();
            string query = "SELECT * FROM essensplaene WHERE kita_id = @kitaId";
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["datum"].ToString());
                        item.SubItems.Add(reader["speise"].ToString());
                        lstEssensplaene.Items.Add(item);
                    }
                }
            }
        }

        private void BtnNachrichtSenden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNachrichtEingabe.Text)) return;
            string query = "SELECT id FROM users WHERE rolle != @rolle AND kita_id = @kitaId LIMIT 1";
            int empfangerId;
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@rolle", _user.Rolle),
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null && reader.Read())
                {
                    empfangerId = reader.GetInt32("id");
                }
                else return;
            }
            var nachricht = new Nachricht();
            nachricht.CreateNachricht(_user.Id, empfangerId, txtNachrichtEingabe.Text, DateTime.Now);
            txtNachrichtEingabe.Clear();
            LadeNachrichten();
        }

        private void BtnAbholungSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAbholerName.Text)) return;
            string query = "SELECT id FROM kinder WHERE eltern_id = @userId AND kita_id = @kitaId LIMIT 1";
            int kindId;
            using (var reader = DBConnection.Instance.ExecuteReader(query,
                new MySqlParameter("@userId", _user.Id),
                new MySqlParameter("@kitaId", _user.KitaId)))
            {
                if (reader != null && reader.Read())
                {
                    kindId = reader.GetInt32("id");
                }
                else return;
            }
            var abholung = new Abholung();
            abholung.CreateAbholung(kindId, txtAbholerName.Text, dtpAbholzeit.Value);
            MessageBox.Show("Abholung gespeichert!", "Erfolg");
        }

        private void BtnEinstellungenSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBenutzernameEinstellung.Text) || string.IsNullOrEmpty(txtPasswortEinstellung.Text)) return;
            var user = new User();
            user.UpdateUser(_user.Id, txtBenutzernameEinstellung.Text, txtPasswortEinstellung.Text, _user.Rolle, _user.KitaId);
            MessageBox.Show("Einstellungen gespeichert!", "Erfolg");
        }

        private void BtnDienstplanSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSchicht.Text)) return;
            var dienstplan = new Dienstplan();
            dienstplan.CreateDienstplan(_user.Id, _user.KitaId, dtpDienstplanDatum.Value, txtSchicht.Text);
            MessageBox.Show("Dienstplan gespeichert!", "Erfolg");
            LadeDienstplaene();
        }

        private void BtnEssensplanSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSpeise.Text)) return;
            var essensplan = new Essensplan();
            essensplan.CreateEssensplan(_user.KitaId, dtpEssensplanDatum.Value, txtSpeise.Text);
            MessageBox.Show("Essensplan gespeichert!", "Erfolg");
            LadeEssensplaene();
        }
    }
}