using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    string[] Colors = { "Blue", "Green", "Yellow", "Pink", "Purple", "White", "Black", "Silver" };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Spawn(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        

    

    private void Spawn(int BatchNum)
    {
         
    }

  /* public abstract class AbstractFactory
   {
        public abstract string ChooseColor();
        public abstract int RandomSpeed();

   }

    public class RacerFactory: AbstractFactory 
    {
        public override string ChooseColor()
        {
            return new GetColor();
        }

        public override int RandomSpeed()
        {
            return new GetColor();
        }
    }

   class GetColor: RacerFactory
    {
        int randomNumber = Random.Range(0,8);
         
    }*/

   
}
