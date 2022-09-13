using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{

    public float speed;
    public float forceJump;
    public float rotation;

    bool isJumping;

    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movimiento();
        Jump();
    }

    public void Movimiento()
    {
        float movement = Input.GetAxis("Horizontal") * speed;
        rb2d.velocity = new Vector2(movement, 0);

        if (Input.GetKeyDown(KeyCode.R))
        {
            rotation += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(0, 0, rotation);
        }
    }

    public void Jump()
    {
        if (Input.GetButton("Jump") && !isJumping)
        {

            rb2d.AddForce(Vector2.up * forceJump;
            isJumping = true;
        }
    }
}
