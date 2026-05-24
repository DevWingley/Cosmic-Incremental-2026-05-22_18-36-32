using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    ClickPulse pulse;

    public ParticleSystem clickParticles;

    void Start()
    {
        pulse = GetComponent<ClickPulse>();
    }

    private void OnMouseDown()
    {
        GameManager.instance.AddEnergy(1);

        pulse.Pulse();

        clickParticles.Stop();
        clickParticles.Play();
    }
}