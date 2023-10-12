using bdKonukIvanpr22._106._22_106_10_KafedraDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdKonukIvanpr22._106.Pages
{
    public partial class Disciplini : Form
    {
        public Disciplini()
        {
            InitializeComponent();
        }

        private void discipliniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discipliniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._22_106_10_KafedraDataSet);

        }

        private void Disciplini_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_22_106_10_KafedraDataSet.Disciplini". При необходимости она может быть перемещена или удалена.
            this.discipliniTableAdapter.Fill(this._22_106_10_KafedraDataSet.Disciplini);

        }
    }
}
