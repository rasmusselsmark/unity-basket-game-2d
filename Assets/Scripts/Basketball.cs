using UnityEngine;

public class Basketball : MonoBehaviour
{
    private Vector3 startOfMovement;
    private Vector2 originalPosition;

    private void Start ()
    {
        originalPosition = transform.position;
    }

    private void OnMouseDown ()
    {
        startOfMovement = Input.mousePosition;
    }

    private void OnMouseUp ()
    {
        Vector2 movement = Input.mousePosition - startOfMovement;
        GetComponent<Rigidbody2D> ().AddForce (movement / 30.0f, ForceMode2D.Impulse);
    }

    private void Reset ()
    {
        GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
        GetComponent<Rigidbody2D> ().angularVelocity = 0.0f;
        transform.position = originalPosition;
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.name == "Reset")
        {
            Reset ();
        }
    }
}
