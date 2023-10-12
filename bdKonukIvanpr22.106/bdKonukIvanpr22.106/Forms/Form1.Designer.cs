namespace bdKonukIvanpr22._106
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisc = new System.Windows.Forms.Button();
            this.btnFac = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnKaf = new System.Windows.Forms.Button();
            this.btnPodTab = new System.Windows.Forms.Button();
            this.btnPrep = new System.Windows.Forms.Button();
            this.btnStud = new System.Windows.Forms.Button();
            this.btnVed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблицы";
            // 
            // btnDisc
            // 
            this.btnDisc.Location = new System.Drawing.Point(85, 93);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(188, 23);
            this.btnDisc.TabIndex = 1;
            this.btnDisc.Text = "Дисциплины";
            this.btnDisc.UseVisualStyleBackColor = true;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // btnFac
            // 
            this.btnFac.Location = new System.Drawing.Point(85, 122);
            this.btnFac.Name = "btnFac";
            this.btnFac.Size = new System.Drawing.Size(188, 23);
            this.btnFac.TabIndex = 2;
            this.btnFac.Text = "Факультеты";
            this.btnFac.UseVisualStyleBackColor = true;
            this.btnFac.Click += new System.EventHandler(this.btnFac_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(85, 151);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(188, 23);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.Text = "Группы";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnKaf
            // 
            this.btnKaf.Location = new System.Drawing.Point(85, 180);
            this.btnKaf.Name = "btnKaf";
            this.btnKaf.Size = new System.Drawing.Size(188, 23);
            this.btnKaf.TabIndex = 4;
            this.btnKaf.Text = "Кафедра";
            this.btnKaf.UseVisualStyleBackColor = true;
            this.btnKaf.Click += new System.EventHandler(this.btnKaf_Click);
            // 
            // btnPodTab
            // 
            this.btnPodTab.Location = new System.Drawing.Point(85, 209);
            this.btnPodTab.Name = "btnPodTab";
            this.btnPodTab.Size = new System.Drawing.Size(188, 23);
            this.btnPodTab.TabIndex = 5;
            this.btnPodTab.Text = "Подчиненные ведомости";
            this.btnPodTab.UseVisualStyleBackColor = true;
            this.btnPodTab.Click += new System.EventHandler(this.btnPodTab_Click);
            // 
            // btnPrep
            // 
            this.btnPrep.Location = new System.Drawing.Point(85, 238);
            this.btnPrep.Name = "btnPrep";
            this.btnPrep.Size = new System.Drawing.Size(188, 23);
            this.btnPrep.TabIndex = 6;
            this.btnPrep.Text = "Преподаватели";
            this.btnPrep.UseVisualStyleBackColor = true;
            this.btnPrep.Click += new System.EventHandler(this.btnPrep_Click);
            // 
            // btnStud
            // 
            this.btnStud.Location = new System.Drawing.Point(85, 267);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(188, 23);
            this.btnStud.TabIndex = 7;
            this.btnStud.Text = "Студенты";
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // btnVed
            // 
            this.btnVed.Location = new System.Drawing.Point(85, 296);
            this.btnVed.Name = "btnVed";
            this.btnVed.Size = new System.Drawing.Size(188, 23);
            this.btnVed.TabIndex = 8;
            this.btnVed.Text = "Ведомости";
            this.btnVed.UseVisualStyleBackColor = true;
            this.btnVed.Click += new System.EventHandler(this.btnVed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 398);
            this.Controls.Add(this.btnVed);
            this.Controls.Add(this.btnStud);
            this.Controls.Add(this.btnPrep);
            this.Controls.Add(this.btnPodTab);
            this.Controls.Add(this.btnKaf);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnFac);
            this.Controls.Add(this.btnDisc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Приложение для бд \"Кафедра\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisc;
        private System.Windows.Forms.Button btnFac;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnKaf;
        private System.Windows.Forms.Button btnPodTab;
        private System.Windows.Forms.Button btnPrep;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.Button btnVed;
    }
}

