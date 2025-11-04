using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 6f);
        if (transform.position.y > 6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
