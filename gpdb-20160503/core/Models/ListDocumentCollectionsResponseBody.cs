// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListDocumentCollectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The queried document collections.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListDocumentCollectionsResponseBodyItems Items { get; set; }
        public class ListDocumentCollectionsResponseBodyItems : TeaModel {
            [NameInMap("CollectionList")]
            [Validation(Required=false)]
            public List<ListDocumentCollectionsResponseBodyItemsCollectionList> CollectionList { get; set; }
            public class ListDocumentCollectionsResponseBodyItemsCollectionList : TeaModel {
                /// <summary>
                /// <para>The name of the document collection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document</para>
                /// </summary>
                [NameInMap("CollectionName")]
                [Validation(Required=false)]
                public string CollectionName { get; set; }

                /// <summary>
                /// <para>The number of vector dimensions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1536</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public int? Dimension { get; set; }

                /// <summary>
                /// <para>The name of the vector algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text-embeddding-v1</para>
                /// </summary>
                [NameInMap("EmbeddingModel")]
                [Validation(Required=false)]
                public string EmbeddingModel { get; set; }

                /// <summary>
                /// <para>The fields that are used for full-text search. Multiple fields are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("FullTextRetrievalFields")]
                [Validation(Required=false)]
                public string FullTextRetrievalFields { get; set; }

                /// <summary>
                /// <para>The metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;page\&quot;: \&quot;int\&quot;, \&quot;title\&quot;: \&quot;text\&quot;}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                /// <summary>
                /// <para>The vector similarity algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cosine</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public string Metrics { get; set; }

                /// <summary>
                /// <para>The analyzer that is used for full-text search.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh_cn</para>
                /// </summary>
                [NameInMap("Parser")]
                [Validation(Required=false)]
                public string Parser { get; set; }

                [NameInMap("SparseRetrievalFields")]
                [Validation(Required=false)]
                public string SparseRetrievalFields { get; set; }

                [NameInMap("SupportSparse")]
                [Validation(Required=false)]
                public bool? SupportSparse { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>fail</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
