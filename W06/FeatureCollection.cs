using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace prove_06;

public class Feature {
    public Properties properties { get; set; }
}

public class Properties {
    public string place { get; set; }
    public double mag { get; set; }
}

public class FeatureCollection {
    public List<Feature> features { get; set; }

    public static async Task FetchEarthquakeData() {
        string url = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using HttpClient client = new();
        string json = await client.GetStringAsync(url);

        FeatureCollection data = JsonSerializer.Deserialize<FeatureCollection>(json);

        Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
        foreach (var feature in data.features) {
            Console.WriteLine($"{feature.properties.place} - Mag {feature.properties.mag}");
        }
    }
}
