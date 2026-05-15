using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class Throwable : MonoBehaviour
{
    private Rigidbody rigidbody;
    private BoxCollider collider;

    public static int towerSize = 0;

    public bool hasCollide = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rigidbody.isKinematic = true;
        
        if (!hasCollide)
            towerSize++;

        hasCollide = true;
    }

    public float GetColliderHeight()
    {
        return collider.bounds.extents.y;
    }
}
