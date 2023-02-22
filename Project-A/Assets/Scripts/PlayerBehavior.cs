using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Animator PlayerAnimator;
    public GameObject Player;
    public GameObject Camera;
    public float PlayerSpeed;
    public float CameraDistanceX;
    public float CameraDistanceY;
    public float CameraDistanceZ;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //Player 좌표이동
        PlayerMove(Player);

        //Player 이동 애니메이터
        PlayerAnimatorController(PlayerAnimator);

        //Camera 좌표이동
        CameraMove(Camera, Player);

    }

    //Player 좌표이동
    public void PlayerMove(GameObject Player)
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.A))
            {
                Player.transform.position += new Vector3(0, 0, PlayerSpeed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Player.transform.position += new Vector3(0, 0, -PlayerSpeed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Player.transform.position += new Vector3(-PlayerSpeed, 0, 0);
            }
            Player.transform.position += new Vector3(PlayerSpeed, 0, 0);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            Player.transform.position += new Vector3(-PlayerSpeed, 0, 0);
            if (Input.GetKey(KeyCode.A))
            {
                Player.transform.position += new Vector3(0, 0, PlayerSpeed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Player.transform.position += new Vector3(0, 0, -PlayerSpeed);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                Player.transform.position += new Vector3(PlayerSpeed, 0, 0);
            }
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Player.transform.position += new Vector3(0, 0, PlayerSpeed);
            if (Input.GetKey(KeyCode.W))
            {
                Player.transform.position += new Vector3(PlayerSpeed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Player.transform.position += new Vector3(-PlayerSpeed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Player.transform.position += new Vector3(0, 0, -PlayerSpeed);
            }

        }

        else if (Input.GetKey(KeyCode.D))
        {
            Player.transform.position += new Vector3(0, 0, -PlayerSpeed);
            if (Input.GetKey(KeyCode.W))
            {
                Player.transform.position += new Vector3(PlayerSpeed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Player.transform.position += new Vector3(-PlayerSpeed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Player.transform.position += new Vector3(0, 0, PlayerSpeed);
            }

        }



        //if (Input.GetKey(KeyCode.A))
        //{
        //    Player.transform.position += new Vector3(0, 0, PlayerSpeed);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Player.transform.position += new Vector3(0, 0, -PlayerSpeed);
        //}

    }

    //Player 이동 애니메이터
    public void PlayerAnimatorController(Animator PlayerAnimator)
    {
        //전진 후진
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            PlayerAnimator.SetBool("GetKeyMoveF", false);
            PlayerAnimator.SetBool("GetKeyMoveB", false);
            PlayerAnimator.SetBool("GetKeyMoveL", false);
            PlayerAnimator.SetBool("GetKeyMoveR", false);

        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            PlayerAnimator.SetBool("GetKeyMoveF", false);
            PlayerAnimator.SetBool("GetKeyMoveB", false);
            PlayerAnimator.SetBool("GetKeyMoveL", false);
            PlayerAnimator.SetBool("GetKeyMoveR", false);

        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            PlayerAnimator.SetBool("GetKeyMoveF", false);
            PlayerAnimator.SetBool("GetKeyMoveB", false);
            PlayerAnimator.SetBool("GetKeyMoveL", false);
            PlayerAnimator.SetBool("GetKeyMoveR", false);

        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            PlayerAnimator.SetBool("GetKeyMoveF", false);
            PlayerAnimator.SetBool("GetKeyMoveB", false);
            PlayerAnimator.SetBool("GetKeyMoveL", false);
            PlayerAnimator.SetBool("GetKeyMoveR", false);
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            PlayerAnimator.SetBool("GetKeyMoveF", false);
            PlayerAnimator.SetBool("GetKeyMoveB", false);
            PlayerAnimator.SetBool("GetKeyMoveL", false);
            PlayerAnimator.SetBool("GetKeyMoveR", false);
        }


        else if (Input.GetKey(KeyCode.W))
        {
            PlayerAnimator.SetBool("GetKeyMoveF", true);
            if (Input.GetKey(KeyCode.A))
            {
                PlayerAnimator.SetBool("GetKeyMoveL", true);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                PlayerAnimator.SetBool("GetKeyMoveR", true);
            }
            else
            {
                PlayerAnimator.SetBool("GetKeyMoveL", false);
                PlayerAnimator.SetBool("GetKeyMoveR", false);

            }


        }
        else if (Input.GetKey(KeyCode.S))
        {
            PlayerAnimator.SetBool("GetKeyMoveB", true);
        }
        else
        {
            PlayerAnimator.SetBool("GetKeyMoveF", false);
            PlayerAnimator.SetBool("GetKeyMoveB", false);
            PlayerAnimator.SetBool("GetKeyMoveL", false);
            PlayerAnimator.SetBool("GetKeyMoveR", false);
        }

        ////전진 후진 동시
        //if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        //{
        //    PlayerAnimator.SetBool("GetKeyMoveF&B", true);
        //}


    }

    //Camera 좌표이동
    public void CameraMove(GameObject Camera, GameObject Player)
    {
        Camera.transform.position = new Vector3(Player.transform.position.x + CameraDistanceX, Player.transform.position.y + CameraDistanceY, Player.transform.position.z + CameraDistanceZ);
    }

}
