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
        Vector3 direction = new Vector3(0,0,0); 


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //On enlève -1 sur l'axe X de cette position
            direction = new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //On enlève -1 sur l'axe Y de cette position
            direction = new Vector3(0, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = new Vector3(0, -1, 0);
        }

        if (Physics2D.Raycast(transform.position, direction, 1f, LayerMask.GetMask("Wall")))
        {
            //Il y a un mur à 1 mètre ou moins à partir de "vectorPosition", et en direction de "vectorDirection"
        }
        else
        {
            //Si il n'y a pas de mur
            //On donne au transform sa nouvelle position
            //transform.position = transform.position + direction;
            transform.position += direction;
        }

    }
}
