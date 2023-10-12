namespace bdKonukIvanpr22._106.Forms
{
    partial class Gruppi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gruppi));
            this._22_106_10_KafedraDataSet = new bdKonukIvanpr22._106._22_106_10_KafedraDataSet();
            this.gruppiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruppiTableAdapter = new bdKonukIvanpr22._106._22_106_10_KafedraDataSetTableAdapters.GruppiTableAdapter();
            this.tableAdapterManager = new bdKonukIvanpr22._106._22_106_10_KafedraDataSetTableAdapters.TableAdapterManager();
            this.gruppiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gruppiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gruppiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._22_106_10_KafedraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingNavigator)).BeginInit();
            this.gruppiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _22_106_10_KafedraDataSet
            // 
            this._22_106_10_KafedraDataSet.DataSetName = "_22_106_10_KafedraDataSet";
            this._22_106_10_KafedraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruppiBindingSource
            // 
            this.gruppiBindingSource.DataMember = "Gruppi";
            this.gruppiBindingSource.DataSource = this._22_106_10_KafedraDataSet;
            // 
            // gruppiTableAdapter
            // 
            this.gruppiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiscipliniTableAdapter = null;
            this.tableAdapterManager.FacultetiTableAdapter = null;
            this.tableAdapterManager.GruppiTableAdapter = this.gruppiTableAdapter;
            this.tableAdapterManager.KafedraTableAdapter = null;
            this.tableAdapterManager.PodchenennaiaTablicaVedomostiTableAdapter = null;
            this.tableAdapterManager.PrepodavateliTableAdapter = null;
            this.tableAdapterManager.StudentiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = bdKonukIvanpr22._106._22_106_10_KafedraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VedomostiTableAdapter = null;
            // 
            // gruppiBindingNavigator
            // 
            this.gruppiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gruppiBindingNavigator.BindingSource = this.gruppiBindingSource;
            this.gruppiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gruppiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gruppiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gruppiBindingNavigatorSaveItem});
            this.gruppiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gruppiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gruppiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gruppiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gruppiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gruppiBindingNavigator.Name = "gruppiBindingNavigator";
            this.gruppiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gruppiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.gruppiBindingNavigator.TabIndex = 0;
            this.gruppiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // gruppiBindingNavigatorSaveItem
            // 
            this.gruppiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gruppiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gruppiBindingNavigatorSaveItem.Image")));
            this.gruppiBindingNavigatorSaveItem.Name = "gruppiBindingNavigatorSaveItem";
            this.gruppiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.gruppiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.gruppiBindingNavigatorSaveItem.Click += new System.EventHandler(this.gruppiBindingNavigatorSaveItem_Click);
            // 
            // gruppiDataGridView
            // 
            this.gruppiDataGridView.AutoGenerateColumns = false;
            this.gruppiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gruppiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gruppiDataGridView.DataSource = this.gruppiBindingSource;
            this.gruppiDataGridView.Location = new System.Drawing.Point(73, 47);
            this.gruppiDataGridView.Name = "gruppiDataGridView";
            this.gruppiDataGridView.Size = new System.Drawing.Size(544, 274);
            this.gruppiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Kod gruppi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kod gruppi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kod kafedri";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kod kafedri";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nomer gruppi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nomer gruppi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "God postuplenia";
            this.dataGridViewTextBoxColumn4.HeaderText = "God postuplenia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kurs obuchenia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kurs obuchenia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Gruppi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gruppiDataGridView);
            this.Controls.Add(this.gruppiBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Gruppi";
            this.Text = "Gruppi";
            this.Load += new System.EventHandler(this.Gruppi_Load);
            ((System.ComponentModel.ISupportInitialize)(this._22_106_10_KafedraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingNavigator)).EndInit();
            this.gruppiBindingNavigator.ResumeLayout(false);
            this.gruppiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _22_106_10_KafedraDataSet _22_106_10_KafedraDataSet;
        private System.Windows.Forms.BindingSource gruppiBindingSource;
        private _22_106_10_KafedraDataSetTableAdapters.GruppiTableAdapter gruppiTableAdapter;
        private _22_106_10_KafedraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gruppiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gruppiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gruppiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}