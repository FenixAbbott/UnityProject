using UnityEngine;
public class EntityInstantiate : MonoBehaviour
{
    public Transform playerSpawn;
    public Transform zombieSpawn;
    public Transform player;
    public Transform zombie;
    void Start()
    {
        Instantiate(player, playerSpawn.position, Quaternion.identity);
        Instantiate(zombie, zombieSpawn.position, Quaternion.identity);
    }
}