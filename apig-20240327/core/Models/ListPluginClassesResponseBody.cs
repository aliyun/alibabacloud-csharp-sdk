// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginClassesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPluginClassesResponseBodyData Data { get; set; }
        public class ListPluginClassesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The plugin details.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListPluginClassesResponseBodyDataItems> Items { get; set; }
            public class ListPluginClassesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The alias of the plugin.</para>
                /// </summary>
                [NameInMap("alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The description of the plugin.</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the plugin is installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("installed")]
                [Validation(Required=false)]
                public bool? Installed { get; set; }

                /// <summary>
                /// <para>The plugin name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oauth</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The plugin type ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pls-d4ghv6em1hkixxxxxxxx</para>
                /// </summary>
                [NameInMap("pluginClassId")]
                [Validation(Required=false)]
                public string PluginClassId { get; set; }

                /// <summary>
                /// <para>The plugin ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-cvu6r4um1hkoxxxxxxxx</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>The publishing status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("publishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// <para>The source of the plugin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HigressOfficial</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The minimum version of the gateway supported by the plugin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0.0</para>
                /// </summary>
                [NameInMap("supportedMinGatewayVersion")]
                [Validation(Required=false)]
                public string SupportedMinGatewayVersion { get; set; }

                /// <summary>
                /// <para>The type of the plugin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Auth</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

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
            /// <para>The number of entries per page.</para>
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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>61EBF577-1601-51E1-B136-9CD6xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
