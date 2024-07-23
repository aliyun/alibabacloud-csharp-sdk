// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Index.InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIndicesResponseBodyData Data { get; set; }
        public class ListIndicesResponseBodyData : TeaModel {
            [NameInMap("Indices")]
            [Validation(Required=false)]
            public List<ListIndicesResponseBodyDataIndices> Indices { get; set; }
            public class ListIndicesResponseBodyDataIndices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public int? ChunkSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>If each RAM user belongs to a RAM group, the configuration is considered compliant.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DocumentIds")]
                [Validation(Required=false)]
                public List<string> DocumentIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>conv-rewrite-qwen-1.8b</para>
                /// </summary>
                [NameInMap("EmbeddingModelName")]
                [Validation(Required=false)]
                public string EmbeddingModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>259899</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>temp_mUB4j</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OverlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("RerankMinScore")]
                [Validation(Required=false)]
                public string RerankMinScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gte-rerank-hybrid</para>
                /// </summary>
                [NameInMap("RerankModelName")]
                [Validation(Required=false)]
                public string RerankModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>\n</para>
                /// </summary>
                [NameInMap("Separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gp-bp1gq62t1788yw2ol</para>
                /// </summary>
                [NameInMap("SinkInstanceId")]
                [Validation(Required=false)]
                public string SinkInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SinkRegion")]
                [Validation(Required=false)]
                public string SinkRegion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>es</para>
                /// </summary>
                [NameInMap("SinkType")]
                [Validation(Required=false)]
                public string SinkType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DATA_CENTER_FILE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>structured</para>
                /// </summary>
                [NameInMap("StructureType")]
                [Validation(Required=false)]
                public string StructureType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Required parameter(%s) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
