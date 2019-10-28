using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FilmDetails : Form
    {

        Films _selectedFilm;
        //Inconsistent accesability
        public FilmDetails(Films selectedFilm)
        {
            Console.WriteLine("Dentro del dialogo");
            InitializeComponent();
            _selectedFilm = selectedFilm;
            Films film = selectedFilm;
            FilmTitle.Text = film.title;
            FilmDescription.Text = film.description;
            FilmLength.Text = film.length + "'";
            FilmRating.Text = film.rating;
            if(FilmRating.Text == "NC-17" || FilmRating.Text == "R")
            {
                FilmRating.ForeColor = Color.Red;
            }
            else
            {
                FilmRating.ForeColor = Color.DarkGray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FilmDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
