using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishAttack : EnemyAttackBaseClass
{
    public override void Start()
    {
        player = PlayerHP.Instance;
        attackDistance = 7;
        dmg = 1;
    }
    protected override void PlayAttackAnimation()
    {
        
    }
    protected override bool IsPlayerInDistance()
    {
        return Vector3.Distance(transform.position, player.transform.position) < attackDistance ? true : false;
    }

    protected override void Freeze()
    {
        isFrozen = true;
    }

    protected override void UnFreeze()
    {
        isFrozen = false;
    }
}
