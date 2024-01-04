using System.Diagnostics;

namespace ThoughtformTCG.GameModels;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Card
{
    public Card()
        {
        }
    // Properties
    public string Name { get; set; } = "";
    public string Affinity { get; set; } = "";
    public string ThoughtformMoveStat { get; set; } = "";
    public string Attack { get; set; } = "";
    public int Level { get; set; }
    public string Type { get; set; } = "";
    public int Range { get; set; }
    public string PlayEffect { get; set; } = "";
    public string LostEffect { get; set; } = "";
    public string RangeType { get; set; } = "";
    public bool ToLostPile { get; set; }
    public int ManaCost { get; set; }
    public int ManaGain { get; set; }
    public int TowerHPGain { get; set; }
    public string MoveStat { get; set; } = "";
    public int DamageStat { get; set; }
    public int HPStat { get; set; }
    public int ManaStat { get; set; }
    public int PlayEffectValue { get; set; }
    public int LostEffectValue { get; set; }
    public string Description { get; set; } = "";
    public string Effect { get; set; } = "";
    public string Passive1 { get; set; } = "";
    public string Passive2 { get; set; } = "";
    public int CastAndTrapDamage { get; set; }
    public int CardID { get; set; }
    public string CardOwner { get; set; } = "";
    public bool Stall { get; set; }

    protected Card(Dictionary<string, object> builder)
    {
        // Set other properties...

        // Ensure properties are set or handle null values appropriately
        Name = builder["Name"]?.ToString() ?? "";
        Affinity = builder["Affinity"]?.ToString() ?? "";
        ThoughtformMoveStat = builder["ThoughtformMoveStat"]?.ToString() ?? "";
        Attack = builder["Attack"]?.ToString() ?? "";
        Level = Convert.ToInt32(builder["Level"]);
        Type = builder["Type"]?.ToString() ?? "";
        Range = Convert.ToInt32(builder["Range"]);
        PlayEffect = builder["PlayEffect"]?.ToString() ?? "";
        LostEffect = builder["LostEffect"]?.ToString() ?? "";
        RangeType = builder["RangeType"]?.ToString() ?? "";
        ToLostPile = Convert.ToBoolean(builder["ToLostPile"]);
        ManaCost = Convert.ToInt32(builder["ManaCost"]);
        ManaGain = Convert.ToInt32(builder["ManaGain"]);
        TowerHPGain = Convert.ToInt32(builder["TowerHPGain"]);
        MoveStat = builder["MoveStat"]?.ToString() ?? "";
        DamageStat = Convert.ToInt32(builder["DamageStat"]);
        HPStat = Convert.ToInt32(builder["HPStat"]);
        ManaStat = Convert.ToInt32(builder["ManaStat"]);
        PlayEffectValue = Convert.ToInt32(builder["PlayEffectValue"]);
        LostEffectValue = Convert.ToInt32(builder["LostEffectValue"]);
        Description = builder["Description"]?.ToString() ?? "";
        Effect = builder["Effect"]?.ToString() ?? "";
        Passive1 = builder["Passive1"]?.ToString() ?? "";
        Passive2 = builder["Passive2"]?.ToString() ?? "";
        CastAndTrapDamage = Convert.ToInt32(builder["CastAndTrapDamage"]);
        CardID = Convert.ToInt32(builder["CardID"]);
        CardOwner = builder["CardOwner"]?.ToString() ?? "";
        Stall = Convert.ToBoolean(builder["Stall"]);
    }
    private string GetDebuggerDisplay()
    {
        return ToString() ?? "Card: (null)";
    }
    
}
public static class CardEffects
    {
        public static void ChangeName(this Card card, string newName)
        {
            card.Name = newName;
        }

        public static void ChangeAffinity(this Card card, string newAffinity)
        {
            card.Affinity = newAffinity;
        }

        public static void ChangeThoughtformMoveStat(this Card card, string newThoughtformMoveStat)
        {
            card.ThoughtformMoveStat = newThoughtformMoveStat;
        }

        public static void ChangeAttack(this Card card, string newAttack)
        {
            card.Attack = newAttack;
        }

        public static void ChangeLevel(this Card card, int newLevel)
        {
            card.Level = newLevel;
        }

        public static void ChangeType(this Card card, string newType)
        {
            card.Type = newType;
        }

        public static void ChangeRange(this Card card, int newRange)
        {
            card.Range = newRange;
        }

        public static void ChangePlayEffect(this Card card, string newPlayEffect)
        {
            card.PlayEffect = newPlayEffect;
        }

        public static void ChangeLostEffect(this Card card, string newLostEffect)
        {
            card.LostEffect = newLostEffect;
        }

        public static void ChangeLostPile(this Card card, bool newLostPile)
        {
            card.ToLostPile = newLostPile;
        }

        public static void ChangeManaCost(this Card card, int newManaCost)
        {
            card.ManaCost = newManaCost;
        }

        public static void ChangeManaGain(this Card card, int newManaGain)
        {
            card.ManaGain = newManaGain;
        }

        public static void ChangeTowerHPGain(this Card card, int newTowerHPGain)
        {
            card.TowerHPGain = newTowerHPGain;
        }

        public static void ChangeMoveStat(this Card card, string newMoveStat)
        {
            card.MoveStat = newMoveStat;
        }

        public static void ChangeDamageStat(this Card card, int newDamageStat)
        {
            card.DamageStat = newDamageStat;
        }

        public static void ChangeHPStat(this Card card, int newHPStat)
        {
            card.HPStat = newHPStat;
        }

        public static void ChangeManaStat(this Card card, int newManaStat)
        {
            card.ManaStat = newManaStat;
        }

        public static void ChangePlayEffectValue(this Card card, int newPlayEffectValue)
        {
            card.PlayEffectValue = newPlayEffectValue;
        }

        public static void ChangeLostEffectValue(this Card card, int newLostEffectValue)
        {
            card.LostEffectValue = newLostEffectValue;
        }

        public static void ChangeDescription(this Card card, string newDescription)
        {
            card.Description = newDescription;
        }

        public static void ChangeEffect(this Card card, string newEffect)
        {
            card.Effect = newEffect;
        }

        public static void ChangePassive1(this Card card, string newPassive1)
        {
            card.Passive1 = newPassive1;
        }

        public static void ChangePassive2(this Card card, string newPassive2)
        {
            card.Passive2 = newPassive2;
        }

        public static void ChangeCastAndTrapDamage(this Card card, int newCastAndTrapDamage)
        {
            card.CastAndTrapDamage = newCastAndTrapDamage;
        }

        public static void ChangeCardOwner(this Card card, string newCardOwner)
        {
            card.CardOwner = newCardOwner;
        }

        public static void ChangeStall(this Card card, bool newStallValue)
        {
            card.Stall = newStallValue;
        }

        // Play and Lost Effects
        public static void PlayAndLost(this Card card)
        {
            // Implementation...
        }
    }