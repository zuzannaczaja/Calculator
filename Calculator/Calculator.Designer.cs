namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnIsNegative = new System.Windows.Forms.Button();
            this.btnClearLastDigit = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Location = new System.Drawing.Point(204, 210);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(61, 31);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseCompatibleTextRendering = true;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Location = new System.Drawing.Point(204, 173);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(61, 31);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseCompatibleTextRendering = true;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMultiply.Location = new System.Drawing.Point(204, 138);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(61, 29);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseCompatibleTextRendering = true;
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDivide.Location = new System.Drawing.Point(204, 101);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(61, 31);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseCompatibleTextRendering = true;
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEquals.Location = new System.Drawing.Point(204, 247);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(61, 31);
            this.btnEquals.TabIndex = 9;
            this.btnEquals.Text = "=";
            this.btnEquals.UseCompatibleTextRendering = true;
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxResult.Location = new System.Drawing.Point(3, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxResult.Size = new System.Drawing.Size(262, 47);
            this.textBoxResult.TabIndex = 10;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(3, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "1";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(70, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "2";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.MenuText;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.ForeColor = System.Drawing.SystemColors.Control;
            this.button0.Location = new System.Drawing.Point(70, 247);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(61, 31);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseCompatibleTextRendering = true;
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(137, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(3, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(70, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "5";
            this.button5.UseCompatibleTextRendering = true;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuText;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(137, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 30);
            this.button6.TabIndex = 17;
            this.button6.Text = "6";
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuText;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(3, 138);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 30);
            this.button7.TabIndex = 18;
            this.button7.Text = "7";
            this.button7.UseCompatibleTextRendering = true;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.MenuText;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(70, 138);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 30);
            this.button8.TabIndex = 19;
            this.button8.Text = "8";
            this.button8.UseCompatibleTextRendering = true;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.MenuText;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(137, 138);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 30);
            this.button9.TabIndex = 20;
            this.button9.Text = "9";
            this.button9.UseCompatibleTextRendering = true;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(70, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 31);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C";
            this.btnClear.UseCompatibleTextRendering = true;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnReverse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReverse.Location = new System.Drawing.Point(204, 64);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(61, 31);
            this.btnReverse.TabIndex = 22;
            this.btnReverse.Text = "₁/x";
            this.btnReverse.UseCompatibleTextRendering = true;
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnIsNegative
            // 
            this.btnIsNegative.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnIsNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsNegative.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIsNegative.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIsNegative.Location = new System.Drawing.Point(3, 247);
            this.btnIsNegative.Name = "btnIsNegative";
            this.btnIsNegative.Size = new System.Drawing.Size(61, 31);
            this.btnIsNegative.TabIndex = 25;
            this.btnIsNegative.Text = "±";
            this.btnIsNegative.UseCompatibleTextRendering = true;
            this.btnIsNegative.UseVisualStyleBackColor = false;
            this.btnIsNegative.Click += new System.EventHandler(this.btnIsNegative_Click);
            // 
            // btnClearLastDigit
            // 
            this.btnClearLastDigit.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnClearLastDigit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLastDigit.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearLastDigit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearLastDigit.Location = new System.Drawing.Point(137, 101);
            this.btnClearLastDigit.Name = "btnClearLastDigit";
            this.btnClearLastDigit.Size = new System.Drawing.Size(61, 31);
            this.btnClearLastDigit.TabIndex = 26;
            this.btnClearLastDigit.Text = "⌫";
            this.btnClearLastDigit.UseCompatibleTextRendering = true;
            this.btnClearLastDigit.UseVisualStyleBackColor = false;
            this.btnClearLastDigit.Click += new System.EventHandler(this.btnClearLastDigit_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Calibri", 17F);
            this.btnSquare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSquare.Location = new System.Drawing.Point(137, 64);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(61, 31);
            this.btnSquare.TabIndex = 27;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseCompatibleTextRendering = true;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRoot.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRoot.Location = new System.Drawing.Point(70, 64);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(61, 31);
            this.btnRoot.TabIndex = 28;
            this.btnRoot.Text = "√";
            this.btnRoot.UseCompatibleTextRendering = true;
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCE.Location = new System.Drawing.Point(3, 101);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(61, 31);
            this.btnCE.TabIndex = 29;
            this.btnCE.Text = "CE";
            this.btnCE.UseCompatibleTextRendering = true;
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPercent.Location = new System.Drawing.Point(3, 64);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(61, 31);
            this.btnPercent.TabIndex = 30;
            this.btnPercent.Text = "%";
            this.btnPercent.UseCompatibleTextRendering = true;
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComma.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnComma.ForeColor = System.Drawing.SystemColors.Control;
            this.btnComma.Location = new System.Drawing.Point(137, 247);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(61, 31);
            this.btnComma.TabIndex = 31;
            this.btnComma.Text = ",";
            this.btnComma.UseCompatibleTextRendering = true;
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(287, 290);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnClearLastDigit);
            this.Controls.Add(this.btnIsNegative);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Name = "Calculator";
            this.Opacity = 0.97D;
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnIsNegative;
        private System.Windows.Forms.Button btnClearLastDigit;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnComma;
    }
}

