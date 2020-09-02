/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 10/09/2019
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace radar_vm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.calcular_vm_button = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DimGray;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(76, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "KM/H no 1º radar:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(76, 147);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(113, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(377, 147);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(113, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DimGray;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(377, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 31);
			this.label2.TabIndex = 4;
			this.label2.Text = "KM/H no 2º radar:\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(170, 228);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(228, 20);
			this.textBox3.TabIndex = 7;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(216, 147);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(136, 20);
			this.textBox4.TabIndex = 8;
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.DimGray;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(216, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 33);
			this.label4.TabIndex = 9;
			this.label4.Text = "Tempo em MINS:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// calcular_vm_button
			// 
			this.calcular_vm_button.BackColor = System.Drawing.Color.DimGray;
			this.calcular_vm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calcular_vm_button.ForeColor = System.Drawing.Color.White;
			this.calcular_vm_button.Location = new System.Drawing.Point(170, 189);
			this.calcular_vm_button.Name = "calcular_vm_button";
			this.calcular_vm_button.Size = new System.Drawing.Size(228, 44);
			this.calcular_vm_button.TabIndex = 5;
			this.calcular_vm_button.Text = "SUA VELOCIDADE ESTÁ... (clique aqui!)";
			this.calcular_vm_button.UseVisualStyleBackColor = false;
			this.calcular_vm_button.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(76, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(113, 82);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(375, 29);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(114, 81);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(186, 268);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(189, 90);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(571, 382);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.calcular_vm_button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Radar";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button calcular_vm_button;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
