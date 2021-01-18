using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes_003_ThrowingUp
{
  public class ThrowingUp : MonoBehaviour
  {
    private Animator animator;
    private Vector3 acceleration = new Vector3(0, -9.8f, 0);
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
      this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      this.velocity += this.acceleration * Time.deltaTime;

      transform.position += this.velocity * Time.deltaTime;

      if (transform.position.y <= 0) {
        transform.position = new Vector3(0, 0, -7f);
        this.animator.SetBool("Jump", false);
      }
    }

    private void OnGUI()
    {
      if(GUI.Button(new Rect(10, 10, 100, 20), "Jump")) {
        this.velocity = new Vector3(0, 4.9f, 0);
        this.animator.SetBool("Jump", true);
      }
    }
  }
}
