using UnityEngine;

public class player_collision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "collision")
        {
            Debug.Log("Desret");
            Destroy(collisionInfo.gameObject); 
        }
    }

}
