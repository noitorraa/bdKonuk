using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdKonukIvanpr22._106.Forms
{
    public partial class Kafedra : Form
    {
        public Kafedra()
        {
            InitializeComponent();
        }

        private void kafedraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kafedraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._22_106_10_KafedraDataSet);

        }

        private void Kafedra_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_22_106_10_KafedraDataSet.Kafedra". При необходимости она может быть перемещена или удалена.
            this.kafedraTableAdapter.Fill(this._22_106_10_KafedraDataSet.Kafedra);

        }
    }
}
