// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginsResponseBody : TeaModel {
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
        public ListPluginsResponseBodyData Data { get; set; }
        public class ListPluginsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of plug-in information.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListPluginsResponseBodyDataItems> Items { get; set; }
            public class ListPluginsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The attachment information.</para>
                /// </summary>
                [NameInMap("attachmentInfo")]
                [Validation(Required=false)]
                public ListPluginsResponseBodyDataItemsAttachmentInfo AttachmentInfo { get; set; }
                public class ListPluginsResponseBodyDataItemsAttachmentInfo : TeaModel {
                    /// <summary>
                    /// <para>Indicates if enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public string Enable { get; set; }

                    /// <summary>
                    /// <para>The attachment ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pa-ct2irn6m1hkreaen0t40</para>
                    /// </summary>
                    [NameInMap("pluginAttachmentId")]
                    [Validation(Required=false)]
                    public string PluginAttachmentId { get; set; }

                }

                /// <summary>
                /// <para>The gateway instance information.</para>
                /// </summary>
                [NameInMap("gatewayInfo")]
                [Validation(Required=false)]
                public ListPluginsResponseBodyDataItemsGatewayInfo GatewayInfo { get; set; }
                public class ListPluginsResponseBodyDataItemsGatewayInfo : TeaModel {
                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gw-cq7og15lhtxx6qasrj60</para>
                    /// </summary>
                    [NameInMap("gatewayId")]
                    [Validation(Required=false)]
                    public string GatewayId { get; set; }

                    /// <summary>
                    /// <para>The instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>apitest-gw</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The plug-in type information.</para>
                /// </summary>
                [NameInMap("pluginClassInfo")]
                [Validation(Required=false)]
                public ListPluginsResponseBodyDataItemsPluginClassInfo PluginClassInfo { get; set; }
                public class ListPluginsResponseBodyDataItemsPluginClassInfo : TeaModel {
                    /// <summary>
                    /// <para>The alias.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-based rate limit</para>
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
                    /// <para>The name of the plug-in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-rate-limit</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The plug-in type ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pls-cqebrgh46ppatmpri</para>
                    /// </summary>
                    [NameInMap("pluginClassId")]
                    [Validation(Required=false)]
                    public string PluginClassId { get; set; }

                    /// <summary>
                    /// <para>The source of the plug-in.</para>
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
                    /// <para>The description of the version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>version description</para>
                    /// </summary>
                    [NameInMap("versionDescription")]
                    [Validation(Required=false)]
                    public string VersionDescription { get; set; }

                }

                /// <summary>
                /// <para>The plug-in ID.</para>
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
        /// <para>168BA42D-F822-569D-A67F-FC59E6ABC2B1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
