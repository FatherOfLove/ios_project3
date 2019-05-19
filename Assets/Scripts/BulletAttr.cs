//Xianghui Huang

﻿using UnityEngine;

/**
 this is the effect of the bullet,
 * */
public class BulletAttr : MonoBehaviour
{
    public int speed;
    public int damage;
    public GameObject webPrefab;

	//put the board to the bullet, use the collider box from the Unity
    private void OnTriggerEnter2D(Collider2D collision)
    {
		//when the bullet touch with fish, the bullet destory
        if (collision.tag == "Border")
        {
            Destroy(gameObject);
        }

		//bullet touch the fish, create the web then destory bullet it self
        if (collision.tag == "Fish")
        {
            GameObject web = Instantiate(webPrefab);
            web.transform.SetParent(gameObject.transform.parent, false);
            web.transform.position = gameObject.transform.position;
            web.GetComponent<WebAttr>().damage = damage;
            Destroy(gameObject);
        }
    }
}
