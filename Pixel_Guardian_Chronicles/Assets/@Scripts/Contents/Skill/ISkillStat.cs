using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISkillStat
{
    public Define.SkillType SkillType { get; set; }
    public int Level { get; set; }

    public float CoolTime { get; set; }

    public Data.SkillData SkillData { get; set; }
}
