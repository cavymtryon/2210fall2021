using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
   public const int gridRows = 2; 
   public const int girdCols = 4; 
   public const float offsetX = 4f;
   public const float offsetY = 5f;

   [SerializeField] private MainCard1 orginalCard;
   [SerializeField] private Sprite[] images;

   private void Start()
   {
       Vector3 stratPos = orginalCard.transform.position;

       int[] numbers = {0, 0, 1, 1, 2, 2, 3, 3};
       numbers = ShuffleArray(numbers);
       
   }

}
