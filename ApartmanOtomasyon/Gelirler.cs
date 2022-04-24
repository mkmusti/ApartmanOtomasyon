using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Gelirler : Form
    {
        SQLHelper sqlHelper= new SQLHelper();
        public Gelirler()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int daireNo = Convert.ToInt32(cbxDaireNo.Text);
            int tutar = Convert.ToInt32(upDown.Value);
            DateTime dt = dateTimePicker1.Value;

            SqlParameter parameterDaire = new SqlParameter("DaireNo",daireNo);
            SqlParameter parameterTutar = new SqlParameter("Tutar", tutar);
            SqlParameter parameterdt = new SqlParameter("Tarih", dt);

            sqlHelper.ExecuteProcedure("sp_odemeAl", parameterDaire, parameterTutar, parameterdt);
            ListeleriTemizle();
            Gelirler_Load(null, null);
        }

        private void ListeleriTemizle()
        {
            lbDaireNo.Items.Clear();
            lbTutar.Items.Clear();
            lbTarih.Items.Clear();
        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetData("select * from AidatOdemesi");

            foreach (DataRow VARIABLE in dt.Rows)
            {
                lbDaireNo.Items.Add(VARIABLE["DaireNo"].ToString());
                lbTutar.Items.Add(VARIABLE["Tutar"]).ToString();
                lbTarih.Items.Add(VARIABLE["Tarih"]).ToString();
            }
        }
    }
}
