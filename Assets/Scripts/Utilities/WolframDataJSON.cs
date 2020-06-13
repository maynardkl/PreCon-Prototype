using System;

//all variables here following the variables from JSON response


[Serializable]
public class WolframDataJSON
{
    public QueryResult queryresult;
}

[Serializable]
public class QueryResult
{
    public bool success;
    public bool error;
    public int numpods;
    public string datatypes;
    public string timedout;
    public string timedOutpods;
    public float timing;
    public float parsetiming;
    public bool parsetimedtut;
    public string recalculate;
    public string id;
    public string host;
    public string server;
    public string related;
    public string version;
    public PodsData[] pods;
}

[Serializable]
public class PodsData
{
    public string title;
    public string scanner;
    public string id;
    public int position;
    public bool error;
    public int numsubpods;
    public bool primary;
    public SubPodsData[] subpods;
    public ExpressionTypesData expressiontypes;
    public StatesData states;
    public InfosData infos;
}

[Serializable]
public class SubPodsData
{
    public string title;
    public MicroSourcesData microsources;
    public DataSources datasources;
    public string plaintext;
}

[Serializable]
public class MicroSourcesData
{
    public MicroSourceData microsource;
}

[Serializable]
public class MicroSourceData
{
    //Data
    //Data2
}

[Serializable]
public class DataSources
{
    public string datasource;
}

[Serializable]
public class ExpressionTypesData
{
    public string name;
}

[Serializable]
public class StatesData
{
    public string name;
    public string input;
}

[Serializable]
public class InfosData
{
    public LinksData links;
}

[Serializable]
public class LinksData
{
    public string url;
    public string text;
}
