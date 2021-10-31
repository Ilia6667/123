
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventDada)
    {
        Application.LoadLevel(1);
    }


    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
