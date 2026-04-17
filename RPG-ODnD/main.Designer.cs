namespace RPG_ODnD
{
    partial class main
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
			this.WindowSplit = new System.Windows.Forms.SplitContainer();
			this.SidebarTabs = new System.Windows.Forms.TabControl();
			this.CharacterTab = new System.Windows.Forms.TabPage();
			this.CharacterListBox = new System.Windows.Forms.ListBox();
			this.CreateCharacterButton = new System.Windows.Forms.Button();
			this.ClassTab = new System.Windows.Forms.TabPage();
			this.EditClassButton = new System.Windows.Forms.Button();
			this.ClassListBox = new System.Windows.Forms.ListBox();
			this.CreateClassButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.WindowSplit)).BeginInit();
			this.WindowSplit.Panel2.SuspendLayout();
			this.WindowSplit.SuspendLayout();
			this.SidebarTabs.SuspendLayout();
			this.CharacterTab.SuspendLayout();
			this.ClassTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// WindowSplit
			// 
			this.WindowSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.WindowSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WindowSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.WindowSplit.Location = new System.Drawing.Point(0, 0);
			this.WindowSplit.Name = "WindowSplit";
			// 
			// WindowSplit.Panel1
			// 
			this.WindowSplit.Panel1.AccessibleName = "MainWindow";
			// 
			// WindowSplit.Panel2
			// 
			this.WindowSplit.Panel2.AccessibleName = "Sidebar";
			this.WindowSplit.Panel2.Controls.Add(this.SidebarTabs);
			this.WindowSplit.Size = new System.Drawing.Size(852, 514);
			this.WindowSplit.SplitterDistance = 670;
			this.WindowSplit.TabIndex = 0;
			// 
			// SidebarTabs
			// 
			this.SidebarTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.SidebarTabs.Controls.Add(this.ClassTab);
			this.SidebarTabs.Controls.Add(this.CharacterTab);
			this.SidebarTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SidebarTabs.Location = new System.Drawing.Point(0, 0);
			this.SidebarTabs.Multiline = true;
			this.SidebarTabs.Name = "SidebarTabs";
			this.SidebarTabs.SelectedIndex = 0;
			this.SidebarTabs.Size = new System.Drawing.Size(174, 510);
			this.SidebarTabs.TabIndex = 2;
			// 
			// CharacterTab
			// 
			this.CharacterTab.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.CharacterTab.Controls.Add(this.CharacterListBox);
			this.CharacterTab.Controls.Add(this.CreateCharacterButton);
			this.CharacterTab.Location = new System.Drawing.Point(23, 4);
			this.CharacterTab.Name = "CharacterTab";
			this.CharacterTab.Padding = new System.Windows.Forms.Padding(3);
			this.CharacterTab.Size = new System.Drawing.Size(147, 502);
			this.CharacterTab.TabIndex = 0;
			this.CharacterTab.Text = "Characters";
			// 
			// CharacterListBox
			// 
			this.CharacterListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CharacterListBox.FormattingEnabled = true;
			this.CharacterListBox.Location = new System.Drawing.Point(3, 40);
			this.CharacterListBox.Name = "CharacterListBox";
			this.CharacterListBox.Size = new System.Drawing.Size(141, 459);
			this.CharacterListBox.TabIndex = 1;
			// 
			// CreateCharacterButton
			// 
			this.CreateCharacterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateCharacterButton.Location = new System.Drawing.Point(6, 6);
			this.CreateCharacterButton.Name = "CreateCharacterButton";
			this.CreateCharacterButton.Size = new System.Drawing.Size(125, 23);
			this.CreateCharacterButton.TabIndex = 0;
			this.CreateCharacterButton.Text = "Create Character";
			this.CreateCharacterButton.UseVisualStyleBackColor = true;
			this.CreateCharacterButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreateCharacterButton_MouseClick);
			// 
			// ClassTab
			// 
			this.ClassTab.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClassTab.Controls.Add(this.EditClassButton);
			this.ClassTab.Controls.Add(this.ClassListBox);
			this.ClassTab.Controls.Add(this.CreateClassButton);
			this.ClassTab.Location = new System.Drawing.Point(23, 4);
			this.ClassTab.Name = "ClassTab";
			this.ClassTab.Padding = new System.Windows.Forms.Padding(3);
			this.ClassTab.Size = new System.Drawing.Size(147, 502);
			this.ClassTab.TabIndex = 1;
			this.ClassTab.Text = "Classes";
			// 
			// EditClassButton
			// 
			this.EditClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditClassButton.Location = new System.Drawing.Point(6, 6);
			this.EditClassButton.Name = "EditClassButton";
			this.EditClassButton.Size = new System.Drawing.Size(55, 23);
			this.EditClassButton.TabIndex = 3;
			this.EditClassButton.Text = "Edit";
			this.EditClassButton.UseVisualStyleBackColor = true;
			this.EditClassButton.Click += new System.EventHandler(this.EditClassButton_Click);
			// 
			// ClassListBox
			// 
			this.ClassListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClassListBox.FormattingEnabled = true;
			this.ClassListBox.Location = new System.Drawing.Point(3, 40);
			this.ClassListBox.Name = "ClassListBox";
			this.ClassListBox.Size = new System.Drawing.Size(129, 459);
			this.ClassListBox.TabIndex = 2;
			this.ClassListBox.SelectedIndexChanged += new System.EventHandler(this.ClassListBox_SelectedIndexChanged);
			// 
			// CreateClassButton
			// 
			this.CreateClassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateClassButton.Location = new System.Drawing.Point(74, 6);
			this.CreateClassButton.Name = "CreateClassButton";
			this.CreateClassButton.Size = new System.Drawing.Size(55, 23);
			this.CreateClassButton.TabIndex = 1;
			this.CreateClassButton.Text = "Create";
			this.CreateClassButton.UseVisualStyleBackColor = true;
			this.CreateClassButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreateClassButton_MouseClick);
			// 
			// main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 514);
			this.Controls.Add(this.WindowSplit);
			this.Name = "main";
			this.Text = "Dungeons & Dragons";
			this.WindowSplit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WindowSplit)).EndInit();
			this.WindowSplit.ResumeLayout(false);
			this.SidebarTabs.ResumeLayout(false);
			this.CharacterTab.ResumeLayout(false);
			this.ClassTab.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.SplitContainer WindowSplit;
		private System.Windows.Forms.Button CreateCharacterButton;
		private System.Windows.Forms.Button CreateClassButton;
		private System.Windows.Forms.TabControl SidebarTabs;
		private System.Windows.Forms.TabPage CharacterTab;
		private System.Windows.Forms.TabPage ClassTab;
		private System.Windows.Forms.ListBox CharacterListBox;
		private System.Windows.Forms.ListBox ClassListBox;
		private System.Windows.Forms.Button EditClassButton;
	}
}

