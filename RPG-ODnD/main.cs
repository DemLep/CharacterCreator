using RPG_ODnD.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_ODnD
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
			EditClassButton.Enabled = false;
			LoadCharacters();
			LoadClasses();
		}

		void LoadCharacters()
		{
			return;
		}

		void LoadClasses()
		{
			ClassListBox.Items.Clear();

			string[] files = Directory.GetFiles(@"../../Classes");
			foreach (string file in files)
			{
				string charclass = file.Substring(file.LastIndexOf("\\") + 1);
				charclass = charclass.Split('.')[0];
				ClassListBox.Items.Add(charclass);
			}
		}

		private void CreateCharacterButton_MouseClick(object sender, MouseEventArgs e)
		{
			WindowSplit.Panel1.Controls.Clear();
            CharacterSheet sheet = new CharacterSheet();
			WindowSplit.Panel1.Controls.Add(sheet);
			sheet.Dock = DockStyle.Fill;
		}

		private void CreateClassButton_MouseClick(object sender, MouseEventArgs e)
		{
			WindowSplit.Panel1.Controls.Clear();
			ClassSheet sheet = new ClassSheet();
			WindowSplit.Panel1.Controls.Add(sheet);
			sheet.Dock = DockStyle.Fill;
		}

		private void ClassListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(ClassListBox.SelectedIndex == -1)
				EditClassButton.Enabled = false;
			else
				EditClassButton.Enabled = true;
		}

		private void EditClassButton_Click(object sender, EventArgs e)
		{
			WindowSplit.Panel1.Controls.Clear();
			ClassSheet sheet = new ClassSheet("../../Classes/" + ClassListBox.SelectedItem.ToString() + ".xml");
			WindowSplit.Panel1.Controls.Add(sheet);
			sheet.Dock = DockStyle.Fill;
		}
	}
}
