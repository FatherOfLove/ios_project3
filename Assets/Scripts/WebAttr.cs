//Xianghui Huang

using UnityEngine;

//when the fish touch the web, it will make damage to the fish
public class WebAttr : MonoBehaviour
{
    public float disapperTime;	
    public int damage;	

    void Start()
    {
        Destroy(gameObject, disapperTime);	//after time the web will disspear
    }

	// here use the library ontriggergeer enter2D from the unity
    private void OnTriggerEnter2D(Collider2D collision)
    {
		//when the bullet touch the fish
        if (collision.tag=="Fish")
        {
			//fish damage
            collision.SendMessage("TakeDamage", damage);
        }
    }
}
