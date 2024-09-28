using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    UnitManager _unitManager;

    int _movementRange;
    private void Awake()
    {
        _unitManager = GetComponent<UnitManager>();
    }
    void HandleMovement() 
    {
        UnitMove();
    }
    void UnitMove()
    {
        _movementRange = _unitManager.UnitCharacter.moveSkill.SkillRange;
    }
}
