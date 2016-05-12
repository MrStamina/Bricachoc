﻿namespace IHM_Catalogue
{
    partial class Form_Catalogue
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCreateProduit = new System.Windows.Forms.Button();
            this.buttonDisplayCat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lesProduitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesProduitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateProduit
            // 
            this.buttonCreateProduit.Location = new System.Drawing.Point(399, 27);
            this.buttonCreateProduit.Name = "buttonCreateProduit";
            this.buttonCreateProduit.Size = new System.Drawing.Size(133, 25);
            this.buttonCreateProduit.TabIndex = 0;
            this.buttonCreateProduit.Text = "Ajouter Produit";
            this.buttonCreateProduit.UseVisualStyleBackColor = true;
            this.buttonCreateProduit.Click += new System.EventHandler(this.buttonCreateProduit_Click);
            // 
            // buttonDisplayCat
            // 
            this.buttonDisplayCat.Location = new System.Drawing.Point(28, 73);
            this.buttonDisplayCat.Name = "buttonDisplayCat";
            this.buttonDisplayCat.Size = new System.Drawing.Size(133, 25);
            this.buttonDisplayCat.TabIndex = 2;
            this.buttonDisplayCat.Text = "AfficherCatalogue";
            this.buttonDisplayCat.UseVisualStyleBackColor = true;
            this.buttonDisplayCat.Click += new System.EventHandler(this.buttonDisplayCat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpuDataGridViewTextBoxColumn,
            this.nomProduitDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.prixUnitaireDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lesProduitsBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 173);
            this.dataGridView1.TabIndex = 3;
            // 
            // catalogueBindingSource
            // 
            this.catalogueBindingSource.DataSource = typeof(Catalogue);
            // 
            // lesProduitsBindingSource
            // 
            this.lesProduitsBindingSource.DataMember = "LesProduits";
            this.lesProduitsBindingSource.DataSource = this.catalogueBindingSource;
            // 
            // cpuDataGridViewTextBoxColumn
            // 
            this.cpuDataGridViewTextBoxColumn.DataPropertyName = "Cpu";
            this.cpuDataGridViewTextBoxColumn.HeaderText = "Cpu";
            this.cpuDataGridViewTextBoxColumn.Name = "cpuDataGridViewTextBoxColumn";
            // 
            // nomProduitDataGridViewTextBoxColumn
            // 
            this.nomProduitDataGridViewTextBoxColumn.DataPropertyName = "Nom_Produit";
            this.nomProduitDataGridViewTextBoxColumn.HeaderText = "Nom_Produit";
            this.nomProduitDataGridViewTextBoxColumn.Name = "nomProduitDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // prixUnitaireDataGridViewTextBoxColumn
            // 
            this.prixUnitaireDataGridViewTextBoxColumn.DataPropertyName = "Prix_Unitaire";
            this.prixUnitaireDataGridViewTextBoxColumn.HeaderText = "Prix_Unitaire";
            this.prixUnitaireDataGridViewTextBoxColumn.Name = "prixUnitaireDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // Form_Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDisplayCat);
            this.Controls.Add(this.buttonCreateProduit);
            this.Name = "Form_Catalogue";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesProduitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateProduit;
        private System.Windows.Forms.Button buttonDisplayCat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource catalogueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lesProduitsBindingSource;
    }
}
