// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListFailureMsgsResponseBody : TeaModel {
        [NameInMap("FailureMsgs")]
        [Validation(Required=false)]
        public List<ListFailureMsgsResponseBodyFailureMsgs> FailureMsgs { get; set; }
        public class ListFailureMsgsResponseBodyFailureMsgs : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            [NameInMap("MessageBody")]
            [Validation(Required=false)]
            public string MessageBody { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("TaskExecutionId")]
            [Validation(Required=false)]
            public string TaskExecutionId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
