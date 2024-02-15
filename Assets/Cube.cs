using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
  public Rigidbody2D myRigidBody;
  public float movementSpeed;

  public float screenEdge;

  int numberOfTimes = 5;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      myRigidBody.velocity = new Vector2(0f, movementSpeed);
    }
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      myRigidBody.velocity = new Vector2(-movementSpeed, 0f);
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      myRigidBody.velocity = new Vector2(movementSpeed, 0f);
    }

    float myPositionX = myRigidBody.position.x;
    if (myPositionX > screenEdge || myPositionX < -screenEdge)
    {
      Debug.LogWarning($"Cube position out of bonds at position {myPositionX}");
    }
  }
}
