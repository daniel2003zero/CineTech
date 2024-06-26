using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineTech
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void cbxFilme_SelectedIndexChanged(object sender, EventArgs e)
        {



            List<string> filmes = new List<string>
            {
             "Toy Story",
             "Frozen",
             "Harry Potter",
             "Hunger Games",
             "Inception",
             "The Godfather",
             "Casablanca",
             "The Bucket List",
             "Driving Miss  Amour", 
            };

            // Adiciona os filmes na ComboBox
            cbxFilme.DataSource = filmes;


        }
    }
}
