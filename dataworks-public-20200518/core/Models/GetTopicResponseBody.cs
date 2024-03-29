// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicResponseBody : TeaModel {
        /// <summary>
        /// The name of the event.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicResponseBodyData Data { get; set; }
        public class GetTopicResponseBodyData : TeaModel {
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public long? AddTime { get; set; }

            /// <summary>
            /// The ID of the Apsara Stack tenant account used by the alert recipient.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// The timestamp when the event was found.
            /// </summary>
            [NameInMap("Assigner")]
            [Validation(Required=false)]
            public string Assigner { get; set; }

            /// <summary>
            /// The status of the event. Valid values: IGNORE, NEW, FIXING, and RECOVER. A value of IGNORE indicates that the event is ignored. A value of NEW indicates that the event is a new event. A value of FIXING indicates that the event is being processed. A value of RECOVER indicates that the event is processed.
            /// </summary>
            [NameInMap("BaselineBuffer")]
            [Validation(Required=false)]
            public long? BaselineBuffer { get; set; }

            /// <summary>
            /// The timestamp when the first alert was reported.
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// The type of the event. Valid values: SLOW and ERROR. A value of SLOW indicates that the duration of the task is significantly longer than the average duration of the task in previous cycles. A value of ERROR indicates that the task fails to run.
            /// </summary>
            [NameInMap("BaselineInGroupId")]
            [Validation(Required=false)]
            public int? BaselineInGroupId { get; set; }

            /// <summary>
            /// The name of the node that triggered the event.
            /// </summary>
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// The timestamp when the system reports the next alert.
            /// </summary>
            [NameInMap("BaselineStatus")]
            [Validation(Required=false)]
            public string BaselineStatus { get; set; }

            /// <summary>
            /// The ID of the event.
            /// </summary>
            [NameInMap("Buffer")]
            [Validation(Required=false)]
            public long? Buffer { get; set; }

            /// <summary>
            /// The name of the baseline to which the worst baseline instance belongs.
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// The ID of the baseline to which the worst baseline instance belongs.
            /// </summary>
            [NameInMap("DealUser")]
            [Validation(Required=false)]
            public string DealUser { get; set; }

            /// <summary>
            /// The margin of the worst baseline instance. Unit: seconds.
            /// </summary>
            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public long? FixTime { get; set; }

            /// <summary>
            /// The ID of the Apsara Stack tenant account used by the user who last processed the event.
            /// </summary>
            [NameInMap("HappenTime")]
            [Validation(Required=false)]
            public long? HappenTime { get; set; }

            /// <summary>
            /// The ID of the cycle of the worst baseline instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The timestamp when the event was processed.
            /// </summary>
            [NameInMap("NextAlertTime")]
            [Validation(Required=false)]
            public long? NextAlertTime { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// The margin of the event. Unit: seconds.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The status of the baseline. Valid values: ERROR, SAFE, DANGROUS, and OVER. A value of ERROR indicates that no nodes are associated with the baseline, or all nodes associated with the baseline are suspended. A value of SAFE indicates that nodes are run before the alert duration begins. A value of DANGROUS indicates that nodes are still running after the alert duration ends but the committed time does not arrive. A value of OVER indicates that nodes are still running after the committed time.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The ID of the instance that triggered the event.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The ID of the node that triggered the event.
            /// </summary>
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

            /// <summary>
            /// The ID of the workspace to which the node that triggered the event belongs.
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// The timestamp when the event was last processed.
            /// </summary>
            [NameInMap("TopicStatus")]
            [Validation(Required=false)]
            public string TopicStatus { get; set; }

            /// <summary>
            /// The timestamp when the system event occurred. A time difference may exist between the time when the event occurred and the time when the event was found.
            /// </summary>
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

        }

        /// <summary>
        /// The details of the event.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the Apsara Stack tenant account used by the event owner.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
