namespace NameManager.WordManager
{
    partial class WordMainForm
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
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBLWORDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvWordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWORDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(52, 64);
            this.txtTextBox.Multiline = true;
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(254, 31);
            this.txtTextBox.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(321, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tBLWORDBindingSource
            // 
            this.tBLWORDBindingSource.DataMember = "TBLWORD";
            // 
            // tBLWORDTableAdapter
            // 
            // dgvWordList
            // 
            this.dgvWordList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvWordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWordList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvWordList.Location = new System.Drawing.Point(52, 118);
            this.dgvWordList.Name = "dgvWordList";
            this.dgvWordList.RowTemplate.Height = 23;
            this.dgvWordList.Size = new System.Drawing.Size(696, 271);
            this.dgvWordList.TabIndex = 6;
            // 
            // WordMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 440);
            this.Controls.Add(this.dgvWordList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTextBox);
            this.Name = "WordMainForm";
            this.Text = "WordMainForm";
            this.Load += new System.EventHandler(this.WordMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLWORDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource tBLWORDBindingSource;
        private System.Windows.Forms.DataGridView dgvWordList;
    }
}