using Google.Protobuf.WellKnownTypes;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            dgList.DataSource = Utils.getQuery(GetlistQuery());
            dgList.Height = ((dgList.RowCount * 30)) > 464 ? 380 : ((dgList.RowCount * 30) + 60);

            if (dgList.RowCount == 0)
                lblNotFound.Visible = true;
            else
                lblNotFound.Visible = false;
            loadList();
            baseboard();

            btnEdit.Enabled = false;
            btnId.Enabled = false;

            this.reportPdfViewer1.RefreshReport();
        }

        private void loadList()
        {
            /*   foreach (DataGridViewRow row in dgList.Rows)
            *   {
            *       string img = FrmRegClient._imgPath + row.Cells["id"].Value.ToString() + ".png";
            *       row.DefaultCellStyle.ForeColor = Color.Peru;
            *       row.Cells["Foto"].Value = Properties.Resources.esquiador;
            *
            *       if (row.Cells["sit_cadastro"].Value.ToString() == "0")
            *       {
            *           row.DefaultCellStyle.ForeColor = Color.Red;
            *       }
            *       if (File.Exists(img))
            *       {
            *           row.Cells["Foto"].Value = Image.FromFile(img);
            *       }
            *
            *   }
            */

        }

        private string GetlistQuery()
        {
            string query = "SELECT * FROM cliente WHERE 1 ";

            if (!string.IsNullOrEmpty(tbSearchId.Text))
            {
                query += $" AND id = {tbSearchId.Text}";

            }

            if (!string.IsNullOrEmpty(tbSearchDocName.Text))
            {

                query += $" AND (documento like '%{tbSearchDocName.Text}%' OR nome like '%{tbSearchDocName.Text}%') ";

            }

            if (!string.IsNullOrEmpty(cbSearchCivilState.Text))
            {
                query += $" AND estado_civil = '{cbSearchCivilState.Text}' ";
            }

            switch (cbSearchGender.Text)
            {
                case "Masculino":

                    query += $" AND Genero = 'M' ";
                    break;

                case "Feminino":

                    query += $" AND Genero = 'F' ";
                    break;

                case "Outros":

                    query += $" AND Genero = 'O' ";
                    break;

                default: break;
            }

            if (!string.IsNullOrEmpty(tbSearchAddresss.Text))
            {
                query += $" and (cidade like '%{tbSearchAddresss.Text}%' or " +
                    $"numero like '%{tbSearchAddresss.Text}%' or " +
                    $"bairro like '%{tbSearchAddresss.Text}%' or " +
                    $"cep like '%{tbSearchAddresss.Text}%' or " +
                    $"endereco like '%{tbSearchAddresss.Text}%' or " +
                    $"estado like '%{tbSearchAddresss.Text}%')";




            }

            try
            {
                DateTime data = Convert.ToDateTime(tbSearchDate.Text);

                query += $" and data_nasc = '{data:yyyy-MM-dd}'";

            }
            catch (Exception ex)
            {
                //  Utils.msgError(ex.Message);
            }

            if (rbSearchActive.Checked)
            {
                query += " AND sit_cadastro = 1";
            }
            else if (rbSearchInative.Checked)
            {
                query += " AND sit_cadastro = 0";
            }

            return query;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmRegClient frmRegClient = new FrmRegClient();

            frmRegClient.ShowDialog();
        }



        private void tbSearchId_TextChanged(object sender, EventArgs e)
        {
            GetlistQuery();

            this.FrmMenu_Load(sender, e);
        }

        private void rbSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSearchAll.Checked)
            {
                tbSearchId_TextChanged(sender, e);
            }
        }

        private void rbSearchActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSearchActive.Checked)
            {
                tbSearchId_TextChanged(sender, e);
            }

        }

        private void rbSearchInative_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSearchInative.Checked)
            {
                tbSearchId_TextChanged(sender, e);
            }
        }

        private void baseboard()
        {
            lbTotal.Text = "Total Localizado: " + dgList.RowCount;
            int active = 0;
            int inative = 0;

            foreach (DataGridViewRow row in dgList.Rows)
            {
                if (row.Cells["sit_cadastro"].Value.ToString() == "0")
                {
                    inative++;
                }
                else
                {
                    active++;
                }
            }

            lbActive.Text = "Total Ativo: " + active;
            lbInative.Text = "Total Inativo: " + inative;

        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmRegClient frm = new FrmRegClient();
            //frm.txtCod.Text =
            //dgList.SelectedRows[e.RowIndex].Cells["id"].Value.ToString();
            btnEdit.Enabled = true;

        }

        private void dgList_MouseEnter(object sender, EventArgs e)
        {
        }

        private void dgList_MouseLeave(object sender, EventArgs e)
        {

        }

        private void dgList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = dgList.Rows[e.RowIndex];

            row.DefaultCellStyle.BackColor = Color.Wheat;

            string img = FrmRegClient._imgPath + row.Cells["id"].Value.ToString() + ".png";
            row.DefaultCellStyle.ForeColor = Color.Peru;
            row.Cells["Foto"].Value = Properties.Resources.esquiador;

            if (row.Cells["sit_cadastro"].Value.ToString() == "0")
            {
                row.DefaultCellStyle.ForeColor = Color.Red;
            }
            if (File.Exists(img))
            {
                //row.Cells["Foto"].Value = Image.FromFile(img);
                using (FileStream imgTemp = new FileStream(img, FileMode.Open, FileAccess.Read))
                {
                    Image imfile = Image.FromStream(imgTemp);
                    row.Cells["Foto"].Value = imfile;
                }

            }
        }

        private void dgList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            dgList.Rows[e.RowIndex].DefaultCellStyle.BackColor = e.RowIndex % 2 == 0 ? Color.White : Color.Turquoise;

            dgList.Rows[e.RowIndex].Cells["Foto"].Value = null;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmRegClient frmRegClient = new FrmRegClient();

            frmRegClient.txtCod.Text = dgList.SelectedCells[0].OwningRow.Cells[1].Value.ToString();


            frmRegClient.ShowDialog();

        }

        private void dgList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {



            string val = "";
            foreach (DataGridViewCell cell in dgList.SelectedCells)
            {

                string celIdList = dgList.Rows[cell.RowIndex].Cells["id"].Value.ToString();
                string columName = dgList.Columns[cell.ColumnIndex].DataPropertyName.ToString();
                if (dgList.SelectedCells[0].RowIndex == cell.RowIndex)
                {
                    val = dgList.Rows[cell.RowIndex].Cells[columName].Value.ToString();
                    if (!Utils.msgYesNO($"Tem certeza que deseja alterar todos os valores selecionados para {val}?"))
                    {
                        break;
                    }
                }
                else
                {

                    Utils.updateComand(celIdList, new Dictionary<string, string>() { { columName, val } });
                    cell.Value = val;
                }
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            DataTable dt = Utils.getQuery("select * from cliente");
            DS.DataCliDataTable dscli = new DS.DataCliDataTable();

            dscli.Merge(dt);

            ReportDataSource rds = new ReportDataSource("DStable", dscli as DataTable);

            reportPdfViewer1.LocalReport.DataSources.Clear();
            reportPdfViewer1.LocalReport.DataSources.Add(rds);

            Utils.ImprimirPdf(reportPdfViewer1, "Relatório Geral");
        }

        private void RepCadastro_Load(object sender, EventArgs e)
        {

        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnId.Enabled = true;
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            string id = dgList.CurrentRow.Cells["id"].Value.ToString();
            
            DataRow lin = Utils.getQuery($"select * from cliente where id = {id}").Rows[0];
            
            /*string genero = "";
            switch (lin["Genero"].ToString()) {
                case "M":
                        genero = "Masculino";
                    break;
                case "F":
                    genero = "Feminino";
                    break;
                default:
                    genero = "Outros";
                    break;
            }
            */
            
            string img = FrmRegClient._imgPath + id.ToString() + ".png";
            
            if (!File.Exists(img))
                img = FrmRegClient._imgPath + "no.png";
            

            ReportParameterCollection parameters = new ReportParameterCollection
            {
              /*  new ReportParameter("nome",lin["nome"].ToString()),
                new ReportParameter("documento",lin["documento"].ToString()),
                new ReportParameter("rg",lin["rg"].ToString()),
                new ReportParameter("email",lin["email"].ToString()),
                new ReportParameter("estado_civil",lin["estado_civil"].ToString()),
                new ReportParameter("celular",lin["celular"].ToString()),
                new ReportParameter("Genero",genero),
                new ReportParameter("obs",lin["obs"].ToString()),
                new ReportParameter("data_nasc",lin["data_nasc"].ToString()),
                new ReportParameter("cidade",lin["cidade"].ToString()),
                new ReportParameter("numero",lin["numero"].ToString()),
                new ReportParameter("bairro",lin["bairro"].ToString()),
                new ReportParameter("cep",lin["cep"].ToString()),
                new ReportParameter("endereco",lin["endereco"].ToString()),
                new ReportParameter("estado",lin["estado"].ToString()),
                new ReportParameter("tipo_doc",lin["tipo_doc"].ToString()),
                */
                new ReportParameter("foto","File://" + img)
            };

            RepCadastro.LocalReport.SetParameters(parameters);
            RepCadastro.RefreshReport();

            DataTable dt = Utils.getQuery($"select * from cliente where id = {id}");
            DS.DataCliDataTable dscli = new DS.DataCliDataTable();

            dscli.Merge(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dscli as DataTable);

            RepCadastro.LocalReport.DataSources.Clear();
            RepCadastro.LocalReport.DataSources.Add(rds);

            Utils.ImprimirPdf(RepCadastro, "Ficha Cadastro clientes");
        }
    }
}
