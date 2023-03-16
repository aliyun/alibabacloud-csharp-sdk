// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineStatusesResponseBody : TeaModel {
        /// <summary>
        /// The list of baseline instances returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselineStatusesResponseBodyData Data { get; set; }
        public class ListBaselineStatusesResponseBodyData : TeaModel {
            /// <summary>
            /// The list of baseline instances.
            /// </summary>
            [NameInMap("BaselineStatuses")]
            [Validation(Required=false)]
            public List<ListBaselineStatusesResponseBodyDataBaselineStatuses> BaselineStatuses { get; set; }
            public class ListBaselineStatusesResponseBodyDataBaselineStatuses : TeaModel {
                /// <summary>
                /// The ID of the baseline.
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// The name of the baseline.
                /// </summary>
                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                /// <summary>
                /// The data timestamp of the baseline instance.
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// The margin of the baseline instance. Unit: seconds.
                /// </summary>
                [NameInMap("Buffer")]
                [Validation(Required=false)]
                public long? Buffer { get; set; }

                /// <summary>
                /// The predicted time when the baseline instance finished running.
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// The alerting time of the baseline instance.
                /// </summary>
                [NameInMap("ExpTime")]
                [Validation(Required=false)]
                public long? ExpTime { get; set; }

                /// <summary>
                /// The status of the baseline instance. Valid values: UNFINISH and FINISH. The value UNFINISH indicates that the baseline instance is still running. The value FINISH indicates that the baseline instance finishes running.
                /// </summary>
                [NameInMap("FinishStatus")]
                [Validation(Required=false)]
                public string FinishStatus { get; set; }

                /// <summary>
                /// The timestamp of the actual time when the baseline instance finished running. This parameter is returned if the value of the FinishStatus parameter is FINISH.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// The ID of the scheduling cycle of the baseline instance. For a baseline instance that is scheduled by day, the value of this parameter is 1. For a baseline instance that is scheduled by hour, the value of this parameter ranges from 1 to 24.
                /// </summary>
                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs are separated by commas (,).
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The priority of the baseline. Valid values: 1, 3, 5, 7, and 8.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The ID of the workspace to which the baseline belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The actual time when the baseline instance finished running.
                /// </summary>
                [NameInMap("SlaTime")]
                [Validation(Required=false)]
                public long? SlaTime { get; set; }

                /// <summary>
                /// The status of the baseline. Valid values: ERROR, SAFE, DANGEROUS, and OVER. The value ERROR indicates that no nodes are associated with the baseline, or all nodes associated with the baseline are suspended. The value SAFE indicates that nodes finish running before the alerting time. The value DANGEROUS indicates that nodes are still running after the alerting time but before the committed completion time. The value OVER indicates that nodes are still running after the committed completion time.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
            /// The total number of baseline instances.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
