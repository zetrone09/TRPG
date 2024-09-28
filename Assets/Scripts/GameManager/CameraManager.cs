using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraPivotTransform;

    private Vector2 cameraRotation;
    private void Awake()
    {
        playerTransform = FindAnyObjectByType<PlayerManager>().transform;
    }
    private void Update()
    {
        HandleAllCamera();
    }
    public void HandleAllCamera()
    {
        CameraFollow();
        CameraRotation();
    }
    void CameraFollow()
    {
        transform.LookAt(playerTransform);
    }
    void CameraRotation()
    {
        if (ControllerManager.Instance.isCameraRotation)
        {

        }
    }
}
