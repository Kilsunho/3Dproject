using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 100f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("s");
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}