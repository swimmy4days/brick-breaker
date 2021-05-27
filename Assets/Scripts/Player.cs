using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject targets;
    [SerializeField] private GameObject balls;
    [SerializeField] private Text textScore;
    private float horizontalAxis;
    private Rigidbody rigidBodyComp;

    private int startingNumberOfTargets = 0;

    void Start()
    {
        rigidBodyComp = GetComponent<Rigidbody>();
        startingNumberOfTargets = targets.GetComponentsInChildren<TargetBlock>().Length;
    }

    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");

        if (balls.GetComponentsInChildren<Ball>().Length == 0) Debug.Log("Lost");
        if (targets.GetComponentsInChildren<TargetBlock>().Length == 0) Debug.Log("Won");
        textScore.text = "Score: " + (startingNumberOfTargets - targets.GetComponentsInChildren<TargetBlock>().Length).ToString();

    }

    private void FixedUpdate()
    {
        rigidBodyComp.velocity = new Vector3(horizontalAxis * 8f, 0, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidBody = other.GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, -rigidBody.velocity.y);
    }
}
