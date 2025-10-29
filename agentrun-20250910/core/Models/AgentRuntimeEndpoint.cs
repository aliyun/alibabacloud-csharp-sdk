// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentRuntimeEndpoint : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:1760720386195983:runtime-endpoints/e56d483c-db80-4116-9ec4-25f16f5facfd</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointArn")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointArn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>are-1234567890abcdef</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointId")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>production-endpoint</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointName")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ar-1234567890abcdef</para>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Production endpoint for customer service agent</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>智能体运行时端点的公网访问地址</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ar-1234567890abcdef.cn-hangzhou.agentrun.aliyuncs.com">https://ar-1234567890abcdef.cn-hangzhou.agentrun.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("endpointPublicUrl")]
        [Validation(Required=false)]
        public string EndpointPublicUrl { get; set; }

        /// <summary>
        /// <para>智能体运行时端点的路由配置，支持多版本权重分配</para>
        /// </summary>
        [NameInMap("routingConfiguration")]
        [Validation(Required=false)]
        public RoutingConfiguration RoutingConfiguration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Endpoint is active and ready</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
