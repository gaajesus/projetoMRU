namespace MRU
{
	partial class frmMRU
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRU));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbbOpcao = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.txtEspacoInicial = new System.Windows.Forms.TextBox();
            this.lblEspacoInicial = new System.Windows.Forms.Label();
            this.rdoMetros = new System.Windows.Forms.RadioButton();
            this.rdoKm = new System.Windows.Forms.RadioButton();
            this.lblMinicial = new System.Windows.Forms.Label();
            this.lblMseg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMfinal = new System.Windows.Forms.Label();
            this.lblStempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(139, 253);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(144, 20);
            this.txtResult.TabIndex = 29;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(151, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 20);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Espaço Final";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(405, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // cbbOpcao
            // 
            this.cbbOpcao.AccessibleDescription = "";
            this.cbbOpcao.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cbbOpcao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbOpcao.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbOpcao.FormattingEnabled = true;
            this.cbbOpcao.Items.AddRange(new object[] {
            "Espaço Inicial",
            "Velocidade",
            "Tempo",
            "Espaço Final"});
            this.cbbOpcao.Location = new System.Drawing.Point(397, 31);
            this.cbbOpcao.Name = "cbbOpcao";
            this.cbbOpcao.Size = new System.Drawing.Size(109, 21);
            this.cbbOpcao.TabIndex = 26;
            this.cbbOpcao.Text = "Espaço Final";
            this.cbbOpcao.SelectedIndexChanged += new System.EventHandler(this.cbbOpcao_SelectedIndexChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnSair.Location = new System.Drawing.Point(405, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 33);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(15, 256);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(84, 13);
            this.lblResultado.TabIndex = 20;
            this.lblResultado.Text = "Espaço Final:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnCalcular.Location = new System.Drawing.Point(227, 314);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 33);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNovo.Location = new System.Drawing.Point(25, 314);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(103, 33);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(139, 197);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(144, 20);
            this.txtTempo.TabIndex = 22;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(15, 200);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(49, 13);
            this.lblTempo.TabIndex = 21;
            this.lblTempo.Text = "Tempo:";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(139, 142);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(144, 20);
            this.txtVelocidade.TabIndex = 19;
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidade.Location = new System.Drawing.Point(15, 145);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(74, 13);
            this.lblVelocidade.TabIndex = 18;
            this.lblVelocidade.Text = "Velocidade:";
            // 
            // txtEspacoInicial
            // 
            this.txtEspacoInicial.Location = new System.Drawing.Point(139, 85);
            this.txtEspacoInicial.MaxLength = 15;
            this.txtEspacoInicial.Name = "txtEspacoInicial";
            this.txtEspacoInicial.Size = new System.Drawing.Size(144, 20);
            this.txtEspacoInicial.TabIndex = 17;
            // 
            // lblEspacoInicial
            // 
            this.lblEspacoInicial.AutoSize = true;
            this.lblEspacoInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblEspacoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacoInicial.Location = new System.Drawing.Point(15, 88);
            this.lblEspacoInicial.Name = "lblEspacoInicial";
            this.lblEspacoInicial.Size = new System.Drawing.Size(91, 13);
            this.lblEspacoInicial.TabIndex = 16;
            this.lblEspacoInicial.Text = "Espaço Inicial:";
            // 
            // rdoMetros
            // 
            this.rdoMetros.AutoSize = true;
            this.rdoMetros.BackColor = System.Drawing.Color.Transparent;
            this.rdoMetros.Checked = true;
            this.rdoMetros.Location = new System.Drawing.Point(405, 55);
            this.rdoMetros.Name = "rdoMetros";
            this.rdoMetros.Size = new System.Drawing.Size(43, 17);
            this.rdoMetros.TabIndex = 30;
            this.rdoMetros.TabStop = true;
            this.rdoMetros.Text = "m/s";
            this.rdoMetros.UseVisualStyleBackColor = false;
            this.rdoMetros.CheckedChanged += new System.EventHandler(this.rdoMetros_CheckedChanged);
            // 
            // rdoKm
            // 
            this.rdoKm.AutoSize = true;
            this.rdoKm.BackColor = System.Drawing.Color.Transparent;
            this.rdoKm.Location = new System.Drawing.Point(455, 55);
            this.rdoKm.Name = "rdoKm";
            this.rdoKm.Size = new System.Drawing.Size(51, 17);
            this.rdoKm.TabIndex = 31;
            this.rdoKm.Text = "Km/h";
            this.rdoKm.UseVisualStyleBackColor = false;
            this.rdoKm.CheckedChanged += new System.EventHandler(this.rdoKm_CheckedChanged);
            // 
            // lblMinicial
            // 
            this.lblMinicial.AutoSize = true;
            this.lblMinicial.BackColor = System.Drawing.Color.Transparent;
            this.lblMinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinicial.Location = new System.Drawing.Point(289, 88);
            this.lblMinicial.Name = "lblMinicial";
            this.lblMinicial.Size = new System.Drawing.Size(44, 13);
            this.lblMinicial.TabIndex = 32;
            this.lblMinicial.Text = "metros";
            // 
            // lblMseg
            // 
            this.lblMseg.AutoSize = true;
            this.lblMseg.BackColor = System.Drawing.Color.Transparent;
            this.lblMseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMseg.Location = new System.Drawing.Point(289, 145);
            this.lblMseg.Name = "lblMseg";
            this.lblMseg.Size = new System.Drawing.Size(98, 13);
            this.lblMseg.TabIndex = 33;
            this.lblMseg.Text = "metros/segundo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 34;
            // 
            // lblMfinal
            // 
            this.lblMfinal.AutoSize = true;
            this.lblMfinal.BackColor = System.Drawing.Color.Transparent;
            this.lblMfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfinal.Location = new System.Drawing.Point(289, 256);
            this.lblMfinal.Name = "lblMfinal";
            this.lblMfinal.Size = new System.Drawing.Size(44, 13);
            this.lblMfinal.TabIndex = 35;
            this.lblMfinal.Text = "metros";
            // 
            // lblStempo
            // 
            this.lblStempo.AutoSize = true;
            this.lblStempo.BackColor = System.Drawing.Color.Transparent;
            this.lblStempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStempo.Location = new System.Drawing.Point(289, 200);
            this.lblStempo.Name = "lblStempo";
            this.lblStempo.Size = new System.Drawing.Size(61, 13);
            this.lblStempo.TabIndex = 36;
            this.lblStempo.Text = "segundos";
            // 
            // frmMRU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 359);
            this.Controls.Add(this.lblStempo);
            this.Controls.Add(this.lblMfinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMseg);
            this.Controls.Add(this.lblMinicial);
            this.Controls.Add(this.rdoKm);
            this.Controls.Add(this.rdoMetros);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbbOpcao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.txtEspacoInicial);
            this.Controls.Add(this.lblEspacoInicial);
            this.Name = "frmMRU";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMRU_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ComboBox cbbOpcao;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.TextBox txtTempo;
		private System.Windows.Forms.Label lblTempo;
		private System.Windows.Forms.TextBox txtVelocidade;
		private System.Windows.Forms.Label lblVelocidade;
		private System.Windows.Forms.TextBox txtEspacoInicial;
		private System.Windows.Forms.Label lblEspacoInicial;
		private System.Windows.Forms.RadioButton rdoMetros;
		private System.Windows.Forms.RadioButton rdoKm;
		private System.Windows.Forms.Label lblMinicial;
		private System.Windows.Forms.Label lblMseg;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblMfinal;
		private System.Windows.Forms.Label lblStempo;
	}
}

