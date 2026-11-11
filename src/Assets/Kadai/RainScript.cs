using UnityEngine;

public class RainScript : MonoBehaviour
{
    static readonly int PuddleThresholdId = Shader.PropertyToID("_PuddleThreshold");

    [Header("開始時の値（大きいほど水たまりが少ない）")]
    [SerializeField, Range(0.0f, 1.0f)] float startThreshold = 0.9f;

    [Header("最終的な値（小さいほど水たまりが広い）")]
    [SerializeField, Range(0.0f, 1.0f)] float endThreshold = 0.2f;

    [Header("何秒かけて広がるか")]
    [SerializeField] float duration = 10.0f;

    Material material;
    float elapsed = 0.0f;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        elapsed += Time.deltaTime;

        float t = Mathf.Clamp01(elapsed / duration);

        material.SetFloat(PuddleThresholdId, Mathf.Lerp(startThreshold, endThreshold, t));
    }

    void OnDestroy()
    {
        Destroy(material);
    }
}
