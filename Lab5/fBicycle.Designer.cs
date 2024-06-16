namespace Lab5
{
    partial class fBicycle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbHandlebars = new System.Windows.Forms.TextBox();
            this.tbFork = new System.Windows.Forms.TextBox();
            this.tbBroadcast = new System.Windows.Forms.TextBox();
            this.tbFrame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHas3Wheels = new System.Windows.Forms.CheckBox();
            this.chbRing = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbHandlebars);
            this.groupBox1.Controls.Add(this.tbFork);
            this.groupBox1.Controls.Add(this.tbBroadcast);
            this.groupBox1.Controls.Add(this.tbFrame);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(325, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(325, 29);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 28);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(147, 28);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(94, 22);
            this.tbModel.TabIndex = 9;
            // 
            // tbHandlebars
            // 
            this.tbHandlebars.Location = new System.Drawing.Point(148, 208);
            this.tbHandlebars.Name = "tbHandlebars";
            this.tbHandlebars.Size = new System.Drawing.Size(93, 22);
            this.tbHandlebars.TabIndex = 8;
            // 
            // tbFork
            // 
            this.tbFork.Location = new System.Drawing.Point(147, 160);
            this.tbFork.Name = "tbFork";
            this.tbFork.Size = new System.Drawing.Size(94, 22);
            this.tbFork.TabIndex = 7;
            // 
            // tbBroadcast
            // 
            this.tbBroadcast.Location = new System.Drawing.Point(147, 110);
            this.tbBroadcast.Name = "tbBroadcast";
            this.tbBroadcast.Size = new System.Drawing.Size(94, 22);
            this.tbBroadcast.TabIndex = 6;
            // 
            // tbFrame
            // 
            this.tbFrame.Location = new System.Drawing.Point(147, 64);
            this.tbFrame.Name = "tbFrame";
            this.tbFrame.Size = new System.Drawing.Size(94, 22);
            this.tbFrame.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Руль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вилка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Передачі";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рама";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва моделі";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHas3Wheels);
            this.groupBox2.Controls.Add(this.chbRing);
            this.groupBox2.Location = new System.Drawing.Point(50, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додаткові дані";
            // 
            // chbHas3Wheels
            // 
            this.chbHas3Wheels.AutoSize = true;
            this.chbHas3Wheels.Location = new System.Drawing.Point(20, 55);
            this.chbHas3Wheels.Name = "chbHas3Wheels";
            this.chbHas3Wheels.Size = new System.Drawing.Size(98, 20);
            this.chbHas3Wheels.TabIndex = 1;
            this.chbHas3Wheels.Text = "Є 3 колеса";
            this.chbHas3Wheels.UseVisualStyleBackColor = true;
            // 
            // chbRing
            // 
            this.chbRing.AutoSize = true;
            this.chbRing.Location = new System.Drawing.Point(21, 29);
            this.chbRing.Name = "chbRing";
            this.chbRing.Size = new System.Drawing.Size(92, 20);
            this.chbRing.TabIndex = 0;
            this.chbRing.Text = "Є дзвінок";
            this.chbRing.UseVisualStyleBackColor = true;
            // 
            // fBicycle
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fBicycle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий велосипед";
            this.Load += new System.EventHandler(this.fPhone_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbHandlebars;
        private System.Windows.Forms.TextBox tbFork;
        private System.Windows.Forms.TextBox tbBroadcast;
        private System.Windows.Forms.TextBox tbFrame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHas3Wheels;
        private System.Windows.Forms.CheckBox chbRing;
        private System.Windows.Forms.Button btnCancel;
    }
}