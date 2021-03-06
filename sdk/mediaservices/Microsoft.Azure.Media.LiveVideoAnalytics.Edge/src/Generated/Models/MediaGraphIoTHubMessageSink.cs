// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Enables a graph to publish messages that can be delivered via routes
    /// declared in the IoT Edge deployment manifest.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphIoTHubMessageSink")]
    public partial class MediaGraphIoTHubMessageSink : MediaGraphSink
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphIoTHubMessageSink
        /// class.
        /// </summary>
        public MediaGraphIoTHubMessageSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphIoTHubMessageSink
        /// class.
        /// </summary>
        /// <param name="name">Name to be used for the media graph
        /// sink.</param>
        /// <param name="inputs">An array of the names of the other nodes in
        /// the media graph, the outputs of which are used as input for this
        /// sink node.</param>
        /// <param name="hubOutputName">Name of the output path to which the
        /// graph will publish message. These messages can then be delivered to
        /// desired destinations by declaring routes referencing the output
        /// path in the IoT Edge deployment manifest.</param>
        public MediaGraphIoTHubMessageSink(string name, IList<MediaGraphNodeInput> inputs, string hubOutputName = default(string))
            : base(name, inputs)
        {
            HubOutputName = hubOutputName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the output path to which the graph will
        /// publish message. These messages can then be delivered to desired
        /// destinations by declaring routes referencing the output path in the
        /// IoT Edge deployment manifest.
        /// </summary>
        [JsonProperty(PropertyName = "hubOutputName")]
        public string HubOutputName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
