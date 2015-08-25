using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public static PlayerController player;

    public SpriteRenderer hairSprite;
    public SpriteRenderer headSprite;
    public SpriteRenderer faceSprite;
    public SpriteRenderer faceHairSprite;
    public SpriteRenderer bodySprite;
    public SpriteRenderer topArmSprite;
    public SpriteRenderer botArmSprite;
    public SpriteRenderer leftLegSprite;
    public SpriteRenderer rightLegSprite;

    public int skinColor;

    public Sprite leftLeg;
    public Sprite rightLeg;
    public Sprite[] hair;
    public Sprite[] head;
    public Sprite[] face;
    public Sprite[] faceHair;
    public Sprite[] body;
    public Sprite[] topArmSm;
    public Sprite[] topArmMd;
    public Sprite[] topArmLg;
    public Sprite[] botArmSm;
    public Sprite[] botArmMd;
    public Sprite[] botArmLg;
   


    //faceSprite.color = new Color(Random.Range(0.00f,1.00f), Random.Range(0.00f,1.00f), Random.Range(0.00f,1.00f));


    void Awake()
    { 
        if (player == null)
        {
            DontDestroyOnLoad(gameObject);
            player = this;
        }
        else if (player != this)
        {
            Destroy(gameObject);
        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RandomizePlayer()
    {
        RandomizeHair();
        RandomizeFacialHair();
        RandomizeFace();
        RandomizeBody();
        SetLimbSprites();
    }

    public void RandomizeHair()
    {
        RandomizeHairStyle();
        RandomizeHairColor();
    }

    void RandomizeHairStyle()
    {
        int hairNumber = Random.Range(0, hair.Length);
        hairSprite.sprite = hair[hairNumber];
        Debug.Log("Hair Style Set To " + hairNumber);
    }


    void RandomizeHairColor()
    {
        Debug.Log("Randomizing Hair Color");
        hairSprite.color = new Color(Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f));
    }

    public void RandomizeFacialHair()
    {
        RandomizeFacialHairStyle();
        RandomizeFacialHairColor();
    }

    void RandomizeFacialHairStyle()
    {
        int hairNumber = Random.Range(0, faceHair.Length);
        faceHairSprite.sprite = faceHair[hairNumber];
        Debug.Log("Facial Hair Style Set To " + hairNumber);
    }

    void RandomizeFacialHairColor()
    {
        Debug.Log("Randomizing Facial Hair Color");
        faceHairSprite.color = new Color(Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f));
    }
    
    

    public void RandomizeFace()
    {
        int faceNumber = Random.Range(0, face.Length);
        faceSprite.sprite = face[faceNumber];
        Debug.Log("Face Set To " + faceNumber);
    }

    public void RandomizeBody()
    {
        RandomizeBodyStyle();
        RandomizeBodyColor();
    }

    void RandomizeBodyStyle()
    {
        int bodyNumber = Random.Range(0, body.Length);
        bodySprite.sprite = body[bodyNumber];
        Debug.Log("Body Style Set To " + bodyNumber);
    }

    void RandomizeBodyColor()
    {
        Debug.Log("Randomizing Body Color");
        bodySprite.color = new Color(Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f), Random.Range(0.00f, 1.00f));
    }

    public void SetLimbSprites()
    {
        int limbNumber = Random.Range(0, 10);
        skinColor = limbNumber;
        SetHeadSprite(limbNumber);
        SetArmSprites(limbNumber);
    }

    void SetHeadSprite(int headNumber)
    {
        headSprite.sprite = head[headNumber];
        Debug.Log("Set head to " + headNumber);
    }

    void SetArmSprites(int armNumber)
    {
        int armSize = Random.Range(0, 3);

        if (armSize == 0)
        {
            topArmSprite.sprite = topArmSm[armNumber];
            botArmSprite.sprite = botArmSm[armNumber];
        }
        else if (armSize == 1)
        {
            topArmSprite.sprite = topArmMd[armNumber];
            botArmSprite.sprite = botArmMd[armNumber];
            
        }
        else if (armSize == 2)
        {
            topArmSprite.sprite = topArmLg[armNumber];
            botArmSprite.sprite = botArmLg[armNumber];
        }

        Debug.Log("Set arms to " + armNumber + " and arm size to " + armSize);
    }





}
