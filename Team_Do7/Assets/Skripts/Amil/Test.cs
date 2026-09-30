using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 5f;
    public KeyCode key;
    private void Update()
    {
        if (Input.GetKey(key))
        {
            this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);


        }
    }





}
