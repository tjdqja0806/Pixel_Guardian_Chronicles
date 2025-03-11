using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public abstract class PassiveSkill : SkillBase
{
    #region Fields
    protected Timer _skillTimer;
    #endregion

    #region Properties
    #endregion

    #region Method
    private void Start()
    {
        _skillTimer = new Timer(UsePassiveSkill);

        _skillTimer.Change(0, SkillData.CoolTime);
    }

    public abstract void UsePassiveSkill(object sender);
    #endregion
}
