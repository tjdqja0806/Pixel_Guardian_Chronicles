using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class PlayerController : CharacterController
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
            Debug.Log($"{nameof(PlayerController)} / {nameof(Init)} Fail");
            return false;
        }

        ObjectType = ObjectType.Player;

        return true;
    }

    public override void CharacterAttack()
    {

    }

    public override void CharacterDamaged()
    {

    }

    public override void CharacterDeath()
    {

    }

    public override void CharacterMove()
    {

    }

    public virtual void DoSignatureMove()
    {

    }
    #endregion
}
