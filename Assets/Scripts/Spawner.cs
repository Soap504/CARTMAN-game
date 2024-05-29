using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float minT = 2f;
    public float maxT = 4f;

    private void Start()
    {
        Spawn();
    }

    private void Spawn(){
        Instantiate(prefab, transform.position, Quaternion.identity);
        Invoke(nameof(Spawn), Random.Range(minT, maxT));
    }
}
