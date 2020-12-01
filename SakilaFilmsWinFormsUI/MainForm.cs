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
        int filmsPerPage;
        int numberOfPages;
        int currentPages = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            filmsFoundLabel.Text = "0 films found";
            pagesFoundLabel.Text = "0 pages";
            filmsPerPage = int.Parse(filmsPerPageComboBox.Text);
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

            //string connectionString = ConfigurationManager.ConnectionStrings["SakilaDB"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) " +
                    $"FROM " +
                    $"film INNER JOIN film_category ON film.film_id = film_category.film_id " +
                    $"INNER JOIN category ON film_category.category_id = category.category_id " +
                    $"WHERE category.name = '{categoryComboBox.Text}'";

                int totalNumberOfFilmsPerCategoryFound = connection.Query<int>(sql).FirstOrDefault();
                filmsFoundLabel.Text = totalNumberOfFilmsPerCategoryFound + "films found";

                numberOfPages = totalNumberOfFilmsPerCategoryFound / int.Parse(filmsPerPageComboBox.Text) + 1;
                currentPages = 0;
                prevButton.Enabled = false;
                nextButton.Enabled = true;
            }
        }

        private void filmsPerPageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsPerPage = int.Parse(filmsPerPageComboBox.Text);
            int lastSelectedIndex = categoryComboBox.SelectedIndex;
            categoryComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = lastSelectedIndex;
        }

        private void UpdateFilmsView()
        {
            pagesFoundLabel.Text = (currentPages + 1) + "of" + numberOfPages + " pages";

            string connectionString = ConfigurationManager.ConnectionStrings["SakilaDB"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT film.film_id AS Id, film.title, film.description, film.length " +
                    $"FROM film " +
                    $"INNER JOIN film_category ON film.film_id = film_category.film_id " +
                    $"INNER JOIN category ON film_category.category_id = category.category_id " +
                    $"WHERE category.name = '{categoryComboBox.Text}' " +
                    $"LIMIT {currentPages * filmsPerPage}, {filmsPerPage}";

                List<FilmModel> films = new List<FilmModel>();
                films = connection.Query<FilmModel>(sql).ToList();
                filmsListView.Items.Clear();
                foreach (FilmModel film in films)
                {
                    filmsListView.Items.Add(film.ToString());
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentPages++;
            if (currentPages == numberOfPages - 1)
            {
                nextButton.Enabled = false;
            }
            prevButton.Enabled = true;
            UpdateFilmsView();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentPages--;
            if (currentPages == 0)
            {
                prevButton.Enabled = false;
            }
            nextButton.Enabled = true;
            UpdateFilmsView();
        }

        private void filmsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filmSelected = filmsListView.SelectedItems[0].Text;
            int filmId = int.Parse(filmSelected.Split(',')[0]);

            FilmDetailForm filmDetailForm = new FilmDetailForm(filmId);
            filmDetailForm.ShowDialog();
        }
    }    
}
