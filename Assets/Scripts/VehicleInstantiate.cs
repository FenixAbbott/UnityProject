using UnityEngine;
public class VehicleInstantiate : MonoBehaviour
{
    public Transform lane_0_spawn;
    public Transform lane_1_spawn;
    public Transform car_0;
    public Transform car_1;
    public Transform car_2;
    public Transform car_3;
    private void FixedUpdate()
    {
        System.Random rand0 = new System.Random();
        float token = rand0.Next(1, 4);
        System.Random rand1 = new System.Random();
        float chance = rand1.Next(1, 450);
        System.Random rand2 = new System.Random();
        float lane = rand2.Next(1, 2);
        if (chance == 1f)
        {
            if(token == 1f)
            {
                if(lane == 1f)
                {
                    Instantiate(car_0, lane_0_spawn.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(car_0, lane_1_spawn.position, Quaternion.identity);
                }
            }
            if(token == 2f)
            {
                if (lane == 1f)
                {
                    Instantiate(car_1, lane_0_spawn.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(car_1, lane_1_spawn.position, Quaternion.identity);
                }
            }
            if (token == 3f)
            {
                if (lane == 1f)
                {
                    Instantiate(car_2, lane_0_spawn.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(car_2, lane_1_spawn.position, Quaternion.identity);
                }
            }
            else
            {
                if (lane == 1f)
                {
                    Instantiate(car_3, lane_0_spawn.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(car_3, lane_1_spawn.position, Quaternion.identity);
                }
            }
        }
    }
}