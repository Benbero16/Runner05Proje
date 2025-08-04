using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] public Animator myAnim;
    [SerializeField] public float speed;
    [SerializeField] public float shift = 2;
    [SerializeField] public bool isLeft, isMiddle, isRight;
    [HideInInspector] public string denemeforgizleme;//gizleme1
    [System.NonSerialized] public string denemeforgizleme2;// gizleme 2
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMiddle = true;
        // transform.position= new Vector3 (0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        #region karakter s�n�rlama
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // 1.y�ntem
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -0.5f)
        {
            transform.Translate(new Vector3(-shift, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 0.5f)
        {
            transform.Translate(shift, 0, 0);

        }






        //2.y�ntem
        /*  if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && isLeft == false)

          {
              if (isMiddle)
              {
                  isLeft = true;
                  isMiddle = false;
              }
              else if (isRight)
              {
                  isMiddle = true;
                  isRight = false;
              }
              transform.Translate(new Vector3(-shift, 0, 0));
          }

          else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && isRight == false)

          {
              if (isMiddle)
              {
                  isRight = true;
                  isMiddle = false;

              }
              else if (isLeft) 
              {
                 isMiddle= true;
                  isLeft= false;
              }
              transform.Translate(new Vector3(shift, 0, 0));
          }

          */
        #endregion




        // rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);



        // transform translate ile ���nlama 
        //  transform.Translate(Vector3.forward*speed*Time.deltaTime);


        /*  if (Input.GetKey(KeyCode.A))
          {
              myAnim.SetBool("Run", true);
          }
          else if (Input.GetKeyUp(KeyCode.A))
          {
              myAnim.SetBool("Run", false);
          }
          if (Input.GetKeyDown(KeyCode.Space)) 
          {
              myAnim.SetBool("Jump", true);        
          }
          else if (Input.GetKeyUp(KeyCode.Space))
          {
              myAnim.SetBool("Jump", false);
          }

          */






    }

    private void FixedUpdate()
    {
        // rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);

    }

}
