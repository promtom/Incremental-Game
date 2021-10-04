using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource sfx_click;
    
    public void OnPointerDown (PointerEventData eventData)
    {
        GameManager.Instance.CollectByTap (eventData.position, transform);
        sfx_click.Play();
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
