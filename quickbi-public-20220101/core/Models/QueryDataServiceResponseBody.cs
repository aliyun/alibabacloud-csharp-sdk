// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceResponseBodyResult Result { get; set; }
        public class QueryDataServiceResponseBodyResult : TeaModel {
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataServiceResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataServiceResponseBodyResultHeaders : TeaModel {
                public string Aggregator { get; set; }
                public string Column { get; set; }
                public string DataType { get; set; }
                public string Granularity { get; set; }
                public string Label { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
