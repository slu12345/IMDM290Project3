/*using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Markup;
using Microsoft.Win32;*/

//using System.Diagnostics;
//using System.Diagnostics;
using UnityEngine;

public class ScreenDivider1 : MonoBehaviour
{
    Texture2D texture;
    float[] values;
    float[,] finalValues;
    const int cornerNum = 4;
    const int smallerSections = 4;
    float sq1;
    float sq2;
    float sq3;
    float sq4;
    float sq5;
    float sq6;
    float sq7;
    float sq8;
    float sq9;
    float sq10;
    float sq11;
    float sq12;
    float sq13;
    float sq14;
    float sq15;
    float sq16;
    static int numberofObj = 2;
    Vector2[] objects = new Vector2[numberofObj];
    

    void Start()
    {
        // objects
        objects[0] = new Vector2(-0.5f, 1.52f); // apple
        objects[1] = new Vector2(1f, -1.14f); // bone 


        GameObject obj = GameObject.Find("Wooden Planks");

        Camera.main.orthographicSize = Screen.height / 2f;
        SpriteRenderer planks = obj.GetComponent<SpriteRenderer>();//use later

        Sprite origin = planks.sprite;

        Texture2D texture = origin.texture;

        if (texture == null)
        {
            Debug.Log("NO SPRITE");
        } else
        {
            Debug.Log("SPRITE FOUND");
        }
        transform.localScale = new Vector3(texture.width, texture.height, 1);

        byte[] pixels = texture.GetRawTextureData();

        for (int row = 0; row < texture.height / 4; ++row)
        {
            int rowOffset = texture.width * row * 4;

            for (int col = 0; col < texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq1 = pixelIndex;

                
                
            }

            for (int col = texture.width / 4; col < texture.width / 2; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq2 = pixelIndex;
            }

            for (int col = texture.width / 2; col < 3 * texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq3 = pixelIndex;
            }
            for (int col = 3 * texture.width / 4; col < texture.width; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq4 = pixelIndex;
            }
        }

        for (int row = texture.height / 4; row < texture.height / 2; ++row)
        {
            int rowOffset = texture.width * row * 4;

            for (int col = 0; col < texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq5 = pixelIndex;
            }
            for (int col = texture.width / 4; col < texture.width / 2; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                 sq6 = pixelIndex;
            }

            for (int col = 3 * texture.width / 4; col < texture.width; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq7 = pixelIndex;
            }
            for (int col = texture.width / 2; col < 3 * texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                 sq8 = pixelIndex;
            }
        }

        for (int row = texture.height / 2; row < 3 * texture.height / 4; ++row)
        {
            int rowOffset = texture.width * row * 4;

            for (int col = 0; col < texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq9 = pixelIndex;
            }
            for (int col = texture.width / 4; col < texture.width / 2; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq10 = pixelIndex;
            }

            for (int col = 3 * texture.width / 4; col < texture.width; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq11 = pixelIndex;
            }
            for (int col = texture.width / 2; col < 3 * texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq12 = pixelIndex;
            }
        }

        for (int row = 3 * texture.height / 4; row < texture.height; ++row)
        {
            int rowOffset = texture.width * row * 4;

            for (int col = 0; col < texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq13 = pixelIndex;
            }
            for (int col = texture.width / 4; col < texture.width / 2; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq14 = pixelIndex;
            }

            for (int col = 3 * texture.width / 4; col < texture.width; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq15 = pixelIndex;
            }
            for (int col = texture.width / 2; col < 3 * texture.width / 4; ++col)
            {
                int pixelIndex = rowOffset + col * 4;
                sq16 = pixelIndex;
            }
        }

        values[0] = sq1;
        values[1] = sq2;
        values[2] = sq3;
        values[3] = sq4;
        values[4] = sq5;
        values[5] = sq6;
        values[6] = sq7;
        values[7] = sq8;
        values[8] = sq9;
        values[9] = sq10;
        values[10] = sq11;
        values[11] = sq12;
        values[12] = sq13;
        values[13] = sq14;
        values[14] = sq15;
        values[15] = sq16;
        int holder = 0;
        int hold2 = 0;
        
        float[]  temp = new float[0];
        for ( int i = 0; i < cornerNum; i++)
        {
            temp = new float[0];
            //holder = 0;
            for (int j = 0; j < smallerSections; j++)
            {
                //idx = 0;
                temp[j] = values[holder];
                holder += 1;
                //idx++;

            }
            for (int k = 0; k < temp.Length; k++)
            {
                finalValues[i,hold2] = temp[k];
                hold2++;
                //smallerSections += 4;
            }
        }
        
        /*
         * for(int i = 0; i < 4; i ++){
         *  for(int j = 0; j < 4: j ++){
         *         final_values[i][j];
         *      }
         *       }
         */
        

        

       texture.LoadRawTextureData(pixels);
       texture.Apply();
    }
    void Update()
    {
        // call pinch value
        //Debug.Log(Interaction.interact.pinchedPosition);
        // collider 
        for (int i = 0;i < numberofObj;i++) {
            double dist = (objects[i] - Interaction.interact.pinchedPosition).magnitude;
            Debug.Log(i + " " + dist);

        }

    }
}
