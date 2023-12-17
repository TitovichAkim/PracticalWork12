using UnityEngine;

public class CameraMovement:MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;
    private Transform _cameraTransform;

    private void Awake ()
    {
        _cameraTransform = this.gameObject.transform;
        _cameraTransform.position = _ballTransform.position;
    }
    private void Update ()
    {
        Vector3 newPos = new Vector3(_ballTransform.position.x, 6f,  _ballTransform.position.z + 5);
        _cameraTransform.position = newPos;
    }
}