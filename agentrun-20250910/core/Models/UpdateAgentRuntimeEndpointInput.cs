// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateAgentRuntimeEndpointInput : TeaModel {
        /// <summary>
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
        /// <b>Example:</b>
        /// <para>Updated endpoint configuration</para>
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
        /// <para>智能体运行时端点的路由配置，支持多版本权重分配</para>
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
        /// <para>智能体运行时的目标版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
