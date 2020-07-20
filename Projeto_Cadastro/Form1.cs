using System;
using System.Windows.Forms;

namespace Projeto_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_CadDataSet);
            MessageBox.Show("Cadastro salvo!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_CadDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.bD_CadDataSet.Table);

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro excluído!");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
