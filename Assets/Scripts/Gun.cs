using UnityEngine;
using Mirror;

public class Gun : NetworkBehaviour
{
    [SerializeField]
    private float raycastDistance = 10f;
    private Color rayColor = Color.green;
    [SerializeField]
    private Color newColor = Color.red;

    

    public Camera playerCamera;
    public GameObject rayPoint;


private void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        Vector3 cameraForward = Camera.main.transform.forward;
        Vector3 rayOrigin = rayPoint.transform.position;
        Vector3 rayDirection = transform.forward;

        Debug.DrawRay(rayOrigin, cameraForward * raycastDistance, rayColor);

       
        RaycastHit hitInfo;

        if (Physics.Raycast(rayOrigin, cameraForward, out hitInfo, raycastDistance))
        {
            GameObject hitObject = hitInfo.collider.gameObject;

            PlayerHealth playerHealth = hitObject.GetComponent<PlayerHealth>();

            Debug.Log(playerHealth.health);

            playerHealth.health -= 1;

            Debug.Log("Hit object: " + hitObject.name);
          
            Renderer hitObjectRenderer = hitObject.GetComponent<Renderer>();


            // Rendererが存在する場合、Materialの色を変更する
            if (hitObjectRenderer != null)
            {
                hitObjectRenderer.material.color = newColor;
            }
        }
    }
}





