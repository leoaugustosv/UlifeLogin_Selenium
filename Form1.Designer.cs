namespace _1_Selenium_UlifeTest
{
    partial class Form1
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
            this.cbxSite = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblNav = new System.Windows.Forms.Label();
            this.rdbChrome = new System.Windows.Forms.RadioButton();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.rdbEdge = new System.Windows.Forms.RadioButton();
            this.rdbFirefox = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSite
            // 
            this.cbxSite.FormattingEnabled = true;
            this.cbxSite.Items.AddRange(new object[] {
            "Ulife - Sala Virtual",
            "Ulife - Portal do Aluno (UAM)"});
            this.cbxSite.Location = new System.Drawing.Point(74, 14);
            this.cbxSite.Name = "cbxSite";
            this.cbxSite.Size = new System.Drawing.Size(209, 21);
            this.cbxSite.TabIndex = 0;
            this.cbxSite.SelectedIndexChanged += new System.EventHandler(this.cbxSite_SelectedIndexChanged);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(12, 9);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(56, 26);
            this.lblSite.TabIndex = 1;
            this.lblSite.Text = "Site:";
            // 
            // lblNav
            // 
            this.lblNav.AutoSize = true;
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNav.Location = new System.Drawing.Point(12, 61);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(124, 26);
            this.lblNav.TabIndex = 2;
            this.lblNav.Text = "Navegador:";
            // 
            // rdbChrome
            // 
            this.rdbChrome.AutoSize = true;
            this.rdbChrome.Location = new System.Drawing.Point(3, 6);
            this.rdbChrome.Name = "rdbChrome";
            this.rdbChrome.Size = new System.Drawing.Size(61, 17);
            this.rdbChrome.TabIndex = 3;
            this.rdbChrome.TabStop = true;
            this.rdbChrome.Text = "Chrome";
            this.rdbChrome.UseVisualStyleBackColor = true;
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.rdbEdge);
            this.pnlNav.Controls.Add(this.rdbFirefox);
            this.pnlNav.Controls.Add(this.rdbChrome);
            this.pnlNav.Location = new System.Drawing.Point(142, 62);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(279, 25);
            this.pnlNav.TabIndex = 4;
            // 
            // rdbEdge
            // 
            this.rdbEdge.AutoSize = true;
            this.rdbEdge.Location = new System.Drawing.Point(132, 6);
            this.rdbEdge.Name = "rdbEdge";
            this.rdbEdge.Size = new System.Drawing.Size(50, 17);
            this.rdbEdge.TabIndex = 5;
            this.rdbEdge.TabStop = true;
            this.rdbEdge.Text = "Edge";
            this.rdbEdge.UseVisualStyleBackColor = true;
            // 
            // rdbFirefox
            // 
            this.rdbFirefox.AutoSize = true;
            this.rdbFirefox.Location = new System.Drawing.Point(70, 6);
            this.rdbFirefox.Name = "rdbFirefox";
            this.rdbFirefox.Size = new System.Drawing.Size(56, 17);
            this.rdbFirefox.TabIndex = 4;
            this.rdbFirefox.TabStop = true;
            this.rdbFirefox.Text = "Firefox";
            this.rdbFirefox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(17, 158);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(266, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(17, 241);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(266, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(3, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Fazer Login";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.button1);
            this.pnlAction.Controls.Add(this.btnGo);
            this.pnlAction.Location = new System.Drawing.Point(17, 288);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(266, 31);
            this.pnlAction.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 331);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.cbxSite);
            this.Name = "Form1";
            this.Text = "Ulife - Login Fácil";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.RadioButton rdbChrome;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.RadioButton rdbEdge;
        private System.Windows.Forms.RadioButton rdbFirefox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button button1;
    }
}

