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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable dt = new SQLHelper().GetData("Select * from GiderTablosu");

            foreach (DataRow row in dt.Rows)
            {
                lbGider.Items.Add(row["Gider"]).ToString();
                lbTutar.Items.Add(row["Tutar"]).ToString();
                lbTarih.Items.Add(row["Tarih"]).ToString();
            }
        }

        SQLHelper sqlHelper = new SQLHelper();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int tutar = (int)numericUpDown1.Value;
            DateTime dt = dateTimePicker1.Value;
            string gider = "";

            foreach (Control control in groupBox1.Controls) 
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    gider += ", " + control.Text;
                }
            }

            gider = gider.Remove(0, 2);

            SqlParameter prmTutar = new SqlParameter("Tutar", tutar);
            SqlParameter prmTarih = new SqlParameter("Tarih", dt);
            SqlParameter prmGider = new SqlParameter("Gider", gider);

            sqlHelper.ExecuteProcedure("sp_Gider", prmTutar, prmTarih, prmGider);

            ListeleriTemizle();
            Giderler_Load(null, null);

            MessageBox.Show("Gider Başarıyla Kayıt Edildi.", "B İ L G İ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ListeleriTemizle()
        {
            lbTutar.Items.Clear();
            lbGider.Items.Clear();
            lbTarih.Items.Clear();
        }
    }
}
