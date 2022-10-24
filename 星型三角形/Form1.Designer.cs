namespace 星型三角形
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
			this.btnLiftTri = new System.Windows.Forms.Button();
			this.txtbRow = new System.Windows.Forms.TextBox();
			this.txtbDisplay = new System.Windows.Forms.TextBox();
			this.btnRightTri = new System.Windows.Forms.Button();
			this.btnTri = new System.Windows.Forms.Button();
			this.lblRow = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLiftTri
			// 
			this.btnLiftTri.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLiftTri.Location = new System.Drawing.Point(328, 21);
			this.btnLiftTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLiftTri.Name = "btnLiftTri";
			this.btnLiftTri.Size = new System.Drawing.Size(137, 51);
			this.btnLiftTri.TabIndex = 0;
			this.btnLiftTri.Text = "靠左三角形";
			this.btnLiftTri.UseVisualStyleBackColor = true;
			this.btnLiftTri.Click += new System.EventHandler(this.BtnLiftTri);
			// 
			// txtbRow
			// 
			this.txtbRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtbRow.Location = new System.Drawing.Point(189, 30);
			this.txtbRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbRow.MaxLength = 2;
			this.txtbRow.Name = "txtbRow";
			this.txtbRow.Size = new System.Drawing.Size(115, 34);
			this.txtbRow.TabIndex = 1;
			// 
			// txtbDisplay
			// 
			this.txtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbDisplay.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbDisplay.Location = new System.Drawing.Point(53, 92);
			this.txtbDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbDisplay.Multiline = true;
			this.txtbDisplay.Name = "txtbDisplay";
			this.txtbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtbDisplay.Size = new System.Drawing.Size(796, 336);
			this.txtbDisplay.TabIndex = 1;
			this.txtbDisplay.WordWrap = false;
			// 
			// btnRightTri
			// 
			this.btnRightTri.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRightTri.Location = new System.Drawing.Point(645, 21);
			this.btnRightTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRightTri.Name = "btnRightTri";
			this.btnRightTri.Size = new System.Drawing.Size(137, 51);
			this.btnRightTri.TabIndex = 0;
			this.btnRightTri.Text = "靠右三角形";
			this.btnRightTri.UseVisualStyleBackColor = true;
			this.btnRightTri.Click += new System.EventHandler(this.BtnRightTri);
			// 
			// btnTri
			// 
			this.btnTri.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnTri.Location = new System.Drawing.Point(487, 21);
			this.btnTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTri.Name = "btnTri";
			this.btnTri.Size = new System.Drawing.Size(137, 51);
			this.btnTri.TabIndex = 0;
			this.btnTri.Text = "等腰三角形";
			this.btnTri.UseVisualStyleBackColor = true;
			this.btnTri.Click += new System.EventHandler(this.BtnTri);
			// 
			// lblRow
			// 
			this.lblRow.AutoSize = true;
			this.lblRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblRow.Location = new System.Drawing.Point(48, 34);
			this.lblRow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRow.Name = "lblRow";
			this.lblRow.Size = new System.Drawing.Size(122, 25);
			this.lblRow.TabIndex = 2;
			this.lblRow.Text = "行數(1~10):";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 460);
			this.Controls.Add(this.lblRow);
			this.Controls.Add(this.txtbDisplay);
			this.Controls.Add(this.txtbRow);
			this.Controls.Add(this.btnRightTri);
			this.Controls.Add(this.btnTri);
			this.Controls.Add(this.btnLiftTri);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLiftTri;
		private System.Windows.Forms.TextBox txtbRow;
		private System.Windows.Forms.TextBox txtbDisplay;
		private System.Windows.Forms.Button btnRightTri;
		private System.Windows.Forms.Button btnTri;
		private System.Windows.Forms.Label lblRow;
	}
}

