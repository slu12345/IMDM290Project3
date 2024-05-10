using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Skeleton skel;
    private Vector3 rightIdx;
    private Vector3 rightThumb;
    public Vector2 pinchedPosition;
    public bool isPinched = false;
    public static int numberofObj = 3;
    public Vector2[] objects = new Vector2[numberofObj];
    public static Interaction interact;
    public GameObject applesprite;
    public GameObject bonesprite;
    public GameObject ribsprite;

    public Vector2 apple;
    float applex;
    float appley;
    public Vector2 bone;
    float bonex;
    float boney;
    public Vector2 ribs;
    float ribsx;
    float ribsy;
    // Start is called before the first frame update



    private void Awake()
    {

         

        if (Interaction.interact == null)
        {
            Interaction.interact = this;
        }
    }
    void Start()
    {

        applex = GameObject.Find("bad apple").transform.position.x;
        appley = GameObject.Find("bad apple").transform.position.y;

        apple = new Vector2(applex, appley);

        bonex = GameObject.Find("funny bone").transform.position.x;
        boney = GameObject.Find("funny bone").transform.position.y;

        bone = new Vector2(bonex, boney);

        ribsx = GameObject.Find("broken ribs").transform.position.x;
        ribsy = GameObject.Find("broken ribs").transform.position.y;

        ribs = new Vector2(ribsx, ribsy);

        objects[0] = apple; // apple
        objects[1] = bone; // bone 
        objects[2] = ribs; // ribs
                           // Debug.Log("hi!");

        /* GameObject skelObj = GameObject.Find("Skeleton");

         if(skelObj == null)
         {
             Debug.Log("Not working");
         } 
         else
         {
             skel = skelObj.GetComponent<Skeleton>();
             Debug.Log("working");
         }*/

    }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log("hi!");
            rightIdx = Gesture.gen.righthandpos[8];
            rightThumb = Gesture.gen.righthandpos[4];
 
            pinchedPosition = new Vector2(Gesture.gen.righthandpos[8].x, Gesture.gen.righthandpos[8].y);

           // Debug.Log("moving");
            if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.1f)
            {
                isPinched = true;
               
                if ((pinchedPosition - objects[0]).magnitude < 0.3f)
                {
                    applesprite.transform.position = new Vector2(pinchedPosition.x, pinchedPosition.y);
                    Debug.Log("hi!");

                }
                else if ((pinchedPosition - objects[1]).magnitude < 0.3f)
                {
                    
                    bonesprite.transform.position = new Vector2(pinchedPosition.x, pinchedPosition.y);

                }
                else if ((pinchedPosition - objects[2]).magnitude < 0.3f)
                {
                   
                    ribsprite.transform.position = new Vector2(pinchedPosition.x, pinchedPosition.y);

                }
                

            }

            else
            {
                isPinched = false;
            }


        }
    
}




        

   