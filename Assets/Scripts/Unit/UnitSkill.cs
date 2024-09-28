using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Unit/New Skill")]
public class UnitSkill : ScriptableObject
{
    public int UnitSkillID;
    public string UnitSkillName;
    public int SkillRange;
}
