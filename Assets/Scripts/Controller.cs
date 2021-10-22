using UnityEngine;

public class Controller : MonoBehaviour{
    
    //[Header("animator")]
    //public Animator animator;

    //public float health = 100f;

    private InputManager inputManager;
    //public GameObject head;
    private CapsuleCollider capsuleCollider;
    private CharacterController characterController;
    public GameObject cameraObject;
    //public GameObject spine;

    //public Controller c ;
    public float jumpForce = 200f, movementSpeed = 12,gravityForce = -9.81f;
    [Range(0.1f, 5f)]public float mouseSensitivity = 2f;

    private Vector3 movementVector, gravity;


    private void Start() {
        characterController = GetComponent<CharacterController>();
        inputManager = GetComponent<InputManager>();
        capsuleCollider = GetComponent<CapsuleCollider>();
    }


    private void Update() {

        // movement --START--
        movementVector =  transform.right * inputManager.horizontal + transform.forward * inputManager.vertical;
        characterController.Move(movementVector * movementSpeed * Time.deltaTime);
        if(isGrounded() && gravity.y < 0)
            gravity.y = -2; 

        gravity.y += gravityForce * Time.deltaTime;
        characterController.Move(gravity * Time.deltaTime);
        
        // movement --END--

        // look and clamp camera --START--
        transform.localRotation *= Quaternion.Euler(0f,inputManager.yValue * mouseSensitivity, 0f);
        if(inputManager.xValue > 0 && cameraObject.transform.localRotation.x > -0.7f){
            cameraObject.transform.localRotation *= Quaternion.Euler(-inputManager.xValue * mouseSensitivity, 0f , 0f);
        }
        if(inputManager.xValue < 0 && cameraObject.transform.localRotation.x < 0.7f){
            cameraObject.transform.localRotation *= Quaternion.Euler(-inputManager.xValue * mouseSensitivity, 0f , 0f);
        }
        
        // look and clamp camera --END--
    }

    /*public void jump(){
        if(isGrounded())
            gravity.y = Mathf.Sqrt(jumpForce * -2  * gravityForce);
    }*/

    private bool isGrounded(){
        RaycastHit raycastHit;
        if(Physics.SphereCast(transform.position,characterController.radius * (1.0f - 0),Vector3.down,out raycastHit,
                                ((characterController.height/2f) - characterController.radius) + .1f,Physics.AllLayers,QueryTriggerInteraction.Ignore)){
            return true;
        }
        else return false;
    }

}
