using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_OO
{
    public partial class Cadastro_Endereco : Form
    {
        public Cadastro_Endereco()
        {
            InitializeComponent();
        }

        private void eNDERECOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eNDERECOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_de_Dados_Projeto_OOTESTE);

        }

        private void Cadastro_Endereco_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_de_Dados_Projeto_OOTESTE.ENDERECO'. Você pode movê-la ou removê-la conforme necessário.
            this.eNDERECOTableAdapter.Fill(this.banco_de_Dados_Projeto_OOTESTE.ENDERECO);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cEPMaskedTextBox.Enabled = true;
            ruaTextBox.Enabled = true;
            bairooTextBox.Enabled = true;
            numeroTextBox.Enabled = true;
        }
    }
}
