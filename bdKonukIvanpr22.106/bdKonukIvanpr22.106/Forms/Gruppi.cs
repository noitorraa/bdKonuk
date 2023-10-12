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
    public partial class Gruppi : Form
    {
        public Gruppi()
        {
            InitializeComponent();
        }

        private void gruppiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruppiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._22_106_10_KafedraDataSet);

        }

        private void Gruppi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_22_106_10_KafedraDataSet.Gruppi". При необходимости она может быть перемещена или удалена.
            this.gruppiTableAdapter.Fill(this._22_106_10_KafedraDataSet.Gruppi);

        }
    }
}
