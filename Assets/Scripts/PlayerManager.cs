using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    public PlatformManager pManager;
    //speed variables
    public float speed;
    public float speedMultiplier;
    public float speedIncreaseMilestone;

    //jump variables
    public float jump;
    public float jumpTime;

    //bools to test if grounded and is running
    public bool isGrounded;
    public bool isRunning;

    //game object to hold the groundcheck object
    public GameObject groundCheck;

    //Ridigbody Component variable
    private Rigidbody myRB;

    //private speed variables
    private float speedMilestoneCount;

    //private jump variables
    private float jumpCounter;

    private bool stopJump;

	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 1f;
        stopJump = true;

        pManager = FindObjectOfType<PlatformManager>();

        myRB = GetComponent<Rigidbody>();

        isRunning = false;

        jumpCounter = jumpTime;

        speedMilestoneCount = speedIncreaseMilestone;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //make linecast from player to the groundCheck object 
        isGrounded = Physics.Linecast(transform.position, groundCheck.transform.position);

        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier;

            speed = speed * speedMultiplier;

            if(speed < 10)
            {
                pManager.ChangeMinMax10();
            }
            else if (speed < 15)
            {
                pManager.ChangeMinMax15();
            }
            else if(speed < 20)
            {
                pManager.ChangeMinMax20();
            }
        }

		#if UNITY_IOS

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && isGrounded)
		{
			myRB.velocity = new Vector3(myRB.velocity.x, jump, myRB.velocity.z);
			stopJump = false;
		}

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary && !stopJump)
		{
			if(jumpCounter > 0)
			{
				myRB.velocity = new Vector3(myRB.velocity.x, jump, myRB.velocity.z);
				jumpCounter -= Time.deltaTime;
			}
		}

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
		{
			jumpCounter = 0f;
			stopJump = true;
		}
		#endif

    }

    void FixedUpdate()
    {
        //if the player is falling then wait to move the player until they touch the ground on start of game
        if(!isRunning)
        {
            if(isGrounded)
            {
                isRunning = true;
            }
        }
        else
        {
            myRB.velocity = new Vector3(speed, myRB.velocity.y, myRB.velocity.z);

            //PC / editor mode
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded )
            {
                Jump();
                stopJump = false;
            }

            if (Input.GetKey(KeyCode.Space) && !stopJump)
            {
                if (jumpCounter > 0)
                {
                    Jump();
                    jumpCounter -= Time.deltaTime;
                }
            }

            if(Input.GetKeyUp(KeyCode.Space))
            {
                jumpCounter = 0f;
                stopJump = true;
            }

            if(isGrounded)
            {
                jumpCounter = jumpTime;
            }
            //mobile mode
        }
    }

    void Jump()
    {
        myRB.velocity = new Vector3(myRB.velocity.x, jump, myRB.velocity.z);
    }

	public void PauseGame()
	{
		Time.timeScale = 0f;
	}

	public void UnPauseGame()
	{
		Time.timeScale = 1f;
	}
}