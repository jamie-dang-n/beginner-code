using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddPoisonEffect : UsableItem.UsageEffect
{
    public int PoisonAmount;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(PoisonAmount);
        return false;
    }
}
