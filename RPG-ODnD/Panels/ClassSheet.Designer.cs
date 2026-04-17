namespace RPG_ODnD.Panels
{
	partial class ClassSheet
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
			this.components = new System.ComponentModel.Container();
			this.ClassTabs = new System.Windows.Forms.TabControl();
			this.MainTab = new System.Windows.Forms.TabPage();
			this.ClassLevelData = new System.Windows.Forms.DataGridView();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hitDieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fightingCapabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attributeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.LimitationBox = new System.Windows.Forms.GroupBox();
			this.MagicLabel = new System.Windows.Forms.Label();
			this.ArmorLabel = new System.Windows.Forms.Label();
			this.WeaponLabel = new System.Windows.Forms.Label();
			this.RaceLabel = new System.Windows.Forms.Label();
			this.MagicBox = new System.Windows.Forms.TextBox();
			this.ArmorBox = new System.Windows.Forms.TextBox();
			this.WeaponBox = new System.Windows.Forms.TextBox();
			this.RaceBox = new System.Windows.Forms.TextBox();
			this.PrimeRequisiteLabel = new System.Windows.Forms.Label();
			this.PrimeRequisiteBox = new System.Windows.Forms.TextBox();
			this.CombatTab = new System.Windows.Forms.TabPage();
			this.AttackMatrixData = new System.Windows.Forms.DataGridView();
			this.plateAndShieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.plateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chainAndShieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leatherAndShieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nothingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attackMatrixBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.SavingThrowData = new System.Windows.Forms.DataGridView();
			this.deathRayOrPoisonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.allWandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dragonBreathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stavesAndSpellsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.savingThrowsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.MagicTab = new System.Windows.Forms.TabPage();
			this.SpellSlotData = new System.Windows.Forms.DataGridView();
			this.firstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fourthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fifthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sixthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.spellSlotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.IsSpellCaster = new System.Windows.Forms.CheckBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.ClassNameBox = new System.Windows.Forms.TextBox();
			this.ClassSaveButton = new System.Windows.Forms.Button();
			this.ClassTabs.SuspendLayout();
			this.MainTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClassLevelData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.attributeBindingSource)).BeginInit();
			this.LimitationBox.SuspendLayout();
			this.CombatTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AttackMatrixData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.attackMatrixBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SavingThrowData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.savingThrowsBindingSource)).BeginInit();
			this.MagicTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpellSlotData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spellSlotsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ClassTabs
			// 
			this.ClassTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClassTabs.Controls.Add(this.MainTab);
			this.ClassTabs.Controls.Add(this.CombatTab);
			this.ClassTabs.Controls.Add(this.MagicTab);
			this.ClassTabs.Location = new System.Drawing.Point(0, 35);
			this.ClassTabs.Name = "ClassTabs";
			this.ClassTabs.SelectedIndex = 0;
			this.ClassTabs.Size = new System.Drawing.Size(732, 582);
			this.ClassTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.ClassTabs.TabIndex = 0;
			// 
			// MainTab
			// 
			this.MainTab.Controls.Add(this.ClassLevelData);
			this.MainTab.Controls.Add(this.LimitationBox);
			this.MainTab.Controls.Add(this.PrimeRequisiteLabel);
			this.MainTab.Controls.Add(this.PrimeRequisiteBox);
			this.MainTab.Location = new System.Drawing.Point(4, 22);
			this.MainTab.Name = "MainTab";
			this.MainTab.Padding = new System.Windows.Forms.Padding(3);
			this.MainTab.Size = new System.Drawing.Size(724, 556);
			this.MainTab.TabIndex = 0;
			this.MainTab.Text = "Main";
			this.MainTab.UseVisualStyleBackColor = true;
			// 
			// ClassLevelData
			// 
			this.ClassLevelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClassLevelData.AutoGenerateColumns = false;
			this.ClassLevelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ClassLevelData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.hitDieDataGridViewTextBoxColumn,
            this.fightingCapabilityDataGridViewTextBoxColumn});
			this.ClassLevelData.DataSource = this.attributeBindingSource;
			this.ClassLevelData.Location = new System.Drawing.Point(7, 173);
			this.ClassLevelData.MultiSelect = false;
			this.ClassLevelData.Name = "ClassLevelData";
			this.ClassLevelData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.ClassLevelData.Size = new System.Drawing.Size(711, 377);
			this.ClassLevelData.TabIndex = 10;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.Width = 52;
			// 
			// experienceDataGridViewTextBoxColumn
			// 
			this.experienceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
			this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
			this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
			this.experienceDataGridViewTextBoxColumn.Width = 85;
			// 
			// hitDieDataGridViewTextBoxColumn
			// 
			this.hitDieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.hitDieDataGridViewTextBoxColumn.DataPropertyName = "HitDie";
			this.hitDieDataGridViewTextBoxColumn.HeaderText = "HitDie";
			this.hitDieDataGridViewTextBoxColumn.Name = "hitDieDataGridViewTextBoxColumn";
			this.hitDieDataGridViewTextBoxColumn.Width = 61;
			// 
			// fightingCapabilityDataGridViewTextBoxColumn
			// 
			this.fightingCapabilityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.fightingCapabilityDataGridViewTextBoxColumn.DataPropertyName = "FightingCapability";
			this.fightingCapabilityDataGridViewTextBoxColumn.HeaderText = "FightingCapability";
			this.fightingCapabilityDataGridViewTextBoxColumn.Name = "fightingCapabilityDataGridViewTextBoxColumn";
			this.fightingCapabilityDataGridViewTextBoxColumn.Width = 114;
			// 
			// attributeBindingSource
			// 
			this.attributeBindingSource.DataSource = typeof(RPG_ODnD.Objects.Attribute);
			// 
			// LimitationBox
			// 
			this.LimitationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LimitationBox.Controls.Add(this.MagicLabel);
			this.LimitationBox.Controls.Add(this.ArmorLabel);
			this.LimitationBox.Controls.Add(this.WeaponLabel);
			this.LimitationBox.Controls.Add(this.RaceLabel);
			this.LimitationBox.Controls.Add(this.MagicBox);
			this.LimitationBox.Controls.Add(this.ArmorBox);
			this.LimitationBox.Controls.Add(this.WeaponBox);
			this.LimitationBox.Controls.Add(this.RaceBox);
			this.LimitationBox.Location = new System.Drawing.Point(7, 35);
			this.LimitationBox.Name = "LimitationBox";
			this.LimitationBox.Size = new System.Drawing.Size(711, 132);
			this.LimitationBox.TabIndex = 9;
			this.LimitationBox.TabStop = false;
			this.LimitationBox.Text = "Limitations";
			// 
			// MagicLabel
			// 
			this.MagicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MagicLabel.AutoSize = true;
			this.MagicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MagicLabel.Location = new System.Drawing.Point(6, 103);
			this.MagicLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.MagicLabel.Name = "MagicLabel";
			this.MagicLabel.Size = new System.Drawing.Size(50, 17);
			this.MagicLabel.TabIndex = 14;
			this.MagicLabel.Text = "Magic";
			// 
			// ArmorLabel
			// 
			this.ArmorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ArmorLabel.AutoSize = true;
			this.ArmorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ArmorLabel.Location = new System.Drawing.Point(6, 76);
			this.ArmorLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.ArmorLabel.Name = "ArmorLabel";
			this.ArmorLabel.Size = new System.Drawing.Size(51, 17);
			this.ArmorLabel.TabIndex = 13;
			this.ArmorLabel.Text = "Armor";
			// 
			// WeaponLabel
			// 
			this.WeaponLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WeaponLabel.AutoSize = true;
			this.WeaponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeaponLabel.Location = new System.Drawing.Point(6, 49);
			this.WeaponLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.WeaponLabel.Name = "WeaponLabel";
			this.WeaponLabel.Size = new System.Drawing.Size(44, 17);
			this.WeaponLabel.TabIndex = 12;
			this.WeaponLabel.Text = "Arms";
			// 
			// RaceLabel
			// 
			this.RaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RaceLabel.AutoSize = true;
			this.RaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RaceLabel.Location = new System.Drawing.Point(6, 22);
			this.RaceLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.RaceLabel.Name = "RaceLabel";
			this.RaceLabel.Size = new System.Drawing.Size(45, 17);
			this.RaceLabel.TabIndex = 11;
			this.RaceLabel.Text = "Race";
			// 
			// MagicBox
			// 
			this.MagicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MagicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MagicBox.Location = new System.Drawing.Point(66, 100);
			this.MagicBox.Name = "MagicBox";
			this.MagicBox.Size = new System.Drawing.Size(639, 21);
			this.MagicBox.TabIndex = 9;
			// 
			// ArmorBox
			// 
			this.ArmorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ArmorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ArmorBox.Location = new System.Drawing.Point(66, 73);
			this.ArmorBox.Name = "ArmorBox";
			this.ArmorBox.Size = new System.Drawing.Size(639, 21);
			this.ArmorBox.TabIndex = 7;
			// 
			// WeaponBox
			// 
			this.WeaponBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WeaponBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeaponBox.Location = new System.Drawing.Point(66, 46);
			this.WeaponBox.Name = "WeaponBox";
			this.WeaponBox.Size = new System.Drawing.Size(639, 21);
			this.WeaponBox.TabIndex = 5;
			// 
			// RaceBox
			// 
			this.RaceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RaceBox.Location = new System.Drawing.Point(66, 19);
			this.RaceBox.Name = "RaceBox";
			this.RaceBox.Size = new System.Drawing.Size(639, 21);
			this.RaceBox.TabIndex = 3;
			// 
			// PrimeRequisiteLabel
			// 
			this.PrimeRequisiteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PrimeRequisiteLabel.AutoSize = true;
			this.PrimeRequisiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrimeRequisiteLabel.Location = new System.Drawing.Point(3, 6);
			this.PrimeRequisiteLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.PrimeRequisiteLabel.Name = "PrimeRequisiteLabel";
			this.PrimeRequisiteLabel.Size = new System.Drawing.Size(135, 20);
			this.PrimeRequisiteLabel.TabIndex = 7;
			this.PrimeRequisiteLabel.Text = "Prime Requisite";
			// 
			// PrimeRequisiteBox
			// 
			this.PrimeRequisiteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PrimeRequisiteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrimeRequisiteBox.Location = new System.Drawing.Point(144, 6);
			this.PrimeRequisiteBox.Name = "PrimeRequisiteBox";
			this.PrimeRequisiteBox.Size = new System.Drawing.Size(568, 23);
			this.PrimeRequisiteBox.TabIndex = 8;
			// 
			// CombatTab
			// 
			this.CombatTab.Controls.Add(this.AttackMatrixData);
			this.CombatTab.Controls.Add(this.SavingThrowData);
			this.CombatTab.Location = new System.Drawing.Point(4, 22);
			this.CombatTab.Name = "CombatTab";
			this.CombatTab.Padding = new System.Windows.Forms.Padding(3);
			this.CombatTab.Size = new System.Drawing.Size(724, 556);
			this.CombatTab.TabIndex = 1;
			this.CombatTab.Text = "Combat";
			this.CombatTab.UseVisualStyleBackColor = true;
			// 
			// AttackMatrixData
			// 
			this.AttackMatrixData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AttackMatrixData.AutoGenerateColumns = false;
			this.AttackMatrixData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.AttackMatrixData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AttackMatrixData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateAndShieldDataGridViewTextBoxColumn,
            this.plateDataGridViewTextBoxColumn,
            this.chainAndShieldDataGridViewTextBoxColumn,
            this.chainDataGridViewTextBoxColumn,
            this.leatherAndShieldDataGridViewTextBoxColumn,
            this.leatherDataGridViewTextBoxColumn,
            this.shieldDataGridViewTextBoxColumn,
            this.nothingDataGridViewTextBoxColumn});
			this.AttackMatrixData.DataSource = this.attackMatrixBindingSource;
			this.AttackMatrixData.Location = new System.Drawing.Point(6, 281);
			this.AttackMatrixData.MultiSelect = false;
			this.AttackMatrixData.Name = "AttackMatrixData";
			this.AttackMatrixData.Size = new System.Drawing.Size(712, 268);
			this.AttackMatrixData.TabIndex = 1;
			// 
			// plateAndShieldDataGridViewTextBoxColumn
			// 
			this.plateAndShieldDataGridViewTextBoxColumn.DataPropertyName = "PlateAndShield";
			this.plateAndShieldDataGridViewTextBoxColumn.HeaderText = "PlateAndShield";
			this.plateAndShieldDataGridViewTextBoxColumn.Name = "plateAndShieldDataGridViewTextBoxColumn";
			this.plateAndShieldDataGridViewTextBoxColumn.Width = 104;
			// 
			// plateDataGridViewTextBoxColumn
			// 
			this.plateDataGridViewTextBoxColumn.DataPropertyName = "Plate";
			this.plateDataGridViewTextBoxColumn.HeaderText = "Plate";
			this.plateDataGridViewTextBoxColumn.Name = "plateDataGridViewTextBoxColumn";
			this.plateDataGridViewTextBoxColumn.Width = 56;
			// 
			// chainAndShieldDataGridViewTextBoxColumn
			// 
			this.chainAndShieldDataGridViewTextBoxColumn.DataPropertyName = "ChainAndShield";
			this.chainAndShieldDataGridViewTextBoxColumn.HeaderText = "ChainAndShield";
			this.chainAndShieldDataGridViewTextBoxColumn.Name = "chainAndShieldDataGridViewTextBoxColumn";
			this.chainAndShieldDataGridViewTextBoxColumn.Width = 107;
			// 
			// chainDataGridViewTextBoxColumn
			// 
			this.chainDataGridViewTextBoxColumn.DataPropertyName = "Chain";
			this.chainDataGridViewTextBoxColumn.HeaderText = "Chain";
			this.chainDataGridViewTextBoxColumn.Name = "chainDataGridViewTextBoxColumn";
			this.chainDataGridViewTextBoxColumn.Width = 59;
			// 
			// leatherAndShieldDataGridViewTextBoxColumn
			// 
			this.leatherAndShieldDataGridViewTextBoxColumn.DataPropertyName = "LeatherAndShield";
			this.leatherAndShieldDataGridViewTextBoxColumn.HeaderText = "LeatherAndShield";
			this.leatherAndShieldDataGridViewTextBoxColumn.Name = "leatherAndShieldDataGridViewTextBoxColumn";
			this.leatherAndShieldDataGridViewTextBoxColumn.Width = 116;
			// 
			// leatherDataGridViewTextBoxColumn
			// 
			this.leatherDataGridViewTextBoxColumn.DataPropertyName = "Leather";
			this.leatherDataGridViewTextBoxColumn.HeaderText = "Leather";
			this.leatherDataGridViewTextBoxColumn.Name = "leatherDataGridViewTextBoxColumn";
			this.leatherDataGridViewTextBoxColumn.Width = 68;
			// 
			// shieldDataGridViewTextBoxColumn
			// 
			this.shieldDataGridViewTextBoxColumn.DataPropertyName = "Shield";
			this.shieldDataGridViewTextBoxColumn.HeaderText = "Shield";
			this.shieldDataGridViewTextBoxColumn.Name = "shieldDataGridViewTextBoxColumn";
			this.shieldDataGridViewTextBoxColumn.Width = 61;
			// 
			// nothingDataGridViewTextBoxColumn
			// 
			this.nothingDataGridViewTextBoxColumn.DataPropertyName = "Nothing";
			this.nothingDataGridViewTextBoxColumn.HeaderText = "Nothing";
			this.nothingDataGridViewTextBoxColumn.Name = "nothingDataGridViewTextBoxColumn";
			this.nothingDataGridViewTextBoxColumn.Width = 69;
			// 
			// attackMatrixBindingSource
			// 
			this.attackMatrixBindingSource.DataSource = typeof(RPG_ODnD.Objects.AttackMatrix);
			// 
			// SavingThrowData
			// 
			this.SavingThrowData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SavingThrowData.AutoGenerateColumns = false;
			this.SavingThrowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.SavingThrowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SavingThrowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deathRayOrPoisonDataGridViewTextBoxColumn,
            this.allWandsDataGridViewTextBoxColumn,
            this.stoneDataGridViewTextBoxColumn,
            this.dragonBreathDataGridViewTextBoxColumn,
            this.stavesAndSpellsDataGridViewTextBoxColumn});
			this.SavingThrowData.DataSource = this.savingThrowsBindingSource;
			this.SavingThrowData.Location = new System.Drawing.Point(7, 7);
			this.SavingThrowData.MultiSelect = false;
			this.SavingThrowData.Name = "SavingThrowData";
			this.SavingThrowData.Size = new System.Drawing.Size(712, 268);
			this.SavingThrowData.TabIndex = 0;
			// 
			// deathRayOrPoisonDataGridViewTextBoxColumn
			// 
			this.deathRayOrPoisonDataGridViewTextBoxColumn.DataPropertyName = "DeathRayOrPoison";
			this.deathRayOrPoisonDataGridViewTextBoxColumn.HeaderText = "DeathRayOrPoison";
			this.deathRayOrPoisonDataGridViewTextBoxColumn.Name = "deathRayOrPoisonDataGridViewTextBoxColumn";
			this.deathRayOrPoisonDataGridViewTextBoxColumn.Width = 123;
			// 
			// allWandsDataGridViewTextBoxColumn
			// 
			this.allWandsDataGridViewTextBoxColumn.DataPropertyName = "AllWands";
			this.allWandsDataGridViewTextBoxColumn.HeaderText = "AllWands";
			this.allWandsDataGridViewTextBoxColumn.Name = "allWandsDataGridViewTextBoxColumn";
			this.allWandsDataGridViewTextBoxColumn.Width = 77;
			// 
			// stoneDataGridViewTextBoxColumn
			// 
			this.stoneDataGridViewTextBoxColumn.DataPropertyName = "Stone";
			this.stoneDataGridViewTextBoxColumn.HeaderText = "Stone";
			this.stoneDataGridViewTextBoxColumn.Name = "stoneDataGridViewTextBoxColumn";
			this.stoneDataGridViewTextBoxColumn.Width = 60;
			// 
			// dragonBreathDataGridViewTextBoxColumn
			// 
			this.dragonBreathDataGridViewTextBoxColumn.DataPropertyName = "DragonBreath";
			this.dragonBreathDataGridViewTextBoxColumn.HeaderText = "DragonBreath";
			this.dragonBreathDataGridViewTextBoxColumn.Name = "dragonBreathDataGridViewTextBoxColumn";
			this.dragonBreathDataGridViewTextBoxColumn.Width = 98;
			// 
			// stavesAndSpellsDataGridViewTextBoxColumn
			// 
			this.stavesAndSpellsDataGridViewTextBoxColumn.DataPropertyName = "StavesAndSpells";
			this.stavesAndSpellsDataGridViewTextBoxColumn.HeaderText = "StavesAndSpells";
			this.stavesAndSpellsDataGridViewTextBoxColumn.Name = "stavesAndSpellsDataGridViewTextBoxColumn";
			this.stavesAndSpellsDataGridViewTextBoxColumn.Width = 112;
			// 
			// savingThrowsBindingSource
			// 
			this.savingThrowsBindingSource.DataSource = typeof(RPG_ODnD.Objects.SavingThrows);
			// 
			// MagicTab
			// 
			this.MagicTab.Controls.Add(this.SpellSlotData);
			this.MagicTab.Controls.Add(this.IsSpellCaster);
			this.MagicTab.Location = new System.Drawing.Point(4, 22);
			this.MagicTab.Name = "MagicTab";
			this.MagicTab.Size = new System.Drawing.Size(724, 556);
			this.MagicTab.TabIndex = 2;
			this.MagicTab.Text = "Magic";
			this.MagicTab.UseVisualStyleBackColor = true;
			// 
			// SpellSlotData
			// 
			this.SpellSlotData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SpellSlotData.AutoGenerateColumns = false;
			this.SpellSlotData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.SpellSlotData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SpellSlotData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstDataGridViewTextBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.thirdDataGridViewTextBoxColumn,
            this.fourthDataGridViewTextBoxColumn,
            this.fifthDataGridViewTextBoxColumn,
            this.sixthDataGridViewTextBoxColumn});
			this.SpellSlotData.DataSource = this.spellSlotsBindingSource;
			this.SpellSlotData.Enabled = false;
			this.SpellSlotData.Location = new System.Drawing.Point(4, 28);
			this.SpellSlotData.Name = "SpellSlotData";
			this.SpellSlotData.Size = new System.Drawing.Size(717, 525);
			this.SpellSlotData.TabIndex = 1;
			// 
			// firstDataGridViewTextBoxColumn
			// 
			this.firstDataGridViewTextBoxColumn.DataPropertyName = "First";
			this.firstDataGridViewTextBoxColumn.HeaderText = "First";
			this.firstDataGridViewTextBoxColumn.Name = "firstDataGridViewTextBoxColumn";
			this.firstDataGridViewTextBoxColumn.Width = 51;
			// 
			// secondDataGridViewTextBoxColumn
			// 
			this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
			this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
			this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
			this.secondDataGridViewTextBoxColumn.Width = 69;
			// 
			// thirdDataGridViewTextBoxColumn
			// 
			this.thirdDataGridViewTextBoxColumn.DataPropertyName = "Third";
			this.thirdDataGridViewTextBoxColumn.HeaderText = "Third";
			this.thirdDataGridViewTextBoxColumn.Name = "thirdDataGridViewTextBoxColumn";
			this.thirdDataGridViewTextBoxColumn.Width = 56;
			// 
			// fourthDataGridViewTextBoxColumn
			// 
			this.fourthDataGridViewTextBoxColumn.DataPropertyName = "Fourth";
			this.fourthDataGridViewTextBoxColumn.HeaderText = "Fourth";
			this.fourthDataGridViewTextBoxColumn.Name = "fourthDataGridViewTextBoxColumn";
			this.fourthDataGridViewTextBoxColumn.Width = 62;
			// 
			// fifthDataGridViewTextBoxColumn
			// 
			this.fifthDataGridViewTextBoxColumn.DataPropertyName = "Fifth";
			this.fifthDataGridViewTextBoxColumn.HeaderText = "Fifth";
			this.fifthDataGridViewTextBoxColumn.Name = "fifthDataGridViewTextBoxColumn";
			this.fifthDataGridViewTextBoxColumn.Width = 52;
			// 
			// sixthDataGridViewTextBoxColumn
			// 
			this.sixthDataGridViewTextBoxColumn.DataPropertyName = "Sixth";
			this.sixthDataGridViewTextBoxColumn.HeaderText = "Sixth";
			this.sixthDataGridViewTextBoxColumn.Name = "sixthDataGridViewTextBoxColumn";
			this.sixthDataGridViewTextBoxColumn.Width = 55;
			// 
			// spellSlotsBindingSource
			// 
			this.spellSlotsBindingSource.DataSource = typeof(RPG_ODnD.Objects.SpellSlots);
			// 
			// IsSpellCaster
			// 
			this.IsSpellCaster.AutoSize = true;
			this.IsSpellCaster.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.IsSpellCaster.Location = new System.Drawing.Point(4, 4);
			this.IsSpellCaster.Name = "IsSpellCaster";
			this.IsSpellCaster.Size = new System.Drawing.Size(88, 17);
			this.IsSpellCaster.TabIndex = 0;
			this.IsSpellCaster.Text = "Spell Caster?";
			this.IsSpellCaster.UseVisualStyleBackColor = true;
			this.IsSpellCaster.CheckedChanged += new System.EventHandler(this.IsSpellCaster_CheckedChanged);
			// 
			// NameLabel
			// 
			this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.Location = new System.Drawing.Point(3, 3);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(75, 26);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Name";
			// 
			// ClassNameBox
			// 
			this.ClassNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClassNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClassNameBox.Location = new System.Drawing.Point(84, 6);
			this.ClassNameBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.ClassNameBox.Name = "ClassNameBox";
			this.ClassNameBox.Size = new System.Drawing.Size(632, 23);
			this.ClassNameBox.TabIndex = 1;
			// 
			// ClassSaveButton
			// 
			this.ClassSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClassSaveButton.Location = new System.Drawing.Point(658, 626);
			this.ClassSaveButton.Name = "ClassSaveButton";
			this.ClassSaveButton.Size = new System.Drawing.Size(75, 23);
			this.ClassSaveButton.TabIndex = 4;
			this.ClassSaveButton.Text = "Save";
			this.ClassSaveButton.UseVisualStyleBackColor = true;
			this.ClassSaveButton.Click += new System.EventHandler(this.ClassSaveButton_Click);
			// 
			// ClassSheet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.ClassNameBox);
			this.Controls.Add(this.ClassTabs);
			this.Controls.Add(this.ClassSaveButton);
			this.Name = "ClassSheet";
			this.Size = new System.Drawing.Size(736, 652);
			this.ClassTabs.ResumeLayout(false);
			this.MainTab.ResumeLayout(false);
			this.MainTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClassLevelData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.attributeBindingSource)).EndInit();
			this.LimitationBox.ResumeLayout(false);
			this.LimitationBox.PerformLayout();
			this.CombatTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AttackMatrixData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.attackMatrixBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SavingThrowData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.savingThrowsBindingSource)).EndInit();
			this.MagicTab.ResumeLayout(false);
			this.MagicTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpellSlotData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spellSlotsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource attributeBindingSource;
		private System.Windows.Forms.TabControl ClassTabs;
		private System.Windows.Forms.TabPage MainTab;
		private System.Windows.Forms.TabPage CombatTab;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox ClassNameBox;
		private System.Windows.Forms.Button ClassSaveButton;
		private System.Windows.Forms.TabPage MagicTab;
		private System.Windows.Forms.Label PrimeRequisiteLabel;
		private System.Windows.Forms.TextBox PrimeRequisiteBox;
		private System.Windows.Forms.DataGridView ClassLevelData;
		private System.Windows.Forms.GroupBox LimitationBox;
		private System.Windows.Forms.TextBox MagicBox;
		private System.Windows.Forms.TextBox ArmorBox;
		private System.Windows.Forms.TextBox WeaponBox;
		private System.Windows.Forms.TextBox RaceBox;
		private System.Windows.Forms.Label RaceLabel;
		private System.Windows.Forms.Label MagicLabel;
		private System.Windows.Forms.Label ArmorLabel;
		private System.Windows.Forms.Label WeaponLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hitDieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fightingCapabilityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView AttackMatrixData;
		private System.Windows.Forms.DataGridViewTextBoxColumn plateAndShieldDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn plateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn chainAndShieldDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn chainDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn leatherAndShieldDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn leatherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shieldDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nothingDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource attackMatrixBindingSource;
		private System.Windows.Forms.DataGridView SavingThrowData;
		private System.Windows.Forms.DataGridViewTextBoxColumn deathRayOrPoisonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn allWandsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dragonBreathDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stavesAndSpellsDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource savingThrowsBindingSource;
		private System.Windows.Forms.BindingSource spellSlotsBindingSource;
		private System.Windows.Forms.CheckBox IsSpellCaster;
		private System.Windows.Forms.DataGridView SpellSlotData;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn thirdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fourthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fifthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sixthDataGridViewTextBoxColumn;
	}
}
