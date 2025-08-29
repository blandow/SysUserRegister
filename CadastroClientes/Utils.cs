using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;


namespace CadastroClientes
{
    internal class Utils
    {
        public static string conectStr = "Server=localhost;Port=3306;Database=base_client;User=root;Password=Abc/123";
        public static void limparCampos(List<Control> controlList)
        {

            foreach (Control Controle in controlList)
            {

                if (Controle.GetType() == typeof(TextBox) || Controle.GetType() == typeof(MaskedTextBox))
                {

                    Controle.Text = "";

                }
                else if (Controle.GetType() == typeof(ComboBox))
                {
                    Controle.Text = "";
                }
                else if (Controle.GetType() == typeof(CheckBox))
                {

                    CheckBox checkBox = (CheckBox)Controle;
                    checkBox.Checked = true;
                }
                else if (Controle.GetType() == typeof(RadioButton))
                {
                    RadioButton radio = (RadioButton)Controle;
                    radio.Checked = false;
                }

            }

        }
        public static void msgError(string msg)
        {
            MessageBox.Show(msg, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void msgAlert(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void msgInfo(string msg)
        {
            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool msgYesNO(string msg)
        {
            return MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static DataTable getQuery(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conect = new MySqlConnection(conectStr))
            {
                conect.Open();

                using (MySqlCommand cmd = conect.CreateCommand())
                {
                    cmd.CommandText = query;

                    using (MySqlDataAdapter data = new MySqlDataAdapter(cmd))
                    {
                        data.Fill(dt);
                    }
                }

            }
            return dt;
        }
        public static void setCombobox(List<ComboBox> cblist)
        {
            foreach (var cbitem in cblist)
            {

                if (cbitem.DisplayMember.ToString() == "")
                {
                    break;
                }

                cbitem.DataSource = getQuery("SELECT DISTINCT(" + cbitem.DisplayMember + ") FROM cliente WHERE TRIM(" + cbitem.DisplayMember + ") <> ''");

                cbitem.SelectedIndex = -1;
            }
        }
        public static void updateComand(string id, Dictionary<string, string> data)
        {
            using (MySqlConnection con = new MySqlConnection(conectStr))
            {
                con.Open();
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    string query = "UPDATE cliente SET ";
                    foreach (var item in data.Keys)
                    {
                        query += item + $" = '{data[item]}' ,";

                    }
                    ;
                    query = query.TrimEnd(',');
                    query += $" WHERE id = {id};";

                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public static void ImprimirPdf(ReportViewer report, string nomeArquivo)
        {
            report.Refresh();
            report.RefreshReport();
            try
            {
                Warning[] warnings;
                string[] streamIds;
                string mimeType;
                string encoding;
                string fileNameExtension;

                byte[] bytes = report.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out fileNameExtension,
                    out streamIds, out warnings);
                using (FileStream fs = new FileStream(nomeArquivo + ".pdf", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
                System.Diagnostics.Process.Start(nomeArquivo + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
