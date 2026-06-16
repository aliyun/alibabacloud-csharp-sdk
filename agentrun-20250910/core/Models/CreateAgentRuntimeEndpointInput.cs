// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateAgentRuntimeEndpointInput : TeaModel {
        /// <summary>
        /// <para>The name of the agent runtime endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production-endpoint</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointName")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointName { get; set; }

        /// <summary>
        /// <para>The description of the agent runtime endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production endpoint for customer service agent</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable public network access for the endpoint.</para>
        /// </summary>
        [NameInMap("disablePublicNetworkAccess")]
        [Validation(Required=false)]
        public bool? DisablePublicNetworkAccess { get; set; }

        /// <summary>
        /// <para>The routing configuration for the agent runtime endpoint. This configuration distributes traffic to multiple versions based on weights.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("routingConfiguration")]
        [Validation(Required=false)]
        public RoutingConfiguration RoutingConfiguration { get; set; }

        /// <summary>
        /// <para>端点的弹性伸缩配置，包括最小实例数和定时扩容策略（复用 ScalingConfig）</para>
        /// </summary>
        [NameInMap("scalingConfig")]
        [Validation(Required=false)]
        public ScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// <para>The target version of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
