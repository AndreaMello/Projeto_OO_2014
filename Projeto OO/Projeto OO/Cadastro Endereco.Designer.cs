namespace Projeto_OO
{
    partial class Cadastro_Endereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Endereco));
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label bairooLabel;
            System.Windows.Forms.Label numeroLabel;
            this.banco_de_Dados_Projeto_OOTESTE = new Projeto_OO.Banco_de_Dados_Projeto_OOTESTE();
            this.eNDERECOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNDERECOTableAdapter = new Projeto_OO.Banco_de_Dados_Projeto_OOTESTETableAdapters.ENDERECOTableAdapter();
            this.tableAdapterManager = new Projeto_OO.Banco_de_Dados_Projeto_OOTESTETableAdapters.TableAdapterManager();
            this.eNDERECOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eNDERECOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.bairooTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.eNDERECODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cEPLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            bairooLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_Dados_Projeto_OOTESTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingNavigator)).BeginInit();
            this.eNDERECOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // banco_de_Dados_Projeto_OOTESTE
            // 
            this.banco_de_Dados_Projeto_OOTESTE.DataSetName = "Banco_de_Dados_Projeto_OOTESTE";
            this.banco_de_Dados_Projeto_OOTESTE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTE_JURIDICOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.ENDERECOTableAdapter = this.eNDERECOTableAdapter;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_OO.Banco_de_Dados_Projeto_OOTESTETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDA_rel_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDATableAdapter = null;
            // 
            // eNDERECOBindingNavigator
            // 
            this.eNDERECOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eNDERECOBindingNavigator.BindingSource = this.eNDERECOBindingSource;
            this.eNDERECOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eNDERECOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eNDERECOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eNDERECOBindingNavigatorSaveItem});
            this.eNDERECOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eNDERECOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eNDERECOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eNDERECOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eNDERECOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eNDERECOBindingNavigator.Name = "eNDERECOBindingNavigator";
            this.eNDERECOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eNDERECOBindingNavigator.Size = new System.Drawing.Size(556, 25);
            this.eNDERECOBindingNavigator.TabIndex = 0;
            this.eNDERECOBindingNavigator.Text = "bindingNavigator1";
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
            // eNDERECOBindingNavigatorSaveItem
            // 
            this.eNDERECOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eNDERECOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eNDERECOBindingNavigatorSaveItem.Image")));
            this.eNDERECOBindingNavigatorSaveItem.Name = "eNDERECOBindingNavigatorSaveItem";
            this.eNDERECOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eNDERECOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.eNDERECOBindingNavigatorSaveItem.Click += new System.EventHandler(this.eNDERECOBindingNavigatorSaveItem_Click);
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(27, 54);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 1;
            cEPLabel.Text = "CEP:";
            // 
            // cEPMaskedTextBox
            // 
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eNDERECOBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Enabled = false;
            this.cEPMaskedTextBox.Location = new System.Drawing.Point(80, 51);
            this.cEPMaskedTextBox.Mask = "99999-999";
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            this.cEPMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEPMaskedTextBox.TabIndex = 1;
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Location = new System.Drawing.Point(27, 80);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(30, 13);
            ruaLabel.TabIndex = 3;
            ruaLabel.Text = "Rua:";
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eNDERECOBindingSource, "Rua", true));
            this.ruaTextBox.Enabled = false;
            this.ruaTextBox.Location = new System.Drawing.Point(80, 77);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ruaTextBox.TabIndex = 2;
            // 
            // bairooLabel
            // 
            bairooLabel.AutoSize = true;
            bairooLabel.Location = new System.Drawing.Point(27, 106);
            bairooLabel.Name = "bairooLabel";
            bairooLabel.Size = new System.Drawing.Size(40, 13);
            bairooLabel.TabIndex = 5;
            bairooLabel.Text = "Bairoo:";
            // 
            // bairooTextBox
            // 
            this.bairooTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eNDERECOBindingSource, "Bairoo", true));
            this.bairooTextBox.Enabled = false;
            this.bairooTextBox.Location = new System.Drawing.Point(80, 103);
            this.bairooTextBox.Name = "bairooTextBox";
            this.bairooTextBox.Size = new System.Drawing.Size(100, 20);
            this.bairooTextBox.TabIndex = 3;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(27, 132);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 7;
            numeroLabel.Text = "Numero:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eNDERECOBindingSource, "Numero", true));
            this.numeroTextBox.Enabled = false;
            this.numeroTextBox.Location = new System.Drawing.Point(80, 129);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTextBox.TabIndex = 4;
            // 
            // eNDERECODataGridView
            // 
            this.eNDERECODataGridView.AutoGenerateColumns = false;
            this.eNDERECODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eNDERECODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.eNDERECODataGridView.DataSource = this.eNDERECOBindingSource;
            this.eNDERECODataGridView.Location = new System.Drawing.Point(12, 189);
            this.eNDERECODataGridView.Name = "eNDERECODataGridView";
            this.eNDERECODataGridView.Size = new System.Drawing.Size(532, 85);
            this.eNDERECODataGridView.TabIndex = 5;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn2.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rua";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rua";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Bairoo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Bairoo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn5.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Cadastro_Endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 435);
            this.Controls.Add(this.eNDERECODataGridView);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(bairooLabel);
            this.Controls.Add(this.bairooTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.eNDERECOBindingNavigator);
            this.Name = "Cadastro_Endereco";
            this.Text = "Cadastro_Endereco";
            this.Load += new System.EventHandler(this.Cadastro_Endereco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_Dados_Projeto_OOTESTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECOBindingNavigator)).EndInit();
            this.eNDERECOBindingNavigator.ResumeLayout(false);
            this.eNDERECOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eNDERECODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Banco_de_Dados_Projeto_OOTESTE banco_de_Dados_Projeto_OOTESTE;
        private System.Windows.Forms.BindingSource eNDERECOBindingSource;
        private Banco_de_Dados_Projeto_OOTESTETableAdapters.ENDERECOTableAdapter eNDERECOTableAdapter;
        private Banco_de_Dados_Projeto_OOTESTETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eNDERECOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eNDERECOBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.TextBox bairooTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.DataGridView eNDERECODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}