using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public float speed = 5f;


    void Update()
    {
        

    }

    void FixedUpdate()
    {
        float mvoex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(mvoex, 0, movey) * speed;
        transform.Translate(movement, Space.World);
    }
}
