
namespace _TP_5
{
    partial class Bilan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comNiveau = new System.Windows.Forms.ComboBox();
            this.comEt = new System.Windows.Forms.ComboBox();
            this.comFiliere = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filiere";
            // 
            // txtMoy
            // 
            this.txtMoy.Location = new System.Drawing.Point(146, 483);
            this.txtMoy.Name = "txtMoy";
            this.txtMoy.Size = new System.Drawing.Size(164, 20);
            this.txtMoy.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Moyenne de la class";
            // 
            // dgvNotes
            // 
            this.dgvNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(24, 183);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.Size = new System.Drawing.Size(390, 283);
            this.dgvNotes.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(339, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Etudiant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Filiere";
            // 
            // comNiveau
            // 
            this.comNiveau.FormattingEnabled = true;
            this.comNiveau.Location = new System.Drawing.Point(24, 134);
            this.comNiveau.Name = "comNiveau";
            this.comNiveau.Size = new System.Drawing.Size(244, 21);
            this.comNiveau.TabIndex = 15;
            // 
            // comEt
            // 
            this.comEt.FormattingEnabled = true;
            this.comEt.Location = new System.Drawing.Point(24, 88);
            this.comEt.Name = "comEt";
            this.comEt.Size = new System.Drawing.Size(244, 21);
            this.comEt.TabIndex = 14;
            // 
            // comFiliere
            // 
            this.comFiliere.FormattingEnabled = true;
            this.comFiliere.Location = new System.Drawing.Point(24, 45);
            this.comFiliere.Name = "comFiliere";
            this.comFiliere.Size = new System.Drawing.Size(244, 21);
            this.comFiliere.TabIndex = 10;
            this.comFiliere.SelectedIndexChanged += new System.EventHandler(this.comFiliere_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMoy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comNiveau);
            this.Controls.Add(this.comEt);
            this.Controls.Add(this.comFiliere);
            this.Controls.Add(this.label1);
            this.Name = "Bilan";
            this.Text = "Bilan";
            this.Load += new System.EventHandler(this.Bilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comNiveau;
        private System.Windows.Forms.ComboBox comEt;
        private System.Windows.Forms.ComboBox comFiliere;
        private System.Windows.Forms.Button button1;
    }
}