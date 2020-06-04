// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitRoutesTable
    {
        internal static ExpressRouteCircuitRoutesTable DeserializeExpressRouteCircuitRoutesTable(JsonElement element)
        {
            Optional<string> network = default;
            Optional<string> nextHop = default;
            Optional<string> locPrf = default;
            Optional<int> weight = default;
            Optional<string> path = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("network"))
                {
                    network = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHop"))
                {
                    nextHop = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locPrf"))
                {
                    locPrf = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weight"))
                {
                    weight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressRouteCircuitRoutesTable(network.Value, nextHop.Value, locPrf.Value, Optional.ToNullable(weight), path.Value);
        }
    }
}