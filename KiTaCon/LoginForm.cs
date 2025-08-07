using System;
using System.Windows.Forms;
using System.Drawing;

namespace KiTaCon
{
public partial class LoginForm : Form
{
public LoginForm()
{
InitializeComponent();
btnRegistrieren.Click += btnRegister_Click;
LadeKitas();
InitializeDesignEvents();
}

private void InitializeDesignEvents()
{
ConfigureTextBoxPlaceholder(txtBenutzername, "Benutzername");
ConfigureTextBoxPlaceholder(txtPasswort, "Passwort");
ConfigureTextBoxPlaceholder(txtRegistrierungsname, "Benutzername");
ConfigureTextBoxPlaceholder(txtEmail, "Email");
ConfigureTextBoxPlaceholder(txtRegistrierungsPasswort, "Passwort");
ConfigureTextBoxPlaceholder(txtPasswortWiederholen, "Passwort wiederholen");

ConfigureButtonHover(btnAnmelden);
ConfigureButtonHover(btnRegistrieren);
}

private void ConfigureTextBoxPlaceholder(TextBox textBox, string placeholder)
{
textBox.ForeColor = Color.Gray;
textBox.Text = placeholder;
bool isPasswordField = textBox == txtPasswort || textBox == txtRegistrierungsPasswort || textBox == txtPasswortWiederholen;

if (isPasswordField)
textBox.UseSystemPasswordChar = false;

textBox.Enter += (s, e) =>
{
if (textBox.Text == placeholder)
{
textBox.Text = "";
textBox.ForeColor = Color.Black;
if (isPasswordField)
textBox.UseSystemPasswordChar = true;
}
};

textBox.Leave += (s, e) =>
{
if (string.IsNullOrEmpty(textBox.Text))
{
textBox.Text = placeholder;
textBox.ForeColor = Color.Gray;
if (isPasswordField)
textBox.UseSystemPasswordChar = false;
}
};
}

private void ConfigureButtonHover(Button button)
{
Color originalColor = button.BackColor;
Color hoverColor = Color.FromArgb(100, 149, 237); // CornflowerBlue

button.MouseEnter += (s, e) =>
{
button.BackColor = hoverColor;
button.FlatAppearance.BorderSize = 1;
button.FlatAppearance.BorderColor = Color.DarkBlue;
};

button.MouseLeave += (s, e) =>
{
button.BackColor = originalColor;
button.FlatAppearance.BorderSize = 0;
};
}

private void LadeKitas()
{
cboKita.Items.Clear();
string query = "SELECT id, name FROM kitas";
using (var reader = DBConnection.Instance.ExecuteReader(query))
{
if (reader != null)
{
while (reader.Read())
{
cboKita.Items.Add(new { Id = reader.GetInt32("id"), Name = reader.GetString("name") });
}
}
}
cboKita.DisplayMember = "Name";
cboKita.ValueMember = "Id";
}

private void btnLogin_Click(object sender, EventArgs e)
{
string benutzername = txtBenutzername.Text == "Benutzername" ? "" : txtBenutzername.Text;
string passwort = txtPasswort.Text == "Passwort" ? "" : txtPasswort.Text;
User user = new User();
if (user.VerifyUser(benutzername, passwort))
{
DashboardForm dashboard = new DashboardForm(user);
dashboard.Show();
this.Hide();
}
else
{
MessageBox.Show("Falscher Benutzername oder Passwort!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}

private void btnRegister_Click(object sender, EventArgs e)
{
string benutzername = txtRegistrierungsname.Text == "Benutzername" ? "" : txtRegistrierungsname.Text;
string passwort = txtRegistrierungsPasswort.Text == "Passwort" ? "" : txtRegistrierungsPasswort.Text;
string passwortWiederholen = txtPasswortWiederholen.Text == "Passwort wiederholen" ? "" : txtPasswortWiederholen.Text;
string rolle = cboRolle.SelectedItem?.ToString();
var selectedKita = cboKita.SelectedItem;
if (string.IsNullOrEmpty(benutzername) || string.IsNullOrEmpty(passwort) || string.IsNullOrEmpty(passwortWiederholen) || string.IsNullOrEmpty(rolle) || selectedKita == null)
{
MessageBox.Show("Bitte alle Felder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
}
if (passwort != passwortWiederholen)
{
MessageBox.Show("Passwörter stimmen nicht überein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
}
User user = new User();
int kitaId = (int)selectedKita.GetType().GetProperty("Id").GetValue(selectedKita);
if (user.RegisterUser(benutzername, passwort, rolle, kitaId))
{
MessageBox.Show("Registrierung erfolgreich! Sie können sich jetzt einloggen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
else
{
MessageBox.Show("Benutzername bereits vergeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
}
}