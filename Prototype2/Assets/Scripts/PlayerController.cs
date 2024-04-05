

sing UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Horizontal input
    private float horizontalInput;
    //Player Speed
    [Serializedfield] float speed = 10.0f;
    //x Axis Limit
    [Serializedfield] float xRange = 10.0f;
    //Projectile prefab
    [Serializedfield] private GameObject projectilePrefab;
    private const string horizontal = "Horizontal"
    // Update is called once per frame
    void Update()
    {
        //Get the horizontal input
        horizontalInput = Input.GetAxis(horizontal);
        //Move the player
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));

        //limit Movement
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, 0.0f, 0.0f);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, 0.0f, 0.0f);
        }

        //Shoot food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
