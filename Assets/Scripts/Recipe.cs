public class Recipe
{
    public string author;
    public string title;
    public string[] ingredients;
    public string howTo;

    public Recipe(string author)
    {
        this.author = author;
        title = "Taco";
        ingredients = new string[] { "Tortilla", "Pico de gallo" };
        howTo = "Make it";
    }

    public void Deconstruct(out string auth, out string title, out string[] ingredients, out string howTo)
    {
        auth = author;
        title = this.title;
        ingredients = this.ingredients;
        howTo = this.howTo;
    }
}