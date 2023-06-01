using System.Windows.Forms;
using System.Xml.Linq;

namespace laba16_OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainTextBox = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            sorting = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            AgeFilter = new System.Windows.Forms.TextBox();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            button9 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // mainTextBox
            // 
            mainTextBox.Location = new Point(316, 32);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.ReadOnly = true;
            mainTextBox.ScrollBars = ScrollBars.Both;
            mainTextBox.Size = new Size(756, 517);
            mainTextBox.TabIndex = 0;
            mainTextBox.Text = "[\r\n\tПустая коллекция\r\n]";
            // 
            // button1
            // 
            button1.Location = new Point(11, 11);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 1;
            button1.Text = "Random Person";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NewPerson_Click;
            // 
            // sorting
            // 
            sorting.AutoSize = true;
            sorting.Location = new Point(11, 62);
            sorting.Name = "sorting";
            sorting.Size = new Size(136, 24);
            sorting.TabIndex = 5;
            sorting.Text = "Отсортировать";
            sorting.UseVisualStyleBackColor = true;
            sorting.CheckedChanged += Sorting_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(AgeFilter);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(11, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 180);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выборка";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 150);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "Возраст:";
            // 
            // AgeFilter
            // 
            AgeFilter.Location = new Point(85, 147);
            AgeFilter.Name = "AgeFilter";
            AgeFilter.Size = new Size(125, 27);
            AgeFilter.TabIndex = 4;
            AgeFilter.TextChanged += AgeFilter_TextChanged_1;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 118);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(131, 24);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Schoolboy";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(108, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "ParttimeStudent";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(205, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Student";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(17, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Person";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.button3);
            groupBox2.Controls.Add(this.button2);
            groupBox2.Location = new System.Drawing.Point(11, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(225, 103);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Изменение коллекции";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(26, 61);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(181, 29);
            button3.TabIndex = 1;
            button3.Text = "Удалить элемент";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(26, 26);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(181, 29);
            button2.TabIndex = 0;
            button2.Text = "Изменить элемент";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(318, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 20);
            label1.TabIndex = 9;
            label1.Text = "Коллекция";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.button9);
            groupBox3.Controls.Add(this.button8);
            groupBox3.Controls.Add(this.button7);
            groupBox3.Controls.Add(this.button6);
            groupBox3.Controls.Add(this.button5);
            groupBox3.Controls.Add(this.button4);
            groupBox3.Location = new System.Drawing.Point(11, 414);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(290, 135);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Сохранить/загрузить файл";
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(153, 101);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(132, 29);
            button9.TabIndex = 5;
            button9.Text = "Загрузить XML";
            button9.UseVisualStyleBackColor = true;
            button9.Click += XmlLoadButton_Click;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(153, 66);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(132, 29);
            button8.TabIndex = 4;
            button8.Text = "Загрузить JSON";
            button8.UseVisualStyleBackColor = true;
            button8.Click += jsonLoadButton_Click;

            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(153, 31);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(132, 29);
            button7.TabIndex = 3;
            button7.Text = "Загрузить Binary";
            button7.UseVisualStyleBackColor = true;
            button7.Click += binaryLoadButton_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(6, 98);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(141, 29);
            button6.TabIndex = 2;
            button6.Text = "Сохранить XML";
            button6.UseVisualStyleBackColor = true;
            button6.Click += XmlSaveButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(6, 65);
            button5.Name = "button5";
            button5.Size = new Size(142, 29);
            button5.TabIndex = 1;
            button5.Text = "Сохранить JSON";
            button5.UseVisualStyleBackColor = true;
            button5.Click += jsonSaveButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 31);
            button4.Name = "button4";
            button4.Size = new Size(142, 29);
            button4.TabIndex = 0;
            button4.Text = "Сохранить Binary";
            button4.UseVisualStyleBackColor = true;
            button4.Click += binarySaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 568);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(sorting);
            Controls.Add(button1);
            Controls.Add(mainTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public TextBox mainTextBox;
        private Button button1;
        public CheckBox sorting;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        public TextBox AgeFilter;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Label label1;
        private GroupBox groupBox3;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label2;
    }
}