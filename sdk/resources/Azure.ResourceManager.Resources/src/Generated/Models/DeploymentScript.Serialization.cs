// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DeploymentScript : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identity");
            writer.WriteObjectValue(Identity);
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static DeploymentScript DeserializeDeploymentScript(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureCLI": return AzureCliScript.DeserializeAzureCliScript(element);
                    case "AzurePowerShell": return AzurePowerShellScript.DeserializeAzurePowerShellScript(element);
                }
            }
            ManagedServiceIdentity identity = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            ScriptType kind = default;
            Optional<SystemData> systemData = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    identity = ManagedServiceIdentity.DeserializeManagedServiceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new ScriptType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = SystemData.DeserializeSystemData(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new DeploymentScript(id.Value, name.Value, type.Value, identity, location, Optional.ToDictionary(tags), kind, systemData.Value);
        }
    }
}