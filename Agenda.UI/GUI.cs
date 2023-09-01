using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace Agenda.UI
{
    public partial class GUI : Form
    {
        //String DB
        string _strCon;
        public GUI()
        {
            InitializeComponent();
            _strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
