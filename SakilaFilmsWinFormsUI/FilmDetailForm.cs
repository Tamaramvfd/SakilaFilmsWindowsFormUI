using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SakilaFilmsWinFormsUI
{
    public partial class FilmDetailForm : Form
    {
        int film_Id;
        public FilmDetailForm(int filmId)
        {
            InitializeComponent();
            film_Id = filmId;
        }

        private void FilmDetailForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SakilaDB"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT * FROM film WHERE film_id = {film_Id}";
                FilmModel film = connection.Query<FilmModel>(sql).FirstOrDefault();

                idText.Text = film.Id.ToString();
                titleText.Text = film.Title;
                descriptionText.Text = film.Description;
                lengthText.Text = film.Length.ToString();
            }
        }
    }
}
