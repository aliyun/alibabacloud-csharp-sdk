// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRemediationExecutionsResponseBody : TeaModel {
        /// <summary>
        /// The queried remediation records.
        /// </summary>
        [NameInMap("RemediationExecutionData")]
        [Validation(Required=false)]
        public ListRemediationExecutionsResponseBodyRemediationExecutionData RemediationExecutionData { get; set; }
        public class ListRemediationExecutionsResponseBodyRemediationExecutionData : TeaModel {
            /// <summary>
            /// The maximum number of entries to return for a single request.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// A pagination token. It can be used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The queried remediation records.
            /// </summary>
            [NameInMap("RemediationExecutions")]
            [Validation(Required=false)]
            public List<ListRemediationExecutionsResponseBodyRemediationExecutionDataRemediationExecutions> RemediationExecutions { get; set; }
            public class ListRemediationExecutionsResponseBodyRemediationExecutionDataRemediationExecutions : TeaModel {
                /// <summary>
                /// The time when the remediation record was created.
                /// </summary>
                [NameInMap("ExecutionCreateDate")]
                [Validation(Required=false)]
                public string ExecutionCreateDate { get; set; }

                /// <summary>
                /// The invocation ID of the remediation record.
                /// </summary>
                [NameInMap("ExecutionInvocationId")]
                [Validation(Required=false)]
                public string ExecutionInvocationId { get; set; }

                /// <summary>
                /// The IDs of the resources to which the remediation belongs. Separate multiple resource IDs with commas (,).
                /// </summary>
                [NameInMap("ExecutionResourceIds")]
                [Validation(Required=false)]
                public string ExecutionResourceIds { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("ExecutionResourceType")]
                [Validation(Required=false)]
                public string ExecutionResourceType { get; set; }

                /// <summary>
                /// The status of the remediation record. Valid values:
                /// 
                /// *   Success
                /// *   Failed
                /// </summary>
                [NameInMap("ExecutionStatus")]
                [Validation(Required=false)]
                public string ExecutionStatus { get; set; }

                /// <summary>
                /// The error message returned when the remediation fails.
                /// </summary>
                [NameInMap("ExecutionStatusMessage")]
                [Validation(Required=false)]
                public string ExecutionStatusMessage { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
