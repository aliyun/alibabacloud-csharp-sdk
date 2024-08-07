// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataResponseBodyResult Result { get; set; }
        public class QueryDataResponseBodyResult : TeaModel {
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataResponseBodyResultHeaders : TeaModel {
                [NameInMap("Aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
