using UnityEngine;

public class AppleDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Apple"))
        {
            Destroy(other.gameObject);
            Debug.Log("Apple missed!");
        }
    }
}