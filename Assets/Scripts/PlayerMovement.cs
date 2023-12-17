using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float speed = 2.0f;
    private void Awake ()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    public void MoveCharacter (Vector3 movement)
    {
        playerRigidbody.AddForce(movement * speed);
    }
}
