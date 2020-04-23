namespace lab3Cs
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
            this.InputA = new System.Windows.Forms.Label();
            this.OupA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.Label();
            this.InputC = new System.Windows.Forms.Label();
            this.InputD = new System.Windows.Forms.Label();
            this.OupB = new System.Windows.Forms.TextBox();
            this.OupC = new System.Windows.Forms.TextBox();
            this.OupD = new System.Windows.Forms.TextBox();
            this.R1 = new System.Windows.Forms.Label();
            this.R2 = new System.Windows.Forms.Label();
            this.OupR1 = new System.Windows.Forms.TextBox();
            this.OupR2 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputA
            // 
            this.InputA.AutoSize = true;
            this.InputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputA.Location = new System.Drawing.Point(13, 15);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(35, 20);
            this.InputA.TabIndex = 0;
            this.InputA.Text = "a = ";
            // 
            // OupA
            // 
            this.OupA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupA.Location = new System.Drawing.Point(50, 15);
            this.OupA.Name = "OupA";
            this.OupA.ReadOnly = true;
            this.OupA.Size = new System.Drawing.Size(92, 26);
            this.OupA.TabIndex = 4;
            // 
            // InputB
            // 
            this.InputB.AutoSize = true;
            this.InputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputB.Location = new System.Drawing.Point(13, 59);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(31, 20);
            this.InputB.TabIndex = 8;
            this.InputB.Text = "b =";
            // 
            // InputC
            // 
            this.InputC.AutoSize = true;
            this.InputC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputC.Location = new System.Drawing.Point(13, 104);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(34, 20);
            this.InputC.TabIndex = 9;
            this.InputC.Text = "c = ";
            // 
            // InputD
            // 
            this.InputD.AutoSize = true;
            this.InputD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputD.Location = new System.Drawing.Point(13, 153);
            this.InputD.Name = "InputD";
            this.InputD.Size = new System.Drawing.Size(31, 20);
            this.InputD.TabIndex = 10;
            this.InputD.Text = "d =";
            // 
            // OupB
            // 
            this.OupB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupB.Location = new System.Drawing.Point(50, 59);
            this.OupB.Name = "OupB";
            this.OupB.ReadOnly = true;
            this.OupB.Size = new System.Drawing.Size(92, 26);
            this.OupB.TabIndex = 11;
            // 
            // OupC
            // 
            this.OupC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupC.Location = new System.Drawing.Point(50, 107);
            this.OupC.Name = "OupC";
            this.OupC.ReadOnly = true;
            this.OupC.Size = new System.Drawing.Size(92, 26);
            this.OupC.TabIndex = 12;
            // 
            // OupD
            // 
            this.OupD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupD.Location = new System.Drawing.Point(50, 153);
            this.OupD.Name = "OupD";
            this.OupD.ReadOnly = true;
            this.OupD.Size = new System.Drawing.Size(92, 26);
            this.OupD.TabIndex = 13;
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R1.Location = new System.Drawing.Point(204, 15);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(43, 20);
            this.R1.TabIndex = 14;
            this.R1.Text = "R1 =";
            this.R1.Click += new System.EventHandler(this.label1_Click);
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R2.Location = new System.Drawing.Point(204, 59);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(43, 20);
            this.R2.TabIndex = 15;
            this.R2.Text = "R2 =";
            // 
            // OupR1
            // 
            this.OupR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupR1.Location = new System.Drawing.Point(253, 12);
            this.OupR1.Name = "OupR1";
            this.OupR1.ReadOnly = true;
            this.OupR1.Size = new System.Drawing.Size(92, 26);
            this.OupR1.TabIndex = 16;
            // 
            // OupR2
            // 
            this.OupR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupR2.Location = new System.Drawing.Point(253, 56);
            this.OupR2.Name = "OupR2";
            this.OupR2.ReadOnly = true;
            this.OupR2.Size = new System.Drawing.Size(92, 26);
            this.OupR2.TabIndex = 17;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(23, 215);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(149, 47);
            this.button.TabIndex = 20;
            this.button.Text = "Посчитать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(215, 104);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 20);
            this.text.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 312);
            this.Controls.Add(this.button);
            this.Controls.Add(this.text);
            this.Controls.Add(this.OupR2);
            this.Controls.Add(this.OupR1);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.OupD);
            this.Controls.Add(this.OupC);
            this.Controls.Add(this.OupB);
            this.Controls.Add(this.InputD);
            this.Controls.Add(this.InputC);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.OupA);
            this.Controls.Add(this.InputA);
            this.MaximumSize = new System.Drawing.Size(438, 351);
            this.MinimumSize = new System.Drawing.Size(438, 351);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputA;
        private System.Windows.Forms.TextBox OupA;
        private System.Windows.Forms.Label InputB;
        private System.Windows.Forms.Label InputC;
        private System.Windows.Forms.Label InputD;
        private System.Windows.Forms.TextBox OupB;
        private System.Windows.Forms.TextBox OupC;
        private System.Windows.Forms.TextBox OupD;
        private System.Windows.Forms.Label R1;
        private System.Windows.Forms.Label R2;
        private System.Windows.Forms.TextBox OupR1;
        private System.Windows.Forms.TextBox OupR2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label text;
    }
}

