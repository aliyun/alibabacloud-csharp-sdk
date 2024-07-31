// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicResponseBody : TeaModel {
        /// <summary>
        /// The details of the event.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicResponseBodyData Data { get; set; }
        public class GetTopicResponseBodyData : TeaModel {
            /// <summary>
            /// The timestamp when the event was found.
            /// </summary>
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public long? AddTime { get; set; }

            /// <summary>
            /// The timestamp when the first alert was reported.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the alert recipient.
            /// </summary>
            [NameInMap("Assigner")]
            [Validation(Required=false)]
            public string Assigner { get; set; }

            /// <summary>
            /// The margin of the worst baseline instance. Unit: seconds.
            /// </summary>
            [NameInMap("BaselineBuffer")]
            [Validation(Required=false)]
            public long? BaselineBuffer { get; set; }

            /// <summary>
            /// The ID of the baseline to which the worst baseline instance belongs.
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// The ID of the cycle of the worst baseline instance.
            /// </summary>
            [NameInMap("BaselineInGroupId")]
            [Validation(Required=false)]
            public int? BaselineInGroupId { get; set; }

            /// <summary>
            /// The name of the baseline to which the worst baseline instance belongs.
            /// </summary>
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// The status of the baseline. Valid values: ERROR, SAFE, DANGROUS, and OVER. The value ERROR indicates that no nodes are associated with the baseline, or all nodes associated with the baseline are suspended. The value SAFE indicates that nodes are run before the alert duration begins. The value DANGROUS indicates that nodes are still running after the alert duration ends but the committed completion time does not arrive. The value OVER indicates that nodes are still running after the committed completion time.
            /// </summary>
            [NameInMap("BaselineStatus")]
            [Validation(Required=false)]
            public string BaselineStatus { get; set; }

            /// <summary>
            /// The margin of the event. Unit: seconds.
            /// </summary>
            [NameInMap("Buffer")]
            [Validation(Required=false)]
            public long? Buffer { get; set; }

            /// <summary>
            /// The timestamp when the event was last processed.
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the user who last processed the event.
            /// </summary>
            [NameInMap("DealUser")]
            [Validation(Required=false)]
            public string DealUser { get; set; }

            /// <summary>
            /// The timestamp when the event was processed.
            /// </summary>
            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public long? FixTime { get; set; }

            /// <summary>
            /// The timestamp when the event occurred. A time difference may exist between the time when the event occurred and the time when the event was found.
            /// </summary>
            [NameInMap("HappenTime")]
            [Validation(Required=false)]
            public long? HappenTime { get; set; }

            /// <summary>
            /// The ID of the instance that triggered the event.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The timestamp when the system reports the next alert.
            /// </summary>
            [NameInMap("NextAlertTime")]
            [Validation(Required=false)]
            public long? NextAlertTime { get; set; }

            /// <summary>
            /// The ID of the node that triggered the event.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// The name of the node that triggered the event.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the event owner.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The ID of the workspace to which the node that triggered the event belongs.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The event ID.
            /// </summary>
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

            /// <summary>
            /// The name of the event.
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// The status of the event. Valid values: IGNORE, NEW, FIXING, and RECOVER.
            /// </summary>
            [NameInMap("TopicStatus")]
            [Validation(Required=false)]
            public string TopicStatus { get; set; }

            /// <summary>
            /// The type of the event. Valid values: SLOW and ERROR. The value SLOW indicates that the duration of the task is significantly longer than the average duration of the task in previous cycles. The value ERROR indicates that the task fails to run.
            /// </summary>
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
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
