using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class Zone : MonoBehaviour
{
    [Header("Zone Settings")]
    [SerializeField] private Color debugColor = new Color(0, 1, 0, 0.3f);

    private void Awake()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    // the 'contract'. Every child object must define what happens in this method.
    protected abstract void ApplyZoneEffect(Player player);

    // We use a trigger to detect the player
    private void OnTriggerStay2D(Collider2D collision)
    {
        // Ensure that the player is actually in this trigger
        if (collision.TryGetComponent(out Player player))
        {
            ApplyZoneEffect(player);
        }
    }

    // Debug purposes only! Visual aid for the Unity editor so you can see zones.
    private void OnDrawGizmos()
    {
        Gizmos.color = debugColor;
        BoxCollider2D box = GetComponent<BoxCollider2D>();

        if (box != null)
        {
            Gizmos.DrawCube(transform.position + (Vector3)box.offset, box.size);
        }
    }
}
