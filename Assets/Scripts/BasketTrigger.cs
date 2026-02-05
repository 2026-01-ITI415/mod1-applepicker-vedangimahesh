using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // If an apple enters the basket trigger, delete it
        if (other.gameObject.name.Contains("Apple"))
        {
            Destroy(other.gameObject);
        }
    }
}