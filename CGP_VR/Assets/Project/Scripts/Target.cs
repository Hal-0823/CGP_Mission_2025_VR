using UnityEngine;

public class Target : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TestBall"))
        {
            Destroy(gameObject);
        }
    }
}
