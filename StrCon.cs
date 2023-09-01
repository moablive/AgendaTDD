using System;
using System.IO;
using Newtonsoft.Json.Linq;

public class StrCon
{
    public string ConnectionString { get; }

    public StrCon()
    {
        // L� o conte�do do arquivo config.json
        string configPath = "config.json";
        string json = File.ReadAllText(configPath);

        // Analisa o JSON e obt�m a string de conex�o
        JObject config = JObject.Parse(json);
        ConnectionString = (string)config["ConnectionString"];
    }
}