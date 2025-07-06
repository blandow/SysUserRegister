using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CadastroClientes
{
    internal class Utils
    {
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
            MessageBox.Show(msg,"ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            return MessageBox.Show(msg,"Confirmação",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static DataTable getQuery(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conect = new MySqlConnection("Server=localhost;Port=3306;Database=base_client;User=root;Password=Abc/123"))
            {
                conect.Open();
                
                using(MySqlCommand cmd = conect.CreateCommand())
                {
                    cmd.CommandText = query;
                    
                    using(MySqlDataAdapter data = new MySqlDataAdapter(cmd)) {
                        data.Fill(dt);
                    }
                }

            }
            return dt;
        }

        public static void setCombobox(List<ComboBox> cblist)
        {
            foreach(var cbitem in cblist){
                
                if(cbitem.DisplayMember.ToString() == "")
                {
                    break;
                }

                cbitem.DataSource = getQuery("SELECT DISTINCT(" + cbitem.DisplayMember + ") FROM cliente WHERE TRIM(" + cbitem.DisplayMember + ") <> ''");
            
                cbitem.SelectedIndex = -1;
            }
        }

    }
}
