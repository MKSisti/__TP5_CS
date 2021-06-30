
namespace _TP_5
{
    partial class GestMatieres
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNiv = new System.Windows.Forms.ComboBox();
            this.cbSem = new System.Windows.Forms.ComboBox();
            this.cbFil = new System.Windows.Forms.ComboBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(289, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(289, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(12, 63);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(63, 13);
            this.lblDes.TabIndex = 6;
            this.lblDes.Text = "Designation";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(15, 79);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(215, 20);
            this.txtDes.TabIndex = 1;
            // 
            // dgvMat
            // 
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Location = new System.Drawing.Point(12, 270);
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.Size = new System.Drawing.Size(352, 150);
            this.dgvMat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filiere";
            // 
            // cbNiv
            // 
            this.cbNiv.FormattingEnabled = true;
            this.cbNiv.Location = new System.Drawing.Point(15, 119);
            this.cbNiv.Name = "cbNiv";
            this.cbNiv.Size = new System.Drawing.Size(215, 21);
            this.cbNiv.TabIndex = 2;
            // 
            // cbSem
            // 
            this.cbSem.FormattingEnabled = true;
            this.cbSem.Location = new System.Drawing.Point(15, 158);
            this.cbSem.Name = "cbSem";
            this.cbSem.Size = new System.Drawing.Size(215, 21);
            this.cbSem.TabIndex = 3;
            // 
            // cbFil
            // 
            this.cbFil.FormattingEnabled = true;
            this.cbFil.Location = new System.Drawing.Point(15, 198);
            this.cbFil.Name = "cbFil";
            this.cbFil.Size = new System.Drawing.Size(215, 21);
            this.cbFil.TabIndex = 4;
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(15, 40);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(215, 20);
            this.txtMat.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code Matiere";
            // 
            // GestMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 432);
            this.Controls.Add(this.cbFil);
            this.Controls.Add(this.cbSem);
            this.Controls.Add(this.cbNiv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.dgvMat);
            this.Name = "GestMatieres";
            this.Text = "GestMatieres";
            this.Load += new System.EventHandler(this.GestMatieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNiv;
        private System.Windows.Forms.ComboBox cbSem;
        private System.Windows.Forms.ComboBox cbFil;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label label4;
    }
}