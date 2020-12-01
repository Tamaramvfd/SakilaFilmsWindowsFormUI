using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace SakilaFilmsWinFormsUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Establecer conexión con la BBDD
            string connectionString = ConfigurationManager.ConnectionStrings["SakilaDB"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "SELECT name FROM sakila.category";
                List<string> categories = new List<string>();
                categories = connection.Query<string>(sql).ToList();
                foreach (string category in categories)
                {
                    categoryComboBox.Items.Add(category);
                }
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SakilaDB"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT film.film_id, film.title, film.description, film.length " +
                    $"FROM +" +
                    $"film INNER JOIN film_category ON film.film.id = film_category.film_id " +
                    $"INNER JOIN category ON film_category.category_id = category.category_id " +
                    $"WHERE category.name = '{categoryComboBox.Text}'";

                List<FilmModel> films = new List<FilmModel>();
                films = connection.Query<FilmModel>(sql).ToList();
                foreach (FilmModel film in films)
                {
                    //filmsListView.Items.Add($"{film.Id}, {film.Title}, {film.Description}, {film.Length}");
                    filmsListView.Items.Add(film.ToString());
                }
            }
        }
    }
}
