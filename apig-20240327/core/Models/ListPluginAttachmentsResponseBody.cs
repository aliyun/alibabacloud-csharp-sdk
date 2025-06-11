// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPluginAttachmentsResponseBodyData Data { get; set; }
        public class ListPluginAttachmentsResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListPluginAttachmentsResponseBodyDataItems> Items { get; set; }
            public class ListPluginAttachmentsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>GatewayRoute</para>
                /// </summary>
                [NameInMap("attachResourceType")]
                [Validation(Required=false)]
                public string AttachResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("environmentInfo")]
                [Validation(Required=false)]
                public EnvironmentInfo EnvironmentInfo { get; set; }

                [NameInMap("parentResourceInfo")]
                [Validation(Required=false)]
                public ParentResourceInfo ParentResourceInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-d0j9t5em1hkncrlo51mg</para>
                /// </summary>
                [NameInMap("pluginAttachmentId")]
                [Validation(Required=false)]
                public string PluginAttachmentId { get; set; }

                [NameInMap("pluginClassInfo")]
                [Validation(Required=false)]
                public PluginClassInfo PluginClassInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bGltaXRfYnlfaGVhZGVyOiB4LWFwaS1rZXkKbGltaXRfa2V5czoKLSBrZXk6IGV4YW1wbGUta2V5LWEKICBxdWVyeV9wZXJfc2Vjb25kOiAxMAotIGtleTogZXhhbXBsZS1rZXktYgogIHF1ZXJ5X3Blcl9zZWNvbmQ6IDEK</para>
                /// </summary>
                [NameInMap("pluginConfig")]
                [Validation(Required=false)]
                public string PluginConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pl-cvu6r4um1hko3b3ti0a0</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("resourceInfos")]
                [Validation(Required=false)]
                public List<ResourceInfo> ResourceInfos { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9640D776-794A-5077-9184-A247CA4B45C1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
