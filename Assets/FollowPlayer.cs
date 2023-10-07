
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float rotationSpeed = 1.0f;
    public float distance = 5.0f;
    public float height = 1.0f;
    private Quaternion initialRotation; // Store the initial rotation

    // Update is called once per frame
    void Start(){
        offset = new Vector3(0, height, -distance);
    }
    void LateUpdate() {
        transform.position = player.position + offset;
        if(Input.GetKey("q")) {
            transform.rotation *= Quaternion.Euler(Vector3.up * rotationSpeed);
        }
        if(Input.GetKey("e")) {
            transform.rotation *= Quaternion.Euler(Vector3.down * rotationSpeed);
        }
    }
} 
