using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.instance.AddEnergy(1);
    }
}