using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;
    public float turnSmoothTime;
    public float turnSmoothVelocity = 0.1f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.right * horizontal + transform.forward * vertical;
        GetComponent<Rigidbody>().velocity = new Vector3(direction.x * speed * Time.deltaTime * 100, GetComponent<Rigidbody>().velocity.y, direction.z * speed * Time.deltaTime * 100);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;

            if (groundPlane.Raycast(cameraRay, out rayLength))
            {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength);
                Debug.DrawLine(cameraRay.origin, pointToLook, Color.cyan);

                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
            }
        }
    }
}