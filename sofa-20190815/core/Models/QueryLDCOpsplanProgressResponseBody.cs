// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCOpsplanProgressResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AppExecuteProgress")]
        [Validation(Required=false)]
        public List<QueryLDCOpsplanProgressResponseBodyAppExecuteProgress> AppExecuteProgress { get; set; }
        public class QueryLDCOpsplanProgressResponseBodyAppExecuteProgress : TeaModel {
            [NameInMap("Blocked")]
            [Validation(Required=false)]
            public long? Blocked { get; set; }

            [NameInMap("Executing")]
            [Validation(Required=false)]
            public long? Executing { get; set; }

            [NameInMap("Failed")]
            [Validation(Required=false)]
            public long? Failed { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Inited")]
            [Validation(Required=false)]
            public long? Inited { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public long? Success { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            [NameInMap("Waiting")]
            [Validation(Required=false)]
            public long? Waiting { get; set; }

        }

        [NameInMap("ExecuteProgress")]
        [Validation(Required=false)]
        public QueryLDCOpsplanProgressResponseBodyExecuteProgress ExecuteProgress { get; set; }
        public class QueryLDCOpsplanProgressResponseBodyExecuteProgress : TeaModel {
            [NameInMap("Blocked")]
            [Validation(Required=false)]
            public long? Blocked { get; set; }
            [NameInMap("Executing")]
            [Validation(Required=false)]
            public long? Executing { get; set; }
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public long? Failed { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Inited")]
            [Validation(Required=false)]
            public long? Inited { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public long? Success { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Waiting")]
            [Validation(Required=false)]
            public long? Waiting { get; set; }
        };

    }

}
