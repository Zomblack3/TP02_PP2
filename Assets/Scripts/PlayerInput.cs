using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Throwable throwablePrefab;

    [SerializeField] private Transform crane;
    [SerializeField] private Transform baseThrowable;

    private const int scorePerObject = 25;

    private Vector3 craneNewPos;

    private Throwable throwableObject = null;
    private Throwable lastThrowedObject = null;

    private bool hasSumScore = false;
    private bool hasThrowedObject = false;

    public int score = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !hasThrowedObject)
        {
            if (!throwableObject)
                lastThrowedObject = throwableObject;

            throwableObject = Instantiate(throwablePrefab, baseThrowable.position, baseThrowable.rotation);

            float throwableObjectHeight = throwableObject.GetColliderHeight() * 2;

            craneNewPos = crane.position;

            craneNewPos.y = crane.transform.position.y + throwableObjectHeight;

            crane.transform.position = craneNewPos;

            hasSumScore = false;

            hasThrowedObject = true;

            //if (lastThrowedObject != null)
            //    Destroy(lastThrowedObject);
        }

        if (throwableObject)
        {
            if (throwableObject.hasCollide && !hasSumScore)
            {
                score += scorePerObject;

                hasSumScore = true;

                hasThrowedObject = false;
            }
        }
    }
}
