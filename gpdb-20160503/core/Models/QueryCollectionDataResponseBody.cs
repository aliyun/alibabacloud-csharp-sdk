// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryCollectionDataResponseBody : TeaModel {
        /// <summary>
        /// The retrieved data.
        /// </summary>
        [NameInMap("Matches")]
        [Validation(Required=false)]
        public QueryCollectionDataResponseBodyMatches Matches { get; set; }
        public class QueryCollectionDataResponseBodyMatches : TeaModel {
            [NameInMap("match")]
            [Validation(Required=false)]
            public List<QueryCollectionDataResponseBodyMatchesMatch> Match { get; set; }
            public class QueryCollectionDataResponseBodyMatchesMatch : TeaModel {
                /// <summary>
                /// The unique ID of the vector data.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The metadata.
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                /// <summary>
                /// The similarity score of the data. It is related to the `l2, ip, or cosine` algorithm that is specified when you create an index.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// The retrieved vector data.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public QueryCollectionDataResponseBodyMatchesMatchValues Values { get; set; }
                public class QueryCollectionDataResponseBodyMatchesMatchValues : TeaModel {
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public List<double?> Value { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The total number of entries that match the search conditions. This parameter is returned only when the Offset parameter is not 0.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
