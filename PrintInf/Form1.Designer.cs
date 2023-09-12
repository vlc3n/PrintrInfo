
namespace PrintInf
{
    partial class Form1
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
            this.comboBoxPrinters = new System.Windows.Forms.ComboBox();
            this.buttonCheckPageCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPaperSizes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pCol = new System.Windows.Forms.TextBox();
            this.pDuplex = new System.Windows.Forms.TextBox();
            this.pDefault = new System.Windows.Forms.TextBox();
            this.pRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPrinters
            // 
            this.comboBoxPrinters.FormattingEnabled = true;
            this.comboBoxPrinters.Location = new System.Drawing.Point(6, 22);
            this.comboBoxPrinters.Name = "comboBoxPrinters";
            this.comboBoxPrinters.Size = new System.Drawing.Size(203, 23);
            this.comboBoxPrinters.TabIndex = 1;
            this.comboBoxPrinters.Text = "Select...";
            this.comboBoxPrinters.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrinters_SelectedIndexChanged);
            // 
            // buttonCheckPageCount
            // 
            this.buttonCheckPageCount.Location = new System.Drawing.Point(6, 51);
            this.buttonCheckPageCount.Name = "buttonCheckPageCount";
            this.buttonCheckPageCount.Size = new System.Drawing.Size(203, 23);
            this.buttonCheckPageCount.TabIndex = 2;
            this.buttonCheckPageCount.Text = "Get Settings";
            this.buttonCheckPageCount.UseVisualStyleBackColor = true;
            this.buttonCheckPageCount.Click += new System.EventHandler(this.buttonCheckPageCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPrinters);
            this.groupBox1.Controls.Add(this.buttonCheckPageCount);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Printer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPaperSizes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pCol);
            this.groupBox2.Controls.Add(this.pDuplex);
            this.groupBox2.Controls.Add(this.pDefault);
            this.groupBox2.Controls.Add(this.pRes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pArea);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(235, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 230);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printer Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBoxPaperSizes
            // 
            this.comboBoxPaperSizes.FormattingEnabled = true;
            this.comboBoxPaperSizes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxPaperSizes.Location = new System.Drawing.Point(105, 76);
            this.comboBoxPaperSizes.Name = "comboBoxPaperSizes";
            this.comboBoxPaperSizes.Size = new System.Drawing.Size(260, 23);
            this.comboBoxPaperSizes.TabIndex = 16;
            this.comboBoxPaperSizes.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaperSizes_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Col. Printing";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Duplex Supp.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Default printer";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max. Resolution";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pCol
            // 
            this.pCol.Location = new System.Drawing.Point(105, 191);
            this.pCol.Name = "pCol";
            this.pCol.ReadOnly = true;
            this.pCol.Size = new System.Drawing.Size(260, 23);
            this.pCol.TabIndex = 10;
            this.pCol.TextChanged += new System.EventHandler(this.pCol_TextChanged);
            // 
            // pDuplex
            // 
            this.pDuplex.Location = new System.Drawing.Point(105, 162);
            this.pDuplex.Name = "pDuplex";
            this.pDuplex.ReadOnly = true;
            this.pDuplex.Size = new System.Drawing.Size(260, 23);
            this.pDuplex.TabIndex = 9;
            this.pDuplex.TextChanged += new System.EventHandler(this.pDuplex_TextChanged);
            // 
            // pDefault
            // 
            this.pDefault.Location = new System.Drawing.Point(105, 133);
            this.pDefault.Name = "pDefault";
            this.pDefault.ReadOnly = true;
            this.pDefault.Size = new System.Drawing.Size(260, 23);
            this.pDefault.TabIndex = 7;
            this.pDefault.TextChanged += new System.EventHandler(this.pDefault_TextChanged);
            // 
            // pRes
            // 
            this.pRes.Location = new System.Drawing.Point(105, 104);
            this.pRes.Name = "pRes";
            this.pRes.ReadOnly = true;
            this.pRes.Size = new System.Drawing.Size(260, 23);
            this.pRes.TabIndex = 6;
            this.pRes.TextChanged += new System.EventHandler(this.pRes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paper Sizes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pArea
            // 
            this.pArea.Location = new System.Drawing.Point(105, 46);
            this.pArea.Name = "pArea";
            this.pArea.ReadOnly = true;
            this.pArea.Size = new System.Drawing.Size(260, 23);
            this.pArea.TabIndex = 3;
            this.pArea.TextChanged += new System.EventHandler(this.pArea_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Printable Area";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Printer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Printer Information App";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPrinters;
        private System.Windows.Forms.Button buttonCheckPageCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pCol;
        private System.Windows.Forms.TextBox pDuplex;
        private System.Windows.Forms.TextBox pDefault;
        private System.Windows.Forms.TextBox pRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPaperSizes;
    }
}

