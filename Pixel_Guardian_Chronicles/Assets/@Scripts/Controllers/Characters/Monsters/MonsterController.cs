using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : CharacterController
{
    #region Fields
    #endregion

    #region Properties
    #endregion

    #region Methods
    public override bool Init()
    {
        if (base.Init() == false)
        {
            Debug.Log($"{nameof(MonsterController)} / {nameof(Init)} Fail");
            return false;
        }

        return true;
    }

    public override void CharacterAttack()
    {
        throw new System.NotImplementedException();
    }

    public override void CharacterDamaged()
    {
        throw new System.NotImplementedException();
    }

    public override void CharacterDeath()
    {
        throw new System.NotImplementedException();
    }

    public override void CharacterMove()
    {
        throw new System.NotImplementedException();
    }
    #endregion
}
