using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;

    private Renderer mRenderer;

    public Color touchColor = Color.green;

    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<Renderer>();
        originalColor = mRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            mRenderer.material.color = touchColor;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = false;
            mRenderer.material.color = originalColor;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            mRenderer.material.color = touchColor;
        }
    }
}
