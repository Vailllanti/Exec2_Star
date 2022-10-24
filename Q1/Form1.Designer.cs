namespace Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnShowTime = new System.Windows.Forms.Button();
			this.lblShowTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnShowTime
			// 
			this.btnShowTime.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowTime.Location = new System.Drawing.Point(137, 33);
			this.btnShowTime.Name = "btnShowTime";
			this.btnShowTime.Size = new System.Drawing.Size(196, 78);
			this.btnShowTime.TabIndex = 0;
			this.btnShowTime.Text = "顯示時間";
			this.btnShowTime.UseVisualStyleBackColor = true;
			this.btnShowTime.Click += new System.EventHandler(this.btnShowTime_Click);
			// 
			// lblShowTime
			// 
			this.lblShowTime.AutoSize = true;
			this.lblShowTime.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblShowTime.Location = new System.Drawing.Point(29, 146);
			this.lblShowTime.Name = "lblShowTime";
			this.lblShowTime.Size = new System.Drawing.Size(135, 31);
			this.lblShowTime.TabIndex = 1;
			this.lblShowTime.Text = "ShowTime";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 235);
			this.Controls.Add(this.lblShowTime);
			this.Controls.Add(this.btnShowTime);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnShowTime;
		private System.Windows.Forms.Label lblShowTime;
	}
}

