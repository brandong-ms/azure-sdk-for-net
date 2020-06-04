// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteObjectValue(Source);
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination");
                writer.WriteObjectValue(Destination);
            }
            if (Optional.IsDefined(AutoStart))
            {
                writer.WritePropertyName("autoStart");
                writer.WriteBooleanValue(AutoStart.Value);
            }
            if (Optional.IsDefined(MonitoringIntervalInSeconds))
            {
                writer.WritePropertyName("monitoringIntervalInSeconds");
                writer.WriteNumberValue(MonitoringIntervalInSeconds.Value);
            }
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints");
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TestConfigurations))
            {
                writer.WritePropertyName("testConfigurations");
                writer.WriteStartArray();
                foreach (var item in TestConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TestGroups))
            {
                writer.WritePropertyName("testGroups");
                writer.WriteStartArray();
                foreach (var item in TestGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs");
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}