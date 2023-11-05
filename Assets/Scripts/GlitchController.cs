using UnityEngine;
using Kino;

public class GlitchController : MonoBehaviour
{
    [SerializeField] private AnalogGlitch GlitchEffect;
    [SerializeField] private float Intensity;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Vector3 distanceVector = collider.transform.position - transform.position;

            GlitchEffect.colorDrift = Intensity / distanceVector.magnitude;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            GlitchEffect.colorDrift = 0;
        }
    }
}