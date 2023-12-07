using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CategoryManager : MonoBehaviour
{

    [SerializeField] private GameObject promptObj;
    private TextMeshProUGUI textMesh;
    public RawImage image;

    string[] textLs =
    {
        "Normal view", // Colorblind
        "Deutan, also known as deuteranomaly, is a form of colorblindness where individuals have difficulty distinguishing between green and red hues due to a malfunction in the green retinal photoreceptors.",
        "Protan, or protanomaly, is a type of color vision deficiency characterized by a reduced sensitivity to red light, often leading to confusion between red, green, and gray shades.",
        "Tritan, known as tritanomaly, is a rare form of colorblindness that involves impaired blue-yellow color discrimination, often due to malfunctioning or absence of blue retinal photoreceptors.",
        "Monochromacy is a severe form of colorblindness where an individual cannot perceive any color at all, seeing the world in shades of gray, due to the absence or non-functioning of two or all three cone photoreceptor types."

    };

    public Texture[] imgs;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = promptObj.GetComponent<TextMeshProUGUI>();
        
    }

    public void SetContext(int num)
    {
        textMesh.text = textLs[num];
        image.texture = imgs[num];

    }
}
