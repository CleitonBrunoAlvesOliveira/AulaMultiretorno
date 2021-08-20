
namespace WF_Aula_FuncaMultiRetorno
{
    partial class Exec03
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
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmCaixaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesasDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhosDoMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeLucrouCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGanhos = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.txtGanho = new System.Windows.Forms.TextBox();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.ValorEmCaixaCol,
            this.DespesasDoMesCol,
            this.GanhosDoMesCol,
            this.ValorLiquidoCol,
            this.SeLucrouCol});
            this.dgHistorico.Location = new System.Drawing.Point(2, 164);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.Size = new System.Drawing.Size(812, 351);
            this.dgHistorico.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 50;
            // 
            // ValorEmCaixaCol
            // 
            this.ValorEmCaixaCol.HeaderText = "Valor Em Caixa";
            this.ValorEmCaixaCol.Name = "ValorEmCaixaCol";
            this.ValorEmCaixaCol.ReadOnly = true;
            this.ValorEmCaixaCol.Width = 190;
            // 
            // DespesasDoMesCol
            // 
            this.DespesasDoMesCol.HeaderText = "Despesas";
            this.DespesasDoMesCol.Name = "DespesasDoMesCol";
            this.DespesasDoMesCol.ReadOnly = true;
            this.DespesasDoMesCol.Width = 140;
            // 
            // GanhosDoMesCol
            // 
            this.GanhosDoMesCol.HeaderText = "Ganhos";
            this.GanhosDoMesCol.Name = "GanhosDoMesCol";
            this.GanhosDoMesCol.ReadOnly = true;
            this.GanhosDoMesCol.Width = 140;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "Liquido";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.ReadOnly = true;
            this.ValorLiquidoCol.Width = 120;
            // 
            // SeLucrouCol
            // 
            this.SeLucrouCol.HeaderText = "Lucrou";
            this.SeLucrouCol.Name = "SeLucrouCol";
            this.SeLucrouCol.ReadOnly = true;
            // 
            // lblGanhos
            // 
            this.lblGanhos.AutoSize = true;
            this.lblGanhos.Location = new System.Drawing.Point(31, 30);
            this.lblGanhos.Name = "lblGanhos";
            this.lblGanhos.Size = new System.Drawing.Size(165, 26);
            this.lblGanhos.TabIndex = 1;
            this.lblGanhos.Text = "Ganhos do Mês";
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Location = new System.Drawing.Point(31, 80);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(186, 26);
            this.lblDespesas.TabIndex = 2;
            this.lblDespesas.Text = "Despesas do Mês";
            // 
            // txtGanho
            // 
            this.txtGanho.Location = new System.Drawing.Point(230, 24);
            this.txtGanho.Name = "txtGanho";
            this.txtGanho.Size = new System.Drawing.Size(327, 32);
            this.txtGanho.TabIndex = 3;
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(230, 74);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(327, 32);
            this.txtDespesa.TabIndex = 4;
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCalcula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcula.Location = new System.Drawing.Point(230, 112);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(107, 34);
            this.btnCalcula.TabIndex = 5;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(697, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpa.Location = new System.Drawing.Point(630, 112);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(174, 34);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Limpa Colunas";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 586);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.txtGanho);
            this.Controls.Add(this.lblDespesas);
            this.Controls.Add(this.lblGanhos);
            this.Controls.Add(this.dgHistorico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Exec03";
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmCaixaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesasDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhosDoMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeLucrouCol;
        private System.Windows.Forms.Label lblGanhos;
        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.TextBox txtGanho;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpa;
    }
}