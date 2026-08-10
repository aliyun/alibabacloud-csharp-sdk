// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SearchKgBySemanticResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The search results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchKgBySemanticResponseBodyData Data { get; set; }
        public class SearchKgBySemanticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of search results.</para>
            /// </summary>
            [NameInMap("SearchResults")]
            [Validation(Required=false)]
            public List<SearchKgBySemanticResponseBodyDataSearchResults> SearchResults { get; set; }
            public class SearchKgBySemanticResponseBodyDataSearchResults : TeaModel {
                /// <summary>
                /// <para>The ID of the matched entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemId</para>
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The entity type code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EntityTypeCode1</para>
                /// </summary>
                [NameInMap("ItemTypeCode")]
                [Validation(Required=false)]
                public string ItemTypeCode { get; set; }

                /// <summary>
                /// <para>The property code that matched the semantic search.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("MatchedPropertyCode")]
                [Validation(Required=false)]
                public string MatchedPropertyCode { get; set; }

                /// <summary>
                /// <para>The actual value of the matched property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("MatchedPropertyValue")]
                [Validation(Required=false)]
                public string MatchedPropertyValue { get; set; }

                /// <summary>
                /// <para>The similarity score ranging from 0.0 to 1.0, based on cosine similarity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.88</para>
                /// </summary>
                [NameInMap("SimilarityScore")]
                [Validation(Required=false)]
                public float? SimilarityScore { get; set; }

            }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640276</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
