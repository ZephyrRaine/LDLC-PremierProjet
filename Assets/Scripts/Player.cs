using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //On récupère la position dans le monde
        Vector3 positionVector = transform.position;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //On enlève -1 sur l'axe X de cette position
            positionVector.x = positionVector.x - 1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            positionVector.x = positionVector.x + 1;
        }
        //On donne au transform sa nouvelle position
        transform.position = positionVector;
    }
}
