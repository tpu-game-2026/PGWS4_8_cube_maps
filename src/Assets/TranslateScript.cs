using UnityEngine;

public class TranslateScript : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    [SerializeField] float range = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Mathf.Cos(Time.time / speed) * Time.deltaTime * range);
    }
}
