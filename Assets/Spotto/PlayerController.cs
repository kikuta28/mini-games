using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    bool isStop;
    float startY;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStop) return;

        // 毎フレーム回転させる
        transform.Rotate(new Vector3(0, 3, 0));

        // 少しづつ下へ
        transform.Translate(0, -0.01f, 0);

        // 下までいったら上へ戻る
        if (1 > transform.position.y)
        {
            Vector3 pos = transform.position;
            pos.y = startY;
            transform.position = pos;
        }

    }

    // コライダーの当たり判定があった時に呼ばれる
    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;

        if (obj.name.Equals("CollisionDetector"))
        {
            Debug.Log("クリアー！！");
        }
    }

    public void Stop()
    {
        isStop = true;

        // 落下させる
        GetComponent<Rigidbody>().isKinematic = false;
    }

    public void Retry()
    {
        SceneManager.LoadScene("SpottoScene");
    }

}
