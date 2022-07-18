using System.Text.Json.Serialization;
/// <summary>
/// Used to map the postcode.io api response
/// </summary>
public class PostCode 
{

    [JsonPropertyName("postcode")]
    public string Code { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("admindistrict")]
    public string AdminDistrict { get {return this.Codes.AdminDistrict; } set{} }

    [JsonPropertyName("parliamentaryconstituency")]
    public string ParliamentaryConstituency { get {return this.Codes.ParliamentaryConstituency;} set{}}

    [JsonPropertyName("area")]        
    public string Area { get {
        System.Console.WriteLine(" Latitude value : " + this.Latitude);
        if(this.Latitude < 52.229466)
            return "South";
        else if(52.229466 <= this.Latitude && this.Latitude < 53.27169)
            return "Midlands";
        else if (this.Latitude >= 53.27169)
            return "North";
        else 
            return null;
    } set{} }

    [JsonPropertyName("codes")]
    public Code Codes{get;set;}

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }
}

/// <summary>
/// Used to map the postcode.io api response
/// </summary>
public class Code
{
    [JsonPropertyName("admin_district")]
    public string AdminDistrict { get; set; }
    
    [JsonPropertyName("parliamentary_constituency")]
    public string ParliamentaryConstituency { get; set; }
}
