using System;

[Serializable]
public class DataClass
{
    public string TotalConfirmed;
    public string TotalDeaths;
    public string TotalRecovered;
}

[Serializable]
public class Summary
{
    public World Global;
    public ByCountry[] Countries;
}

[Serializable]
public class World
{
    public string NewConfirmed;
    public string TotalConfirmed;
    public string NewDeaths;
    public string TotalDeaths;
    public string NewRecovered;
    public string TotalRecovered;
}

[Serializable]
public class ByCountry
{
    public string Country;
    public string CountryCode;
    public string Slug;
    public string NewConfirmed;
    public string TotalConfirmed;
    public string NewDeaths;
    public string TotalDeaths;
    public string NewRecovered;
    public string TotalRecovered;
    public string Date;
}
