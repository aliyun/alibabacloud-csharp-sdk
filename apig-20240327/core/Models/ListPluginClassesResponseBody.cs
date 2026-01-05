// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginClassesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPluginClassesResponseBodyData Data { get; set; }
        public class ListPluginClassesResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListPluginClassesResponseBodyDataItems> Items { get; set; }
            public class ListPluginClassesResponseBodyDataItems : TeaModel {
                [NameInMap("alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("installed")]
                [Validation(Required=false)]
                public bool? Installed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oauth</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pls-d4ghv6em1hkixxxxxxxx</para>
                /// </summary>
                [NameInMap("pluginClassId")]
                [Validation(Required=false)]
                public string PluginClassId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pl-cvu6r4um1hkoxxxxxxxx</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("publishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HigressOfficial</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.0.0</para>
                /// </summary>
                [NameInMap("supportedMinGatewayVersion")]
                [Validation(Required=false)]
                public string SupportedMinGatewayVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Auth</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

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
        /// <b>Example:</b>
        /// <para>61EBF577-1601-51E1-B136-9CD6xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
