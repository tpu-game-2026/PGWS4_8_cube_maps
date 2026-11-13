using UnityEngine;

public class ReflectionProbeScript : MonoBehaviour
{
    [SerializeField] Material material = default!;
    ReflectionProbe probe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        probe = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        Texture cubemap = probe.texture;

        if (cubemap == null) return;

        material.SetTexture("_ReflectionCubemap", cubemap);
    }
}
