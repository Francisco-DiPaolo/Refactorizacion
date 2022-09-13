using UnityEngine;


public class Ejercicio01 : MonoBehaviour
{
    public float force;
    public float speed;

    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        force = 100f;
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector2 speed = new Vector2(x, y);

        rb2d.AddForce(speed * force * Time.deltaTime);
    }
}
