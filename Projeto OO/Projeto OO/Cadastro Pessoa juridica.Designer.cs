namespace Projeto_OO
{
    partial class Cadastro_Pessoa_juridica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Pessoa_juridica));
            System.Windows.Forms.Label razao_socialLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label fK_EnderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label e_mailLabel;
            this.banco_de_Dados_Projeto_OOTESTE = new Projeto_OO.Banco_de_Dados_Projeto_OOTESTE();
            this.cLIENTE_JURIDICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTE_JURIDICOTableAdapter = new Projeto_OO.Banco_de_Dados_Projeto_OOTESTETableAdapters.CLIENTE_JURIDICOTableAdapter();
            this.tableAdapterManager = new Projeto_OO.Banco_de_Dados_Projeto_OOTESTETableAdapters.TableAdapterManager();
            this.cLIENTE_JURIDICOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cLIENTE_JURIDICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razao_socialTextBox = new System.Windows.Forms.TextBox();
            this.cNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fK_EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.eNDERECOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNDERECOTableAdapter = new Projeto_OO.Banco_de_Dados_Projeto_OOTESTETableAdapters.ENDERECOTableAdapter();
            this.eNDERECODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            razao_socialLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            fK_EnderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_Dados_Projeto_OOTESTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTE_JURIDICOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTE_JURIDICOBindingNavigator)).BeginInit();
            this.cLIENTE_JURIDICOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTE_JURIDICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // banco_de_Dados_Projeto_OOTESTE
            // 
            this.banco_de_Dados_Projeto_OOTESTE.DataSetName = "Banco_de_Dados_Projeto_OOTESTE";
            this.banco_de_Dados_Projeto_OOTESTE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTE_JURIDICOBindingSource
            // 
            this.cLIENTE_JURIDICOBindingSource.DataMember = "CLIENTE_JURIDICO";
            this.cLIENTE_JURIDICOBindingSource.DataSource = this.banco_de_Dados_Projeto_OOTESTE;
            // 
            // cLIENTE_JURIDICOTableAdapter
            // 
            this.cLIENTE_JURIDICOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTE_JURIDICOTableAdapter = this.cLIENTE_JURIDICOTableAdapter;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.ENDERECOTableAdapter = this.eNDERECOTableAdapter;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_OO.Banco_de_Dados_Projeto_OOTESTETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDA_rel_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDATableAdapter = null;
            // 
            // cLIENTE_JURIDICOBindingNavigator
            // 
            this.cLIENTE_JURIDICOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTE_JURIDICOBindingNavigator.BindingSource = this.cLIENTE_JURIDICOBindingSource;
            this.cLIENTE_JURIDICOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTE_JURIDICOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTE_JURIDICOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem});
            this.cLIENTE_JURIDICOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLIENTE_JURIDICOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTE_JURIDICOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTE_JURIDICOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTE_JURIDICOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTE_JURIDICOBindingNavigator.Name = "cLIENTE_JURIDICOBindingNavigator";
            this.cLIENTE_JURIDICOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTE_JURIDICOBindingNavigator.Size = new System.Drawing.Size(530, 25);
            this.cLIENTE_JURIDICOBindingNavigator.TabIndex = 0;
            this.cLIENTE_JURIDICOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // cLIENTE_JURIDICOBindingNavigatorSaveItem
            // 
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTE_JURIDICOBindingNavigatorSaveItem.Image")));
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem.Name = "cLIENTE_JURIDICOBindingNavigatorSaveItem";
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cLIENTE_JURIDICOBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTE_JURIDICOBindingNavigatorSaveItem_Click);
            // 
            // cLIENTE_JURIDICODataGridView
            // 
            this.cLIENTE_JURIDICODataGridView.AutoGenerateColumns = false;
            this.cLIENTE_JURIDICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTE_JURIDICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cLIENTE_JURIDICODataGridView.DataSource = this.cLIENTE_JURIDICOBindingSource;
            this.cLIENTE_JURIDICODataGridView.Location = new System.Drawing.Point(12, 355);
            this.cLIENTE_JURIDICODataGridView.Name = "cLIENTE_JURIDICODataGridView";
            this.cLIENTE_JURIDICODataGridView.Size = new System.Drawing.Size(506, 79);
            this.cLIENTE_JURIDICODataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Razao social";
            this.dataGridViewTextBoxColumn2.HeaderText = "Razao social";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FK_Endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "FK_Endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "E-mail";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // razao_socialLabel
            // 
            razao_socialLabel.AutoSize = true;
            razao_socialLabel.Location = new System.Drawing.Point(46, 51);
            razao_socialLabel.Name = "razao_socialLabel";
            razao_socialLabel.Size = new System.Drawing.Size(71, 13);
            razao_socialLabel.TabIndex = 4;
            razao_socialLabel.Text = "Razao social:";
            // 
            // razao_socialTextBox
            // 
            this.razao_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTE_JURIDICOBindingSource, "Razao social", true));
            this.razao_socialTextBox.Enabled = false;
            this.razao_socialTextBox.Location = new System.Drawing.Point(124, 48);
            this.razao_socialTextBox.Name = "razao_socialTextBox";
            this.razao_socialTextBox.Size = new System.Drawing.Size(100, 20);
            this.razao_socialTextBox.TabIndex = 1;
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(46, 77);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(37, 13);
            cNPJLabel.TabIndex = 6;
            cNPJLabel.Text = "CNPJ:";
            // 
            // cNPJMaskedTextBox
            // 
            this.cNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTE_JURIDICOBindingSource, "CNPJ", true));
            this.cNPJMaskedTextBox.Enabled = false;
            this.cNPJMaskedTextBox.Location = new System.Drawing.Point(124, 74);
            this.cNPJMaskedTextBox.Mask = "99.999.999/9999-99";
            this.cNPJMaskedTextBox.Name = "cNPJMaskedTextBox";
            this.cNPJMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cNPJMaskedTextBox.TabIndex = 2;
            // 
            // fK_EnderecoLabel
            // 
            fK_EnderecoLabel.AutoSize = true;
            fK_EnderecoLabel.Location = new System.Drawing.Point(46, 103);
            fK_EnderecoLabel.Name = "fK_EnderecoLabel";
            fK_EnderecoLabel.Size = new System.Drawing.Size(68, 13);
            fK_EnderecoLabel.TabIndex = 8;
            fK_EnderecoLabel.Text = "Id Endereco:";
            // 
            // fK_EnderecoTextBox
            // 
            this.fK_EnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTE_JURIDICOBindingSource, "FK_Endereco", true));
            this.fK_EnderecoTextBox.Enabled = false;
            this.fK_EnderecoTextBox.Location = new System.Drawing.Point(124, 100);
            this.fK_EnderecoTextBox.Name = "fK_EnderecoTextBox";
            this.fK_EnderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.fK_EnderecoTextBox.TabIndex = 3;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(46, 129);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 10;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTE_JURIDICOBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Enabled = false;
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(124, 126);
            this.telefoneMaskedTextBox.Mask = "(99)9999-9999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneMaskedTextBox.TabIndex = 5;
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(46, 155);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(38, 13);
            e_mailLabel.TabIndex = 12;
            e_mailLabel.Text = "E-mail:";
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTE_JURIDICOBindingSource, "E-mail", true));
            this.e_mailTextBox.Enabled = false;
            this.e_mailTextBox.Location = new System.Drawing.Point(124, 152);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_mailTextBox.TabIndex = 6;
            // 
            // eNDERECOBindingSource
            // 
            this.eNDERECOBindingSource.DataMember = "ENDERECO";
            this.eNDERECOBindingSource.DataSource = this.banco_de_Dados_Projeto_OOTESTE;
            // 
            // eNDERECOTableAdapter
            // 
            this.eNDERECOTableAdapter.ClearBeforeFill = true;
            // 
            // eNDERECODataGridView
            // 
            this.eNDERECODataGridView.AutoGenerateColumns = false;
            this.eNDERECODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eNDERECODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.eNDERECODataGridView.DataSource = this.eNDERECOBindingSource;
            this.eNDERECODataGridView.Location = new System.Drawing.Point(12, 222);
            this.eNDERECODataGridView.Name = "eNDERECODataGridView";
            this.eNDERECODataGridView.Size = new System.Drawing.Size(509, 77);
            this.eNDERECODataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn8.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Rua";
            this.dataGridViewTextBoxColumn9.HeaderText = "Rua";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Bairoo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Bairoo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn11.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tabela Endereços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "tabela Cliente Juridico";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "adicionarEndereco";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastro_Pessoa_juridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eNDERECODataGridView);
            this.Controls.Add(razao_socialLabel);
            this.Controls.Add(this.razao_socialTextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJMaskedTextBox);
            this.Controls.Add(fK_EnderecoLabel);
            this.Controls.Add(this.fK_EnderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(this.cLIENTE_JURIDICODataGridView);
            this.Controls.Add(this.cLIENTE_JURIDICOBindingNavigator);
            this.Name = "Cadastro_Pessoa_juridica";
            this.Text = "Cadastro_Pessoa_juridica";
            this.Load += new System.EventHandler(this.Cadastro_Pessoa_juridica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_Dados_Projeto_OOTESTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTE_JURIDICOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTE_JURIDICOBindingNavigator)).EndInit();
            this.cLIENTE_JURIDICOBindingNavigator.ResumeLayout(false);
            this.cLIENTE_JURIDICOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTE_JURIDICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Banco_de_Dados_Projeto_OOTESTE banco_de_Dados_Projeto_OOTESTE;
        private System.Windows.Forms.BindingSource cLIENTE_JURIDICOBindingSource;
        private Banco_de_Dados_Projeto_OOTESTETableAdapters.CLIENTE_JURIDICOTableAdapter cLIENTE_JURIDICOTableAdapter;
        private Banco_de_Dados_Projeto_OOTESTETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTE_JURIDICOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cLIENTE_JURIDICOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cLIENTE_JURIDICODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Banco_de_Dados_Projeto_OOTESTETableAdapters.ENDERECOTableAdapter eNDERECOTableAdapter;
        private System.Windows.Forms.TextBox razao_socialTextBox;
        private System.Windows.Forms.MaskedTextBox cNPJMaskedTextBox;
        private System.Windows.Forms.TextBox fK_EnderecoTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.BindingSource eNDERECOBindingSource;
        private System.Windows.Forms.DataGridView eNDERECODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}