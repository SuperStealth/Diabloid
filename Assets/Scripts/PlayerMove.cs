using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float jumpStrength = 3f;

    private bool _isGrounded;
    private CharacterController _playerController;
    private void Awake()
    {
        _playerController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        var horizontalMoveSpeed = Input.GetAxis("Horizontal");
        var verticalMoveSpeed = Input.GetAxis("Vertical");
        _playerController.Move(new Vector3(horizontalMoveSpeed, 0, verticalMoveSpeed) * Time.deltaTime * speed);
    }
}