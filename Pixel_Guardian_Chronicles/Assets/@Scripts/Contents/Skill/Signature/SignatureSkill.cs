using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public abstract class SignatureSkill : SkillBase
{
    #region Fields
    protected bool _isUsable;
    #endregion

    #region Mathods

    public IEnumerable CoolTimeTimer()
    {
        yield return new WaitForSeconds(SkillData.CoolTime);
        _isUsable = true;
    }

    public void UseSignatureSkill()
    {

    }
    #endregion
}
