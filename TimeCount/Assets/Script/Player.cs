
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI TimeText;
    [SerializeField]float TimeToComplete = 3f;
    [SerializeField]float CurrnetTimeToHold = 0f;
    [SerializeField]bool heldkey = true;
    [SerializeField]TextMeshProUGUI CompleteText;
    [SerializeField]TextMeshProUGUI GuideText;

   
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            TimeText.text = "";
            CompleteText.text = "";
            GuideText.text = "Release Key if you think you held spacebar to 3 seconds";
            CurrnetTimeToHold = CurrnetTimeToHold + Time.deltaTime; 
            heldkey = true;
        }
        if(!Input.GetKey(KeyCode.Space))
        {
            heldkey = false;
            if(heldkey == false)
            {
                float Completebyplayertime = CurrnetTimeToHold;
                TimeText.text = Completebyplayertime.ToString();
                if(Completebyplayertime == TimeToComplete)
                {
                    CompleteText.text = "Good Job";
                }
            }
        }
        
    }
}
