namespace Final_Prj.Decoration_View
{
    partial class StudyTask_Form
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
            this.dataGridViewStudyTask = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudyTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudyTask
            // 
            this.dataGridViewStudyTask.AllowUserToOrderColumns = true;
            this.dataGridViewStudyTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudyTask.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewStudyTask.Name = "dataGridViewStudyTask";
            this.dataGridViewStudyTask.Size = new System.Drawing.Size(979, 379);
            this.dataGridViewStudyTask.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(917, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StudyTask_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 514);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewStudyTask);
            this.Name = "StudyTask_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Task Timeline";
            this.Load += new System.EventHandler(this.StudyTask_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudyTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudyTask;
        private System.Windows.Forms.Button btnClose;
    }
}