using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Util;

public class Define
{
    public static readonly Dictionary<Type, Array> _enumDict = new Dictionary<Type, Array>();

    #region 스테이지관련 데이터
    public static readonly int STAGE_SOULCOUNT = 10;
    public static readonly float STAGE_SOULDROP_RATE = 0.05f;
    public static readonly int BOSS_GEN_TIME = 5; // 웨이브 시작 10초 후 보스 젠
    public static readonly float MAPSIZE_REDUCTION_VALUE = 0.9f; // 웨이브 시작시 줄어드는 맵 크기
    #endregion

    #region 가챠 확률
    public static readonly float[] SUPPORTSKILL_GRADE_PROB = new float[]
    {
        //0.04f,   // Common 확률
        //0.04f,   // Uncommon 확률
        //0.01f,   // Rare 확률
        //0.5f,  // Epic 확률
        //0.45f,  // Legend 확률

        0.4f,   // Common 확률
        0.4f,   // Uncommon 확률
        0.1f,   // Rare 확률
        0.07f,  // Epic 확률
        0.03f,  // Legend 확률

    };

    public static readonly float[] COMMON_GACHA_GRADE_PROB = new float[]
    {
        0,
        0.62f,   // Common 확률
        0.18f,   // Uncommon 확률
        0.15f,   // Rare 확률
        0.05f,  // Epic 확률
    };

    public static readonly float[] ADVENCED_GACHA_GRADE_PROB = new float[]
    {
        0,
        0.55f,   // Common 확률
        0.20f,   // Uncommon 확률
        0.15f,   // Rare 확률
        0.10f,  // Epic 확률
    };

    public static readonly float[] PICKUP_GACHA_GRADE_PROB = new float[]
    {
            0,
        0.55f,   // Common 확률
        0.20f,   // Uncommon 확률
        0.15f,   // Rare 확률
        0.10f,  // Epic 확률
    };

    public static readonly float[] SOUL_SHOP_COST_PROB = new float[]
    {
        0,
        45,   // Common 가격
        55,   // Uncommon 가격
        80,  // Rare 가격
        160,  // Epic 가격
        320,  // Legend 가격
        80,   // 리롤 가격
    };
    #endregion
    
    #region 보석 경험치 획득량
    public const int SMALL_EXP_AMOUNT = 1;
    public const int GREEN_EXP_AMOUNT = 2;
    public const int BLUE_EXP_AMOUNT = 5;
    public const int YELLOW_EXP_AMOUNT = 10;
    #endregion
   
    #region Enum
    public enum DropItemType
    {
        Potion,
        Magnet,
        DropBox,
        Bomb
    }

    //장비아이템에서 인벤토리에 있는지 케릭터 장비 에 있는지

    public enum GachaRarity
    {
        Normal,
        Special,
    }

    public enum EquipmentType
    {
        Weapon,
        Gloves,
        Ring,
        Belt,
        Armor,
        Boots,
    }

    public enum EquipmentGrade
    {
        None,
        Common,
        Uncommon,
        Rare,
        Epic,
        Epic1,
        Epic2,
        Legendary,
        Legendary1,
        Legendary2,
        Legendary3,
        Myth,
        Myth1,
        Myth2,
        Myth3
    }

    public enum EquipmentSortType
    {
        Level,
        Grade,
    }

    public enum MergeEquipmentType
    {
        None,
        ItemCode,
        Grade,
    }

    public enum CreatureState
    {
        Idle,
        Skill,
        Moving,
        OnDamaged,
        Dead
    }

    public enum ObjectType
    {
        Player,
        Monster,
        EliteMonster,
        Boss,
        Projectile,
        Gem,
        Soul,
        Potion,
        DropBox,
        Magnet,
        Bomb
    }

    public enum WaveType
    {
        None,
        Elete,// 엘리트몹 등장
        Boss,
    }

    public enum CreatureType
    {
        None,
        Player,
        Monster,
        RegularMonster,
        Boss
    }

    public enum MissionType
    {
        Complete, // 완료시
        Daily,
        Weekly,
    }

    public enum Scene
    {
        Unknown,
        TitleScene,
        LobbyScene,
        GameScene,
    }

    public enum Sound
    {
        Bgm,
        SubBgm,
        Effect,
        Max,
    }

    public enum UIEvent
    {
        Click,
        Preseed,
        PointerDown,
        PointerUp,
        BeginDrag,
        Drag,
        EndDrag,
    }
    #endregion

}
