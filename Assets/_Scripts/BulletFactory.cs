using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject regularBullet;
    public GameObject fatBullet;
    public GameObject pulsingBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject createBullet(BulletType  type = BulletType.RANDOM)
    {
        if(type == BulletType.RANDOM)
        {
            var randomBullet = Random.Range(0, 3);
            type = (BulletType)randomBullet;
        }
        

        GameObject tempBullet = null;
        switch(type)
        {
            case BulletType.REGULAR:
                tempBullet = Instantiate(regularBullet);
                tempBullet.GetComponent<BulletController>().damage = 10;
                break;
            case BulletType.FAT:
                tempBullet = Instantiate(fatBullet);
                tempBullet.GetComponent<BulletController>().damage = 20;
                break;
            case BulletType.PULSING:
                tempBullet = Instantiate(pulsingBullet);
                tempBullet.GetComponent<BulletController>().damage = 30;
                break;
        }

        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }

    //public IApplyDamage createBullet(string name)
    //{
    //    GameObject tempBullet;

    //    switch (name)
    //    {
    //        case "Bullet":
    //            //Debug.Log("10 Damage");
    //            tempBullet = Instantiate((IApplyDamage)this.bullet);
    //            break;
    //        case "Fat Bullet":
    //            Debug.Log("20 Damage");
    //            break;
    //        case "Pulsing Bullet":
    //            Debug.Log("40 Damage");
    //            break;
    //    }

    //    return tempBullet;
    //}
}
