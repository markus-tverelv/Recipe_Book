using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public TextMeshProUGUI textToDisplay;

    private IDataSerializer serializer;

    // Deconstructed Recipe
    private string author;
    private string title;
    private string[] ingredients;
    private string howTo;

    // Start is called before the first frame update
    void Start()
    {
        serializer = new DataSerializer();
    }

    public void OnSaveData()
    {
        Recipe recipe = new Recipe("Markus");
        serializer.SaveData($"/{title}.json", recipe);
    }

    public void OnLoadData()
    {
        Recipe recipe = serializer.LoadData<Recipe>($"/{title}.json");
        recipe.Deconstruct(out author, out title, out ingredients, out howTo);
        textToDisplay.text = ($"{title} Created by {author}. It contains: {ingredients[0]} and {ingredients[1]}. This is how you cook it: {howTo}");
    }
}