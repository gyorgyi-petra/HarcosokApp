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
		const string harcosSQL = "CREATE TABLE IF NOT EXISTS harcosok( id INTEGER AUTO_INCREMENT PRIMARY KEY, nev VARCHAR(50) NOT NULL UNIQUE, letrehozas DATE NOT NULL)";

		const string kepessegSQL = "CREATE TABLE IF NOT EXISTS kepessegek(id INTEGER AUTO_INCREMENT PRIMARY KEY , nev VARCHAR(80) NOT NULL, leiras TEXT NOT NULL, harcos_id INTEGER NOT NULL, FOREIGN KEY (harcos_id) REFERENCES harcos(id) )";

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





		}

		//Harcos hozáadása
		private void letrehozasButton_Click(object sender, EventArgs e)
		{

			string nev = harcosNeveTextBox.Text;



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
		}


		//Képesség hozzáadása
		private void hozzaadButton_Click(object sender, EventArgs e)
		{
			string hasznalo = hasznaloComboBox.Text;
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

		}

		private void torlesButton_Click(object sender, EventArgs e)
		{
			string nev = kepessegekListBox.Text;

			using (var conn = new MySqlConnection("Server=localhost;Database=harcos_keszito;UID=root;Pwd="))
			{
				conn.Open();




				var command4 = conn.CreateCommand();
				command4.CommandText = "DELETE FROM felhasznalo WHERE nev = @nev";
				command4.Parameters.AddWithValue("@nev", nev);
				int erintettsorok = command4.ExecuteNonQuery();


			}
		}

		private void modositButton_Click(object sender, EventArgs e)
		{
			string leiras = kepessegekLeirasaTextBox.Text;
			string kepesseg = kepessegekListBox.Text;

			using (var conn = new MySqlConnection("Server=localhost;Database=harcos_keszito;UID=root;Pwd="))
			{
				conn.Open();




				var command5 = conn.CreateCommand();
				command5.CommandText = "UPDATE leiras SET leiras = @leiras WHERE nev = @nev";
				command5.Parameters.AddWithValue("@nev",kepesseg);
				command5.Parameters.AddWithValue("@leiras", leiras);
				int erintettsorok = command5.ExecuteNonQuery();


			}
		}
	}
}
