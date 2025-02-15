﻿
namespace FirstWinForms_GIM
{
    partial class Ex3Form
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lBoxImiona = new System.Windows.Forms.ListBox();
            this.txtBoxNewContact = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listViewDemo = new System.Windows.Forms.ListView();
            this.colTitle = new System.Windows.Forms.ColumnHeader();
            this.colAuthor = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(290, 106);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(316, 29);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Dodaj nowego znajomego";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Imion:";
            // 
            // lBoxImiona
            // 
            this.lBoxImiona.FormattingEnabled = true;
            this.lBoxImiona.ItemHeight = 20;
            this.lBoxImiona.Location = new System.Drawing.Point(21, 106);
            this.lBoxImiona.Name = "lBoxImiona";
            this.lBoxImiona.Size = new System.Drawing.Size(248, 544);
            this.lBoxImiona.TabIndex = 3;
            this.lBoxImiona.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxImiona_MouseDoubleClick);
            // 
            // txtBoxNewContact
            // 
            this.txtBoxNewContact.Location = new System.Drawing.Point(21, 63);
            this.txtBoxNewContact.Name = "txtBoxNewContact";
            this.txtBoxNewContact.Size = new System.Drawing.Size(248, 27);
            this.txtBoxNewContact.TabIndex = 4;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(290, 160);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(316, 29);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Wyczyść listę znajomych";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(290, 214);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(316, 29);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Wstaw kolejnego znajomego";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(316, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Usuń wybranego znajomego";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(316, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Zmień zawartość";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listViewDemo
            // 
            this.listViewDemo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitle,
            this.colAuthor,
            this.colPrice});
            this.listViewDemo.GridLines = true;
            this.listViewDemo.HideSelection = false;
            this.listViewDemo.Location = new System.Drawing.Point(659, 79);
            this.listViewDemo.Name = "listViewDemo";
            this.listViewDemo.Size = new System.Drawing.Size(521, 571);
            this.listViewDemo.TabIndex = 9;
            this.listViewDemo.UseCompatibleStateImageBehavior = false;
            this.listViewDemo.View = System.Windows.Forms.View.Details;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Tytuł";
            this.colTitle.Width = 150;
            // 
            // colAuthor
            // 
            this.colAuthor.Text = "Autor";
            this.colAuthor.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Cena";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colId
            // 
            this.colId.Text = "Lp";
            // 
            // Ex3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 662);
            this.Controls.Add(this.listViewDemo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtBoxNewContact);
            this.Controls.Add(this.lBoxImiona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Name = "Ex3Form";
            this.Text = "Ćwiczenie 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ex3Form_FormClosed);
            this.Load += new System.EventHandler(this.Ex3Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxImiona;
        private System.Windows.Forms.TextBox txtBoxNewContact;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listViewDemo;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colAuthor;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colId;
    }
}