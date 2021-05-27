using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialYSpeed = 10f;
    [SerializeField] private float initialXSpeed = 10f;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(initialXSpeed, initialYSpeed);
    }
}
