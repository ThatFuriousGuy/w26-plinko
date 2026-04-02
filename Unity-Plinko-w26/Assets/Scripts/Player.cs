using UnityEngine;

public class Player : MonoBehaviour
{
    // random vars
    public float speed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 position = transform.position;
        position.x += x;
        transform.position = new Vector3(transform.position.x + x, position.y, 0);
    }
}
