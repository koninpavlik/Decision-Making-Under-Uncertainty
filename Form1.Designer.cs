
namespace Upr6
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownElements = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCriteries = new System.Windows.Forms.NumericUpDown();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElements)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCriteries)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.richTextBox1);
            this.groupBox9.Location = new System.Drawing.Point(12, 355);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(604, 166);
            this.groupBox9.TabIndex = 48;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Результат";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(591, 141);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCalculate);
            this.groupBox5.Location = new System.Drawing.Point(479, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(137, 52);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Рассчитать";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(6, 19);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(124, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRandomize);
            this.groupBox3.Location = new System.Drawing.Point(336, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 52);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Рандомизировать";
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(6, 19);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(124, 23);
            this.buttonRandomize.TabIndex = 0;
            this.buttonRandomize.Text = "Рандомизировать";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 279);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ввод значений";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownElements);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 52);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество векторов";
            // 
            // numericUpDownElements
            // 
            this.numericUpDownElements.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownElements.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownElements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownElements.Name = "numericUpDownElements";
            this.numericUpDownElements.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownElements.TabIndex = 0;
            this.numericUpDownElements.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownElements.ValueChanged += new System.EventHandler(this.numericUpDownElements_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownCriteries);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 52);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество критериев";
            // 
            // numericUpDownCriteries
            // 
            this.numericUpDownCriteries.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownCriteries.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownCriteries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCriteries.Name = "numericUpDownCriteries";
            this.numericUpDownCriteries.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownCriteries.TabIndex = 0;
            this.numericUpDownCriteries.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCriteries.ValueChanged += new System.EventHandler(this.numericUpDownCriteries_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 536);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Принятие решений в условиях неопределенности";
            this.groupBox9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElements)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCriteries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownElements;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownCriteries;
    }
}

