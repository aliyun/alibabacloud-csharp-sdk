// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class PathConfig : TeaModel {
        /// <summary>
        /// <para>agent runtime 版本（仅当 resourceType 为 runtime 时有效）</para>
        /// </summary>
        [NameInMap("agentRuntimeEndpointName")]
        [Validation(Required=false)]
        public string AgentRuntimeEndpointName { get; set; }

        /// <summary>
        /// <para>支持的方法有：HEAD, GET, POST, PUT, DELETE, PATCH, OPTIONS</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;GET&quot;]</para>
        /// </summary>
        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// <para>此条路由规则对应的请求路径。</para>
        /// 
        /// <b>Example:</b>
        /// <para>/login</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>资源名称</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>资源类型（和凭证关联资源类型一致）</para>
        /// 
        /// <b>Example:</b>
        /// <para>runtime</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
