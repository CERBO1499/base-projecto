using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = false;
    }
}
