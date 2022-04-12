
namespace week12_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(118, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read from CSV";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // grid
            // 
            this.grid.AllowDrop = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(13, 41);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(525, 395);
            this.grid.TabIndex = 1;
            this.grid.DragDrop += new System.Windows.Forms.DragEventHandler(this.grid_DragDrop);
            this.grid.DragOver += new System.Windows.Forms.DragEventHandler(this.grid_DragOver);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save to CSV";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listCategories
            // 
            this.listCategories.FormattingEnabled = true;
            this.listCategories.Location = new System.Drawing.Point(545, 41);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(130, 394);
            this.listCategories.TabIndex = 3;
            this.listCategories.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listCategories_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Known Categories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listCategories;
        private System.Windows.Forms.Label label1;
    }
}

