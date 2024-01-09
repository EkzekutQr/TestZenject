using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * _speed;
        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * _speed;
    }
}
