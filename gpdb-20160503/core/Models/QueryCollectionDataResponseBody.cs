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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
