// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateRemediationExecutionsResponseBody : TeaModel {
        [NameInMap("RemediationExecutionData")]
        [Validation(Required=false)]
        public ListAggregateRemediationExecutionsResponseBodyRemediationExecutionData RemediationExecutionData { get; set; }
        public class ListAggregateRemediationExecutionsResponseBodyRemediationExecutionData : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("RemediationExecutions")]
            [Validation(Required=false)]
            public List<ListAggregateRemediationExecutionsResponseBodyRemediationExecutionDataRemediationExecutions> RemediationExecutions { get; set; }
            public class ListAggregateRemediationExecutionsResponseBodyRemediationExecutionDataRemediationExecutions : TeaModel {
                [NameInMap("ExecutionCreateDate")]
                [Validation(Required=false)]
                public string ExecutionCreateDate { get; set; }

                [NameInMap("ExecutionInvocationId")]
                [Validation(Required=false)]
                public string ExecutionInvocationId { get; set; }

                [NameInMap("ExecutionResourceIds")]
                [Validation(Required=false)]
                public string ExecutionResourceIds { get; set; }

                [NameInMap("ExecutionResourceType")]
                [Validation(Required=false)]
                public string ExecutionResourceType { get; set; }

                [NameInMap("ExecutionStatus")]
                [Validation(Required=false)]
                public string ExecutionStatus { get; set; }

                [NameInMap("ExecutionStatusMessage")]
                [Validation(Required=false)]
                public string ExecutionStatusMessage { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
