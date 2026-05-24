using System.Collections;
using UnityEngine;

public class ClickPulse : MonoBehaviour
{
    Vector3 originalScale;

    public float pulseSize = 1.1f;
    public float pulseTime = 0.1f;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void Pulse()
    {
        StopAllCoroutines();
        StartCoroutine(PulseAnimation());
    }

    IEnumerator PulseAnimation()
    {
        transform.localScale = originalScale * pulseSize;

        yield return new WaitForSeconds(pulseTime);

        transform.localScale = originalScale;
    }
}
