using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private void FixedUpdate()
    {
        transform.parent.Translate(new Vector3((-1) * speed * Time.fixedDeltaTime, 0f, 0f));
    }
}