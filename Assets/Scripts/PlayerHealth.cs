using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerHealth : NetworkBehaviour
{
    [SyncVar]
    public int health = 100;

 



    private void Update()
    {
        if (health < 0)
        {
            // スクリプトがアタッチされているゲームオブジェクトのRendererコンポーネントを取得する
            Renderer renderer = GetComponent<Renderer>();

            // Rendererコンポーネントからマテリアルを取得する
            Material material = renderer.material;

            material.color = Color.blue;

        }
    }

}
