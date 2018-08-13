namespace Calculator
{
    partial class Form1
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
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.comboOp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(36, 61);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(89, 20);
            this.txtFirstValue.TabIndex = 1;
            this.txtFirstValue.KeyPress += Common_txt_KeyPress;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Nokia Large", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalc.Location = new System.Drawing.Point(36, 161);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(64, 64);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "=";
            this.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalc.UseCompatibleTextRendering = true;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(128, 190);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result: ";
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(189, 61);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(89, 20);
            this.txtSecondValue.TabIndex = 4;
            this.txtSecondValue.KeyPress += Common_txt_KeyPress;
            // 
            // comboOp
            // 
            this.comboOp.FormattingEnabled = true;
            this.comboOp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboOp.Location = new System.Drawing.Point(131, 60);
            this.comboOp.Name = "comboOp";
            this.comboOp.Size = new System.Drawing.Size(52, 21);
            this.comboOp.TabIndex = 5;
            this.comboOp.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insert Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboOp);
            this.Controls.Add(this.txtSecondValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtFirstValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.ComboBox comboOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

