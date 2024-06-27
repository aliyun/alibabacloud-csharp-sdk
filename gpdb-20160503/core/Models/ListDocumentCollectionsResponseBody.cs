// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListDocumentCollectionsResponseBody : TeaModel {
        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The queried document collections.
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
                /// The name of the document collection.
                /// </summary>
                [NameInMap("CollectionName")]
                [Validation(Required=false)]
                public string CollectionName { get; set; }

                /// <summary>
                /// The number of vector dimensions.
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public int? Dimension { get; set; }

                /// <summary>
                /// The name of the vector algorithm.
                /// </summary>
                [NameInMap("EmbeddingModel")]
                [Validation(Required=false)]
                public string EmbeddingModel { get; set; }

                /// <summary>
                /// The fields that are used for full-text search. Multiple fields are separated by commas (,).
                /// </summary>
                [NameInMap("FullTextRetrievalFields")]
                [Validation(Required=false)]
                public string FullTextRetrievalFields { get; set; }

                /// <summary>
                /// The metadata.
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                /// <summary>
                /// The vector similarity algorithm.
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public string Metrics { get; set; }

                /// <summary>
                /// The analyzer that is used for full-text search.
                /// </summary>
                [NameInMap("Parser")]
                [Validation(Required=false)]
                public string Parser { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **success**
        /// *   **fail**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
