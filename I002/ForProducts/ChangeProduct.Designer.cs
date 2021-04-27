
namespace I002
{
    partial class ChangeProduct
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnClos = new System.Windows.Forms.Button();
            this.TxtAddProduct = new System.Windows.Forms.TextBox();
            this.LabNameProduct = new System.Windows.Forms.Label();
            this.BtnChangeProduct = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnClos);
            this.MainPanel.Controls.Add(this.TxtAddProduct);
            this.MainPanel.Controls.Add(this.LabNameProduct);
            this.MainPanel.Controls.Add(this.BtnChangeProduct);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(640, 324);
            this.MainPanel.TabIndex = 2;
            // 
            // btnClos
            // 
            this.btnClos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnClos.Font = new System.Drawing.Font("Calibri", 11.2F);
            this.btnClos.ForeColor = System.Drawing.Color.Black;
            this.btnClos.Location = new System.Drawing.Point(527, 4);
            this.btnClos.Margin = new System.Windows.Forms.Padding(4);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(100, 34);
            this.btnClos.TabIndex = 34;
            this.btnClos.Text = "Закрыть";
            this.btnClos.UseVisualStyleBackColor = true;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // TxtAddProduct
            // 
            this.TxtAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddProduct.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtAddProduct.Location = new System.Drawing.Point(101, 119);
            this.TxtAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAddProduct.Name = "TxtAddProduct";
            this.TxtAddProduct.Size = new System.Drawing.Size(425, 34);
            this.TxtAddProduct.TabIndex = 8;
            this.TxtAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabNameProduct
            // 
            this.LabNameProduct.AutoSize = true;
            this.LabNameProduct.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.LabNameProduct.Location = new System.Drawing.Point(137, 57);
            this.LabNameProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabNameProduct.Name = "LabNameProduct";
            this.LabNameProduct.Size = new System.Drawing.Size(349, 29);
            this.LabNameProduct.TabIndex = 7;
            this.LabNameProduct.Text = "Введите новое название товара:";
            // 
            // BtnChangeProduct
            // 
            this.BtnChangeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnChangeProduct.Font = new System.Drawing.Font("Calibri", 15.2F);
            this.BtnChangeProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnChangeProduct.Location = new System.Drawing.Point(160, 176);
            this.BtnChangeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChangeProduct.Name = "BtnChangeProduct";
            this.BtnChangeProduct.Size = new System.Drawing.Size(300, 45);
            this.BtnChangeProduct.TabIndex = 0;
            this.BtnChangeProduct.Text = "Изменить";
            this.BtnChangeProduct.UseVisualStyleBackColor = true;
            this.BtnChangeProduct.Click += new System.EventHandler(this.BtnChangeProduct_Click);
            // 
            // ChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 324);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование продукта";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtAddProduct;
        private System.Windows.Forms.Label LabNameProduct;
        private System.Windows.Forms.Button BtnChangeProduct;
        private System.Windows.Forms.Button btnClos;
    }
}