using UnityEngine;

public class PickerScript : MonoBehaviour
{
    public float speed = 5f;
    public float limit = 5f;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float newPosition = transform.position.x + horizontalInput * speed * Time.deltaTime;
        newPosition = Mathf.Clamp(newPosition, -limit, limit);
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            gameManager.AddPoit();
            Destroy(collision.gameObject);
        }
    }
}
