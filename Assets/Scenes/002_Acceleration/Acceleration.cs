using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scene_002_Acceleration {

  public class Acceleration : MonoBehaviour
  {
    private Animator animator;

    // 速度
    private Vector3 velocity   = Vector3.zero;

    // 加速度
    private float acceleration = 0;

    // Start is called before the first frame update
    void Start()
    {
      this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      // 加速度運動
      this.velocity.x += acceleration * Time.deltaTime;

      if (0 <= this.velocity.x) {
        this.transform.position += this.velocity * Time.deltaTime;
        this.animator.SetFloat("Speed", Mathf.Max(0, this.velocity.magnitude * 0.5f));
      } else {
        this.animator.SetBool("Walk", false);
      }
    }

    private void OnGUI()
    {
      if (GUI.Button(new Rect(10, 10, 100, 20), "加速度運動 加速")) {
        this.transform.position = new Vector3(-5, 0, -5);
        this.acceleration = 1f;
        this.velocity = Vector3.zero;
        this.animator.SetBool("Walk", true);
      }

      if (GUI.Button(new Rect(10, 40, 100, 20), "加速度運土 減速")) {
        this.transform.position = new Vector3(-5, 0, -5);
        this.acceleration = -1f;
        this.velocity = new Vector3(5, 0, 0);
        this.animator.SetBool("Walk", true);
      }
    }
  }

}