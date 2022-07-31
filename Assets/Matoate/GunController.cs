using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject prefabBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // マウスが離された時
        if (Input.GetMouseButtonUp(0))
        {
            // 離されたマウスの場所へレイ（光線）を飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // ベクトルを取得（ワールド座標）
            Vector3 dir = ray.direction;

            GameObject bullet = Instantiate(prefabBullet);

            // 発射する
            bullet.transform.position = transform.position;
            bullet.GetComponent<BulletController>().Shoot(dir.normalized * 3000);
        }
    }
}
