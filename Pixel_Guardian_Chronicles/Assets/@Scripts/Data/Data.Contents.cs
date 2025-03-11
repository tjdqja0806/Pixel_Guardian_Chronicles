using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

namespace Data
{
    #region LevelData
    //[Serializable]
    //public class LevelData
    //{
    //    public int Level;
    //    public int TotalExp;
    //    public int RequiredExp;
    //}

    //[Serializable]
    //public class LevelDataLoader : ILoader<int, LevelData>
    //{
    //    public List<LevelData> levels = new List<LevelData>();
    //    public Dictionary<int, LevelData> MakeDict()
    //    {
    //        Dictionary<int, LevelData> dict = new Dictionary<int, LevelData>();
    //        foreach (LevelData levelData in levels)
    //            dict.Add(levelData.Level, levelData);
    //        return dict;
    //    }
    //}
    #endregion

    #region SkillData
    [Serializable]
    public class SkillData
    {
        public int DataId;
        public string Name;
        public string Description;
        public string PrefabPath;
        public int CoolTime;//ms
    }
    #endregion
}