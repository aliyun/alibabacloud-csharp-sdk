// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListDocumentCollectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListDocumentCollectionsResponseBodyItems Items { get; set; }
        public class ListDocumentCollectionsResponseBodyItems : TeaModel {
            [NameInMap("CollectionList")]
            [Validation(Required=false)]
            public List<ListDocumentCollectionsResponseBodyItemsCollectionList> CollectionList { get; set; }
            public class ListDocumentCollectionsResponseBodyItemsCollectionList : TeaModel {
                [NameInMap("CollectionName")]
                [Validation(Required=false)]
                public string CollectionName { get; set; }

                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public int? Dimension { get; set; }

                [NameInMap("EmbeddingModel")]
                [Validation(Required=false)]
                public string EmbeddingModel { get; set; }

                [NameInMap("FullTextRetrievalFields")]
                [Validation(Required=false)]
                public string FullTextRetrievalFields { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public string Metrics { get; set; }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The creation status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b>: The operation succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>fail</b>: The operation failed.</para>
        /// </description></item>
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
