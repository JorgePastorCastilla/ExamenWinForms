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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string connectionString = "Server=localhost;Port=3306;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t;";


        private void FindButton_Click(object sender, EventArgs e)
        {
            List<Films> films = new List<Films>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT film_id, title, description, length, rating FROM film WHERE film.title LIKE '%{SearchTextBox.Text}%'";
            //string sql = $"SELECT film.title FROM film WHERE film.title LIKE '%[^a - z]{SearchTextBox.Text}[^a - z]%'";
            Console.WriteLine( sql );
              films = connection.Query<Films>(sql).ToList();
            FilmsListBox.DataSource = films;
            FilmsListBox.DisplayMember = "ShowTitle";

            connection.Close();
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void FilmsListBox_DoubleClick_1(object sender, EventArgs e)
        {
            if (FilmsListBox.SelectedItem != null)
            {
                Films selectedFilm = FilmsListBox.SelectedItem as Films;
                FilmDetails filmDetailsForm = new FilmDetails(selectedFilm);
                Console.WriteLine("Dentro del evento doubleClick");

                //Button prop DialogResult

                DialogResult result = filmDetailsForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    // Read the contents of testDialog's TextBox.
                    //this.txtResult.Text = testDialog.TextBox1.Text;
                }
                else if (result == DialogResult.Cancel)
                {
                    //this.txtResult.Text = "Cancelled";

                }
                filmDetailsForm.Dispose();
            }
        }


        Boolean isStaff = false;
        Boolean isLogged = false;
        string loggedUser;
        string loggedUserLastName;

        private void button1_Click(object sender, EventArgs e)
        {
            if (isLogged)
            {
                isStaff = false;
                isLogged = false;
                HelloLabel.Hide();
                loggedUser = "";
                loggedUserLastName = "";
                LogInButton.Text = "Log in";
                //connectionString = "Server=localhost;Port=3306;Database=sakila;Uid=client;Pwd=$3cr3t;";
                staffImage.Show();
            }
            else
            {
                if (UserTextBox.Text == "guest" && PaswordTextBox.Text == "123")
                {
                    connectionString = "Server=localhost;Port=3306;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t;";
                    isStaff = true;
                    isLogged = true;
                    LogInButton.Text = "Log out";
                    tabControl1.SelectedTab = FilmsTab;
                    loggedUserLastName = "guest";
                    HelloLabel.Text = "hello mr. " + loggedUserLastName;
                    HelloLabel.Show();
                    //staffImage.Visible = !staffImage.Visible;
                }
                else
                {
                    List<string> users = new List<string>();
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    string sql = $"SELECT last_name FROM staff WHERE first_name = '{UserTextBox.Text}';";
                    users = connection.Query<string>(sql).ToList();
                    if (users.Count() != 0 && PaswordTextBox.Text == "456")
                    {
                        isStaff = true;
                        isLogged = true;
                        LogInButton.Text = "Log out";
                        tabControl1.SelectedTab = FilmsTab;
                        staffImage.Hide();
                        loggedUser = UserTextBox.Text;
                        loggedUserLastName = users.FirstOrDefault().ToString();
                        HelloLabel.Text = "hello mr. " + loggedUserLastName;
                        HelloLabel.Show();


                    }
                    connection.Close();

                }
            }


        }

        private void UpdateEmailButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"Update staff set email = '{EmailTextBox.Text}' where first_name ='{loggedUser}'";
            connection.Execute(sql);
            
            MessageBox.Show( $"Email updated succesfully", "Staff Manager", MessageBoxButtons.OK );
            connection.Close();
        }
    }
 }

