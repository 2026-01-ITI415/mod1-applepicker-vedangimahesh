using UnityEngine;

public class Apple : MonoBehaviour
{
    public float bottomY = -20f;

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(gameObject);
        }
    }
}