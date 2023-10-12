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
    public partial class Faculteti : Form
    {
        public Faculteti()
        {
            InitializeComponent();
        }

        private void facultetiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultetiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._22_106_10_KafedraDataSet);

        }

        private void Faculteti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_22_106_10_KafedraDataSet.Faculteti". При необходимости она может быть перемещена или удалена.
            this.facultetiTableAdapter.Fill(this._22_106_10_KafedraDataSet.Faculteti);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
