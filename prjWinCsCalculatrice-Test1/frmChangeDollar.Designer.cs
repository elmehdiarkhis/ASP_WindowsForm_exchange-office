namespace prjWinCsCalculatrice_Test1
{
    partial class frmChangeDollar
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
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCurrencytoDollard = new System.Windows.Forms.Label();
            this.lblDollardToCurrency = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCurrencyToDollar = new System.Windows.Forms.RadioButton();
            this.radDollarToCurrency = new System.Windows.Forms.RadioButton();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDeviseFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(48, 150);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(392, 33);
            this.cboCountry.TabIndex = 45;
            this.cboCountry.Text = "Choose a Country";
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            this.cboCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCountry_KeyPress);
            // 
            // lblCurrencytoDollard
            // 
            this.lblCurrencytoDollard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencytoDollard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencytoDollard.Location = new System.Drawing.Point(489, 202);
            this.lblCurrencytoDollard.Name = "lblCurrencytoDollard";
            this.lblCurrencytoDollard.Size = new System.Drawing.Size(430, 48);
            this.lblCurrencytoDollard.TabIndex = 44;
            this.lblCurrencytoDollard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDollardToCurrency
            // 
            this.lblDollardToCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDollardToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollardToCurrency.Location = new System.Drawing.Point(489, 138);
            this.lblDollardToCurrency.Name = "lblDollardToCurrency";
            this.lblDollardToCurrency.Size = new System.Drawing.Size(430, 48);
            this.lblDollardToCurrency.TabIndex = 43;
            this.lblDollardToCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCurrencyToDollar);
            this.groupBox1.Controls.Add(this.radDollarToCurrency);
            this.groupBox1.Location = new System.Drawing.Point(48, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 138);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From/To";
            // 
            // radCurrencyToDollar
            // 
            this.radCurrencyToDollar.AutoSize = true;
            this.radCurrencyToDollar.Location = new System.Drawing.Point(25, 79);
            this.radCurrencyToDollar.Name = "radCurrencyToDollar";
            this.radCurrencyToDollar.Size = new System.Drawing.Size(27, 26);
            this.radCurrencyToDollar.TabIndex = 1;
            this.radCurrencyToDollar.TabStop = true;
            this.radCurrencyToDollar.UseVisualStyleBackColor = true;
            this.radCurrencyToDollar.CheckedChanged += new System.EventHandler(this.radCurrencyToDollar_CheckedChanged);
            // 
            // radDollarToCurrency
            // 
            this.radDollarToCurrency.AutoSize = true;
            this.radDollarToCurrency.Location = new System.Drawing.Point(25, 44);
            this.radDollarToCurrency.Name = "radDollarToCurrency";
            this.radDollarToCurrency.Size = new System.Drawing.Size(27, 26);
            this.radDollarToCurrency.TabIndex = 0;
            this.radDollarToCurrency.TabStop = true;
            this.radDollarToCurrency.UseVisualStyleBackColor = true;
            this.radDollarToCurrency.CheckedChanged += new System.EventHandler(this.radDollarToCurrency_CheckedChanged);
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(48, 547);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(392, 48);
            this.lblResultat.TabIndex = 41;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(766, 550);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(153, 48);
            this.btnQuiter.TabIndex = 40;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(766, 410);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(153, 48);
            this.btnEffacer.TabIndex = 39;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(766, 356);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(153, 48);
            this.btnConvertir.TabIndex = 38;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(489, 410);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(220, 48);
            this.txtAmount.TabIndex = 37;
            this.txtAmount.Text = "1";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblDeviseFrom
            // 
            this.lblDeviseFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeviseFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviseFrom.Location = new System.Drawing.Point(489, 349);
            this.lblDeviseFrom.Name = "lblDeviseFrom";
            this.lblDeviseFrom.Size = new System.Drawing.Size(220, 48);
            this.lblDeviseFrom.TabIndex = 36;
            this.lblDeviseFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "BUREAU DE CHANGE (Dollar)";
            // 
            // frmChangeDollar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 642);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.lblCurrencytoDollard);
            this.Controls.Add(this.lblDollardToCurrency);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDeviseFrom);
            this.Controls.Add(this.label1);
            this.Name = "frmChangeDollar";
            this.Text = "Bureau de Change (Dollar)";
            this.Load += new System.EventHandler(this.frmChangeDollar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCurrencytoDollard;
        private System.Windows.Forms.Label lblDollardToCurrency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCurrencyToDollar;
        private System.Windows.Forms.RadioButton radDollarToCurrency;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDeviseFrom;
        private System.Windows.Forms.Label label1;
    }
}