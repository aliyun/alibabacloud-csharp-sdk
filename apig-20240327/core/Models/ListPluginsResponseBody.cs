// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPluginsResponseBodyData Data { get; set; }
        public class ListPluginsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The plugin list.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListPluginsResponseBodyDataItems> Items { get; set; }
            public class ListPluginsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The plugin attachment information.</para>
                /// </summary>
                [NameInMap("attachmentInfo")]
                [Validation(Required=false)]
                public ListPluginsResponseBodyDataItemsAttachmentInfo AttachmentInfo { get; set; }
                public class ListPluginsResponseBodyDataItemsAttachmentInfo : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the plugin is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public string Enable { get; set; }

                    /// <summary>
                    /// <para>The plugin attachment ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pa-ct2irn6m1hkreaen0t40</para>
                    /// </summary>
                    [NameInMap("pluginAttachmentId")]
                    [Validation(Required=false)]
                    public string PluginAttachmentId { get; set; }

                }

                /// <summary>
                /// <para>The gateway information.</para>
                /// </summary>
                [NameInMap("gatewayInfo")]
                [Validation(Required=false)]
                public ListPluginsResponseBodyDataItemsGatewayInfo GatewayInfo { get; set; }
                public class ListPluginsResponseBodyDataItemsGatewayInfo : TeaModel {
                    /// <summary>
                    /// <para>The gateway ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gw-cq7og15lhtxx6qasrj60</para>
                    /// </summary>
                    [NameInMap("gatewayId")]
                    [Validation(Required=false)]
                    public string GatewayId { get; set; }

                    /// <summary>
                    /// <para>The gateway name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>apitest-gw</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The plugin type information.</para>
                /// </summary>
                [NameInMap("pluginClassInfo")]
                [Validation(Required=false)]
                public ListPluginsResponseBodyDataItemsPluginClassInfo PluginClassInfo { get; set; }
                public class ListPluginsResponseBodyDataItemsPluginClassInfo : TeaModel {
                    /// <summary>
                    /// <para>The alias.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>基于 Key 限流</para>
                    /// </summary>
                    [NameInMap("alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The execution priority.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>999</para>
                    /// </summary>
                    [NameInMap("executePriority")]
                    [Validation(Required=false)]
                    public string ExecutePriority { get; set; }

                    /// <summary>
                    /// <para>The execution stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AUTHZ</para>
                    /// </summary>
                    [NameInMap("executeStage")]
                    [Validation(Required=false)]
                    public string ExecuteStage { get; set; }

                    /// <summary>
                    /// <para>The plugin name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-rate-limit</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The plugin type ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pls-cqebrgh46ppatmpri</para>
                    /// </summary>
                    [NameInMap("pluginClassId")]
                    [Validation(Required=false)]
                    public string PluginClassId { get; set; }

                    /// <summary>
                    /// <para>The plugin source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HigressOfficial</para>
                    /// </summary>
                    [NameInMap("source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0.3</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    /// <summary>
                    /// <para>The version description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>版本描述</para>
                    /// </summary>
                    [NameInMap("versionDescription")]
                    [Validation(Required=false)]
                    public string VersionDescription { get; set; }

                }

                /// <summary>
                /// <para>The plugin ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-cvu6r4um1hko3b3ti0a0</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>168BA42D-F822-569D-A67F-FC59E6ABC2B1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
