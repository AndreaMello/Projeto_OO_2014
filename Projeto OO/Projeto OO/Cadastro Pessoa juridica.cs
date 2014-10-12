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
    public partial class Cadastro_Pessoa_juridica : Form
    {
        public Cadastro_Pessoa_juridica()
        {
            InitializeComponent();
        }

        private void cLIENTE_JURIDICOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTE_JURIDICOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_de_Dados_Projeto_OOTESTE);

        }

        private void Cadastro_Pessoa_juridica_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_de_Dados_Projeto_OOTESTE.ENDERECO'. Você pode movê-la ou removê-la conforme necessário.
            this.eNDERECOTableAdapter.Fill(this.banco_de_Dados_Projeto_OOTESTE.ENDERECO);
            // TODO: esta linha de código carrega dados na tabela 'banco_de_Dados_Projeto_OOTESTE.CLIENTE_JURIDICO'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTE_JURIDICOTableAdapter.Fill(this.banco_de_Dados_Projeto_OOTESTE.CLIENTE_JURIDICO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_Endereco cade = new Cadastro_Endereco();
            cade.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            razao_socialTextBox.Enabled = true;
            cNPJMaskedTextBox.Enabled = true;
            fK_EnderecoTextBox.Enabled = true;
            telefoneMaskedTextBox.Enabled = true;
            e_mailTextBox.Enabled = true;
            // TODO: esta linha de código carrega dados na tabela 'banco_de_Dados_Projeto_OOTESTE.ENDERECO'. Você pode movê-la ou removê-la conforme necessário.
            this.eNDERECOTableAdapter.Fill(this.banco_de_Dados_Projeto_OOTESTE.ENDERECO);

        }
    }
}
