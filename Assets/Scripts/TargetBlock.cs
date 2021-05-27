using UnityEngine;

public class TargetBlock : MonoBehaviour
{
    [SerializeField] private Material[] materials = null;
    [SerializeField] private int hitCount = 0;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        checkToDestroy();
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidBody = other.gameObject.GetComponent<Rigidbody>();

        rigidBody.velocity = new Vector3(rigidBody.velocity.x, -rigidBody.velocity.y);
        hitCount--;

        if (checkToDestroy())
        {
            // Object Was Destroyed
        }

    }

    private bool checkToDestroy()
    {
        if (!(1 <= hitCount && hitCount <= 3))
        {
            Destroy(gameObject);
            return true;
        }
        rend.sharedMaterial = materials[hitCount - 1];
        return false;
    }
}
