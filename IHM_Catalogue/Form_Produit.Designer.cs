﻿namespace IHM_Catalogue
{
    partial class Form_Produit
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.textBoxNomProd = new System.Windows.Forms.TextBox();
            this.comboBoxCatProd = new System.Windows.Forms.ComboBox();
            this.textBoxDescription_Prod = new System.Windows.Forms.TextBox();
            this.textBoxPrix_Unitaire = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            this.labelNom_Prod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(274, 112);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(274, 159);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(274, 208);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.Location = new System.Drawing.Point(108, 42);
            this.textBoxNomProd.MaxLength = 30;
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.Size = new System.Drawing.Size(121, 20);
            this.textBoxNomProd.TabIndex = 3;
            // 
            // comboBoxCatProd
            // 
            this.comboBoxCatProd.FormattingEnabled = true;
            this.comboBoxCatProd.Location = new System.Drawing.Point(106, 91);
            this.comboBoxCatProd.Name = "comboBoxCatProd";
            this.comboBoxCatProd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCatProd.TabIndex = 4;
            // 
            // textBoxDescription_Prod
            // 
            this.textBoxDescription_Prod.Location = new System.Drawing.Point(108, 139);
            this.textBoxDescription_Prod.MaxLength = 250;
            this.textBoxDescription_Prod.Multiline = true;
            this.textBoxDescription_Prod.Name = "textBoxDescription_Prod";
            this.textBoxDescription_Prod.Size = new System.Drawing.Size(121, 58);
            this.textBoxDescription_Prod.TabIndex = 5;
            // 
            // textBoxPrix_Unitaire
            // 
            this.textBoxPrix_Unitaire.Location = new System.Drawing.Point(108, 229);
            this.textBoxPrix_Unitaire.Name = "textBoxPrix_Unitaire";
            this.textBoxPrix_Unitaire.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrix_Unitaire.TabIndex = 6;
            // 
            // numericUpDownQuantite
            // 
            this.numericUpDownQuantite.Location = new System.Drawing.Point(108, 285);
            this.numericUpDownQuantite.Name = "numericUpDownQuantite";
            this.numericUpDownQuantite.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownQuantite.TabIndex = 7;
            // 
            // labelNom_Prod
            // 
            this.labelNom_Prod.AutoSize = true;
            this.labelNom_Prod.Location = new System.Drawing.Point(12, 49);
            this.labelNom_Prod.Name = "labelNom_Prod";
            this.labelNom_Prod.Size = new System.Drawing.Size(65, 13);
            this.labelNom_Prod.TabIndex = 8;
            this.labelNom_Prod.Text = "Nom Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categorie Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prix unitaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantité";
            // 
            // Form_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNom_Prod);
            this.Controls.Add(this.numericUpDownQuantite);
            this.Controls.Add(this.textBoxPrix_Unitaire);
            this.Controls.Add(this.textBoxDescription_Prod);
            this.Controls.Add(this.comboBoxCatProd);
            this.Controls.Add(this.textBoxNomProd);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonValider);
            this.Name = "Form_Produit";
            this.Text = "Form_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.TextBox textBoxNomProd;
        private System.Windows.Forms.ComboBox comboBoxCatProd;
        private System.Windows.Forms.TextBox textBoxDescription_Prod;
        private System.Windows.Forms.TextBox textBoxPrix_Unitaire;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantite;
        private System.Windows.Forms.Label labelNom_Prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}