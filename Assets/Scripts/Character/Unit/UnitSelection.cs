using Unity.VisualScripting;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    Camera mainCamera;

    GameObject SelectedUnit;

    private void Awake()
    {
        mainCamera = Camera.main;
    }
    private void Update()
    {
        if (ControllerManager.Instance.isConfirm) 
        {
            SelectUnit();
        }
    }
    void SelectUnit()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) 
        {
            if (hit.collider.CompareTag("Unit")) 
            {
                if (SelectedUnit != null)
                {
                    DeSelectUnit();
                }
                SelectedUnit = hit.collider.gameObject;
            }            
        }
    }
    void DeSelectUnit()
    {
        if (SelectedUnit != null) 
        {
            SelectedUnit = null;
        }
    }
}
