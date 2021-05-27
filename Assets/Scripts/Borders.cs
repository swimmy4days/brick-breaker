using UnityEngine;

public class Borders : MonoBehaviour
{
    [SerializeField] private bool isLowerBorder = false;


    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidBody = other.GetComponent<Rigidbody>();
        if (isLowerBorder)
            Destroy(other.gameObject);
        else if (Mathf.Abs(other.gameObject.transform.position.x) >= 13.7)
            rigidBody.velocity = new Vector3(-rigidBody.velocity.x, rigidBody.velocity.y);
        else
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, -rigidBody.velocity.y);

    }
}
