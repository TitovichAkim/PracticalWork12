using UnityEngine;

public class DoorManager:MonoBehaviour
{
    private bool _playerActive;
    [SerializeField] private GameObject _doText;
    private Animator _anim;

    private void Start ()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update ()
    {
        if(_playerActive && Input.GetKey(KeyCode.F))
        {
            OpenDoor();
        }
    }
    private void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("ball"))
        {
            Debug.Log("ball");
            _doText.SetActive(true);
            _playerActive = true;
        }
    }

    private void OnTriggerExit (Collider other)
    {

        if(other.CompareTag("ball"))
        {
            Debug.Log("ball");
            _doText.SetActive(false);
            _playerActive = false;
        }
    }

    private void OpenDoor ()
    {
        _anim.SetBool("Open", true);
        Invoke("CloseDoor", 3f);
    }

    private void CloseDoor ()
    {
        _anim.SetBool("Open", false);
    }
}
