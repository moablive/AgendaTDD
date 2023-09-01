using System;
using System.IO;
using Newtonsoft.Json.Linq;

public class StrCon
{
    public string ConnectionString { get; }

    public StrCon()
    {
        // Lê o conteúdo do arquivo config.json
        string configPath = "config.json";
        string json = File.ReadAllText(configPath);

        // Analisa o JSON e obtém a string de conexão
        JObject config = JObject.Parse(json);
        ConnectionString = (string)config["ConnectionString"];
    }
}