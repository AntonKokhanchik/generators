namespace generators
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxKey = new System.Windows.Forms.TextBox();
			this.textBoxSquare = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxFib = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(89, 51);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(100, 28);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Сгенерировать";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ключ генератора";
			// 
			// textBoxKey
			// 
			this.textBoxKey.Location = new System.Drawing.Point(15, 25);
			this.textBoxKey.Name = "textBoxKey";
			this.textBoxKey.Size = new System.Drawing.Size(100, 20);
			this.textBoxKey.TabIndex = 1;
			// 
			// textBoxSquare
			// 
			this.textBoxSquare.Location = new System.Drawing.Point(12, 98);
			this.textBoxSquare.Multiline = true;
			this.textBoxSquare.Name = "textBoxSquare";
			this.textBoxSquare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxSquare.Size = new System.Drawing.Size(127, 194);
			this.textBoxSquare.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Метод Середины квадрата";
			// 
			// textBoxFib
			// 
			this.textBoxFib.Location = new System.Drawing.Point(145, 98);
			this.textBoxFib.Multiline = true;
			this.textBoxFib.Name = "textBoxFib";
			this.textBoxFib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxFib.Size = new System.Drawing.Size(127, 194);
			this.textBoxFib.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(161, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Метод Фибоначчи";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 304);
			this.Controls.Add(this.textBoxFib);
			this.Controls.Add(this.textBoxSquare);
			this.Controls.Add(this.textBoxKey);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonStart);
			this.Name = "Form1";
			this.Text = "Генерация случайных чисел";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxKey;
		private System.Windows.Forms.TextBox textBoxSquare;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFib;
		private System.Windows.Forms.Label label3;
	}
}

