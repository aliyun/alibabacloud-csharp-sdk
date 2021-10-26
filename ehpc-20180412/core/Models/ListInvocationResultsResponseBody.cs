// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInvocationResultsResponseBody : TeaModel {
        [NameInMap("InvocationResults")]
        [Validation(Required=false)]
        public ListInvocationResultsResponseBodyInvocationResults InvocationResults { get; set; }
        public class ListInvocationResultsResponseBodyInvocationResults : TeaModel {
            [NameInMap("InvocationResult")]
            [Validation(Required=false)]
            public List<ListInvocationResultsResponseBodyInvocationResultsInvocationResult> InvocationResult { get; set; }
            public class ListInvocationResultsResponseBodyInvocationResultsInvocationResult : TeaModel {
                public string CommandId { get; set; }
                public int? ExitCode { get; set; }
                public string FinishedTime { get; set; }
                public string InstanceId { get; set; }
                public string InvokeRecordStatus { get; set; }
                public string Message { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
