namespace Lab3_Emelin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.ruleEd = new System.Windows.Forms.NumericUpDown();
            this.ruleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab0 = new System.Windows.Forms.Label();
            this.lab13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab12 = new System.Windows.Forms.Label();
            this.lab11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab9 = new System.Windows.Forms.Label();
            this.lab8 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lab14 = new System.Windows.Forms.Label();
            this.lab10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEd)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 612);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startStopBtn);
            this.panel1.Controls.Add(this.ruleEd);
            this.panel1.Controls.Add(this.ruleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 612);
            this.panel1.TabIndex = 1;
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(27, 78);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(119, 45);
            this.startStopBtn.TabIndex = 2;
            this.startStopBtn.Text = "Start / Stop";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // ruleEd
            // 
            this.ruleEd.Location = new System.Drawing.Point(75, 32);
            this.ruleEd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ruleEd.Name = "ruleEd";
            this.ruleEd.Size = new System.Drawing.Size(81, 20);
            this.ruleEd.TabIndex = 1;
            this.ruleEd.ValueChanged += new System.EventHandler(this.ruleEd_ValueChanged);
            // 
            // ruleLabel
            // 
            this.ruleLabel.AutoSize = true;
            this.ruleLabel.Location = new System.Drawing.Point(12, 34);
            this.ruleLabel.Name = "ruleLabel";
            this.ruleLabel.Size = new System.Drawing.Size(29, 13);
            this.ruleLabel.TabIndex = 0;
            this.ruleLabel.Text = "Rule";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 15;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.tableLayoutPanel1.Controls.Add(this.lab0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab13, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.lab12, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lab11, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.lab9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lab8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lab7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lab6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lab5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lab4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lab3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lab2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lab1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.lab14, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.lab10, 0, 10);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(235, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 612);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            // 
            // lab0
            // 
            this.lab0.AutoSize = true;
            this.lab0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab0.Location = new System.Drawing.Point(5, 2);
            this.lab0.Name = "lab0";
            this.lab0.Size = new System.Drawing.Size(30, 31);
            this.lab0.TabIndex = 0;
            this.lab0.Text = "0";
            // 
            // lab13
            // 
            this.lab13.AutoSize = true;
            this.lab13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab13.Location = new System.Drawing.Point(5, 522);
            this.lab13.Name = "lab13";
            this.lab13.Size = new System.Drawing.Size(32, 24);
            this.lab13.TabIndex = 22;
            this.lab13.Text = "13";
            this.lab13.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(137, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 37);
            this.label7.TabIndex = 6;
            // 
            // lab12
            // 
            this.lab12.AutoSize = true;
            this.lab12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab12.Location = new System.Drawing.Point(5, 482);
            this.lab12.Name = "lab12";
            this.lab12.Size = new System.Drawing.Size(32, 24);
            this.lab12.TabIndex = 19;
            this.lab12.Text = "12";
            this.lab12.Visible = false;
            // 
            // lab11
            // 
            this.lab11.AutoSize = true;
            this.lab11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab11.Location = new System.Drawing.Point(5, 442);
            this.lab11.Name = "lab11";
            this.lab11.Size = new System.Drawing.Size(32, 24);
            this.lab11.TabIndex = 20;
            this.lab11.Text = "11";
            this.lab11.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(181, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 8;
            // 
            // lab9
            // 
            this.lab9.AutoSize = true;
            this.lab9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab9.Location = new System.Drawing.Point(5, 362);
            this.lab9.Name = "lab9";
            this.lab9.Size = new System.Drawing.Size(30, 31);
            this.lab9.TabIndex = 18;
            this.lab9.Text = "9";
            this.lab9.Visible = false;
            // 
            // lab8
            // 
            this.lab8.AutoSize = true;
            this.lab8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab8.Location = new System.Drawing.Point(5, 322);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(30, 31);
            this.lab8.TabIndex = 15;
            this.lab8.Text = "8";
            this.lab8.Visible = false;
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab7.Location = new System.Drawing.Point(5, 282);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(30, 31);
            this.lab7.TabIndex = 21;
            this.lab7.Text = "7";
            this.lab7.Visible = false;
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab6.Location = new System.Drawing.Point(5, 242);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(30, 31);
            this.lab6.TabIndex = 17;
            this.lab6.Text = "6";
            this.lab6.Visible = false;
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab5.Location = new System.Drawing.Point(5, 202);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(30, 31);
            this.lab5.TabIndex = 23;
            this.lab5.Text = "5";
            this.lab5.Visible = false;
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab4.Location = new System.Drawing.Point(5, 162);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(30, 31);
            this.lab4.TabIndex = 24;
            this.lab4.Text = "4";
            this.lab4.Visible = false;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab3.Location = new System.Drawing.Point(5, 122);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(30, 31);
            this.lab3.TabIndex = 25;
            this.lab3.Text = "3";
            this.lab3.Visible = false;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab2.Location = new System.Drawing.Point(5, 82);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(30, 31);
            this.lab2.TabIndex = 25;
            this.lab2.Text = "2";
            this.lab2.Visible = false;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab1.Location = new System.Drawing.Point(5, 42);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(30, 31);
            this.lab1.TabIndex = 26;
            this.lab1.Text = "1";
            this.lab1.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(49, 562);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 37);
            this.label15.TabIndex = 14;
            // 
            // lab14
            // 
            this.lab14.AutoSize = true;
            this.lab14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab14.Location = new System.Drawing.Point(5, 562);
            this.lab14.Name = "lab14";
            this.lab14.Size = new System.Drawing.Size(32, 24);
            this.lab14.TabIndex = 27;
            this.lab14.Text = "14";
            this.lab14.Visible = false;
            // 
            // lab10
            // 
            this.lab10.AutoSize = true;
            this.lab10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab10.Location = new System.Drawing.Point(5, 402);
            this.lab10.Name = "lab10";
            this.lab10.Size = new System.Drawing.Size(32, 24);
            this.lab10.TabIndex = 16;
            this.lab10.Text = "10";
            this.lab10.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 612);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEd)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.NumericUpDown ruleEd;
        private System.Windows.Forms.Label ruleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab13;
        private System.Windows.Forms.Label lab12;
        private System.Windows.Forms.Label lab11;
        private System.Windows.Forms.Label lab10;
        private System.Windows.Forms.Label lab9;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab14;
    }
}

