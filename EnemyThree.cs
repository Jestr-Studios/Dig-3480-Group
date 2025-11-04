using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThree : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 2f);
        if (transform.position.x > 10f)
        {
            Destroy(this.gameObject);
        }
    }
}
