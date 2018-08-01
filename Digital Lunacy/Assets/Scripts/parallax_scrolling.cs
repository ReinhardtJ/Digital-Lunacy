using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax_scrolling : MonoBehaviour
{

    public GameObject mainCamera;

    // contains every GameObject that have a sprite renderer
    private List<GameObject> allSprites;

    // contains every sprite depending on their sorting layer
    // Bg = background layer, Mid = midground layer, Fg = foreground layer
    private List<GameObject> layerBg3;
    private List<GameObject> layerBg2;
    private List<GameObject> layerBg1;
    private List<GameObject> layerMid;
    private List<GameObject> layerFg1;
    private List<GameObject> layerFg2;


    void Start()
    {
        // initialize Lists
        allSprites = new List<GameObject>();
        layerBg3 = new List<GameObject>();
        layerBg2 = new List<GameObject>();
        layerBg1 = new List<GameObject>();
        layerMid = new List<GameObject>();
        layerFg1 = new List<GameObject>();
        layerFg2 = new List<GameObject>();
        
        // collect all game objects in one array
        GameObject[] gameObjects = FindObjectsOfType<GameObject>();
        
        // sort out non-sprites
        foreach (GameObject go in gameObjects)
        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                allSprites.Add(go);
            }
        }

        //sort all sprites according to their sorting layer 
        foreach (GameObject go in allSprites)
        {
            switch (go.GetComponent<SpriteRenderer>().sortingLayerName)
            {
                case "bg_3": layerBg3.Add(go); break;
                case "bg_2": layerBg2.Add(go); break;
                case "bg_1": layerBg1.Add(go); break;
                case "player": layerMid.Add(go); break;
                case "mid": layerMid.Add(go); break;
                case "fg_1" : layerFg1.Add(go); break;
                case "fg_2": layerFg2.Add(go); break;
                default: throw new System.Exception("Sprite " + go.ToString() + " can't be assigned to a valid sorting layer group.");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {


    }
}
