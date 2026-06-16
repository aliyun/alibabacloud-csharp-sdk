// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class FlowEndpoint : TeaModel {
        /// <summary>
        /// <para>The creation timestamp for the flow endpoint, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the flow endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production endpoint for flow</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Set to true to disable public network access for this endpoint.</para>
        /// </summary>
        [NameInMap("disablePublicNetworkAccess")]
        [Validation(Required=false)]
        public bool? DisablePublicNetworkAccess { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the flow endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:1760720386195983:workspaces/ws-xxx/flows/flow-xxx/endpoints/fe-xxx</para>
        /// </summary>
        [NameInMap("flowEndpointArn")]
        [Validation(Required=false)]
        public string FlowEndpointArn { get; set; }

        /// <summary>
        /// <para>The unique identifier of the flow endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe-1234567890abcdef</para>
        /// </summary>
        [NameInMap("flowEndpointId")]
        [Validation(Required=false)]
        public string FlowEndpointId { get; set; }

        /// <summary>
        /// <para>The name of the flow endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flow-endpoint</para>
        /// </summary>
        [NameInMap("flowEndpointName")]
        [Validation(Required=false)]
        public string FlowEndpointName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-1234567890abcdef</para>
        /// </summary>
        [NameInMap("flowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The last update timestamp for the flow endpoint, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The routing configuration that distributes traffic to different versions of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("routingConfiguration")]
        [Validation(Required=false)]
        public List<FlowEndpointRoutingConfig> RoutingConfiguration { get; set; }

        /// <summary>
        /// <para>The flow version targeted by the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
