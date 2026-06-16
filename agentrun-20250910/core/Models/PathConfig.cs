// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class PathConfig : TeaModel {
        /// <summary>
        /// <para>The agent runtime version. This parameter takes effect only when <c>resourceType</c> is <c>runtime</c>.</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointName")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointName { get; set; }

        /// <summary>
        /// <para>The compatible protocol, used to convert the backend response format. This parameter is required only when <c>resourceType</c> is <c>flow</c>. Valid values: <c>native</c> indicates an FnF native call; <c>openai</c>, <c>dify-workflow</c>, and <c>dify-chatflow</c> map to their corresponding compatible APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>native</para>
        /// </summary>
        [NameInMap("compatibleProtocol")]
        [Validation(Required=false)]
        public string CompatibleProtocol { get; set; }

        /// <summary>
        /// <para>The Flow version/alias. This parameter takes effect only when <c>resourceType</c> is <c>flow</c>. Default value: <c>Default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("flowEndpointName")]
        [Validation(Required=false)]
        public string FlowEndpointName { get; set; }

        /// <summary>
        /// <para>Supported methods: HEAD, GET, POST, PUT, DELETE, PATCH, and OPTIONS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;GET\&quot;]</para>
        /// </summary>
        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// <para>The path for this routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/login</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("removeBasePathOnForward")]
        [Validation(Required=false)]
        public bool? RemoveBasePathOnForward { get; set; }

        /// <summary>
        /// <para>The resource name.</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource type. This type must match the one associated with the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>runtime</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
