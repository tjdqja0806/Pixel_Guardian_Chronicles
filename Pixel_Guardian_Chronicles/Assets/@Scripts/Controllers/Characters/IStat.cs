using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStat
{
    #region Properties
    //캐릭터 체력
    public int HP { get; set; }

    //캐릭터 마력
    public int MP { get; set; }
    
    //캐릭터 이동 속도
    public float Speed { get; set; }

    //캐릭터 방어력
    public int DEF { get; set; }

    //캐릭터 공격력
    public float AttackPower { get; set; }

    //캐릭터 공격속도
    public float AttackSpeed { get; set; }

    //공격 회피 확률
    public float DodgeProb { get; set; }

    //크리티컬 확률
    public float CriticalProb { get; set; }
    #endregion
}
