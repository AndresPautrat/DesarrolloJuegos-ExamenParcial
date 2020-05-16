using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [HideInInspector]
    private Rigidbody2D rb;
    Rigidbody2D body;
    float minX;
    float maxX;
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        float heigh = Camera.main.orthographicSize * 2f;
        float width = heigh * Screen.width / Screen.height;
        minX = -width/2;
        maxX = width/2;
    }


    void FixedUpdate()
    {
        if (transform.position.x > maxX)
            transform.position = new Vector3(maxX, transform.position.y, 1);
        else if (transform.position.x < minX)
            transform.position = new Vector3(minX, transform.position.y, 1);
        if (Input.GetKey(KeyCode.A))
        {
            if (gameObject.transform.position.x > minX)
            {
                print(gameObject.transform.position.x);
                print(minX);
                body.velocity = new Vector2(-2, 0);
            }
        }

        else if (Input.GetKey(KeyCode.D))
        {
            if (gameObject.transform.position.x < maxX)
            {
                body.velocity = new Vector2(2, 0);
            }
        }
        else
        {
            body.velocity = new Vector2();
        }
    }
}

