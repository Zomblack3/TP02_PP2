using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Throwable throwablePrefab;

    [SerializeField] private Transform crane;
    [SerializeField] private Transform baseThrowable;

    private Vector3 craneNewPos;

    const float distance = 4.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Throwable throwableObject = Instantiate(throwablePrefab, baseThrowable.position, baseThrowable.rotation);

            float throwableObjectHeight = throwableObject.GetColliderHeight() * 2;

            //throwableObject.Logic(true);

            craneNewPos = crane.position;

            craneNewPos.y = crane.transform.position.y + throwableObjectHeight;

            crane.transform.position = craneNewPos;
        }
    }
}
