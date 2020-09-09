using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    Vector2 m_velo;
    Rigidbody2D myRigid;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void Move(Vector2 velo)
    {
        m_velo = velo;
    }

    public void FixedUpdate()
    {
        myRigid.MovePosition(myRigid.position + m_velo * Time.fixedDeltaTime);
        //myRigid.AddForce(m_velo);

        
    }
    
}
