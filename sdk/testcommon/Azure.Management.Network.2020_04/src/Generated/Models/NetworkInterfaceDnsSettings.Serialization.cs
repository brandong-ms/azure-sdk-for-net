// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkInterfaceDnsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers");
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InternalDnsNameLabel))
            {
                writer.WritePropertyName("internalDnsNameLabel");
                writer.WriteStringValue(InternalDnsNameLabel);
            }
            writer.WriteEndObject();
        }

        internal static NetworkInterfaceDnsSettings DeserializeNetworkInterfaceDnsSettings(JsonElement element)
        {
            Optional<IList<string>> dnsServers = default;
            Optional<IReadOnlyList<string>> appliedDnsServers = default;
            Optional<string> internalDnsNameLabel = default;
            Optional<string> internalFqdn = default;
            Optional<string> internalDomainNameSuffix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("appliedDnsServers"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    appliedDnsServers = array;
                    continue;
                }
                if (property.NameEquals("internalDnsNameLabel"))
                {
                    internalDnsNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalFqdn"))
                {
                    internalFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalDomainNameSuffix"))
                {
                    internalDomainNameSuffix = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkInterfaceDnsSettings(Optional.ToList(dnsServers), Optional.ToList(appliedDnsServers), internalDnsNameLabel.Value, internalFqdn.Value, internalDomainNameSuffix.Value);
        }
    }
}