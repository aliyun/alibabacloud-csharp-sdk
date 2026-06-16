// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateFlowEndpointInput : TeaModel {
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
        /// <para>Specifies whether to disable public network access for the flow endpoint.</para>
        /// </summary>
        [NameInMap("disablePublicNetworkAccess")]
        [Validation(Required=false)]
        public bool? DisablePublicNetworkAccess { get; set; }

        /// <summary>
        /// <para>The unique name of the flow endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flow-endpoint</para>
        /// </summary>
        [NameInMap("flowEndpointName")]
        [Validation(Required=false)]
        public string FlowEndpointName { get; set; }

        /// <summary>
        /// <para>The routing configuration that defines traffic distribution for the flow endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("routingConfiguration")]
        [Validation(Required=false)]
        public List<FlowEndpointRoutingConfig> RoutingConfiguration { get; set; }

        /// <summary>
        /// <para>The target version for the flow endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
