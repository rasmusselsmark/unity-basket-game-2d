using UnityEngine;

public class HoopScore : MonoBehaviour
{
    public GameObject ParticleEffectPrefab;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Basketball")
        {
            var effect = Instantiate(ParticleEffectPrefab, this.transform);
            Destroy(effect, 2);
        }
    }
}
