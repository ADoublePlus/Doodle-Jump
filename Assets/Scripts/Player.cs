using UnityEngine;

namespace DJ
{
    [RequireComponent(typeof(Rigidbody2D))]

    public class Player : MonoBehaviour
    {
        Rigidbody2D rigid;

        public float movementSpeed = 10f;

        float movement = 0f;

        // Use this for initialization
        void Start ()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update ()
        {
            movement = Input.GetAxis("Horizontal") * movementSpeed;
        }

        void FixedUpdate ()
        {
            Vector2 velocity = rigid.velocity;

            velocity.x = movement;

            rigid.velocity = velocity;
        }
    }
}