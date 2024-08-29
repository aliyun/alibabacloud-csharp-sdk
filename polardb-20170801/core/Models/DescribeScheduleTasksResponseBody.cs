// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksResponseBody : TeaModel {
        /// <summary>
        /// The result data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScheduleTasksResponseBodyData Data { get; set; }
        public class DescribeScheduleTasksResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the page returned.
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
            /// The details of the scheduled task.
            /// </summary>
            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<DescribeScheduleTasksResponseBodyDataTimerInfos> TimerInfos { get; set; }
            public class DescribeScheduleTasksResponseBodyDataTimerInfos : TeaModel {
                /// <summary>
                /// The type of the scheduled tasks.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The description of the cluster.
                /// </summary>
                [NameInMap("DbClusterDescription")]
                [Validation(Required=false)]
                public string DbClusterDescription { get; set; }

                /// <summary>
                /// The state of the cluster.
                /// </summary>
                [NameInMap("DbClusterStatus")]
                [Validation(Required=false)]
                public string DbClusterStatus { get; set; }

                /// <summary>
                /// The ID of the order.
                /// 
                /// >  This parameter is returned only when you set the `Action` parameter to **CreateDBNodes** or **ModifyDBNodeClass**.
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// The latest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.
                /// </summary>
                [NameInMap("PlannedEndTime")]
                [Validation(Required=false)]
                public string PlannedEndTime { get; set; }

                [NameInMap("PlannedFlashingOffTime")]
                [Validation(Required=false)]
                public string PlannedFlashingOffTime { get; set; }

                /// <summary>
                /// The earliest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.
                /// </summary>
                [NameInMap("PlannedStartTime")]
                [Validation(Required=false)]
                public string PlannedStartTime { get; set; }

                /// <summary>
                /// The expected start time of the task. The time is displayed in UTC.
                /// </summary>
                [NameInMap("PlannedTime")]
                [Validation(Required=false)]
                public string PlannedTime { get; set; }

                /// <summary>
                /// The ID of the region in which the scheduled task runs.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The state of the scheduled task.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Indicates whether the scheduled task can be canceled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("TaskCancel")]
                [Validation(Required=false)]
                public bool? TaskCancel { get; set; }

                /// <summary>
                /// The ID of the task.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }

        }

        /// <summary>
        /// The message that is returned for the request.
        /// 
        /// >  If the request is successful, **Successful** is returned. If the request fails, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
