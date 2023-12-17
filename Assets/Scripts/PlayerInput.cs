using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Vector3 movement;

    private void Awake ()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector3(-horizontal, 0, -vertical);
    }

    private void FixedUpdate ()
    {
        playerMovement.MoveCharacter(movement);
    }
}
