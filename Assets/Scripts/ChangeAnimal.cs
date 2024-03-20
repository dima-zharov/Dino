using System.Collections.Generic;
using UnityEngine;


public class ChangeAnimal : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private List<GameObject> Animals;
    private int firstUnlock = 150;
    private int secondUnlock = 350;

    public void UpdateSprites(float hiscore)
    {
        if (hiscore < firstUnlock)
            gameManager.prizeText.text = Mathf.FloorToInt(firstUnlock).ToString("D5");
        if (hiscore >= firstUnlock)
            UpdateChanges(1);
        if (hiscore >= secondUnlock)
        {
            UpdateChanges(2);
            gameManager.prizeText.text = "All animals unlocked!";
        }

    }

    private void ChangeAnimalFunc(int numberAnimal)
    {
        Animals[numberAnimal].gameObject.SetActive(true);

        for(int i = 0; i < Animals.Count; i++)
        {
            if (numberAnimal != i)
            {
                Animals[i].gameObject.SetActive(false);
            }
        }
    }

    private void UpdateChanges(int numberAnimal)
    {
        ChangeAnimalFunc(numberAnimal);
        gameManager.prizeText.text = Mathf.FloorToInt(secondUnlock).ToString("D5");



    }
}
