namespace prjWinCsCalculatrice_Test1
{
    partial class frmChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCurrencyFrom = new System.Windows.Forms.ComboBox();
            this.lblDeviseFrom = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboCurrencyTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUREAU DE CHANGE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboCurrencyFrom
            // 
            this.cboCurrencyFrom.FormattingEnabled = true;
            this.cboCurrencyFrom.Location = new System.Drawing.Point(70, 134);
            this.cboCurrencyFrom.Name = "cboCurrencyFrom";
            this.cboCurrencyFrom.Size = new System.Drawing.Size(763, 33);
            this.cboCurrencyFrom.TabIndex = 1;
            this.cboCurrencyFrom.Text = "Currency (From)";
            this.cboCurrencyFrom.SelectedIndexChanged += new System.EventHandler(this.cboCurrencyFrom_SelectedIndexChanged);
            this.cboCurrencyFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCurrencyFrom_KeyPress);
            // 
            // lblDeviseFrom
            // 
            this.lblDeviseFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeviseFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviseFrom.Location = new System.Drawing.Point(312, 327);
            this.lblDeviseFrom.Name = "lblDeviseFrom";
            this.lblDeviseFrom.Size = new System.Drawing.Size(99, 48);
            this.lblDeviseFrom.TabIndex = 6;
            this.lblDeviseFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(70, 327);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(220, 48);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Text = "1";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(439, 327);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(153, 48);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cboCurrencyTo
            // 
            this.cboCurrencyTo.FormattingEnabled = true;
            this.cboCurrencyTo.Location = new System.Drawing.Point(70, 224);
            this.cboCurrencyTo.Name = "cboCurrencyTo";
            this.cboCurrencyTo.Size = new System.Drawing.Size(763, 33);
            this.cboCurrencyTo.TabIndex = 11;
            this.cboCurrencyTo.Text = "currency (To)";
            this.cboCurrencyTo.SelectedIndexChanged += new System.EventHandler(this.cboCurrencyTo_SelectedIndexChanged);
            this.cboCurrencyTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCurrencyTo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "From : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "To : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount : ";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(612, 327);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(221, 48);
            this.lblResultat.TabIndex = 15;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(571, 425);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(199, 48);
            this.btnQuiter.TabIndex = 10;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(339, 425);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(199, 48);
            this.btnEffacer.TabIndex = 9;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Result :";
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(716, 173);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(117, 45);
            this.btnSwitch.TabIndex = 18;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 48);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Mettre a jours";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(12, 492);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(858, 46);
            this.lblUpdate.TabIndex = 20;
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 552);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCurrencyTo);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDeviseFrom);
            this.Controls.Add(this.cboCurrencyFrom);
            this.Controls.Add(this.label1);
            this.Name = "frmChange";
            this.Text = "frmChange";
            this.Load += new System.EventHandler(this.frmChange_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCurrencyFrom;
        private System.Windows.Forms.Label lblDeviseFrom;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboCurrencyTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdate;
    }
}