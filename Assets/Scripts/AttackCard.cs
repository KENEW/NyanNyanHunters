﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCard : Card
{
    public float percent;
    public int damage;
    public int energyCost;
    public List<int> positions;


    public override void UseCard()
    {
        base.UseCard();
    }
}
