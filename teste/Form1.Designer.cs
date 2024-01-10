namespace teste
{
    partial class frmTeste
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblId = new Label();
            lblNome = new Label();
            lblDocumento = new Label();
            lblContato = new Label();
            txbID = new TextBox();
            txbNome = new TextBox();
            txbContato = new TextBox();
            txbDocumento = new TextBox();
            btnIncerir = new Button();
            btnAtualizar = new Button();
            dtgTabela = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgTabela).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(93, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(93, 106);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(93, 186);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(93, 266);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 3;
            lblContato.Text = "Contato";
            // 
            // txbID
            // 
            txbID.Location = new Point(93, 44);
            txbID.Name = "txbID";
            txbID.Size = new Size(100, 23);
            txbID.TabIndex = 4;
            txbID.TextChanged += txbID_TextChanged;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(93, 124);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(323, 23);
            txbNome.TabIndex = 5;
            // 
            // txbContato
            // 
            txbContato.Location = new Point(93, 284);
            txbContato.Name = "txbContato";
            txbContato.Size = new Size(323, 23);
            txbContato.TabIndex = 7;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(93, 204);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(323, 23);
            txbDocumento.TabIndex = 6;
            // 
            // btnIncerir
            // 
            btnIncerir.Location = new Point(118, 347);
            btnIncerir.Name = "btnIncerir";
            btnIncerir.Size = new Size(101, 23);
            btnIncerir.TabIndex = 8;
            btnIncerir.Text = "Inserir";
            btnIncerir.UseVisualStyleBackColor = true;
            btnIncerir.Click += btnIncerir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(287, 347);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(101, 23);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dtgTabela
            // 
            dtgTabela.AllowUserToAddRows = false;
            dtgTabela.AllowUserToDeleteRows = false;
            dtgTabela.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dtgTabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgTabela.DefaultCellStyle = dataGridViewCellStyle2;
            dtgTabela.Location = new Point(447, 26);
            dtgTabela.Name = "dtgTabela";
            dtgTabela.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Yellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgTabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgTabela.RowHeadersVisible = false;
            dtgTabela.RowTemplate.Height = 25;
            dtgTabela.Size = new Size(421, 344);
            dtgTabela.TabIndex = 10;
            // 
            // frmTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 401);
            Controls.Add(dtgTabela);
            Controls.Add(btnAtualizar);
            Controls.Add(btnIncerir);
            Controls.Add(txbContato);
            Controls.Add(txbDocumento);
            Controls.Add(txbNome);
            Controls.Add(txbID);
            Controls.Add(lblContato);
            Controls.Add(lblDocumento);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "frmTeste";
            Text = "Trabalhando no Excel";
            Load += frmTeste_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblId;
        public Label lblNome;
        public Label lblDocumento;
        public Label lblContato;
        public TextBox txbID;
        public TextBox txbNome;
        public TextBox txbContato;
        public TextBox txbDocumento;
        public Button btnIncerir;
        public Button btnAtualizar;
        public DataGridView dtgTabela;
    }
}