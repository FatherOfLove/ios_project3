//Xianghui Huang

using UnityEngine;

// the way to get the gold and the music of gettting the gold
public class GoldCollect : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gold")
        {
            AudioManager.Instance.PlayEffectSound(AudioManager.Instance.goldClip);
            Destroy(collision.gameObject);
        }
    }
}
