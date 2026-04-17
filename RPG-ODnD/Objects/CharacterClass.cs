using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG_ODnD.Objects
{
	struct Limitation
	{
		string race;
		string weapon;
		string armor;
		string magic;
	}

	internal class Attribute
	{
		public string Title {  get; set; }
		public Int32 Experience { get; set; }
		public string HitDie { get; set; }
		public string FightingCapability { get; set; }

		public Attribute() {}
		public Attribute(string title, Int32 experience, string hitdie, string fightingCapability)
		{
			Title = title;
			Experience = experience;
			HitDie = hitdie;
			FightingCapability = fightingCapability;
		}
	}

	internal class AttackMatrix
	{
		public Int32 PlateAndShield { get; set; }
		public Int32 Plate { get; set; }
		public Int32 ChainAndShield { get; set; }
		public Int32 Chain { get; set; }
		public Int32 LeatherAndShield { get; set; }
		public Int32 Leather { get; set; }
		public Int32 Shield { get; set; }
		public Int32 Nothing { get; set; }
		
		public AttackMatrix() {}
		public AttackMatrix(int plateAndShield, int plate, int chainAndShield, int chain, int leatherAndShield, int leather, int shield, int nothing)
		{
			PlateAndShield = plateAndShield;
			Plate = plate;
			ChainAndShield = chainAndShield;
			Chain = chain;
			LeatherAndShield = leatherAndShield;
			Leather = leather;
			Shield = shield;
			Nothing = nothing;
		}
	}

	internal class SavingThrows
	{

		public Int32 DeathRayOrPoison { get; set; }
		public Int32 AllWands { get; set; }
		public Int32 Stone { get; set; }
		public Int32 DragonBreath { get; set; }
		public Int32 StavesAndSpells { get; set; }

		public SavingThrows() {}
		public SavingThrows(int deathRayOrPoison, int allWands, int stone, int dragonBreath, int stavesAndSpells)
		{
			DeathRayOrPoison = deathRayOrPoison;
			AllWands = allWands;
			Stone = stone;
			DragonBreath = dragonBreath;
			StavesAndSpells = stavesAndSpells;
		}
	}

	internal class SpellSlots
	{
		public Int32 First { get; set; }
		public Int32 Second { get; set; }
		public Int32 Third { get; set; }
		public Int32 Fourth { get; set; }
		public Int32 Fifth { get; set; }
		public Int32 Sixth { get; set; }

		public SpellSlots() {}
		public SpellSlots(Int32 first, Int32 second, Int32 third, Int32 fourth, Int32 fifth, Int32 sixth)
		{
			First = first;
			Second = second;
			Third = third;
			Fourth = fourth;
			Fifth = fifth;
			Sixth = sixth;
		}
	}

	internal class CharacterClass
	{
		public string Name { get; set; }
		public string PrimeReq { get; set; }
		public Limitation Limitation { get; set; }
		public List<Attribute> attributes;
		public List<SavingThrows> saving_throws;
		public List<AttackMatrix> attack_matrix;
		public List<SpellSlots> spell_slots;

		public CharacterClass()
		{
			attributes = new List<Attribute>();
			saving_throws = new List<SavingThrows>();
			attack_matrix = new List<AttackMatrix>();
			spell_slots = new List<SpellSlots>();
		}

		public CharacterClass(string name, string primeReq, Limitation limits, List<Attribute> attr, List<SavingThrows> savingThrows,
			List<AttackMatrix> attackMatrix, List<SpellSlots> spellSlots)
		{
			Name = name;
			PrimeReq = primeReq;

			Limitation = limits;
			attributes = new List<Attribute>();
			attributes.AddRange(attr);
			saving_throws = new List<SavingThrows>();
			saving_throws.AddRange(savingThrows);
			attack_matrix = new List<AttackMatrix>();
			attack_matrix.AddRange(attackMatrix);
			spell_slots = new List<SpellSlots>();
			spell_slots.AddRange(spell_slots);
		}
		
	}
}
