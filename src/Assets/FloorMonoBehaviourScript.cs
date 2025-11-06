using UnityEngine;

public class FloorMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Material material = default!;
    [SerializeField, Range(0.0f, 100.0f)] float Amplitude = 2.0f;
    [SerializeField, Range(0.0f, 1.0f)] float Frequency = 0.1f;
    float Angle = 0.0f;

    void Update()
    {
        Angle += Time.deltaTime;

        float x = Amplitude * Mathf.Sin(2.0f * Mathf.PI * Frequency * Angle);
        material.SetVector("_Probe_Center_Bias", new Vector3(x, 0, 0));
    }
}
