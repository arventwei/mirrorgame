using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{

    public float speed = 0.5f;

    public float minimumX =-20;
    public float maximumX =20;
    public float  minimumY  =-20;
    public float maximumY =20;

    Vector3 newPos = new Vector3();
    Transform localTransform;
    void HandleMovement()
	{
		if (isLocalPlayer)
		{
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
           
          //  if(moveHorizontal !=0  || moveVertical > 0)
			//{
                newPos.x += moveHorizontal * speed;
                newPos.z += moveVertical * speed;
          //  Debug.Log($"{moveVertical}-{moveHorizontal} -{newPos}");
                newPos.x = Mathf.Clamp(newPos.x, minimumX, maximumX);
                newPos.z = Mathf.Clamp(newPos.z, minimumY, maximumY);
                localTransform.position = newPos;
         //   }
          
            
        }


	}
    // Start is called before the first frame update
    void Start()
    {
        newPos = transform.position;
        localTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
}
