﻿
namespace I002.ForProductOnStorage
{
    partial class SellProductDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.TxtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFindProduct = new System.Windows.Forms.TextBox();
            this.tableForProducts = new System.Windows.Forms.DataGridView();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableForProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnBack);
            this.MainPanel.Controls.Add(this.TxtQuantity);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.TxtPrice);
            this.MainPanel.Controls.Add(this.BtnAddProduct);
            this.MainPanel.Controls.Add(this.BtnAdd);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.TxtFindProduct);
            this.MainPanel.Controls.Add(this.tableForProducts);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(895, 673);
            this.MainPanel.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 11.2F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(13, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 34);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtQuantity.Location = new System.Drawing.Point(316, 450);
            this.TxtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(301, 34);
            this.TxtQuantity.TabIndex = 34;
            this.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.label5.Location = new System.Drawing.Point(82, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Количество партий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.label4.Location = new System.Drawing.Point(83, 518);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Цена, руб.партия";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPrice.Location = new System.Drawing.Point(316, 518);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(301, 34);
            this.TxtPrice.TabIndex = 31;
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAddProduct.Font = new System.Drawing.Font("Calibri", 15.2F);
            this.BtnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnAddProduct.Location = new System.Drawing.Point(317, 590);
            this.BtnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(300, 45);
            this.BtnAddProduct.TabIndex = 30;
            this.BtnAddProduct.Text = "Добавить товар";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(1025, 759);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(301, 48);
            this.BtnAdd.TabIndex = 29;
            this.BtnAdd.Text = "Закупить товар";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.label3.Location = new System.Drawing.Point(308, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Выберите товар для покупки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.label2.Location = new System.Drawing.Point(312, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Введите данные для поиска:";
            // 
            // TxtFindProduct
            // 
            this.TxtFindProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFindProduct.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtFindProduct.Location = new System.Drawing.Point(152, 138);
            this.TxtFindProduct.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFindProduct.Name = "TxtFindProduct";
            this.TxtFindProduct.Size = new System.Drawing.Size(595, 34);
            this.TxtFindProduct.TabIndex = 26;
            this.TxtFindProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFindProduct.TextChanged += new System.EventHandler(this.TxtFindProduct_TextChanged);
            // 
            // tableForProducts
            // 
            this.tableForProducts.AllowUserToAddRows = false;
            this.tableForProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableForProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableForProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableForProducts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tableForProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableForProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableForProducts.Location = new System.Drawing.Point(89, 207);
            this.tableForProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tableForProducts.MultiSelect = false;
            this.tableForProducts.Name = "tableForProducts";
            this.tableForProducts.ReadOnly = true;
            this.tableForProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableForProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tableForProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableForProducts.RowTemplate.Height = 35;
            this.tableForProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableForProducts.Size = new System.Drawing.Size(716, 204);
            this.tableForProducts.TabIndex = 25;
            this.tableForProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableForProducts_CellClick);
            // 
            // SellProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 673);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SellProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите продукт";
            this.Load += new System.EventHandler(this.SellProductDialog_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableForProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFindProduct;
        private System.Windows.Forms.DataGridView tableForProducts;
        private System.Windows.Forms.NumericUpDown TxtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button btnBack;
    }
}