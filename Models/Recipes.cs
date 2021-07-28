using System.Collections.Generic;
public class Ingredients
{
    public string quantity { get; set; }
    public string name { get; set; }
    public string type { get; set; }

}

public class recipes
{
  public string name { get; set; }
  public List <Ingredients> ingredients { get; set; }
  public List <string> steps{get;set;}
  public List<int> timers { get; set; }
  public string imageURL { get; set; }
  public string originalURL { get; set; }
}