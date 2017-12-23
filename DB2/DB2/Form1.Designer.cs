namespace DB2
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
            this.humanGrid = new System.Windows.Forms.DataGridView();
            this.moreGrid = new System.Windows.Forms.DataGridView();
            this.studGrid = new System.Windows.Forms.DataGridView();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.humanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // humanGrid
            // 
            this.humanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.humanGrid.Location = new System.Drawing.Point(13, 13);
            this.humanGrid.Name = "humanGrid";
            this.humanGrid.Size = new System.Drawing.Size(365, 346);
            this.humanGrid.TabIndex = 0;
            this.humanGrid.DoubleClick += new System.EventHandler(this.humanGrid_DoubleClick);
            // 
            // moreGrid
            // 
            this.moreGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moreGrid.Location = new System.Drawing.Point(384, 13);
            this.moreGrid.Name = "moreGrid";
            this.moreGrid.Size = new System.Drawing.Size(365, 175);
            this.moreGrid.TabIndex = 1;
            // 
            // studGrid
            // 
            this.studGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrid.Location = new System.Drawing.Point(384, 194);
            this.studGrid.Name = "studGrid";
            this.studGrid.Size = new System.Drawing.Size(365, 165);
            this.studGrid.TabIndex = 2;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(13, 366);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(132, 23);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Добавить человека";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(289, 366);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить человека";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.studGrid);
            this.Controls.Add(this.moreGrid);
            this.Controls.Add(this.humanGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.humanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView humanGrid;
        private System.Windows.Forms.DataGridView moreGrid;
        private System.Windows.Forms.DataGridView studGrid;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
    }
}

