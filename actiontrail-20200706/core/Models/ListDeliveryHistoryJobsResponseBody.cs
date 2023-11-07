// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDeliveryHistoryJobsResponseBody : TeaModel {
        /// <summary>
        /// The list of historical event delivery tasks.
        /// </summary>
        [NameInMap("DeliveryHistoryJobs")]
        [Validation(Required=false)]
        public List<ListDeliveryHistoryJobsResponseBodyDeliveryHistoryJobs> DeliveryHistoryJobs { get; set; }
        public class ListDeliveryHistoryJobsResponseBodyDeliveryHistoryJobs : TeaModel {
            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The time when the task ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The home region of the trail.
            /// </summary>
            [NameInMap("HomeRegion")]
            [Validation(Required=false)]
            public string HomeRegion { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// The task status. Valid values:
            /// 
            /// *   0: The task is initializing.
            /// *   1: The task is delivering historical events.
            /// *   2: The task is complete.
            /// *   3: The task fails.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            /// <summary>
            /// The time when the task started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The name of the trail.
            /// </summary>
            [NameInMap("TrailName")]
            [Validation(Required=false)]
            public string TrailName { get; set; }

            /// <summary>
            /// The time when the task was updated.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The number of historical event delivery tasks returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
