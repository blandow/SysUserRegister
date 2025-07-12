using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace CadastroClientes
{
    public partial class FrmRegClient : Form
    {
        public string Cod
        {
            get { return txtCod.Text; }
            set { txtCod.Text = value; }
        }
        public class Jcep
        {
            public Jcep()
            {


                erro = string.Empty; 
                cep = string.Empty; 
                logradouro = string.Empty; 
                complemento = string.Empty; 
                unidade = string.Empty;
                bairro = string.Empty;
                localidade = string.Empty; 
                uf = string.Empty;
                estado = string.Empty;
                regiao = string.Empty;
                ibge = string.Empty;
                gia = string.Empty; 
                ddd = string.Empty;
                siafi = string.Empty;
        }
            public string erro {  get; set; }
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string unidade { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string estado { get; set; }
            public string regiao { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
        }

        public static string _imgPath = AppDomain.CurrentDomain.BaseDirectory + "/Fotos/";
        public List<TextBox> initiateListTextBox()
        {
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.AddRange(new List<TextBox> { txtNome, txtNum, txtRG });

            return listTextBox;
        }

        public FrmRegClient()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ComboBox> cblist = new List<ComboBox>();

            cblist.Add(cbEndereco);
            cblist.Add(cbCidade);
            cblist.Add(cbBairro);

            Utils.setCombobox(cblist);

            if (txtCod.Text == "")
                return;

            btnSalvar.Text = "Atualizar";
            DataTable dt = Utils.getQuery("SELECT * FROM cliente where id = \"" + txtCod.Text + "\"");



            txtCod.Text = dt.Rows[0]["id"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtNome.Text = dt.Rows[0]["nome"].ToString();
            txtNum.Text = dt.Rows[0]["numero"].ToString();
            txtObs.Text = dt.Rows[0]["obs"].ToString();
            txtRG.Text = dt.Rows[0]["rg"].ToString();

            maskCel.Text = dt.Rows[0]["celular"].ToString();
            maskCep.Text = dt.Rows[0]["cep"].ToString();
            maskData.Text = dt.Rows[0]["data_nasc"].ToString();


            if (dt.Rows[0]["documento"].ToString().Length > 11)
            {
                radCnpj.Checked = true;
            }
            else
            {
                radCpf.Checked = true;
            }

            maskDoc.Text = dt.Rows[0]["documento"].ToString();

            cbBairro.Text = dt.Rows[0]["bairro"].ToString();
            cbCidade.Text = dt.Rows[0]["cidade"].ToString();
            cbEndereco.Text = dt.Rows[0]["endereco"].ToString(); ;
            cbEstado.Text = dt.Rows[0]["estado"].ToString(); ;
            cbEstadoCivil.Text = dt.Rows[0]["estado_civil"].ToString(); ;

            if (dt.Rows[0]["sit_cadastro"].ToString() == "1")
            {
                checkActive.Checked = true;
            }
            else
            {
                checkActive.Checked = false;
            }

            switch (dt.Rows[0]["Genero"].ToString())
            {
                case "O":
                    radOutro.Checked = true;
                    break;
                case "M":
                    radMasc.Checked = true;
                    break;
                case "F":
                    radFem.Checked = true;
                    break;

                default:
                    break;
            }

            string path = _imgPath + txtCod.Text + ".png";
            
            if (File.Exists(path))
            {
                Img.LoadAsync(path);
            }
            else
            {
                Img.Image = Properties.Resources.esquiador;
            }

        }   
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void FrmRegClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
        private void addDBValuesFromForm()
        {
            MySqlConnection conect = new MySqlConnection(Utils.conectStr);
            conect.Open();
            using (MySqlCommand com = conect.CreateCommand())
            {
                com.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper());
                com.Parameters.AddWithValue("@documento", maskDoc.Text);
                com.Parameters.AddWithValue("@rg", txtRG.Text);
                com.Parameters.AddWithValue("@email", txtEmail.Text);
                com.Parameters.AddWithValue("@estado_civil", cbEstadoCivil.Text);
                com.Parameters.AddWithValue("@celular", maskCel.Text);
                if (maskData.Text == "  /  /")
                {
                    com.Parameters.AddWithValue("@data_nasc", DBNull.Value);
                }
                else
                {
                    com.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(maskData.Text));
                }
                com.Parameters.AddWithValue("@cidade", cbCidade.Text);
                com.Parameters.AddWithValue("@numero", txtNum.Text);
                com.Parameters.AddWithValue("@bairro", cbBairro.Text.ToUpper());
                com.Parameters.AddWithValue("@cep", maskCep.Text);
                com.Parameters.AddWithValue("@endereco", cbEndereco.Text.ToUpper());
                com.Parameters.AddWithValue("@estado", cbEstado.Text);
                com.Parameters.AddWithValue("@obs", txtObs.Text);
                if (checkActive.Checked)
                {
                    com.Parameters.AddWithValue("@sit_cadastro", 1);
                }
                else
                {
                    com.Parameters.AddWithValue("@sit_cadastro", 0);
                }
                if (radMasc.Checked)
                {
                    com.Parameters.AddWithValue("@Genero", "M");
                }
                else if (radFem.Checked)
                {
                    com.Parameters.AddWithValue("@Genero", "F");
                }
                else
                {
                    com.Parameters.AddWithValue("@Genero", "O");
                }
                com.Parameters.AddWithValue("@tipo_doc", radCpf.Checked ? "CPF" : "CNPJ");
                insertForm(com);
            }
        }
        private void insertForm(MySqlCommand com)
        {
            if (txtCod.Text == "")
            {
                com.CommandText = $"INSERT INTO cliente (nome,documento,tipo_doc,rg,email,estado_civil,celular,Genero," +
            "data_nasc," +
            $"cidade,numero,bairro,cep,endereco,estado,obs,sit_cadastro)" +
            $"VALUES(@nome,@documento,@tipo_doc,@rg,@email,@estado_civil,@celular,@Genero," +
            "@data_nasc," +
            $"@cidade,@numero,@bairro,@cep,@endereco,@estado,@obs,@sit_cadastro)";
            }
            else
            {
                com.CommandText = "UPDATE cliente SET " +
                    "nome = @nome,documento = @documento,tipo_doc = @tipo_doc,rg = @rg,email = @email,estado_civil = @estado_civil" +
                    ",celular = @celular,Genero = @Genero,data_nasc = @data_nasc," +
                    "cidade = @cidade,numero = @numero,bairro = @bairro,cep = @cep,endereco = @endereco,estado = @estado," +
                    "obs = @obs,sit_cadastro = @sit_cadastro WHERE id = " + txtCod.Text;
            }
            com.ExecuteNonQuery();
            if (txtCod.Text == "")
            {

                com.CommandText = "SELECT @@IDENTITY";
                txtCod.Text = com.ExecuteScalar().ToString();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            addDBValuesFromForm();
            MessageBox.Show("OK");
        }
        private bool ValidateForm()
        {
            //CPF & CNPJ
            if (!radCnpj.Checked && !radCpf.Checked)
            {
                radCpf.Focus();
                Utils.msgError("Marcar o tipo de documento");
                return false;
            }
            if (string.IsNullOrEmpty(maskDoc.Text))
            {
                maskDoc.Focus();
                Utils.msgError(radCpf.Checked ? "Digite o CPF" : "Digite o CNPJ");
                return false;
            }
            //Sexo
            if (!radFem.Checked && !radMasc.Checked && !radOutro.Checked)
            {
                radMasc.Focus();
                Utils.msgError("Marcar o Sexo");
                return false;
            }
            //Nome
            var listText = initiateListTextBox();
            foreach (var list in listText)
            {
                if (string.IsNullOrEmpty(list.Text))
                {
                    Utils.msgError($"{list.Name.Substring(3)} é obrigatório");
                    return false;
                }
            }


            //email
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.ToLower().Contains(".com"))
            {
                Utils.msgAlert("Digitar um email válido");
                txtEmail.Focus();
                return false;
            }

            //data
            try
            {
                Convert.ToDateTime(maskData.Text);
            }
            catch (Exception)
            {
                Utils.msgAlert("Digitar uma data válida");
                maskData.Focus();
                return false;
            }
            return true;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!Utils.msgYesNO("Deseja limpar todos os campos?"))
            {
                return;
            }
            Utils.limparCampos(getControls());
            btnSalvar.Text = "Salvar";
            Img.Image = Properties.Resources.esquiador;
        }
        private List<Control> getControls()
        {
            List<Control> controlsList = new List<Control>();
            foreach (Control Controles in this.Controls)
            {
                controlsList.Add(Controles);
                foreach (Control gbox in groupBox1.Controls)
                    controlsList.Add(gbox);
            }
            return controlsList;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void radCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (radCpf.Checked)
            {
                maskDoc.Mask = "000.000.000-00";
                maskDoc.Focus();
            }
        }
        private void radCnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (radCnpj.Checked)
            {
                maskDoc.Mask = "00.000.000/0000-00";
                maskDoc.Focus();
            }
        }
        private void maskData_Validating(object sender, CancelEventArgs e)
        {
            if (maskData.Text == "  /  /")
            {
                return;
            }

            try
            {
                maskData.Text = Convert.ToDateTime(maskData.Text).ToString();
            }
            catch (Exception)
            {
                Utils.msgAlert("Data inválida");
                e.Cancel = true;
            }
        }

        private void cbEstadoCivil_Validating(object sender, CancelEventArgs e)
        {
            if (cbEstadoCivil.SelectedIndex == 0)
            {
                return;
            }
            if (cbEstadoCivil.SelectedIndex == -1)
            {
                Utils.msgAlert("inserir estado cívil válido");
                e.Cancel = true;
            }
        }

        private void cbEstado_Validating(object sender, CancelEventArgs e)
        {
            if (cbEstado.SelectedIndex == 0)
            {
                return;
            }
            if (cbEstado.SelectedIndex == -1)
            {
                Utils.msgAlert("inserir estado válido");
                e.Cancel = true;
            }
        }

        private void maskCep_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Jcep jcep = new Jcep();
                if (maskCep.Text.Length == 0)
                {
                    return;

                }
                if (maskCep.Text.Trim(' ').Length < 8)
                {
                    Utils.msgAlert("digitar cep válido");
                    e.Cancel = true;
                    return;
                }



                using (HttpClient client = new HttpClient())
                {
                    lblLoad.Visible =  true;
                    Application.DoEvents();
                    HttpResponseMessage res = client.GetAsync($"https://viacep.com.br/ws/{maskCep.Text.ToString()}/json/").Result;


                    jcep = JsonConvert.DeserializeObject<Jcep>(res.Content.ReadAsStringAsync().Result);
                    fillLoc(jcep);
                }
            }
            catch (Exception)
            {

                Utils.msgError($"Erro ao buscar o CEP, \rfavor verifique sua conexão");
            }

            lblLoad.Visible = false;
            Application.DoEvents();
        }
        private void fillLoc(Jcep jsonClass)
        {
            if (!string.IsNullOrEmpty(jsonClass.erro))
            {
                Utils.limparCampos(new List<Control> { cbEndereco, cbCidade, cbBairro, cbEstado});
                Utils.msgError("Cep não existe");
                return;
            }
            cbEndereco.Text = jsonClass.logradouro;
            cbCidade.Text = jsonClass.localidade;
            cbBairro.Text = jsonClass.bairro;
            cbEstado.Text = jsonClass.estado;
        }
        private void maskDoc_Validating(object sender, CancelEventArgs e)
        {
            if (maskDoc.Text.Length == 0)
                return;
            if (radCnpj.Checked && maskDoc.Text.Replace(" ", "").Length < 14
                    || radCpf.Checked && maskDoc.Text.Replace(" ", "").Length < 11)
            {

                Utils.msgAlert("digitar documento válido");
                e.Cancel = true;
            }
        }

        private void BtnAddImg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text))
            {
                Utils.msgError("Favor adicionar uma imagen em um cliente com código válido");
                return;
            }
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] extension = dialog.FileName.Split('.');

                Img.Image = Image.FromFile(dialog.FileName);
                File.Copy(dialog.FileName, _imgPath + txtCod.Text + ".png");
            }
        }

        private void Img_Click(object sender, EventArgs e)
        {
        }

        private void BtnRemoveImg_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCod.Text))
            {
                Utils.msgError("Não há fotos para deletar");
                return;
            }
            if (!File.Exists(_imgPath + txtCod.Text + ".png"))
            {
                Utils.msgError("Foto não existe para deletar");
                return;
            }
            if (!Utils.msgYesNO("Deseja remover a foto?"))
                return;

            File.Delete(_imgPath + txtCod.Text + ".png");
            Img.Image = Properties.Resources.esquiador;

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
