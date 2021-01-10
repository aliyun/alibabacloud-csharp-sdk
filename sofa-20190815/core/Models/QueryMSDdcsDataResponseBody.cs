// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMSDdcsDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QueryResult")]
        [Validation(Required=false)]
        public List<QueryMSDdcsDataResponseBodyQueryResult> QueryResult { get; set; }
        public class QueryMSDdcsDataResponseBodyQueryResult : TeaModel {
            [NameInMap("Cell")]
            [Validation(Required=false)]
            public string Cell { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

    }

}
