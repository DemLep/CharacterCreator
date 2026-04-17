namespace RPG_ODnD.Panels
{
	partial class CharacterSheet
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CharacterPanel = new System.Windows.Forms.Panel();
			this.CharacterNameBox = new System.Windows.Forms.TextBox();
			this.CharacterNameLabel = new System.Windows.Forms.Label();
			this.CharacterClassLabel = new System.Windows.Forms.Label();
			this.CharacterClassBox = new System.Windows.Forms.ComboBox();
			this.CharacterPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// CharacterPanel
			// 
			this.CharacterPanel.AutoSize = true;
			this.CharacterPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CharacterPanel.Controls.Add(this.CharacterClassBox);
			this.CharacterPanel.Controls.Add(this.CharacterClassLabel);
			this.CharacterPanel.Controls.Add(this.CharacterNameLabel);
			this.CharacterPanel.Controls.Add(this.CharacterNameBox);
			this.CharacterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CharacterPanel.Location = new System.Drawing.Point(0, 0);
			this.CharacterPanel.Name = "CharacterPanel";
			this.CharacterPanel.Size = new System.Drawing.Size(542, 610);
			this.CharacterPanel.TabIndex = 0;
			// 
			// CharacterNameBox
			// 
			this.CharacterNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CharacterNameBox.Location = new System.Drawing.Point(71, 4);
			this.CharacterNameBox.Name = "CharacterNameBox";
			this.CharacterNameBox.Size = new System.Drawing.Size(207, 26);
			this.CharacterNameBox.TabIndex = 0;
			this.CharacterNameBox.Text = "Name";
			// 
			// CharacterNameLabel
			// 
			this.CharacterNameLabel.AutoSize = true;
			this.CharacterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CharacterNameLabel.Location = new System.Drawing.Point(4, 4);
			this.CharacterNameLabel.Name = "CharacterNameLabel";
			this.CharacterNameLabel.Size = new System.Drawing.Size(61, 24);
			this.CharacterNameLabel.TabIndex = 1;
			this.CharacterNameLabel.Text = "Name";
			// 
			// CharacterClassLabel
			// 
			this.CharacterClassLabel.AutoSize = true;
			this.CharacterClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CharacterClassLabel.Location = new System.Drawing.Point(17, 37);
			this.CharacterClassLabel.Name = "CharacterClassLabel";
			this.CharacterClassLabel.Size = new System.Drawing.Size(48, 20);
			this.CharacterClassLabel.TabIndex = 2;
			this.CharacterClassLabel.Text = "Class";
			// 
			// CharacterClassBox
			// 
			this.CharacterClassBox.FormattingEnabled = true;
			this.CharacterClassBox.Items.AddRange(new object[] {
            "Test"});
			this.CharacterClassBox.Location = new System.Drawing.Point(71, 36);
			this.CharacterClassBox.Name = "CharacterClassBox";
			this.CharacterClassBox.Size = new System.Drawing.Size(121, 21);
			this.CharacterClassBox.TabIndex = 3;
			// 
			// CharacterSheet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CharacterPanel);
			this.Name = "CharacterSheet";
			this.Size = new System.Drawing.Size(542, 610);
			this.CharacterPanel.ResumeLayout(false);
			this.CharacterPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel CharacterPanel;
		private System.Windows.Forms.TextBox CharacterNameBox;
		private System.Windows.Forms.Label CharacterNameLabel;
		private System.Windows.Forms.Label CharacterClassLabel;
		private System.Windows.Forms.ComboBox CharacterClassBox;
	}
}
