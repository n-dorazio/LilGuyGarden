using UnityEngine;

public abstract class BaseMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] protected float moveSpeed = 5f;
    
    protected Rigidbody2D rb;
    protected Vector2 movementDirection;
    protected bool canMove = true;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError($"Rigidbody2D component missing on {gameObject.name}");
        }
    }

    protected virtual void FixedUpdate()
    {
        if (!canMove) return;
        Move();
    }

    protected virtual void Move()
    {
        if (movementDirection != Vector2.zero)
        {
            rb.velocity = movementDirection * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    public virtual void SetMovementDirection(Vector2 direction)
    {
        movementDirection = direction.normalized;
    }

    public virtual void SetCanMove(bool value)
    {
        canMove = value;
        if (!canMove)
        {
            rb.velocity = Vector2.zero;
        }
    }

    public virtual void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }
} 