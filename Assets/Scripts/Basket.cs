using UnityEngine;

public class Basket : MonoBehaviour
{
    public float speed = 10f;
    public float leftRightLimit = 8f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += horizontal * speed * Time.deltaTime;

        if (pos.x < -leftRightLimit)
            pos.x = -leftRightLimit;
        if (pos.x > leftRightLimit)
            pos.x = leftRightLimit;

        transform.position = pos;
    }
}