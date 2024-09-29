using System.Runtime.CompilerServices;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Transform respawnPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.position;
        }
            
    }
}
