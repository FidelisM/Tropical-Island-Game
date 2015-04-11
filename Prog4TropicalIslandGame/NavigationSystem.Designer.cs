﻿namespace Prog4TropicalIslandGame
{
    partial class NavigationSystem
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Direct = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MapSize = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "End Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.MapSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Direct);
            this.groupBox1.Controls.Add(this.Heading);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RowLabel);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(206, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Direct
            // 
            this.Direct.AutoSize = true;
            this.Direct.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direct.Location = new System.Drawing.Point(173, 23);
            this.Direct.Name = "Direct";
            this.Direct.Size = new System.Drawing.Size(21, 14);
            this.Direct.TabIndex = 5;
            this.Direct.Text = "--";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(109, 23);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(63, 14);
            this.Heading.TabIndex = 4;
            this.Heading.Text = "Heading:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Column:";
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowLabel.Location = new System.Drawing.Point(26, 26);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(35, 14);
            this.RowLabel.TabIndex = 2;
            this.RowLabel.Text = "Row:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Map Size:";
            // 
            // MapSize
            // 
            this.MapSize.AutoSize = true;
            this.MapSize.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapSize.Location = new System.Drawing.Point(109, 61);
            this.MapSize.Name = "MapSize";
            this.MapSize.Size = new System.Drawing.Size(42, 14);
            this.MapSize.TabIndex = 9;
            this.MapSize.Text = "- x -";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Game";
            this.Text = "Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Direct;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MapSize;
        private System.Windows.Forms.Button button3;
    }
}