using UnityEngine.UI;
//using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
//using UnityEngine.UIElements;
//using Image = UnityEngine.UI.Image;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start(){
        totalhealthBar.fillAmount = playerHealth.currentHealth / 10;

    }

    private void Update(){
        currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
    }
}
