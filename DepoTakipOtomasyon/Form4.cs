using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace DepoTakipOtomasyon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=datam.accdb");

        private void Form4_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "SELECT * FROM hareket";
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr["hareket"].ToString() + dr["tarih"].ToString() + dr["kullanici".ToString()]);


            }


            bag.Close();
        }
    }
}
