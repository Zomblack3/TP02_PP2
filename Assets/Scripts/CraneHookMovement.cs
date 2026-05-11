using UnityEngine;

public class CraneHookMovement : MonoBehaviour
{
    const float maxDistance = 8.0f;

    [SerializeField] private Transform player;

    [SerializeField] private float baseSpeed = 5.0f;
    [SerializeField] private float speed = 5.0f;

    private Vector3 startingPos;

    private bool isGoingRight = true;

    private void Start()
    {
        startingPos = player.position;
    }

    private void Update()
    {
        if (player.position.x > startingPos.x + maxDistance && isGoingRight)
        {
            speed *= -1.0f;

            isGoingRight = false;
        }
        else if (player.position.x < startingPos.x - maxDistance && !isGoingRight)
        {
            speed = baseSpeed;

            isGoingRight = true;
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
