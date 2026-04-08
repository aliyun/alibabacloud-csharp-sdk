// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateFlowEndpointInput : TeaModel {
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
        /// <para>工作流端点的唯一标识名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flow-endpoint</para>
        /// </summary>
        [NameInMap("flowEndpointName")]
        [Validation(Required=false)]
        public string FlowEndpointName { get; set; }

        /// <summary>
        /// <para>工作流端点的版本路由配置，用于流量分配</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("routingConfiguration")]
        [Validation(Required=false)]
        public List<FlowEndpointRoutingConfig> RoutingConfiguration { get; set; }

        /// <summary>
        /// <para>工作流端点的标签信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

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
