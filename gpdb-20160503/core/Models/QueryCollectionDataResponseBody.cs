// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryCollectionDataResponseBody : TeaModel {
        [NameInMap("Matches")]
        [Validation(Required=false)]
        public QueryCollectionDataResponseBodyMatches Matches { get; set; }
        public class QueryCollectionDataResponseBodyMatches : TeaModel {
            [NameInMap("match")]
            [Validation(Required=false)]
            public List<QueryCollectionDataResponseBodyMatchesMatch> Match { get; set; }
            public class QueryCollectionDataResponseBodyMatchesMatch : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                [NameInMap("MetadataV2")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetadataV2 { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("SparseValues")]
                [Validation(Required=false)]
                public QueryCollectionDataResponseBodyMatchesMatchSparseValues SparseValues { get; set; }
                public class QueryCollectionDataResponseBodyMatchesMatchSparseValues : TeaModel {
                    [NameInMap("Indices")]
                    [Validation(Required=false)]
                    public QueryCollectionDataResponseBodyMatchesMatchSparseValuesIndices Indices { get; set; }
                    public class QueryCollectionDataResponseBodyMatchesMatchSparseValuesIndices : TeaModel {
                        [NameInMap("Indice")]
                        [Validation(Required=false)]
                        public List<int?> Indice { get; set; }

                    }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public QueryCollectionDataResponseBodyMatchesMatchSparseValuesValues Values { get; set; }
                    public class QueryCollectionDataResponseBodyMatchesMatchSparseValuesValues : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public List<float?> Value { get; set; }

                    }

                }

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

        /// <summary>
        /// <para>Detailed information when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1234</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: Success.</description></item>
        /// <item><description><b>fail</b>: Failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Only returned when the Offset is not 0, this value represents the total number of hits for the search criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
