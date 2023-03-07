// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// The result of the command.
        /// </summary>
        [NameInMap("InvocationResults")]
        [Validation(Required=false)]
        public ListInvocationResultsResponseBodyInvocationResults InvocationResults { get; set; }
        public class ListInvocationResultsResponseBodyInvocationResults : TeaModel {
            [NameInMap("InvocationResult")]
            [Validation(Required=false)]
            public List<ListInvocationResultsResponseBodyInvocationResultsInvocationResult> InvocationResult { get; set; }
            public class ListInvocationResultsResponseBodyInvocationResultsInvocationResult : TeaModel {
                /// <summary>
                /// The ID of the command.
                /// </summary>
                [NameInMap("CommandId")]
                [Validation(Required=false)]
                public string CommandId { get; set; }

                /// <summary>
                /// The exit code.
                /// </summary>
                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public int? ExitCode { get; set; }

                /// <summary>
                /// The time at which the command entered the Finished state.
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                /// <summary>
                /// The ID of the node on which the command was run.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The status of the command. Valid values:
                /// 
                /// *   Finished
                /// *   Running
                /// *   Failed
                /// *   Stopped
                /// </summary>
                [NameInMap("InvokeRecordStatus")]
                [Validation(Required=false)]
                public string InvokeRecordStatus { get; set; }

                /// <summary>
                /// The output result.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Indicates whether the command was run and its result was obtained.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
