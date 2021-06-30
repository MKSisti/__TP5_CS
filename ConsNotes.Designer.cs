
namespace _TP_5
{
    partial class ConsNotes
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
            this.comFiliere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comMatiere = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comNiveau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // comFiliere
            // 
            this.comFiliere.FormattingEnabled = true;
            this.comFiliere.Location = new System.Drawing.Point(21, 39);
            this.comFiliere.Name = "comFiliere";
            this.comFiliere.Size = new System.Drawing.Size(244, 21);
            this.comFiliere.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filiere";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(339, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comMatiere
            // 
            this.comMatiere.FormattingEnabled = true;
            this.comMatiere.Location = new System.Drawing.Point(21, 82);
            this.comMatiere.Name = "comMatiere";
            this.comMatiere.Size = new System.Drawing.Size(244, 21);
            this.comMatiere.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matiere";
            // 
            // comNiveau
            // 
            this.comNiveau.FormattingEnabled = true;
            this.comNiveau.Location = new System.Drawing.Point(21, 128);
            this.comNiveau.Name = "comNiveau";
            this.comNiveau.Size = new System.Drawing.Size(244, 21);
            this.comNiveau.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Niveau";
            // 
            // dgvNotes
            // 
            this.dgvNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(21, 212);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.Size = new System.Drawing.Size(393, 246);
            this.dgvNotes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Moyenne de la class";
            // 
            // txtMoy
            // 
            this.txtMoy.Location = new System.Drawing.Point(168, 483);
            this.txtMoy.Name = "txtMoy";
            this.txtMoy.Size = new System.Drawing.Size(164, 20);
            this.txtMoy.TabIndex = 5;
            // 
            // ConsNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 515);
            this.Controls.Add(this.txtMoy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comNiveau);
            this.Controls.Add(this.comMatiere);
            this.Controls.Add(this.comFiliere);
            this.Name = "ConsNotes";
            this.Text = "ConsNotes";
            this.Load += new System.EventHandler(this.ConsNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comFiliere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comMatiere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comNiveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoy;
    }
}