using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    public float speed = 360f;
    
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
