using UnityEngine;

[CreateAssetMenu(menuName = "Unit/New Unit")]
public class UnitCharacter : ScriptableObject
{
    public int UnitID;
    public string UnitName;

    public UnitSkill moveSkill;
}
