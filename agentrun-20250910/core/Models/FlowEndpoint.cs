// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class FlowEndpoint : TeaModel {
        /// <summary>
        /// <para>工作流端点的创建时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>工作流端点的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production endpoint for flow</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>是否禁用该端点的公网访问</para>
        /// </summary>
        [NameInMap("disablePublicNetworkAccess")]
        [Validation(Required=false)]
        public bool? DisablePublicNetworkAccess { get; set; }

        /// <summary>
        /// <para>工作流端点的全局唯一资源名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:1760720386195983:workspaces/ws-xxx/flows/flow-xxx/endpoints/fe-xxx</para>
        /// </summary>
        [NameInMap("flowEndpointArn")]
        [Validation(Required=false)]
        public string FlowEndpointArn { get; set; }

        /// <summary>
        /// <para>工作流端点的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe-1234567890abcdef</para>
        /// </summary>
        [NameInMap("flowEndpointId")]
        [Validation(Required=false)]
        public string FlowEndpointId { get; set; }

        /// <summary>
        /// <para>工作流端点的名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flow-endpoint</para>
        /// </summary>
        [NameInMap("flowEndpointName")]
        [Validation(Required=false)]
        public string FlowEndpointName { get; set; }

        /// <summary>
        /// <para>工作流的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-1234567890abcdef</para>
        /// </summary>
        [NameInMap("flowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>工作流端点最后一次更新的时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>工作流端点的版本路由配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("routingConfiguration")]
        [Validation(Required=false)]
        public List<FlowEndpointRoutingConfig> RoutingConfiguration { get; set; }

        /// <summary>
        /// <para>工作流端点指向的目标版本号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
