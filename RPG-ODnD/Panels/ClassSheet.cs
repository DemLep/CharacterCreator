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
using System.Xml;
using RPG_ODnD.Objects;

namespace RPG_ODnD.Panels
{
	public partial class ClassSheet : UserControl
	{
		private void Save()
		{
			XmlWriter writer = XmlWriter.Create("../../Classes/" + ClassNameBox.Text + ".xml");
			writer.WriteStartDocument();
			writer.WriteWhitespace("\r\n");

			writer.WriteStartElement("class");
			writer.WriteAttributeString("name", ClassNameBox.Text);
			writer.WriteWhitespace("\r\n\t");

			writer.WriteStartElement("prime_req");
			writer.WriteString(PrimeRequisiteBox.Text);
			writer.WriteEndElement();
			writer.WriteWhitespace("\r\n\t");

			writer.WriteStartElement("limitations");
			writer.WriteWhitespace("\r\n\t\t");
			writer.WriteElementString("race", RaceBox.Text);
			writer.WriteWhitespace("\r\n\t\t");
			writer.WriteElementString("weapon", WeaponBox.Text);
			writer.WriteWhitespace("\r\n\t\t");
			writer.WriteElementString("armor", ArmorBox.Text);
			writer.WriteWhitespace("\r\n\t\t");
			writer.WriteElementString("magic", MagicBox.Text);
			writer.WriteWhitespace("\r\n\t");
			writer.WriteEndElement();
			writer.WriteWhitespace("\r\n\t");

			writer.WriteStartElement("levels");
			foreach (DataGridViewRow row in ClassLevelData.Rows)
			{
				if (row.Index == ClassLevelData.RowCount - 1) break;

				writer.WriteWhitespace("\r\n\t\t");
				writer.WriteStartElement("level");
				string title;
				if(row.Cells[0].Value == null)
					title = string.Empty;
				else
					title = row.Cells[0].Value.ToString();
				writer.WriteAttributeString("title", title);
				string experience;
				if (row.Cells[1].Value == null)
					experience = string.Empty;
				else
					experience = row.Cells[1].Value.ToString();
				writer.WriteAttributeString("experience", experience);
				string hitdice;
				if (row.Cells[2].Value == null)
					hitdice = string.Empty;
				else
					hitdice = row.Cells[2].Value.ToString();
				writer.WriteAttributeString("hitdice", hitdice);
				string fighting_capability;
				if (row.Cells[3].Value == null)
					fighting_capability = string.Empty;
				else
					fighting_capability = row.Cells[3].Value.ToString();
				writer.WriteAttributeString("fighting_capability", fighting_capability);
				writer.WriteString((row.Index + 1).ToString());
				writer.WriteEndElement();
			}
			writer.WriteWhitespace("\r\n\t");
			writer.WriteEndElement();
			writer.WriteWhitespace("\r\n\t");

			writer.WriteStartElement("attack_matrix");
			foreach (DataGridViewRow row in AttackMatrixData.Rows)
			{
				if (row.Index == AttackMatrixData.RowCount - 1) break;

				writer.WriteWhitespace("\r\n\t\t");
				writer.WriteStartElement("level");
				string ac2;
				if (row.Cells[0].Value == null)
					ac2 = string.Empty;
				else
					ac2 = row.Cells[0].Value.ToString();
				writer.WriteAttributeString("ac2", ac2);
				string ac3;
				if (row.Cells[1].Value == null)
					ac3 = string.Empty;
				else
					ac3 = row.Cells[1].Value.ToString();
				writer.WriteAttributeString("ac3", ac3);
				string ac4;
				if (row.Cells[2].Value == null)
					ac4 = string.Empty;
				else
					ac4 = row.Cells[2].Value.ToString();
				writer.WriteAttributeString("ac4", ac4);
				string ac5;
				if (row.Cells[3].Value == null)
					ac5 = string.Empty;
				else
					ac5 = row.Cells[3].Value.ToString();
				writer.WriteAttributeString("ac5", ac5);
				string ac6;
				if (row.Cells[4].Value == null)
					ac6 = string.Empty;
				else
					ac6 = row.Cells[4].Value.ToString();
				writer.WriteAttributeString("ac6", ac6);
				string ac7;
				if (row.Cells[5].Value == null)
					ac7 = string.Empty;
				else
					ac7 = row.Cells[5].Value.ToString();
				writer.WriteAttributeString("ac7", ac7);
				string ac8;
				if (row.Cells[6].Value == null)
					ac8 = string.Empty;
				else
					ac8 = row.Cells[6].Value.ToString();
				writer.WriteAttributeString("ac8", ac8);
				string ac9;
				if (row.Cells[7].Value == null)
					ac9 = string.Empty;
				else
					ac9 = row.Cells[7].Value.ToString();
				writer.WriteAttributeString("ac9", ac9);
				writer.WriteString((row.Index + 1).ToString());
				writer.WriteEndElement();
			}
			writer.WriteWhitespace("\r\n\t");
			writer.WriteEndElement();
			writer.WriteWhitespace("\r\n\t");

			writer.WriteStartElement("saving_throws");
			foreach (DataGridViewRow row in SavingThrowData.Rows)
			{
				if (row.Index == SavingThrowData.RowCount - 1) break;

				writer.WriteWhitespace("\r\n\t\t");
				writer.WriteStartElement("level");
				string deathRayOrPoison;
				if (row.Cells[0].Value == null)
					deathRayOrPoison = string.Empty;
				else
					deathRayOrPoison = row.Cells[0].Value.ToString();
				writer.WriteAttributeString("deathray_or_poison", deathRayOrPoison);
				string allWands;
				if (row.Cells[1].Value == null)
					allWands = string.Empty;
				else
					allWands = row.Cells[1].Value.ToString();
				writer.WriteAttributeString("all_wands", allWands);
				string stone;
				if (row.Cells[2].Value == null)
					stone = string.Empty;
				else
					stone = row.Cells[2].Value.ToString();
				writer.WriteAttributeString("stone", stone);
				string dragonBreath;
				if (row.Cells[3].Value == null)
					dragonBreath = string.Empty;
				else
					dragonBreath = row.Cells[3].Value.ToString();
				writer.WriteAttributeString("dragon_breath", dragonBreath);
				string stavesAndSpells;
				if (row.Cells[4].Value == null)
					stavesAndSpells = string.Empty;
				else
					stavesAndSpells = row.Cells[4].Value.ToString();
				writer.WriteAttributeString("staves_and_spells", stavesAndSpells);
				writer.WriteString((row.Index + 1).ToString());
				writer.WriteEndElement();
			}
			writer.WriteWhitespace("\r\n\t");
			writer.WriteEndElement();
			writer.WriteWhitespace("\r\n\t");

			if (IsSpellCaster.Checked)
			{
				writer.WriteStartElement("spell_slots");
				foreach (DataGridViewRow row in SpellSlotData.Rows)
				{
					if (row.Index == SpellSlotData.RowCount - 1) break;

					writer.WriteWhitespace("\r\n\t\t");
					writer.WriteStartElement("level");
					string first;
					if (row.Cells[0].Value == null)
						first = string.Empty;
					else
						first = row.Cells[0].Value.ToString();
					writer.WriteAttributeString("first", first);
					string second;
					if (row.Cells[1].Value == null)
						second = string.Empty;
					else
						second = row.Cells[1].Value.ToString();
					writer.WriteAttributeString("second", second);
					string third;
					if (row.Cells[2].Value == null)
						third = string.Empty;
					else
						third = row.Cells[2].Value.ToString();
					writer.WriteAttributeString("third", third);
					string fourth;
					if (row.Cells[3].Value == null)
						fourth = string.Empty;
					else
						fourth = row.Cells[3].Value.ToString();
					writer.WriteAttributeString("fourth", fourth);
					string fifth;
					if (row.Cells[4].Value == null)
						fifth = string.Empty;
					else
						fifth = row.Cells[4].Value.ToString();
					writer.WriteAttributeString("fifth", fifth);
					string sixth;
					if (row.Cells[5].Value == null)
						sixth = string.Empty;
					else
						sixth = row.Cells[5].Value.ToString();
					writer.WriteAttributeString("sixth", sixth);
					writer.WriteString((row.Index + 1).ToString());
					writer.WriteEndElement();
				}
				writer.WriteWhitespace("\r\n\t");
				writer.WriteEndElement();
				writer.WriteWhitespace("\r\n\t");
			}

			writer.WriteEndElement();
			writer.WriteEndDocument();
			writer.Close();
		}

		private void Load(string path)
		{
			XmlReader reader = XmlReader.Create(path);

			while (reader.Read())
			{
				switch (reader.Name)
				{
					case "class":
						if(reader.IsStartElement())
							ClassNameBox.Text = reader.GetAttribute("name");
						break;
					case "prime_req":
						PrimeRequisiteBox.Text = reader.ReadString();
						break;
					case "race":
						RaceBox.Text = reader.ReadString();
						break;
					case "weapon":
						WeaponBox.Text = reader.ReadString();
						break;
					case "armor":
						ArmorBox.Text = reader.ReadString();
						break;
					case "magic":
						MagicBox.Text = reader.ReadString();
						break;
					case "levels":
						
						while(reader.Read() && reader.Name != "levels")
						{
							if(reader.Name == "level")
							{
								if (reader.IsStartElement())
								{
									Objects.Attribute attribute = new Objects.Attribute();
									attribute.Title = reader.GetAttribute("title");
									attribute.Experience = Int32.Parse(reader.GetAttribute("experience"));
									attribute.HitDie = reader.GetAttribute("hitdice");
									attribute.FightingCapability = reader.GetAttribute("fighting_capability");

									attributeBindingSource.Add(attribute);
								}
							}
						}
						break;
					case "attack_matrix":

						while (reader.Read() && reader.Name != "attack_matrix")
						{
							if (reader.Name == "level")
							{
								if (reader.IsStartElement())
								{
									Objects.AttackMatrix attackMatrix = new Objects.AttackMatrix();
									attackMatrix.PlateAndShield = Int32.Parse(reader.GetAttribute("ac2"));
									attackMatrix.Plate = Int32.Parse(reader.GetAttribute("ac3"));
									attackMatrix.ChainAndShield = Int32.Parse(reader.GetAttribute("ac4"));
									attackMatrix.Chain = Int32.Parse(reader.GetAttribute("ac5"));
									attackMatrix.LeatherAndShield = Int32.Parse(reader.GetAttribute("ac6"));
									attackMatrix.Leather = Int32.Parse(reader.GetAttribute("ac7"));
									attackMatrix.Shield = Int32.Parse(reader.GetAttribute("ac8"));
									attackMatrix.Nothing = Int32.Parse(reader.GetAttribute("ac9"));

									attackMatrixBindingSource.Add(attackMatrix);
								}
							}
						}
						break;
					case "saving_throws":

						while (reader.Read() && reader.Name != "saving_throws")
						{
							if (reader.Name == "level")
							{
								if (reader.IsStartElement())
								{
									Objects.SavingThrows savingThrows = new Objects.SavingThrows();
									savingThrows.DeathRayOrPoison = Int32.Parse(reader.GetAttribute("deathray_or_poison"));
									savingThrows.AllWands = Int32.Parse(reader.GetAttribute("all_wands"));
									savingThrows.Stone = Int32.Parse(reader.GetAttribute("stone"));
									savingThrows.DragonBreath = Int32.Parse(reader.GetAttribute("dragon_breath"));
									savingThrows.StavesAndSpells = Int32.Parse(reader.GetAttribute("staves_and_spells"));

									savingThrowsBindingSource.Add(savingThrows);
								}
							}
						}
						break;
					case "spell_slots":

						while (reader.Read() && reader.Name != "spell_slots")
						{
							IsSpellCaster.Checked = true;
							if (reader.Name == "level")
							{
								if (reader.IsStartElement())
								{
									Objects.SpellSlots spellSlots = new Objects.SpellSlots();
									spellSlots.First = Int32.Parse(reader.GetAttribute("first"));
									spellSlots.Second = Int32.Parse(reader.GetAttribute("second"));
									spellSlots.Third = Int32.Parse(reader.GetAttribute("third"));
									spellSlots.Fourth = Int32.Parse(reader.GetAttribute("fourth"));
									spellSlots.Fifth = Int32.Parse(reader.GetAttribute("fifth"));
									spellSlots.Sixth = Int32.Parse(reader.GetAttribute("sixth"));

									spellSlotsBindingSource.Add(spellSlots);
								}
							}
						}
						break;
				}
			}
			reader.Close();
		}

		public ClassSheet()
		{
			InitializeComponent();
		}

		public ClassSheet(string charclass)
		{
			if (!File.Exists(charclass))
				return;

			InitializeComponent();

			Load(charclass);
		}

		private void IsSpellCaster_CheckedChanged(object sender, EventArgs e)
		{
			if(IsSpellCaster.Checked)
				SpellSlotData.Enabled = true;
			else
				SpellSlotData.Enabled = false;
		}

		private void ClassSaveButton_Click(object sender, EventArgs e)
		{
			Save();
		}
	}
}
