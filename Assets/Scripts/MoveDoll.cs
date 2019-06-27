using UnityEngine;

public class MoveDoll : MonoBehaviour {

    public Vector2 right = new Vector2(1, 0);
    public Vector2 left  = new Vector2(-1, 0);

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position = Vector2.MoveTowards(new Vector2(-1,0),left,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector2.MoveTowards(new Vector2(1,0),right,0);
        }

        //var touch = Input.GetTouch(0);
        //if (touch.position.x < Screen.width / 2)
        //{
        //    transform.position = Vector2.MoveTowards(new Vector2(0,0), right, 2);
        //}
        //else if (touch.position.x > Screen.width / 2)
        //{
        //    transform.position = Vector2.MoveTowards(new Vector2(0, 0), right, 2);
        //}

    }

}
