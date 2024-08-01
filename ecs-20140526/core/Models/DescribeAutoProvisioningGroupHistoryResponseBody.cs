// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupHistoryResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of AutoProvisioningGroupHistory data.
        /// </summary>
        [NameInMap("AutoProvisioningGroupHistories")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories AutoProvisioningGroupHistories { get; set; }
        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories : TeaModel {
            [NameInMap("AutoProvisioningGroupHistory")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory> AutoProvisioningGroupHistory { get; set; }
            public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory : TeaModel {
                /// <summary>
                /// An array consisting of ActivityDetail data.
                /// </summary>
                [NameInMap("ActivityDetails")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails ActivityDetails { get; set; }
                public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails : TeaModel {
                    [NameInMap("ActivityDetail")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail> ActivityDetail { get; set; }
                    public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail : TeaModel {
                        /// <summary>
                        /// The execution details of instance creation performed by the single scheduling task.
                        /// </summary>
                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                        /// <summary>
                        /// The execution status of instance creation performed by the single scheduling task. Valid values:
                        /// 
                        /// *   Successful: Instances are created.
                        /// *   Failed: Instances failed to be created.
                        /// *   InProgress: Instances are being created.
                        /// *   Warning: Some instances are created.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The execution time of the last instance creation performed by the single scheduling task.
                /// </summary>
                [NameInMap("LastEventTime")]
                [Validation(Required=false)]
                public string LastEventTime { get; set; }

                /// <summary>
                /// The start time of executing the single scheduling task.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The execution status of the single scheduling task. Valid values:
                /// 
                /// *   prepare: The scheduling task is being executed.
                /// *   success: The scheduling task is executed.
                /// *   failed: The scheduling task failed to be executed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the scheduling task.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

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
        /// The number of queried scheduling tasks in the auto provisioning group.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
