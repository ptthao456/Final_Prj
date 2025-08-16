namespace Final_Prj.Decoration_View
{
    partial class WorkTask_Form
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
            this.dataGridViewWorkTask = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkTask
            // 
            this.dataGridViewWorkTask.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridViewWorkTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkTask.Location = new System.Drawing.Point(23, 12);
            this.dataGridViewWorkTask.Name = "dataGridViewWorkTask";
            this.dataGridViewWorkTask.Size = new System.Drawing.Size(943, 416);
            this.dataGridViewWorkTask.TabIndex = 0;
            this.dataGridViewWorkTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkTask_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(891, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WorkTask_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewWorkTask);
            this.Name = "WorkTask_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Task Timeline";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWorkTask;
        private System.Windows.Forms.Button btnClose;
    }
}