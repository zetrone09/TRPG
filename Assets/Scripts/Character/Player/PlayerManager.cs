using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerManager : MonoBehaviour
{
    [HideInInspector] public NavMeshAgent agent;
    [HideInInspector] public Camera mainCamera;

    PlayerMotion PlayerMotion;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        PlayerMotion = GetComponent<PlayerMotion>();
        mainCamera = Camera.main;
    }
    private void Update()
    {
        PlayerMotion.HandleAllMovement();
    }
}
