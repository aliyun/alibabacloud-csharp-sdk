// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySmarttagJobResponseBody : TeaModel {
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public QuerySmarttagJobResponseBodyResults Results { get; set; }
        public class QuerySmarttagJobResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QuerySmarttagJobResponseBodyResultsResult> Result { get; set; }
            public class QuerySmarttagJobResponseBodyResultsResult : TeaModel {
                public string Data { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
