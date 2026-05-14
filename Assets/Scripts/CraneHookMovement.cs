using UnityEngine;

public class CraneHookMovement : MonoBehaviour
{
    const float maxDistance = 10.0f;

    [SerializeField] private Transform hook;

    [SerializeField] private float baseSpeed = 5.0f;
    [SerializeField] private float speed = 5.0f;

    private Vector3 startingPos;

    private bool isGoingRight = true;

    private void Start()
    {
        startingPos = hook.position;
    }

    private void Update()
    {
        if (hook.position.x > startingPos.x + maxDistance && isGoingRight)
        {
            speed *= -1.0f;

            isGoingRight = false;
        }
        else if (hook.position.x < startingPos.x - maxDistance && !isGoingRight)
        {
            speed = baseSpeed;

            isGoingRight = true;
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
