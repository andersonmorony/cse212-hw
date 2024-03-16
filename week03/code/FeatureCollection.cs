public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> features { get; set; }
}

public class Feature
{
   public FeatureProperties properties { get; set; }
}

public class FeatureProperties
{
    public double mag { get; set; }
    public string place { get; set; }
    public void Display()
    {
        Console.WriteLine($"{place} - Mag {mag}");
    }
}