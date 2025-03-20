using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class PlayerController : CreatureController
{
    #region Fields
    #endregion

    #region Properties
    public GameManager Game { get; private set; }
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

        Game = Managers.Game;

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
