
namespace Bankzaken
{
    partial class BankrekeningForm
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
            this.btStortenLeft = new System.Windows.Forms.Button();
            this.btOpnemenLeft = new System.Windows.Forms.Button();
            this.btStortenRight = new System.Windows.Forms.Button();
            this.btOpnemenRight = new System.Windows.Forms.Button();
            this.tbSaldoGegeve = new System.Windows.Forms.TextBox();
            this.btRightToLeft = new System.Windows.Forms.Button();
            this.btLeftToRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSaldoLeft = new System.Windows.Forms.Label();
            this.lbSaldoRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaldoLinksTest = new System.Windows.Forms.Label();
            this.SaldoRechtsTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RekeningNmrLinks = new System.Windows.Forms.Label();
            this.RekeningNmrRechts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStortenLeft
            // 
            this.btStortenLeft.Location = new System.Drawing.Point(38, 84);
            this.btStortenLeft.Name = "btStortenLeft";
            this.btStortenLeft.Size = new System.Drawing.Size(75, 23);
            this.btStortenLeft.TabIndex = 2;
            this.btStortenLeft.Text = "Storten";
            this.btStortenLeft.UseVisualStyleBackColor = true;
            this.btStortenLeft.Click += new System.EventHandler(this.btStortenLinks_Click);
            // 
            // btOpnemenLeft
            // 
            this.btOpnemenLeft.Location = new System.Drawing.Point(119, 84);
            this.btOpnemenLeft.Name = "btOpnemenLeft";
            this.btOpnemenLeft.Size = new System.Drawing.Size(78, 23);
            this.btOpnemenLeft.TabIndex = 3;
            this.btOpnemenLeft.Text = "Opnemen";
            this.btOpnemenLeft.UseVisualStyleBackColor = true;
            this.btOpnemenLeft.Click += new System.EventHandler(this.btOpnemenLeft_Click);
            // 
            // btStortenRight
            // 
            this.btStortenRight.Location = new System.Drawing.Point(328, 84);
            this.btStortenRight.Name = "btStortenRight";
            this.btStortenRight.Size = new System.Drawing.Size(75, 23);
            this.btStortenRight.TabIndex = 4;
            this.btStortenRight.Text = "Storten";
            this.btStortenRight.UseVisualStyleBackColor = true;
            this.btStortenRight.Click += new System.EventHandler(this.btStortenRight_Click);
            // 
            // btOpnemenRight
            // 
            this.btOpnemenRight.Location = new System.Drawing.Point(409, 84);
            this.btOpnemenRight.Name = "btOpnemenRight";
            this.btOpnemenRight.Size = new System.Drawing.Size(78, 23);
            this.btOpnemenRight.TabIndex = 5;
            this.btOpnemenRight.Text = "Opnemen";
            this.btOpnemenRight.UseVisualStyleBackColor = true;
            this.btOpnemenRight.Click += new System.EventHandler(this.btOpnemenRight_Click);
            // 
            // tbSaldoGegeve
            // 
            this.tbSaldoGegeve.Location = new System.Drawing.Point(231, 54);
            this.tbSaldoGegeve.Name = "tbSaldoGegeve";
            this.tbSaldoGegeve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSaldoGegeve.Size = new System.Drawing.Size(75, 22);
            this.tbSaldoGegeve.TabIndex = 6;
            // 
            // btRightToLeft
            // 
            this.btRightToLeft.Location = new System.Drawing.Point(231, 84);
            this.btRightToLeft.Name = "btRightToLeft";
            this.btRightToLeft.Size = new System.Drawing.Size(75, 23);
            this.btRightToLeft.TabIndex = 9;
            this.btRightToLeft.Text = "<<<";
            this.btRightToLeft.UseVisualStyleBackColor = true;
            this.btRightToLeft.Click += new System.EventHandler(this.btRightToLeft_Click);
            // 
            // btLeftToRight
            // 
            this.btLeftToRight.Location = new System.Drawing.Point(231, 113);
            this.btLeftToRight.Name = "btLeftToRight";
            this.btLeftToRight.Size = new System.Drawing.Size(75, 23);
            this.btLeftToRight.TabIndex = 10;
            this.btLeftToRight.Text = ">>>";
            this.btLeftToRight.UseVisualStyleBackColor = true;
            this.btLeftToRight.Click += new System.EventHandler(this.btLeftToRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 11;
            // 
            // lbSaldoLeft
            // 
            this.lbSaldoLeft.AutoSize = true;
            this.lbSaldoLeft.Location = new System.Drawing.Point(101, 57);
            this.lbSaldoLeft.Name = "lbSaldoLeft";
            this.lbSaldoLeft.Size = new System.Drawing.Size(48, 17);
            this.lbSaldoLeft.TabIndex = 12;
            this.lbSaldoLeft.Text = " €0.00";
            this.lbSaldoLeft.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSaldoRight
            // 
            this.lbSaldoRight.AutoSize = true;
            this.lbSaldoRight.Location = new System.Drawing.Point(382, 57);
            this.lbSaldoRight.Name = "lbSaldoRight";
            this.lbSaldoRight.Size = new System.Drawing.Size(48, 17);
            this.lbSaldoRight.TabIndex = 13;
            this.lbSaldoRight.Text = " €0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Saldo";
            // 
            // SaldoLinksTest
            // 
            this.SaldoLinksTest.AutoSize = true;
            this.SaldoLinksTest.Location = new System.Drawing.Point(196, 216);
            this.SaldoLinksTest.Name = "SaldoLinksTest";
            this.SaldoLinksTest.Size = new System.Drawing.Size(77, 17);
            this.SaldoLinksTest.TabIndex = 16;
            this.SaldoLinksTest.Text = "SaldoLinks";
            // 
            // SaldoRechtsTest
            // 
            this.SaldoRechtsTest.AutoSize = true;
            this.SaldoRechtsTest.Location = new System.Drawing.Point(196, 250);
            this.SaldoRechtsTest.Name = "SaldoRechtsTest";
            this.SaldoRechtsTest.Size = new System.Drawing.Size(88, 17);
            this.SaldoRechtsTest.TabIndex = 17;
            this.SaldoRechtsTest.Text = "SaldoRechts";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Test saldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RekeningNmrLinks
            // 
            this.RekeningNmrLinks.AutoSize = true;
            this.RekeningNmrLinks.Location = new System.Drawing.Point(325, 216);
            this.RekeningNmrLinks.Name = "RekeningNmrLinks";
            this.RekeningNmrLinks.Size = new System.Drawing.Size(127, 17);
            this.RekeningNmrLinks.TabIndex = 19;
            this.RekeningNmrLinks.Text = "RekeningNmrLinks";
            // 
            // RekeningNmrRechts
            // 
            this.RekeningNmrRechts.AutoSize = true;
            this.RekeningNmrRechts.Location = new System.Drawing.Point(325, 250);
            this.RekeningNmrRechts.Name = "RekeningNmrRechts";
            this.RekeningNmrRechts.Size = new System.Drawing.Size(138, 17);
            this.RekeningNmrRechts.TabIndex = 20;
            this.RekeningNmrRechts.Text = "RekeningNmrRechts";
            // 
            // BankrekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 296);
            this.Controls.Add(this.RekeningNmrRechts);
            this.Controls.Add(this.RekeningNmrLinks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaldoRechtsTest);
            this.Controls.Add(this.SaldoLinksTest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSaldoRight);
            this.Controls.Add(this.lbSaldoLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLeftToRight);
            this.Controls.Add(this.btRightToLeft);
            this.Controls.Add(this.tbSaldoGegeve);
            this.Controls.Add(this.btOpnemenRight);
            this.Controls.Add(this.btStortenRight);
            this.Controls.Add(this.btOpnemenLeft);
            this.Controls.Add(this.btStortenLeft);
            this.Name = "BankrekeningForm";
            this.Text = "BankrekeningForm";
            this.Load += new System.EventHandler(this.BankrekeningForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStortenLeft;
        private System.Windows.Forms.Button btOpnemenLeft;
        private System.Windows.Forms.Button btStortenRight;
        private System.Windows.Forms.Button btOpnemenRight;
        private System.Windows.Forms.TextBox tbSaldoGegeve;
        private System.Windows.Forms.Button btRightToLeft;
        private System.Windows.Forms.Button btLeftToRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSaldoLeft;
        private System.Windows.Forms.Label lbSaldoRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SaldoLinksTest;
        private System.Windows.Forms.Label SaldoRechtsTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RekeningNmrLinks;
        private System.Windows.Forms.Label RekeningNmrRechts;
    }
}

