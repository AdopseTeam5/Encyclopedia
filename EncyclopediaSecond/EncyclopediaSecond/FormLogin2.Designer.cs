namespace EncyclopediaSecond
{
    partial class FormLogin2
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.LinkLabelEpanafora = new System.Windows.Forms.LinkLabel();
            this.LinkLabelNewAccount = new System.Windows.Forms.LinkLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.LoginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(93, 193);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Όνομα χρήστη ή email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EncyclopediaSecond.Properties.Resources.icons8_customer_961;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(155, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "username";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(96, 226);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(223, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(92, 272);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Κωδικός";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "password";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(96, 294);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '*';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(219, 23);
            this.materialSingleLineTextField2.TabIndex = 4;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            this.materialSingleLineTextField2.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(198, 337);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(121, 18);
            this.materialCheckBox1.TabIndex = 6;
            this.materialCheckBox1.Text = "Να με θυμασαι";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // LinkLabelEpanafora
            // 
            this.LinkLabelEpanafora.AutoSize = true;
            this.LinkLabelEpanafora.Location = new System.Drawing.Point(125, 378);
            this.LinkLabelEpanafora.Name = "LinkLabelEpanafora";
            this.LinkLabelEpanafora.Size = new System.Drawing.Size(162, 13);
            this.LinkLabelEpanafora.TabIndex = 7;
            this.LinkLabelEpanafora.TabStop = true;
            this.LinkLabelEpanafora.Text = "Ξεχάσατε το λογαριασμό σας;";
            this.LinkLabelEpanafora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // LinkLabelNewAccount
            // 
            this.LinkLabelNewAccount.AutoSize = true;
            this.LinkLabelNewAccount.Location = new System.Drawing.Point(126, 467);
            this.LinkLabelNewAccount.Name = "LinkLabelNewAccount";
            this.LinkLabelNewAccount.Size = new System.Drawing.Size(161, 13);
            this.LinkLabelNewAccount.TabIndex = 8;
            this.LinkLabelNewAccount.TabStop = true;
            this.LinkLabelNewAccount.Text = "Δημιουργήστε νεο λογαριασμο";
            this.LinkLabelNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelNewAccount_LinkClicked);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 358);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(413, 1);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // LoginButton
            // 
            this.LoginButton.Depth = 0;
            this.LoginButton.Location = new System.Drawing.Point(155, 414);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = true;
            this.LoginButton.Size = new System.Drawing.Size(104, 37);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Είσοδος";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // FormLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 489);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.LinkLabelNewAccount);
            this.Controls.Add(this.LinkLabelEpanafora);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLogin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ΕΙΣΟΔΟΣ";
            this.Load += new System.EventHandler(this.LOGINFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.LinkLabel LinkLabelEpanafora;
        private System.Windows.Forms.LinkLabel LinkLabelNewAccount;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton LoginButton;
    }
}