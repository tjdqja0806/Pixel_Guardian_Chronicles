using Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBase : MonoBehaviour, ISkillStat
{
    #region Properties
    public Define.SkillType SkillType { get; set; }
    public int Level { get; set; }
    public float CoolTime { get; set; }
    public SkillData SkillData { get; set; }

    public GameManager GameManager { get; set; }
    #endregion

    public void SkillLevelUp()
    {
        //Skill Data Reload
    }
}
