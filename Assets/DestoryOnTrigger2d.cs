using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnTrigger2d : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    [SerializeField] TMPro.TextMeshPro msg;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {

            Destroy(this.gameObject);
            Destroy(other.gameObject);
            msg.SetText("Game Over!");

        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
