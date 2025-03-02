using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public abstract class CharacterController : BaseController, IStat
{
    #region Properties
    public int HP { get; set; }
    public int MP { get; set; }
    public float Speed { get; set; }
    public int DEF { get; set; }
    public float AttackPower { get; set; }
    public float AttackSpeec { get; set; }
    public float DodgeProb { get; set; }
    public float CriticalProb { get; set; }

    public CreatureState State { get; set; }
    #endregion

    #region Methods
    public override bool Init()
    {
        if (base.Init() == false)
        {
            Debug.Log($"{nameof(CharacterController)} / {nameof(Init)} Fail");
            return false;
        }

        return true;
    }

    public abstract void CharacterMove();
    public abstract void CharacterAttack();
    public abstract void CharacterDamaged();
    public abstract void CharacterDeath();
    #endregion
}
