// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentRuntimeEndpoint : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the agent runtime endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:1760720386195983:runtime-endpoints/e56d483c-db80-4116-9ec4-25f16f5facfd</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointArn")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointArn { get; set; }

        /// <summary>
        /// <para>The unique identifier of the agent runtime endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>are-1234567890abcdef</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointId")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointId { get; set; }

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
        /// <para>The unique identifier of the agent runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ar-1234567890abcdef</para>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

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
        /// <para>If <c>true</c>, public access for this endpoint is disabled.</para>
        /// </summary>
        [NameInMap("disablePublicNetworkAccess")]
        [Validation(Required=false)]
        public bool? DisablePublicNetworkAccess { get; set; }

        /// <summary>
        /// <para>The public access address for the agent runtime endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ar-1234567890abcdef.cn-hangzhou.agentrun.aliyuncs.com">https://ar-1234567890abcdef.cn-hangzhou.agentrun.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("endpointPublicUrl")]
        [Validation(Required=false)]
        public string EndpointPublicUrl { get; set; }

        /// <summary>
        /// <para>The configuration for weight-based routing across multiple agent versions.</para>
        /// </summary>
        [NameInMap("routingConfiguration")]
        [Validation(Required=false)]
        public RoutingConfiguration RoutingConfiguration { get; set; }

        /// <summary>
        /// <para>端点的弹性伸缩状态，包括最小/目标/当前实例数及定时策略（复用 ScalingStatus）</para>
        /// </summary>
        [NameInMap("scalingStatus")]
        [Validation(Required=false)]
        public ScalingStatus ScalingStatus { get; set; }

        /// <summary>
        /// <para>The current status of the agent runtime endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason for the current status of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint is active and ready</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The agent version that the endpoint targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
