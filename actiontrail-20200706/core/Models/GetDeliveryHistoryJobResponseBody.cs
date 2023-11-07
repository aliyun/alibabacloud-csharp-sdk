// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetDeliveryHistoryJobResponseBody : TeaModel {
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
        /// The ID of the task.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the task started.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// A list of task statuses in each region.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<GetDeliveryHistoryJobResponseBodyStatus> Status { get; set; }
        public class GetDeliveryHistoryJobResponseBodyStatus : TeaModel {
            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The task status in each region. Valid values:
            /// 
            /// *   0: The task is initializing.
            /// *   1: The task is delivering historical events.
            /// *   2: The task is complete.
            /// *   3: The task fails.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The name of the trail based on which the task delivers events.
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

}
