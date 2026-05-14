using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class Throwable : MonoBehaviour
{
    private Rigidbody rigidbody;
    private BoxCollider collider;

    public bool wasThrowed = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
    }

    public float GetColliderHeight()
    {
        return collider.bounds.extents.y;
    }



    //public void Logic(bool throwIt)
    //{
    //    wasThrowed = throwIt;

    //    if (wasThrowed)
    //        rigidbody.useGravity = true;
    //}
}
