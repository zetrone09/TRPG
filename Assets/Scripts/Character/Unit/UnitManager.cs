using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public UnitCharacter UnitCharacter;
    UnitMovement UnitMovement;
    private void Awake()
    {
        gameObject.name = UnitCharacter.UnitName;
    }
    private void Update()
    {
        
    }
}
