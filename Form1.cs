using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
	public partial class Form1 : Form
	{


		//Táblák létrehozása
		const string harcosSQL = @"CREATE TABLE IF NOT EXISTS harcosok( id INTEGER AUTO_INCREMENT PRIMARY KEY, nev VARCHAR(50) NOT NULL UNIQUE, letrehozas DATE NOT NULL)";

		const string kepessegSQL = @"CREATE TABLE IF NOT EXISTS kepessegek(id INTEGER AUTO_INCREMENT PRIMARY KEY , nev VARCHAR(80) NOT NULL, leiras TEXT NOT NULL, harcos_id INTEGER NOT NULL, FOREIGN KEY (harcos_id) REFERENCES harcos(id) )";

		MySqlConnection conn;



		public Form1()
		{
			InitializeComponent();

			try
			{
				conn = new MySqlConnection("Server=localhost;Database=harcos_keszito;Uid=root;Pwd=;");
				conn.Open();
				var letrehozas = conn.CreateCommand();
				letrehozas.CommandText = harcosSQL;
				letrehozas.ExecuteNonQuery();

				var letrehozas2 = conn.CreateCommand();
				letrehozas2.CommandText = kepessegSQL;
				letrehozas2.ExecuteNonQuery();
			}
			catch (MySqlException e)
			{
				MessageBox.Show("Adatbázis hiba: " + e);
				conn.Close();
			}


			Kiiras();


		}

		public void Kiiras() {

			using (var conn = new MySqlConnection(
			  "Server=localhost;Database=harcos_keszito;Uid=root;Password=;"))
			{
				conn.Open();
				harcosokListBox.Items.Clear();
				string formatString = "{0} létrehozás:{1}";

				var cmd = conn.CreateCommand();
				cmd.CommandText = @"
            SELECT * FROM harcosok";
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					harcosokListBox.Items.Add(string.Format(formatString, reader["nev"], reader["letrehozas"]));
					hasznaloComboBox.Items.Add(string.Format("{0}", reader["nev"]));
				}
			}
		}

		//Harcos hozáadása
		private void letrehozasButton_Click(object sender, EventArgs e)
		{

			string nev = "";
			DateTime letrehozas = DateTime.Now;



			using (var conn = new MySqlConnection("Server=localhost;Database=harcos_keszito;UID=root;Pwd="))
			{
				conn.Open();

				var ellenorzes = conn.CreateCommand();
				ellenorzes.CommandText = "SELECT COUNT(*) FROM harcos WHERE nev = @nev";
				ellenorzes.Parameters.AddWithValue("@nev", nev);
				var darab = (long)ellenorzes.ExecuteScalar();

				if (darab != 0)
				{
					MessageBox.Show("Ez a harcos nev mar szerepel!");
					return;

				}


				var command = conn.CreateCommand();
				command.CommandText = "INSERT INTO harcos (nev, letrehozas) VALUES (@nev,@letrehozas)";
				command.Parameters.AddWithValue("@nev", nev);
				command.Parameters.AddWithValue("@letrehozas", "Dátum");
				int erintettsorok = command.ExecuteNonQuery();

				var command2 = conn.CreateCommand();
				command2.CommandText = "SELECT * FROM harcosok";


		
				
				conn.Open();
				var r = command2.ExecuteReader();
				while (r.Read())
				{
					harcosokListBox.Items.Clear();
					harcosokListBox.Items.Add(r["nev"]);
					harcosokListBox.Items.Add(r["letrehozas"]);
					hasznaloComboBox.Items.Clear();
					hasznaloComboBox.Items.Add(r["nev"]);
				}
				conn.Close();


			}

			Kiiras();
		}


		//Képesség hozzáadása
		private void hozzaadButton_Click(object sender, EventArgs e)
		{
			string hasznalo = hasznaloComboBox.ToString(); 
			string nev = kepessegNeveTextBox.Text;
			string leiras = kepessegekLeirasaTextBox.Text;

			using (var conn = new MySqlConnection("Server=localhost;Database=harcos_keszito;UID=root;Pwd="))
			{
				conn.Open();

				var command3 = conn.CreateCommand();
				command3.CommandText = "INSERT INTO  kepessegek(harcos_id, nev, leiras) VALUES (@harcos_id,@nev,@leiras)";
				command3.Parameters.AddWithValue("@harcos_id", hasznalo);
				command3.Parameters.AddWithValue("@nev", nev);
				command3.Parameters.AddWithValue("@leiras", leiras);
				int erintettsorok = command3.ExecuteNonQuery();
			}
			Kiiras();
		}

		private void harcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			kepessegekListBox.Items.Clear();
			leirasTextBox.Clear();
			string nev = harcosokListBox.SelectedItem.ToString();
			
			using (var conn = new MySqlConnection(
					 "Server=localhost;Database=harcos_keszito;Uid=root;Password=;"))
			{
				conn.Open();

				var cmd = conn.CreateCommand();
				cmd.CommandText = @"
                SELECT kepessegek.nev
                FROM kepessegek
                INNER JOIN harcosok ON kepessegek.harcos_id = harcosok.id
                WHERE harcosok.nev = @nev";
				cmd.Parameters.AddWithValue("@nev", nev);
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					kepessegekListBox.Items.Add(string.Format("{0}", reader["nev"]));
				}


			}
			Kiiras();
		}

		private void kepessegekListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			kepessegekLeirasaTextBox.Clear();
			string nev = kepessegekListBox.SelectedItem.ToString();


			using (var conn = new MySqlConnection(
					 "Server=localhost;Database=harcos_keszito;Uid=root;Password=;"))
			{
				conn.Open();

				var cmd = conn.CreateCommand();
				cmd.CommandText = @"
                SELECT leiras
                FROM kepessegek
                WHERE nev = @nev";
				cmd.Parameters.AddWithValue("@nev", nev);
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					kepessegekLeirasaTextBox.Text = string.Format("{0}", reader["leiras"]);

				}


			}
			Kiiras();
		}

		private void torlesButton_Click(object sender, EventArgs e)
		{
			if (kepessegekListBox.SelectedItem.ToString() != null)
			{
				using (var conn = new MySqlConnection(
							 "Server=localhost;Database=harcos_keszito;Uid=root;Password=;"))
				{
					conn.Open();


					var command = conn.CreateCommand();
					command.CommandText = "DELETE FROM kepessegek WHERE nev = @nev";

					command.Parameters.AddWithValue("@nev", kepessegekListBox.SelectedItem.ToString());

					int erintettSorok = command.ExecuteNonQuery();
				}
			}
			Kiiras();

		}

		
	}

	
	}

