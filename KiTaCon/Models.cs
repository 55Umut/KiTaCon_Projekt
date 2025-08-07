using System;
using MySql.Data.MySqlClient;

namespace KiTaCon
{
    public class User
    {
        public int Id { get; set; }
        public string Benutzername { get; set; }
        public string Passwort { get; set; }
        public string Rolle { get; set; }
        public int KitaId { get; set; }

        public bool VerifyUser(string benutzername, string passwort)
        {
            string query = "SELECT id, passwort, rolle, kita_id FROM users WHERE benutzername = @benutzername";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@benutzername", benutzername)))
            {
                if (reader != null && reader.Read())
                {
                    string dbPasswort = reader["passwort"].ToString();
                    if (BCrypt.Net.BCrypt.Verify(passwort, dbPasswort))
                    {
                        Id = reader.GetInt32("id");
                        Benutzername = benutzername;
                        Passwort = dbPasswort;
                        Rolle = reader["rolle"].ToString();
                        KitaId = reader.GetInt32("kita_id");
                        return true;
                    }
                }
            }
            return false;
        }

        public bool RegisterUser(string benutzername, string passwort, string rolle, int kitaId)
        {
            string checkQuery = "SELECT COUNT(*) FROM users WHERE benutzername = @benutzername";
            using (var reader = DBConnection.Instance.ExecuteReader(checkQuery, new MySqlParameter("@benutzername", benutzername)))
            {
                if (reader != null && reader.Read())
                {
                    int count = reader.GetInt32(0);
                    reader.Close();
                    if (count > 0)
                        return false;
                }
            }
            string hash = BCrypt.Net.BCrypt.HashPassword(passwort);
            string insertQuery = "INSERT INTO users (benutzername, passwort, rolle, kita_id) VALUES (@benutzername, @passwort, @rolle, @kita_id)";
            DBConnection.Instance.ExecuteQuery(insertQuery,
                new MySqlParameter("@benutzername", benutzername),
                new MySqlParameter("@passwort", hash),
                new MySqlParameter("@rolle", rolle),
                new MySqlParameter("@kita_id", kitaId));
            return true;
        }

        public void CreateUser(string benutzername, string passwort, string rolle, int kitaId)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(passwort);
            string query = "INSERT INTO users (benutzername, passwort, rolle, kita_id) VALUES (@benutzername, @passwort, @rolle, @kita_id)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@benutzername", benutzername),
                new MySqlParameter("@passwort", hash),
                new MySqlParameter("@rolle", rolle),
                new MySqlParameter("@kita_id", kitaId));
        }

        public User GetUser(int id)
        {
            string query = "SELECT * FROM users WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new User
                    {
                        Id = reader.GetInt32("id"),
                        Benutzername = reader.GetString("benutzername"),
                        Passwort = reader.GetString("passwort"),
                        Rolle = reader.GetString("rolle"),
                        KitaId = reader.GetInt32("kita_id")
                    };
                }
                return null;
            }
        }

        public void UpdateUser(int id, string benutzername, string passwort, string rolle, int kitaId)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(passwort);
            string query = "UPDATE users SET benutzername = @benutzername, passwort = @passwort, rolle = @rolle, kita_id = @kita_id WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@benutzername", benutzername),
                new MySqlParameter("@passwort", hash),
                new MySqlParameter("@rolle", rolle),
                new MySqlParameter("@kita_id", kitaId));
        }

        public void DeleteUser(int id)
        {
            string query = "DELETE FROM users WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Kita
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }

        public void CreateKita(string name, string adresse)
        {
            string query = "INSERT INTO kitas (name, adresse) VALUES (@name, @adresse)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@name", name),
                new MySqlParameter("@adresse", adresse));
        }

        public Kita GetKita(int id)
        {
            string query = "SELECT * FROM kitas WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Kita
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Adresse = reader.GetString("adresse")
                    };
                }
                return null;
            }
        }

        public void UpdateKita(int id, string name, string adresse)
        {
            string query = "UPDATE kitas SET name = @name, adresse = @adresse WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@name", name),
                new MySqlParameter("@adresse", adresse));
        }

        public void DeleteKita(int id)
        {
            string query = "DELETE FROM kitas WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Kind
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElternId { get; set; }
        public int KitaId { get; set; }

        public void CreateKind(string name, int elternId, int kitaId)
        {
            string query = "INSERT INTO kinder (name, eltern_id, kita_id) VALUES (@name, @eltern_id, @kita_id)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@name", name),
                new MySqlParameter("@eltern_id", elternId),
                new MySqlParameter("@kita_id", kitaId));
        }

        public Kind GetKind(int id)
        {
            string query = "SELECT * FROM kinder WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Kind
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        ElternId = reader.GetInt32("eltern_id"),
                        KitaId = reader.GetInt32("kita_id")
                    };
                }
                return null;
            }
        }

        public void UpdateKind(int id, string name, int elternId, int kitaId)
        {
            string query = "UPDATE kinder SET name = @name, eltern_id = @eltern_id, kita_id = @kita_id WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@name", name),
                new MySqlParameter("@eltern_id", elternId),
                new MySqlParameter("@kita_id", kitaId));
        }

        public void DeleteKind(int id)
        {
            string query = "DELETE FROM kinder WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Aktivitaet
    {
        public int Id { get; set; }
        public int KindId { get; set; }
        public string Beschreibung { get; set; }
        public DateTime Zeit { get; set; }

        public void CreateAktivitaet(int kindId, string beschreibung, DateTime zeit)
        {
            string query = "INSERT INTO aktivitaeten (kind_id, beschreibung, zeit) VALUES (@kind_id, @beschreibung, @zeit)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@beschreibung", beschreibung),
                new MySqlParameter("@zeit", zeit));
        }

        public Aktivitaet GetAktivitaet(int id)
        {
            string query = "SELECT * FROM aktivitaeten WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Aktivitaet
                    {
                        Id = reader.GetInt32("id"),
                        KindId = reader.GetInt32("kind_id"),
                        Beschreibung = reader.GetString("beschreibung"),
                        Zeit = reader.GetDateTime("zeit")
                    };
                }
                return null;
            }
        }

        public void UpdateAktivitaet(int id, int kindId, string beschreibung, DateTime zeit)
        {
            string query = "UPDATE aktivitaeten SET kind_id = @kind_id, beschreibung = @beschreibung, zeit = @zeit WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@beschreibung", beschreibung),
                new MySqlParameter("@zeit", zeit));
        }

        public void DeleteAktivitaet(int id)
        {
            string query = "DELETE FROM aktivitaeten WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Ereignis
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public DateTime Datum { get; set; }
        public string Beschreibung { get; set; }

        public void CreateEreignis(string titel, DateTime datum, string beschreibung)
        {
            string query = "INSERT INTO ereignisse (titel, datum, beschreibung) VALUES (@titel, @datum, @beschreibung)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@titel", titel),
                new MySqlParameter("@datum", datum),
                new MySqlParameter("@beschreibung", beschreibung));
        }

        public Ereignis GetEreignis(int id)
        {
            string query = "SELECT * FROM ereignisse WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Ereignis
                    {
                        Id = reader.GetInt32("id"),
                        Titel = reader.GetString("titel"),
                        Datum = reader.GetDateTime("datum"),
                        Beschreibung = reader.GetString("beschreibung")
                    };
                }
                return null;
            }
        }

        public void UpdateEreignis(int id, string titel, DateTime datum, string beschreibung)
        {
            string query = "UPDATE ereignisse SET titel = @titel, datum = @datum, beschreibung = @beschreibung WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@titel", titel),
                new MySqlParameter("@datum", datum),
                new MySqlParameter("@beschreibung", beschreibung));
        }

        public void DeleteEreignis(int id)
        {
            string query = "DELETE FROM ereignisse WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Nachricht
    {
        public int Id { get; set; }
        public int AbsenderId { get; set; }
        public int EmpfangerId { get; set; }
        public string NachrichtText { get; set; }
        public DateTime Zeit { get; set; }

        public void CreateNachricht(int absenderId, int empfangerId, string nachricht, DateTime zeit)
        {
            string query = "INSERT INTO nachrichten (absender_id, empfanger_id, nachricht, zeit) VALUES (@absender_id, @empfanger_id, @nachricht, @zeit)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@absender_id", absenderId),
                new MySqlParameter("@empfanger_id", empfangerId),
                new MySqlParameter("@nachricht", nachricht),
                new MySqlParameter("@zeit", zeit));
        }

        public Nachricht GetNachricht(int id)
        {
            string query = "SELECT * FROM nachrichten WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Nachricht
                    {
                        Id = reader.GetInt32("id"),
                        AbsenderId = reader.GetInt32("absender_id"),
                        EmpfangerId = reader.GetInt32("empfanger_id"),
                        NachrichtText = reader.GetString("nachricht"),
                        Zeit = reader.GetDateTime("zeit")
                    };
                }
                return null;
            }
        }

        public void UpdateNachricht(int id, int absenderId, int empfangerId, string nachricht, DateTime zeit)
        {
            string query = "UPDATE nachrichten SET absender_id = @absender_id, empfanger_id = @empfanger_id, nachricht = @nachricht, zeit = @zeit WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@absender_id", absenderId),
                new MySqlParameter("@empfanger_id", empfangerId),
                new MySqlParameter("@nachricht", nachricht),
                new MySqlParameter("@zeit", zeit));
        }

        public void DeleteNachricht(int id)
        {
            string query = "DELETE FROM nachrichten WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Foto
    {
        public int Id { get; set; }
        public int KindId { get; set; }
        public string Dateipfad { get; set; }
        public DateTime Datum { get; set; }

        public void CreateFoto(int kindId, string dateipfad, DateTime datum)
        {
            string query = "INSERT INTO fotos (kind_id, dateipfad, datum) VALUES (@kind_id, @dateipfad, @datum)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@dateipfad", dateipfad),
                new MySqlParameter("@datum", datum));
        }

        public Foto GetFoto(int id)
        {
            string query = "SELECT * FROM fotos WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Foto
                    {
                        Id = reader.GetInt32("id"),
                        KindId = reader.GetInt32("kind_id"),
                        Dateipfad = reader.GetString("dateipfad"),
                        Datum = reader.GetDateTime("datum")
                    };
                }
                return null;
            }
        }

        public void UpdateFoto(int id, int kindId, string dateipfad, DateTime datum)
        {
            string query = "UPDATE fotos SET kind_id = @kind_id, dateipfad = @dateipfad, datum = @datum WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@dateipfad", dateipfad),
                new MySqlParameter("@datum", datum));
        }

        public void DeleteFoto(int id)
        {
            string query = "DELETE FROM fotos WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Entwicklungsbericht
    {
        public int Id { get; set; }
        public int KindId { get; set; }
        public string Bericht { get; set; }
        public DateTime Datum { get; set; }

        public void CreateEntwicklungsbericht(int kindId, string bericht, DateTime datum)
        {
            string query = "INSERT INTO entwicklungsberichte (kind_id, bericht, datum) VALUES (@kind_id, @bericht, @datum)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@bericht", bericht),
                new MySqlParameter("@datum", datum));
        }

        public Entwicklungsbericht GetEntwicklungsbericht(int id)
        {
            string query = "SELECT * FROM entwicklungsberichte WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Entwicklungsbericht
                    {
                        Id = reader.GetInt32("id"),
                        KindId = reader.GetInt32("kind_id"),
                        Bericht = reader.GetString("bericht"),
                        Datum = reader.GetDateTime("datum")
                    };
                }
                return null;
            }
        }

        public void UpdateEntwicklungsbericht(int id, int kindId, string bericht, DateTime datum)
        {
            string query = "UPDATE entwicklungsberichte SET kind_id = @kind_id, bericht = @bericht, datum = @datum WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@bericht", bericht),
                new MySqlParameter("@datum", datum));
        }

        public void DeleteEntwicklungsbericht(int id)
        {
            string query = "DELETE FROM entwicklungsberichte WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Abholung
    {
        public int Id { get; set; }
        public int KindId { get; set; }
        public string Abholer { get; set; }
        public DateTime Zeit { get; set; }

        public void CreateAbholung(int kindId, string abholer, DateTime zeit)
        {
            string query = "INSERT INTO abholungen (kind_id, abholer, zeit) VALUES (@kind_id, @abholer, @zeit)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@abholer", abholer),
                new MySqlParameter("@zeit", zeit));
        }

        public Abholung GetAbholung(int id)
        {
            string query = "SELECT * FROM abholungen WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Abholung
                    {
                        Id = reader.GetInt32("id"),
                        KindId = reader.GetInt32("kind_id"),
                        Abholer = reader.GetString("abholer"),
                        Zeit = reader.GetDateTime("zeit")
                    };
                }
                return null;
            }
        }

        public void UpdateAbholung(int id, int kindId, string abholer, DateTime zeit)
        {
            string query = "UPDATE abholungen SET kind_id = @kind_id, abholer = @abholer, zeit = @zeit WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@kind_id", kindId),
                new MySqlParameter("@abholer", abholer),
                new MySqlParameter("@zeit", zeit));
        }

        public void DeleteAbholung(int id)
        {
            string query = "DELETE FROM abholungen WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Dienstplan
    {
        public int Id { get; set; }
        public int ErzieherId { get; set; }
        public int KitaId { get; set; }
        public DateTime Datum { get; set; }
        public string Schicht { get; set; }

        public void CreateDienstplan(int erzieherId, int kitaId, DateTime datum, string schicht)
        {
            string query = "INSERT INTO dienstplaene (erzieher_id, kita_id, datum, schicht) VALUES (@erzieher_id, @kita_id, @datum, @schicht)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@erzieher_id", erzieherId),
                new MySqlParameter("@kita_id", kitaId),
                new MySqlParameter("@datum", datum),
                new MySqlParameter("@schicht", schicht));
        }

        public Dienstplan GetDienstplan(int id)
        {
            string query = "SELECT * FROM dienstplaene WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Dienstplan
                    {
                        Id = reader.GetInt32("id"),
                        ErzieherId = reader.GetInt32("erzieher_id"),
                        KitaId = reader.GetInt32("kita_id"),
                        Datum = reader.GetDateTime("datum"),
                        Schicht = reader.GetString("schicht")
                    };
                }
                return null;
            }
        }

        public void UpdateDienstplan(int id, int erzieherId, int kitaId, DateTime datum, string schicht)
        {
            string query = "UPDATE dienstplaene SET erzieher_id = @erzieher_id, kita_id = @kita_id, datum = @datum, schicht = @schicht WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@erzieher_id", erzieherId),
                new MySqlParameter("@kita_id", kitaId),
                new MySqlParameter("@datum", datum),
                new MySqlParameter("@schicht", schicht));
        }

        public void DeleteDienstplan(int id)
        {
            string query = "DELETE FROM dienstplaene WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }

    public class Essensplan
    {
        public int Id { get; set; }
        public int KitaId { get; set; }
        public DateTime Datum { get; set; }
        public string Speise { get; set; }

        public void CreateEssensplan(int kitaId, DateTime datum, string speise)
        {
            string query = "INSERT INTO essensplaene (kita_id, datum, speise) VALUES (@kita_id, @datum, @speise)";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@kita_id", kitaId),
                new MySqlParameter("@datum", datum),
                new MySqlParameter("@speise", speise));
        }

        public Essensplan GetEssensplan(int id)
        {
            string query = "SELECT * FROM essensplaene WHERE id = @id";
            using (var reader = DBConnection.Instance.ExecuteReader(query, new MySqlParameter("@id", id)))
            {
                if (reader != null && reader.Read())
                {
                    return new Essensplan
                    {
                        Id = reader.GetInt32("id"),
                        KitaId = reader.GetInt32("kita_id"),
                        Datum = reader.GetDateTime("datum"),
                        Speise = reader.GetString("speise")
                    };
                }
                return null;
            }
        }

        public void UpdateEssensplan(int id, int kitaId, DateTime datum, string speise)
        {
            string query = "UPDATE essensplaene SET kita_id = @kita_id, datum = @datum, speise = @speise WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query,
                new MySqlParameter("@id", id),
                new MySqlParameter("@kita_id", kitaId),
                new MySqlParameter("@datum", datum),
                new MySqlParameter("@speise", speise));
        }

        public void DeleteEssensplan(int id)
        {
            string query = "DELETE FROM essensplaene WHERE id = @id";
            DBConnection.Instance.ExecuteQuery(query, new MySqlParameter("@id", id));
        }
    }
}