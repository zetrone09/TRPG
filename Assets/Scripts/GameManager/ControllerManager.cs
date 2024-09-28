using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    public static ControllerManager Instance;

    Controller Controller;

    public Vector2 MovementInput;
    public Vector2 CameraInput;

    [Header("Flags")]
    public bool isConfirm;
    public bool isCameraRotation;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else 
        { 
            Destroy(gameObject); 
        }
        if (Controller == null)
        {
            Controller = new Controller();

            Controller.PlayerMovement.Movement.performed += i => MovementInput = i.ReadValue<Vector2>();
            Controller.PlayerMovement.Movement.canceled += i => MovementInput = Vector2.zero;
            Controller.PlayerMovement.Confirm.performed += i => isConfirm = true;
            Controller.PlayerMovement.Confirm.canceled += i => isConfirm = false;

            Controller.PlayerCamera.Movement.performed += i => CameraInput = i.ReadValue<Vector2>();
            Controller.PlayerCamera.Movement.canceled += i => CameraInput = Vector2.zero;
            Controller.PlayerCamera.Rotation.performed += i => isCameraRotation = true;
            Controller.PlayerCamera.Rotation.canceled += i => isCameraRotation = false;
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void OnEnable()
    {
        Controller.Enable();
    }
    private void OnDisable()
    {
        Controller.Disable();
    }

}
