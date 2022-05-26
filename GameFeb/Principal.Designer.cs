namespace GameFeb
{
    partial class Principal
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
            this.btnCadastroUsuarios = new System.Windows.Forms.Button();
            this.btnCadastroJogos = new System.Windows.Forms.Button();
            this.btnCompraJogos = new System.Windows.Forms.Button();
            this.btnVendaJogos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroJogos = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subTesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subTeste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComprarJogos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenderJogos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastroUsuarios
            // 
            this.btnCadastroUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUsuarios.Location = new System.Drawing.Point(42, 70);
            this.btnCadastroUsuarios.Name = "btnCadastroUsuarios";
            this.btnCadastroUsuarios.Size = new System.Drawing.Size(197, 63);
            this.btnCadastroUsuarios.TabIndex = 0;
            this.btnCadastroUsuarios.Text = "Cadastro de Usuários";
            this.btnCadastroUsuarios.UseVisualStyleBackColor = true;
            this.btnCadastroUsuarios.Click += new System.EventHandler(this.btnCadastroUsuarios_Click);
            // 
            // btnCadastroJogos
            // 
            this.btnCadastroJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroJogos.Location = new System.Drawing.Point(42, 166);
            this.btnCadastroJogos.Name = "btnCadastroJogos";
            this.btnCadastroJogos.Size = new System.Drawing.Size(197, 63);
            this.btnCadastroJogos.TabIndex = 1;
            this.btnCadastroJogos.Text = "Cadastro de Jogos";
            this.btnCadastroJogos.UseVisualStyleBackColor = true;
            // 
            // btnCompraJogos
            // 
            this.btnCompraJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraJogos.Location = new System.Drawing.Point(275, 70);
            this.btnCompraJogos.Name = "btnCompraJogos";
            this.btnCompraJogos.Size = new System.Drawing.Size(197, 63);
            this.btnCompraJogos.TabIndex = 2;
            this.btnCompraJogos.Text = "Compra de Jogos";
            this.btnCompraJogos.UseVisualStyleBackColor = true;
            this.btnCompraJogos.Click += new System.EventHandler(this.btnCompraJogos_Click);
            // 
            // btnVendaJogos
            // 
            this.btnVendaJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaJogos.Location = new System.Drawing.Point(275, 166);
            this.btnVendaJogos.Name = "btnVendaJogos";
            this.btnVendaJogos.Size = new System.Drawing.Size(197, 63);
            this.btnVendaJogos.TabIndex = 3;
            this.btnVendaJogos.Text = "Venda de Jogos";
            this.btnVendaJogos.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroUsuarios,
            this.mnuCadastroJogos,
            this.testeToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // mnuCadastroUsuarios
            // 
            this.mnuCadastroUsuarios.Name = "mnuCadastroUsuarios";
            this.mnuCadastroUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuCadastroUsuarios.Text = "Usuários";
            this.mnuCadastroUsuarios.Click += new System.EventHandler(this.mnuCadastroUsuarios_Click);
            // 
            // mnuCadastroJogos
            // 
            this.mnuCadastroJogos.Name = "mnuCadastroJogos";
            this.mnuCadastroJogos.Size = new System.Drawing.Size(180, 22);
            this.mnuCadastroJogos.Text = "Jogos";
            this.mnuCadastroJogos.Click += new System.EventHandler(this.mnuCadastroJogos_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subTesteToolStripMenuItem,
            this.subTeste2ToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem.Text = "Teste";
            // 
            // subTesteToolStripMenuItem
            // 
            this.subTesteToolStripMenuItem.Name = "subTesteToolStripMenuItem";
            this.subTesteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.subTesteToolStripMenuItem.Text = "Sub teste 1";
            // 
            // subTeste2ToolStripMenuItem
            // 
            this.subTeste2ToolStripMenuItem.Name = "subTeste2ToolStripMenuItem";
            this.subTeste2ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.subTeste2ToolStripMenuItem.Text = "Sub teste 2";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuComprarJogos,
            this.mnuVenderJogos});
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // mnuComprarJogos
            // 
            this.mnuComprarJogos.Name = "mnuComprarJogos";
            this.mnuComprarJogos.Size = new System.Drawing.Size(154, 22);
            this.mnuComprarJogos.Text = "Comprar Jogos";
            // 
            // mnuVenderJogos
            // 
            this.mnuVenderJogos.Name = "mnuVenderJogos";
            this.mnuVenderJogos.Size = new System.Drawing.Size(154, 22);
            this.mnuVenderJogos.Text = "Vender Jogos";
            // 
            // mnuSair
            // 
            this.mnuSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVendaJogos);
            this.Controls.Add(this.btnCompraJogos);
            this.Controls.Add(this.btnCadastroJogos);
            this.Controls.Add(this.btnCadastroUsuarios);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "GameFeb - Compre seu jogo bosta aqui";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroUsuarios;
        private System.Windows.Forms.Button btnCadastroJogos;
        private System.Windows.Forms.Button btnCompraJogos;
        private System.Windows.Forms.Button btnVendaJogos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroJogos;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuComprarJogos;
        private System.Windows.Forms.ToolStripMenuItem mnuVenderJogos;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subTesteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subTeste2ToolStripMenuItem;
    }
}

