// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class Flow : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("CodeModeRunInfo")]
        [Validation(Required=false)]
        public string CodeModeRunInfo { get; set; }

        [NameInMap("CreateFrom")]
        [Validation(Required=false)]
        public string CreateFrom { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("FlowStoragePath")]
        [Validation(Required=false)]
        public string FlowStoragePath { get; set; }

        [NameInMap("FlowTemplateId")]
        [Validation(Required=false)]
        public string FlowTemplateId { get; set; }

        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Runtime")]
        [Validation(Required=false)]
        public FlowRuntime Runtime { get; set; }
        public class FlowRuntime : TeaModel {
            /// <summary>
            /// <para>运行时ID</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

            /// <summary>
            /// <para>运行时名称</para>
            /// </summary>
            [NameInMap("RuntimeName")]
            [Validation(Required=false)]
            public string RuntimeName { get; set; }

            /// <summary>
            /// <para>运行时状态</para>
            /// </summary>
            [NameInMap("RuntimeStatus")]
            [Validation(Required=false)]
            public string RuntimeStatus { get; set; }

            /// <summary>
            /// <para>运行时类型</para>
            /// </summary>
            [NameInMap("RuntimeType")]
            [Validation(Required=false)]
            public string RuntimeType { get; set; }

            /// <summary>
            /// <para>是否支持SSE</para>
            /// </summary>
            [NameInMap("SupportSSEStream")]
            [Validation(Required=false)]
            public bool? SupportSSEStream { get; set; }

        }

        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        [NameInMap("SourceUri")]
        [Validation(Required=false)]
        public string SourceUri { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("WorkDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
