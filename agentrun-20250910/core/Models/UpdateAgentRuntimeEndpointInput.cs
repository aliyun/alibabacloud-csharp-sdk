// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateAgentRuntimeEndpointInput : TeaModel {
        /// <summary>
        /// <para>Agent runtime endpoint Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>production-endpoint</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointName")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointName { get; set; }

        /// <summary>
        /// <para>为 true 时删除该端点的弹性配置</para>
        /// </summary>
        [NameInMap("deleteScalingConfig")]
        [Validation(Required=false)]
        public bool? DeleteScalingConfig { get; set; }

        /// <summary>
        /// <para>Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>Updated endpoint configuration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether to disable public network access for this endpoint</para>
        /// </summary>
        [NameInMap("disablePublicNetworkAccess")]
        [Validation(Required=false)]
        public bool? DisablePublicNetworkAccess { get; set; }

        /// <summary>
        /// <para>The Ingress configuration of the agent runtime endpoint, which supports weight assignment across multiple versions</para>
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
        /// <para>Target Version of the agent runtime</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
