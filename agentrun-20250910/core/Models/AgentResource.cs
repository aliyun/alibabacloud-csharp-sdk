// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentResource : TeaModel {
        /// <summary>
        /// <para>当 resourceType 为 Flow 时，此字段包含完整的工作流对象，包括所有配置和状态信息；当 resourceType 为 AgentRuntime 时，此字段为空</para>
        /// </summary>
        [NameInMap("flow")]
        [Validation(Required=false)]
        public Flow Flow { get; set; }

        /// <summary>
        /// <para>资源的最新发布版本摘要，包含版本号、描述和创建时间。如果资源没有已发布版本，则此字段为空</para>
        /// </summary>
        [NameInMap("latestVersion")]
        [Validation(Required=false)]
        public AgentResourceLatestVersion LatestVersion { get; set; }
        public class AgentResourceLatestVersion : TeaModel {
            /// <summary>
            /// <para>版本发布时间，采用ISO 8601格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-15T08:30:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>该版本的描述信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>修复了消息处理的并发问题</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>版本发布者（仅 AgentRuntime 类型资源返回）</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("publisher")]
            [Validation(Required=false)]
            public string Publisher { get; set; }

            /// <summary>
            /// <para>最新发布的版本号</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>资源类型标识符，用于区分资源是智能体运行时（AgentRuntime）还是工作流（Flow）</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentRuntime</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>当 resourceType 为 AgentRuntime 时，此字段包含完整的智能体运行时对象，包括所有配置和状态信息；当 resourceType 为 Flow 时，此字段为空</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public AgentRuntime Runtime { get; set; }

    }

}
