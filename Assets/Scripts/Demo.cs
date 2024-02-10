using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public TextMeshProUGUI textToDisplay;

    private IDataSerializer serializer;

    // Start is called before the first frame update
    void Start()
    {
        serializer = new DataSerializer();
    }

    public void OnSaveData()
    {
        Recipe newRecipe = new Recipe(this.name);
        serializer.SaveData("/new-recipe.json", newRecipe);
    }

    public void OnLoadData()
    {
        Recipe loadedRecipe = new Recipe(this.name);
        loadedRecipe = serializer.LoadData<Recipe>("/new-recipe.json");

        DisplayRecipe(loadedRecipe);
    }

    private void DisplayRecipe(Recipe recipeToDisplay)
    {
        (string author, string title, string[] ingredients, string howTo) = recipeToDisplay;
        textToDisplay.text = ($"{title} Created by {author}. It contains: {ingredients[0]} and {ingredients[1]}. This is how you cook it: {howTo}");
    }
}