using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Recipedata", menuName = "ScriptableObjects/Recipe", order = 1)]
public class RecipeSO : ScriptableObject
{
    public Image preview;

    public Recipe recipe;
}