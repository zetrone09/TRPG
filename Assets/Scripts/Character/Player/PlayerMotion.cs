using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    PlayerManager playerManager;

    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
    }
    public void HandleAllMovement()
    {
        if (ControllerManager.Instance.isConfirm)
        {
            HandleMovementOnClick();
        }     
    }
    private void HandleMovementOnClick() 
    {
        Ray ray = playerManager.mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit))
        {
            playerManager.agent.SetDestination(hit.point);
        }  
    }

}
