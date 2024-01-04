using ThoughtformTCG.GameModels;
public class CardEffects
{
    public static void ChangeName(Card card, string newName)
    {
        card.Name = newName;
    }

    public static void ChangeAffinity(Card card, string newAffinity)
    {
        card.Affinity = newAffinity;
    }

    public static void ChangeThoughtformMoveStat(Card card, string newThoughtformMoveStat)
    {
        card.ThoughtformMoveStat = newThoughtformMoveStat;
    }

    public static void ChangeAttack(Card card, string newAttack)
    {
        card.Attack = newAttack;
    }

    public static void ChangeLevel(Card card, int newLevel)
    {
        card.Level = newLevel;
    }

    public static void ChangeType(Card card, string newType)
    {
        card.Type = newType;
    }

    public static void ChangeRange(Card card, int newRange)
    {
        card.Range = newRange;
    }

    public static void ChangePlayEffect(Card card, string newPlayEffect)
    {
        card.PlayEffect = newPlayEffect;
    }

    public static void ChangeLostEffect(Card card, string newLostEffect)
    {
        card.LostEffect = newLostEffect;
    }

    public static void ChangeLostPile(Card card, bool newLostPile)
    {
        card.ToLostPile = newLostPile;
    }

    public static void ChangeManaCost(Card card, int newManaCost)
    {
        card.ManaCost = newManaCost;
    }

    public static void ChangeManaGain(Card card, int newManaGain)
    {
        card.ManaGain = newManaGain;
    }

    public static void ChangeTowerHPGain(Card card, int newTowerHPGain)
    {
        card.TowerHPGain = newTowerHPGain;
    }

    public static void ChangeMoveStat(Card card, string newMoveStat)
    {
        card.MoveStat = newMoveStat;
    }

    public static void ChangeDamageStat(Card card, int newDamageStat)
    {
        card.DamageStat = newDamageStat;
    }

    public static void ChangeHPStat(Card card, int newHPStat)
    {
        card.HPStat = newHPStat;
    }

    public static void ChangeManaStat(Card card, int newManaStat)
    {
        card.ManaStat = newManaStat;
    }

    public static void ChangePlayEffectValue(Card card, int newPlayEffectValue)
    {
        card.PlayEffectValue = newPlayEffectValue;
    }

    public static void ChangeLostEffectValue(Card card, int newLostEffectValue)
    {
        card.LostEffectValue = newLostEffectValue;
    }

    public static void ChangeDescription(Card card, string newDescription)
    {
        card.Description = newDescription;
    }

    public static void ChangeEffect(Card card, string newEffect)
    {
        card.Effect = newEffect;
    }

    public static void ChangePassive1(Card card, string newPassive1)
    {
        card.Passive1 = newPassive1;
    }

    public static void ChangePassive2(Card card, string newPassive2)
    {
        card.Passive2 = newPassive2;
    }

    public static void ChangeCastAndTrapDamage(Card card, int newCastAndTrapDamage)
    {
        card.CastAndTrapDamage = newCastAndTrapDamage;
    }

    public static void ChangeCardOwner(Card card, string newCardOwner)
    {
        card.CardOwner = newCardOwner;
    }

    public static void ChangeStall(Card card, bool newStallValue)
    {
        card.Stall = newStallValue;
    }
    // Play and Lost Effects
    public static void PlayAndLost(Card card)
    {
        
    }
}
