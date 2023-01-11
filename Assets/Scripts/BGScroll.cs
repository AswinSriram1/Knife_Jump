using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scrollSpeed = 0.3f;
    private MeshRenderer mesh;

    public bool movrRight = false;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        if (!movrRight)
        {
            Vector2 Offset = mesh.sharedMaterial.GetTextureOffset("_MainTex");
            Offset.y += Time.deltaTime * scrollSpeed;
            mesh.sharedMaterial.SetTextureOffset("_MainTex", Offset);
        }
        if (movrRight)
        {
            Vector2 Offset = mesh.sharedMaterial.GetTextureOffset("_MainTex");
            Offset.x += Time.deltaTime * scrollSpeed;
            mesh.sharedMaterial.SetTextureOffset("_MainTex", Offset);
        }   
        
    }
}
