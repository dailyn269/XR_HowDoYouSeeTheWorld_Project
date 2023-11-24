using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class PanelManager : MonoBehaviour
{
    public int stage = 0;
    List<string> prompt = new List<string>();
    [SerializeField] private GameObject mainTextObj;
    [SerializeField] private GameObject titleObj;
    private TextMeshProUGUI mainText;
    private TextMeshProUGUI title;
    public Button prev;
    public Button next;

    string[] mainTextLs =
    {
        "Welcome back!\nHaving experienced simulations of cataracts, glaucoma, and color blindness, you've taken a significant step in understanding visual impairment. Now, let's delve deeper into these conditions, explore other forms of visual impairments, and learn about their impact on daily life.",
        @"<size=80%>Color blindness, also known as color vision deficiency, is a condition where an individual's ability to perceive colors is different from the norm.

        <indent=0%><b>Causes:</b> This condition arises due to anomalies in the cone cells in the retina of the eye, which are responsible for color vision.</indent>
        <indent=0%><b>Variations and Severity:</b> The severity and type of color blindness vary; some people may have trouble distinguishing certain colors, such as red and green, or blue and yellow, while others may not perceive color at all, a condition known as achromatopsia.</indent>
        <indent=0%><b>Adaptation and Aids:</b> While it can pose challenges in daily activities, most people with color blindness adapt well, and various tools and aids are available to assist them.</indent></size>
        ",
        @"<size=80%>Cataract is a prevalent eye condition characterized by the clouding of the natural lens in the eye. This cloudiness can significantly impair vision, making it a leading cause of vision loss, especially among the elderly.

        <indent=0%><b>Causes:</b> While age is the most common cause of cataracts, factors such as genetics, underlying medical conditions like diabetes, and environmental elements like UV light exposure also contribute to their development.</indent>
        <indent=0%><b>Symptoms and Diagnosis:</b> Symptoms of cataracts include blurred vision, difficulty with night vision, increased sensitivity to light and glare, and a noticeable fading of colors. Diagnosis is typically made through a comprehensive eye examination.</indent>
        <indent=0%><b>Adaptation and Aids:</b> The primary treatment for cataracts is surgical removal of the cloudy lens, often replaced with an artificial one. This surgery is generally safe and effective, restoring vision in most cases.</indent></size>
        ",
        @"<size=80%>Glaucoma is an eye problem where the nerve connecting the eye to the brain (optic nerve) gets damaged, often due to high pressure inside the eye.

        <indent=0%><b>Causes:</b> Mostly, glaucoma happens when there's too much pressure inside the eye. This can be due to the eye's fluid not draining well. Sometimes, you can get glaucoma even if the pressure in your eye is normal. Things like being older, having a family history of glaucoma, or certain medical conditions can increase your risk.</indent>
        <indent=0%><b>Symptoms and Diagnosis:</b> Glaucoma can be sneaky - often there are no early signs. Sometimes, you might not notice anything is wrong until your vision is affected. In rare cases, like with acute glaucoma, you might have eye pain, blurred vision, or headaches.</indent>
        <indent=0%><b>Adaptation and Aids:</b> This usually requires using eye drops or other treatments your doctor suggests, like laser or surgery. It's also good to wear eye protection and avoid things that can increase eye pressure. If your vision changes, things like special glasses can help.</indent></size>
        ",
        @"Visual impairment manifests in various forms, each presenting unique challenges beyond cataracts, glaucoma, and color blindness. Let's explore:
        <size=80%>-<indent=5%>Myopia (nearsightedness): A common condition where distant objects appear blurry.</indent></size>
        <size=80%>-<indent=5%>Hyperopia (farsightedness): Difficulty in seeing nearby objects clearly.</indent></size>
        <size=80%>-<indent=5%>Astigmatism: Blurry vision due to an irregularly shaped cornea.</indent></size>
        ",
        @"<size=80%>According to the World Health Organization, at least 2.2 billion people have a near or distance vision impairment. In about half of these cases, vision impairment could have been prevented or has yet to be addressed. This statistic underscores the critical importance of regular eye examinations and timely treatment, which can drastically reduce the risk of severe vision loss.

        <indent=0%>As future leaders, innovators, and community members, you have the power to make a difference. Awareness and education are key in combating visual impairments. By promoting regular eye check-ups, supporting research in eye health, and advocating for accessible eye care services, we can work towards reducing the number of preventable vision impairments. Remember, <b><uppercase>every effort counts</uppercase></b> in the journey towards a world with better vision for all.</indent></size>
        "
    };
    string[] titleLs =
    {
        "Overview",
        "Color Blindness",
        "Cataract",
        "Glaucoma",
        "Other Types of Visual Impairments",
        "Awareness"
    };

    public VideoPlayer videoPlayer;
    public VideoClip colorBlindnessVid;
    public VideoClip cataractVid;
    public VideoClip glaucomaVid;

    // Start is called before the first frame update
    void Start()
    {
        mainText = mainTextObj.GetComponent<TextMeshProUGUI>();
        title = titleObj.GetComponent<TextMeshProUGUI>();

        UpdatePanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdatePanel()
    {
        title.text = titleLs[stage];
        mainText.text = mainTextLs[stage];
    }

    void UpdateVideo()
    {
        if (titleLs[stage] == "Color Blindness")
        {
            videoPlayer.clip = colorBlindnessVid;
        } else if (titleLs[stage] == "Cataract")
        {
            videoPlayer.clip = cataractVid;
        } else if (titleLs[stage] == "Glaucoma")
        {
            videoPlayer.clip = glaucomaVid;
        } else
        {
            videoPlayer.clip = null;
        }
    }

    public void StageIncrease()
    {
        stage++;
        UpdatePanel();

        prev.interactable = true;
        if (stage == titleLs.Length-1)
        {
            next.interactable = false;
            //next.get
        }
        UpdatePanel();
        UpdateVideo();
    }

    public void StageDecrease()
    {
        stage--;
        UpdatePanel();

        next.interactable = true;
        if (stage == 0)
        {
            prev.interactable = false;
        }
        UpdatePanel();
        UpdateVideo();
    }

}
