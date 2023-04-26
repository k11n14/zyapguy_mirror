using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    //レイの届く距離
    public float raycastDistance = 10f;

    //レイの色
    public Color rayColor = Color.green;


    void Update()
    {
        // レイを発射する位置（原点）
        Vector3 rayOrigin = transform.position;
        //レイの方向
        Vector3 rayDirection = transform.forward;

        // レイを可視化する（レイの原点、レイの向き＊レイの距離、、レイの色）；
        Debug.DrawRay(rayOrigin, rayDirection * raycastDistance, rayColor);


        //RaycastHitは、Physics.Raycastで使用される、レイが当たったオブジェクトの情報を格納するための構造体
        RaycastHit hitInfo;
        //collider: 当たったオブジェクトのコライダー
        //transform: 当たったオブジェクトのTransformコンポーネント
        //point: 当たった地点のワールド座標
        //normal: 当たった面の法線ベクトル
        //distance: レイの起点から当たった地点までの距離
        //outキーワードを使用することで、Physics.Raycastから値を返す。

        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo, raycastDistance))
        {
            // 交差したオブジェクトが存在する場合の処理
            Debug.Log("Hit object: " + hitInfo.collider.gameObject.name);
        }

        //Physics.Raycastは、指定された位置と方向からレイを発射し、最初に当たったコライダーを取得するためのUnityの関数
        //public static bool Raycast(
        //Vector3 origin,
        //Vector3 direction,
        //out RaycastHit hitInfo,
        //float maxDistance = Mathf.Infinity,
        //int layerMask = DefaultRaycastLayers,
        //QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);

        //origin: 発射するレイの起点となる位置を表すVector3構造体
        //direction: レイの向きを表すVector3構造体
        //out hitInfo: レイが当たったオブジェクトの情報を格納するRaycastHit構造体
        //maxDistance: レイの最大長（省略可能でデフォルトは無限大）
        //layerMask: レイが当たるレイヤーマスク（省略可能でデフォルトはデフォルトのレイキャストレイヤー）
        //queryTriggerInteraction: トリガーを判定するかどうか（省略可能でデフォルトはQueryTriggerInteraction.UseGlobal）



    }
}
