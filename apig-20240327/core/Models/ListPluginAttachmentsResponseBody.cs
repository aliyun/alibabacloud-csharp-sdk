// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPluginAttachmentsResponseBodyData Data { get; set; }
        public class ListPluginAttachmentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of resource attachments.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListPluginAttachmentsResponseBodyDataItems> Items { get; set; }
            public class ListPluginAttachmentsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The types of resource attachments.</para>
                /// <list type="bullet">
                /// <item><description>HttpApi</description></item>
                /// <item><description>Operation</description></item>
                /// <item><description>GatewayRoute</description></item>
                /// <item><description>GatewayDomain</description></item>
                /// <item><description>Gateway</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GatewayRoute</para>
                /// </summary>
                [NameInMap("attachResourceType")]
                [Validation(Required=false)]
                public string AttachResourceType { get; set; }

                /// <summary>
                /// <para>Indicates if enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The environment metadata.</para>
                /// </summary>
                [NameInMap("environmentInfo")]
                [Validation(Required=false)]
                public EnvironmentInfo EnvironmentInfo { get; set; }

                /// <summary>
                /// <para>The parent resource metadata.</para>
                /// </summary>
                [NameInMap("parentResourceInfo")]
                [Validation(Required=false)]
                public ParentResourceInfo ParentResourceInfo { get; set; }

                /// <summary>
                /// <para>The ID of the resource attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-d0j9t5em1hkncrlo51mg</para>
                /// </summary>
                [NameInMap("pluginAttachmentId")]
                [Validation(Required=false)]
                public string PluginAttachmentId { get; set; }

                /// <summary>
                /// <para>The plug-in type metadata.</para>
                /// </summary>
                [NameInMap("pluginClassInfo")]
                [Validation(Required=false)]
                public PluginClassInfo PluginClassInfo { get; set; }

                /// <summary>
                /// <para>The plug-in configurations (Base64-encoded).</para>
                /// 
                /// <b>Example:</b>
                /// <para>bGltaXRfYnlfaGVhZGVyOiB4LWFwaS1rZXkKbGltaXRfa2V5czoKLSBrZXk6IGV4YW1wbGUta2V5LWEKICBxdWVyeV9wZXJfc2Vjb25kOiAxMAotIGtleTogZXhhbXBsZS1rZXktYgogIHF1ZXJ5X3Blcl9zZWNvbmQ6IDEK</para>
                /// </summary>
                [NameInMap("pluginConfig")]
                [Validation(Required=false)]
                public string PluginConfig { get; set; }

                /// <summary>
                /// <para>The plug-in ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-cvu6r4um1hko3b3ti0a0</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>The information of resource attachments.</para>
                /// </summary>
                [NameInMap("resourceInfos")]
                [Validation(Required=false)]
                public List<ResourceInfo> ResourceInfos { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9640D776-794A-5077-9184-A247CA4B45C1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
