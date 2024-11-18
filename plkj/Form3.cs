using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plkj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnrecher_Click(object sender, EventArgs e)
        {
            DGV.DataSource = null;//DGV_Produits est le dataGridV
            DGV.Rows.Clear();
            DGV.Columns.Clear();
            string req = "Select * from Plats ";
            if (txtrecher.Text.Trim() == "")
            { MessageBox.Show("Il est recommandé de saisir ..."); }

            else
            {
                req = req + "where name = " + txtrecher.Text;
            }
            List<Plats> ListPlats = DataAccess<Plats>.LireListe(req);

            DGV.Columns.Add("id_plat","Id_plat");
            DGV.Columns.Add("nom", "Nom ");
            DGV.Columns.Add("prix", "Prix ");
            foreach (var r in ListPlats)
                DGV.Rows.Add(r.id_plat, r.nom, r.prix);
        }
    }
}
