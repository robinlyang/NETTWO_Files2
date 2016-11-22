namespace NETTWO_Files2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.readFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveRTF = new System.Windows.Forms.Button();
            this.readRTF = new System.Windows.Forms.Button();
            this.saveSequential = new System.Windows.Forms.Button();
            this.readSequential = new System.Windows.Forms.Button();
            this.sequentialCSV = new System.Windows.Forms.Button();
            this.sequentialFormatted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(13, 71);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(105, 71);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 3;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(13, 148);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 4;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // readFile
            // 
            this.readFile.Location = new System.Drawing.Point(105, 148);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(106, 23);
            this.readFile.TabIndex = 5;
            this.readFile.Text = "Read File";
            this.readFile.UseVisualStyleBackColor = true;
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(555, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(21, 23);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // saveRTF
            // 
            this.saveRTF.Location = new System.Drawing.Point(13, 206);
            this.saveRTF.Name = "saveRTF";
            this.saveRTF.Size = new System.Drawing.Size(100, 23);
            this.saveRTF.TabIndex = 7;
            this.saveRTF.Text = "Save RTF";
            this.saveRTF.UseVisualStyleBackColor = true;
            this.saveRTF.Click += new System.EventHandler(this.saveRTF_Click);
            // 
            // readRTF
            // 
            this.readRTF.Location = new System.Drawing.Point(147, 206);
            this.readRTF.Name = "readRTF";
            this.readRTF.Size = new System.Drawing.Size(224, 23);
            this.readRTF.TabIndex = 8;
            this.readRTF.Text = "Read RTF";
            this.readRTF.UseVisualStyleBackColor = true;
            this.readRTF.Click += new System.EventHandler(this.readRTF_Click);
            // 
            // saveSequential
            // 
            this.saveSequential.Location = new System.Drawing.Point(404, 70);
            this.saveSequential.Name = "saveSequential";
            this.saveSequential.Size = new System.Drawing.Size(90, 51);
            this.saveSequential.TabIndex = 9;
            this.saveSequential.Text = "Save Sequential";
            this.saveSequential.UseVisualStyleBackColor = true;
            this.saveSequential.Click += new System.EventHandler(this.saveSequential_Click);
            // 
            // readSequential
            // 
            this.readSequential.Location = new System.Drawing.Point(534, 71);
            this.readSequential.Name = "readSequential";
            this.readSequential.Size = new System.Drawing.Size(93, 50);
            this.readSequential.TabIndex = 10;
            this.readSequential.Text = "Read Sequential";
            this.readSequential.UseVisualStyleBackColor = true;
            this.readSequential.Click += new System.EventHandler(this.readSequential_Click);
            // 
            // sequentialCSV
            // 
            this.sequentialCSV.Location = new System.Drawing.Point(404, 148);
            this.sequentialCSV.Name = "sequentialCSV";
            this.sequentialCSV.Size = new System.Drawing.Size(90, 60);
            this.sequentialCSV.TabIndex = 11;
            this.sequentialCSV.Text = "Sequential CSV";
            this.sequentialCSV.UseVisualStyleBackColor = true;
            this.sequentialCSV.Click += new System.EventHandler(this.sequentialCSV_Click);
            // 
            // sequentialFormatted
            // 
            this.sequentialFormatted.Location = new System.Drawing.Point(534, 148);
            this.sequentialFormatted.Name = "sequentialFormatted";
            this.sequentialFormatted.Size = new System.Drawing.Size(93, 60);
            this.sequentialFormatted.TabIndex = 12;
            this.sequentialFormatted.Text = "Sequential Formatted";
            this.sequentialFormatted.UseVisualStyleBackColor = true;
            this.sequentialFormatted.Click += new System.EventHandler(this.sequentialFormatted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 282);
            this.Controls.Add(this.sequentialFormatted);
            this.Controls.Add(this.sequentialCSV);
            this.Controls.Add(this.readSequential);
            this.Controls.Add(this.saveSequential);
            this.Controls.Add(this.readRTF);
            this.Controls.Add(this.saveRTF);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.readFile);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.read);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button readFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveRTF;
        private System.Windows.Forms.Button readRTF;
        private System.Windows.Forms.Button saveSequential;
        private System.Windows.Forms.Button readSequential;
        private System.Windows.Forms.Button sequentialCSV;
        private System.Windows.Forms.Button sequentialFormatted;
    }
}

