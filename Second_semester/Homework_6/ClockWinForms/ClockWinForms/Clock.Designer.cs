﻿namespace ClockWinForms
{
    partial class Clock
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
            this.ClockFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClockFace)).BeginInit();
            this.SuspendLayout();
            // 
            // ClockFace
            // 
            this.ClockFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClockFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClockFace.Location = new System.Drawing.Point(0, 0);
            this.ClockFace.Name = "ClockFace";
            this.ClockFace.Size = new System.Drawing.Size(315, 400);
            this.ClockFace.TabIndex = 0;
            this.ClockFace.TabStop = false;
            this.ClockFace.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingOfClockFace);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(315, 400);
            this.Controls.Add(this.ClockFace);
            this.Name = "Clock";
            this.Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)(this.ClockFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ClockFace;
    }
}

