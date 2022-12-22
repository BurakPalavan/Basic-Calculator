namespace Modern_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btnclearhst = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.txtdisplay1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnesıt = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btneksı = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.button2);
            this.PnlTitle.Controls.Add(this.button1);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(380, 40);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(230, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(280, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(330, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.richTextBox1);
            this.PnlHistory.Controls.Add(this.Btnclearhst);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 509);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(380, 61);
            this.PnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(380, 4);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Btnclearhst
            // 
            this.Btnclearhst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btnclearhst.FlatAppearance.BorderSize = 0;
            this.Btnclearhst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btnclearhst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnclearhst.Image = ((System.Drawing.Image)(resources.GetObject("Btnclearhst.Image")));
            this.Btnclearhst.Location = new System.Drawing.Point(0, 4);
            this.Btnclearhst.Margin = new System.Windows.Forms.Padding(0);
            this.Btnclearhst.Name = "Btnclearhst";
            this.Btnclearhst.Size = new System.Drawing.Size(380, 57);
            this.Btnclearhst.TabIndex = 3;
            this.Btnclearhst.UseVisualStyleBackColor = true;
            this.Btnclearhst.Click += new System.EventHandler(this.Btnclearhst_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 40);
            this.panel1.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 40);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = false;
            // 
            // txtdisplay1
            // 
            this.txtdisplay1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtdisplay1.Font = new System.Drawing.Font("Segoe Fluent Icons", 30F, System.Drawing.FontStyle.Bold);
            this.txtdisplay1.ForeColor = System.Drawing.Color.LightGray;
            this.txtdisplay1.Location = new System.Drawing.Point(0, 80);
            this.txtdisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.txtdisplay1.Multiline = true;
            this.txtdisplay1.Name = "txtdisplay1";
            this.txtdisplay1.Size = new System.Drawing.Size(380, 50);
            this.txtdisplay1.TabIndex = 4;
            this.txtdisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdisplay1.TextChanged += new System.EventHandler(this.txtdisplay1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(20, 303);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(116, 303);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.Location = new System.Drawing.Point(20, 446);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(115, 373);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnesıt
            // 
            this.btnesıt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnesıt.Image = ((System.Drawing.Image)(resources.GetObject("btnesıt.Image")));
            this.btnesıt.Location = new System.Drawing.Point(212, 243);
            this.btnesıt.Margin = new System.Windows.Forms.Padding(0);
            this.btnesıt.Name = "btnesıt";
            this.btnesıt.Size = new System.Drawing.Size(75, 40);
            this.btnesıt.TabIndex = 9;
            this.btnesıt.UseVisualStyleBackColor = false;
            this.btnesıt.Click += new System.EventHandler(this.btnesıt_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnplus.Image = ((System.Drawing.Image)(resources.GetObject("btnplus.Image")));
            this.btnplus.Location = new System.Drawing.Point(296, 446);
            this.btnplus.Margin = new System.Windows.Forms.Padding(0);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 50);
            this.btnplus.TabIndex = 10;
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.button8_Click);
            // 
            // btncarp
            // 
            this.btncarp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncarp.Image = ((System.Drawing.Image)(resources.GetObject("btncarp.Image")));
            this.btncarp.Location = new System.Drawing.Point(296, 303);
            this.btncarp.Margin = new System.Windows.Forms.Padding(0);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(75, 50);
            this.btncarp.TabIndex = 11;
            this.btncarp.UseVisualStyleBackColor = false;
            this.btncarp.Click += new System.EventHandler(this.btncarp_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(212, 303);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.Location = new System.Drawing.Point(116, 446);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(20, 373);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnbol
            // 
            this.btnbol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbol.Image = ((System.Drawing.Image)(resources.GetObject("btnbol.Image")));
            this.btnbol.Location = new System.Drawing.Point(296, 238);
            this.btnbol.Margin = new System.Windows.Forms.Padding(0);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(75, 50);
            this.btnbol.TabIndex = 15;
            this.btnbol.UseVisualStyleBackColor = false;
            this.btnbol.Click += new System.EventHandler(this.btnbol_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.Location = new System.Drawing.Point(212, 446);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btneksı
            // 
            this.btneksı.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneksı.Image = ((System.Drawing.Image)(resources.GetObject("btneksı.Image")));
            this.btneksı.Location = new System.Drawing.Point(296, 373);
            this.btneksı.Margin = new System.Windows.Forms.Padding(0);
            this.btneksı.Name = "btneksı";
            this.btneksı.Size = new System.Drawing.Size(75, 50);
            this.btneksı.TabIndex = 17;
            this.btneksı.UseVisualStyleBackColor = false;
            this.btneksı.Click += new System.EventHandler(this.btneksı_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(212, 373);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.Color.Violet;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(296, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 570);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btneksı);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnesıt);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtdisplay1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btnclearhst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.TextBox txtdisplay1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnesıt;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnbol;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btneksı;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button3;
    }
}

