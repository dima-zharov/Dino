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
        if (hiscore >= firstUnlock)
            UpdateChanges(1, firstUnlock);
        else if (hiscore >= secondUnlock)
            UpdateChanges(2, secondUnlock);
            
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

    private void UpdateChanges(int numberAnimal, int needScore)
    {
        ChangeAnimalFunc(numberAnimal);
        gameManager.prizeText.text = Mathf.FloorToInt(needScore).ToString("D5");
    }
}
