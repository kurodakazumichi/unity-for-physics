using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scene_001_Uniform { 

  public class Uniform : MonoBehaviour
  {
    private Animator animator;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
      this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += this.velocity * Time.deltaTime;
    }

    private void OnGUI()
    {
      if (GUI.Button(new Rect(10, 10, 100, 20), "等速直線運動")) {
        this.animator.SetBool("Walk", true);
        this.velocity = new Vector3(1, 0, 0);
      }
    }
  }

}