using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color highlightColor = Color.cyan;

    public void OnMouseOver() {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null) sprite.color = highlightColor;
    }

    public void OnMouseExit() {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null) sprite.color = Color.white;
    }

    public void OnMouseDown() {
        transform.localScale = new Vector3(.11f, .11f, .11f);
    }

    public void OnMouseUp() {
        transform.localScale = new Vector3(.1f, .1f, .1f);
        if (targetObject != null) targetObject.SendMessage(targetMessage);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
