using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Skeleton skel;
    private Vector3 rightIdx;
    private Vector3 rightThumb;
    private Vector3 leftIdx;
    private Vector3 leftThumb;


    // Start is called before the first frame update
    void Start()
    {
        /*
        GameObject skelObj = GameObject.Find("Skeleton");

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

        rightIdx = Gesture.gen.righthandpos[8];
        rightThumb = Gesture.gen.righthandpos[4];

        leftIdx = Gesture.gen.lefthandpos[8];
        leftThumb = Gesture.gen.lefthandpos[4];

        
        Debug.Log(rightIdx);
        Debug.Log(rightThumb);

        Debug.Log("SPlit");
        Debug.Log(leftIdx);
        Debug.Log(leftThumb);
        
        /*Vector3 index = skel.rightIdx;
        Vector3 thumb = skel.rightThumb;
        Debug.Log(index);
        Debug.Log(thumb);*/




        //if (index)



        /*
        if ((Gesture.gen.righthandpos[8] - Gesture.gen.righthandpos[4]).magnitude < 0.03f) // if right hand is pinched within one of the squares, do~
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
