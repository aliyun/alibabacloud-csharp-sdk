// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListNacosMcpServersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNacosMcpServersResponseBodyData Data { get; set; }
        public class ListNacosMcpServersResponseBodyData : TeaModel {
            [NameInMap("PageItems")]
            [Validation(Required=false)]
            public List<ListNacosMcpServersResponseBodyDataPageItems> PageItems { get; set; }
            public class ListNacosMcpServersResponseBodyDataPageItems : TeaModel {
                [NameInMap("Capabilities")]
                [Validation(Required=false)]
                public List<string> Capabilities { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mcp-sse</para>
                /// </summary>
                [NameInMap("FrontProtocol")]
                [Validation(Required=false)]
                public string FrontProtocol { get; set; }

                /// <summary>
                /// <para>ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2385420b-6176-4a37-aba4-d3d382e4bb84</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>stdio</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("VersionDetail")]
                [Validation(Required=false)]
                public ListNacosMcpServersResponseBodyDataPageItemsVersionDetail VersionDetail { get; set; }
                public class ListNacosMcpServersResponseBodyDataPageItemsVersionDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Is_latest")]
                    [Validation(Required=false)]
                    public bool? IsLatest { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-07-16</para>
                    /// </summary>
                    [NameInMap("Release_date")]
                    [Validation(Required=false)]
                    public string ReleaseDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>pageNumber.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>pagesAvailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADDD8AB7-8D1C-4697-A83E-410D2607****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
