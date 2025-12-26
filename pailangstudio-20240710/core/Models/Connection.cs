// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class Connection : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public string CustomType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<ConnectionModels> Models { get; set; }
        public class ConnectionModels : TeaModel {
            /// <summary>
            /// <para>模型展示名称</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>最大上下文长度</para>
            /// </summary>
            [NameInMap("MaxModelLength")]
            [Validation(Required=false)]
            public int? MaxModelLength { get; set; }

            /// <summary>
            /// <para>模型名</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>模型类型</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>是否支持Reasoning</para>
            /// </summary>
            [NameInMap("SupportReasoning")]
            [Validation(Required=false)]
            public bool? SupportReasoning { get; set; }

            /// <summary>
            /// <para>是否支持输出Schema</para>
            /// </summary>
            [NameInMap("SupportResponseSchema")]
            [Validation(Required=false)]
            public bool? SupportResponseSchema { get; set; }

            /// <summary>
            /// <para>是否支持Vision</para>
            /// </summary>
            [NameInMap("SupportVision")]
            [Validation(Required=false)]
            public bool? SupportVision { get; set; }

            /// <summary>
            /// <para>是否支持ToolCall</para>
            /// </summary>
            [NameInMap("ToolCall")]
            [Validation(Required=false)]
            public bool? ToolCall { get; set; }

        }

        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public ConnectionResourceMeta ResourceMeta { get; set; }
        public class ConnectionResourceMeta : TeaModel {
            /// <summary>
            /// <para>资源实例ID</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>资源实例名称</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
