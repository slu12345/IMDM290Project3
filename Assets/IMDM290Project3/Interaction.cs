using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Skeleton skel;
    private Vector3 rightIdx;
    private Vector3 rightThumb;
    private Vector3 leftIdx;
    private Vector3 leftThumb;
    public Vector2 pinchedPosition;
    public bool isPinched;
    public static Interaction interact;
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
 
    

    // Update is called once per frame
    void Update()
        {

            rightIdx = Gesture.gen.righthandpos[8];
            rightThumb = Gesture.gen.righthandpos[4];

            leftIdx = Gesture.gen.lefthandpos[8];
            leftThumb = Gesture.gen.lefthandpos[4];


            //Debug.Log(rightIdx);
            //Debug.Log(rightThumb);

            //Debug.Log("SPlit");
            //Debug.Log(leftIdx);
            //Debug.Log(leftThumb);

            Vector3 index = skel.rightIdx;
            Vector3 thumb = skel.rightThumb;
            Debug.Log(index);
            Debug.Log(thumb);




            //if (index)

            GameObject.Find("objects");



            if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f)
            {
                isPinched = true;
                pinchedPosition = new Vector2(Gesture.gen.righthandpos[8].x, Gesture.gen.righthandpos[8].y);

                //ScreenDivider.gen.objects[];

                if ((pinchedPosition - ScreenDivider1.Vector2.objects[0]).magnitude < 0.03f)
                {
                    ScreenDivider1.Vector2.objects[0] = pinchedPosition;
                    //  ScreenDivider1.objects[0] = pinchedPosition;

                }


                //interact with object;
                //Debug.Log(pinchedPosition);
            }


            else if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f)
            { // if right hand is pinched within one of the squares, do~
                isPinched = true;
                pinchedPosition = new Vector2(Gesture.gen.righthandpos[8].x, Gesture.gen.righthandpos[8].y);

                //ScreenDivider.gen.objects[];

                if ((pinchedPosition - ScreenDivider1.Vector2.objects[1]).magnitude < 0.03f)
                {
                    ScreenDivider1.objects[1] = pinchedPosition;
                    //  ScreenDivider1.objects[1] = pinchedPosition;

                }


                //interact with object;
                //Debug.Log(pinchedPosition);
            }

            else if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f)
            {  // if right hand is pinched within one of the squares, do~

                isPinched = true;
                pinchedPosition = new Vector2(Gesture.gen.righthandpos[8].x, Gesture.gen.righthandpos[8].y);

                //ScreenDivider.gen.objects[];

                if ((pinchedPosition - ScreenDivider1.Vector2.objects[2]).magnitude < 0.03f)
                {
                    ScreenDivider1.objects[2] = pinchedPosition;
                    // ScreenDivider1.objects[2] = pinchedPosition;

                }


                //interact with object;
                //Debug.Log(pinchedPosition);
            }

            else
            {
                isPinched = false;
            }




            /*if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f) // if right hand is pinched within one of the squares, do~
            {
                isPinched = true;
                //interact with object;
            }
            else
            {
                isPinched = false;
            }
            // Lefthand skeleton draw*/



        }
    }
}



    /*//using System.Diagnostics;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Skeleton skel;
    private Vector3 rightIdx;
    public ScreenDivider1 screenDivider;
    private Vector3 rightThumb;
    private Vector3 leftIdx;
    private Vector3 leftThumb;
    public Vector2 pinchedPosition;
    public bool isPinched;
    public static Interaction interact;
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
        GameObject screenDividerObject = GameObject.Find("control");
        if (screenDividerObject != null)
        {
            screenDivider = screenDividerObject.GetComponent<ScreenDivider1>();
            if (screenDivider == null)
            {
                Debug.LogError("ScreenDivider1 component not found on the GameObject.");
            }
        }
        else
        {
            Debug.LogError("GameObject containing ScreenDivider1 not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {

        rightIdx = Gesture.gen.righthandpos[8];
        rightThumb = Gesture.gen.righthandpos[4];

        leftIdx = Gesture.gen.lefthandpos[8];
        leftThumb = Gesture.gen.lefthandpos[4];


        //Debug.Log(rightIdx);
        //Debug.Log(rightThumb);

        //Debug.Log("SPlit");
        //Debug.Log(leftIdx);
        //Debug.Log(leftThumb);

        /*Vector3 index = skel.rightIdx;
        Vector3 thumb = skel.rightThumb;
        Debug.Log(index);
        Debug.Log(thumb);




    //if (index)

    GameObject.Find("objects");


        if ((Gesture.gen.righthandpos[0] - Gesture.gen.righthandpos[4]).magnitude< 0.03f)
        {
            isPinched = true;
            Vector3 worldPinchPosition = Gesture.gen.righthandpos[8];

            if (screenDivider.IsPositionInSection(new Vector2(worldPinchPosition.x, worldPinchPosition.y)))
            {
                Debug.Log("Pinch position is inside one of the squares");
                // Additional logic...
                
            }
        }


        // else if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f){ // if right hand is pinched within one of the squares, do~
        // isPinched = true;
        // pinchedPosition = new Vector2(Gesture.gen.righthandpos[8].x, Gesture.gen.righthandpos[8].y);

        // //ScreenDivider.gen.objects[];

        // if ((pinchedPosition - ScreenDivider1.objects[1]).magnitude < 0.03f)
        // {
        // ScreenDivider1.objects[1] = pinchedPosition;

        // }


        // //interact with object;
        // //Debug.Log(pinchedPosition);
        // }

        // else if((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f){ // if right hand is pinched within one of the squares, do~

        // isPinched = true;
        // pinchedPosition = new Vector2(Gesture.gen.righthandpos[8].x, Gesture.gen.righthandpos[8].y);

        // //ScreenDivider.gen.objects[];

        // if ((pinchedPosition - ScreenDivider1.objects[2]).magnitude < 0.03f)
        // {
        // ScreenDivider1.Vector2.objects[2] = pinchedPosition;

        // }


        // //interact with object;
        // //Debug.Log(pinchedPosition);
        // }

        // else
        // {
        // isPinched = false;
        // }



        
        if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f) // if right hand is pinched within one of the squares, do~
        {
        isPinched = true;
        //interact with object;
        }
        else
        {
        isPinched = false;
        }
        // Lefthand skeleton draw



    }
}


*/
        

   