public class Recipe
{
    private string author;
    private string title;
    private string[] ingredients;
    private string howTo;

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