// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetAlertMessageResponseBody : TeaModel {
        /// <summary>
        /// The details of the returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlertMessageResponseBodyData Data { get; set; }
        public class GetAlertMessageResponseBodyData : TeaModel {
            /// <summary>
            /// The alert ID.
            /// </summary>
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            /// <summary>
            /// The sending status of the notification. Valid values:
            /// 
            /// *   READY_TO_SEND: The notification is waiting to be sent.
            /// *   SEND_FAIL: The notification fails to be sent.
            /// *   SEND_SUCCESS: The notification is sent.
            /// *   SEND_OVERLIMIT: The number of notifications that are sent exceeds the upper limit.
            /// </summary>
            [NameInMap("AlertMessageStatus")]
            [Validation(Required=false)]
            public string AlertMessageStatus { get; set; }

            /// <summary>
            /// The notification method. Valid values:
            /// 
            /// *   MAIL.
            /// *   SMS.
            /// *   PHONE. Only DataWorks Professional Edition and more advanced editions support the PHONE notification method.
            /// </summary>
            [NameInMap("AlertMethod")]
            [Validation(Required=false)]
            public string AlertMethod { get; set; }

            /// <summary>
            /// The time when the alert was reported.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the alert recipient.
            /// </summary>
            [NameInMap("AlertUser")]
            [Validation(Required=false)]
            public string AlertUser { get; set; }

            /// <summary>
            /// The content of the alert.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The instances that triggered the custom alert rule. This parameter is returned if the value of the Source parameter is REMIND_ALERT. This parameter is left empty if the value of the Source parameter is not REMIND_ALERT.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataInstances> Instances { get; set; }
            public class GetAlertMessageResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The ID of the workspace to which the node belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   NOT_RUN
                /// *   WAIT_TIME
                /// *   WAIT_RESOURCE
                /// *   RUNNING
                /// *   CHECKING
                /// *   CHECKING_CONDITION
                /// *   FAILURE
                /// *   SUCCESS
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The nodes returned for different alert sources. The nodes that form a loop are returned if the value of the Source parameter is NODE_CYCLE_ALERT. The nodes that are isolated are returned if the value of the Source parameter is NODE_LONELY_ALERT.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataNodes> Nodes { get; set; }
            public class GetAlertMessageResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the node owner.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The ID of the workspace to which the node belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// The ID of the custom alert rule that was triggered. This parameter is returned if the value of the Source parameter is REMIND_ALERT.
            /// </summary>
            [NameInMap("RemindId")]
            [Validation(Required=false)]
            public long? RemindId { get; set; }

            /// <summary>
            /// The name of the custom alert rule that was triggered. This parameter is returned if the value of the Source parameter is REMIND_ALERT.
            /// </summary>
            [NameInMap("RemindName")]
            [Validation(Required=false)]
            public string RemindName { get; set; }

            /// <summary>
            /// The basic information about the baseline instance that triggered an alert. This parameter is returned if the value of the Source parameter is SLA_ALERT. This parameter is left empty if the value of the Source parameter is not SLA_ALERT.
            /// </summary>
            [NameInMap("SlaAlert")]
            [Validation(Required=false)]
            public GetAlertMessageResponseBodyDataSlaAlert SlaAlert { get; set; }
            public class GetAlertMessageResponseBodyDataSlaAlert : TeaModel {
                /// <summary>
                /// The baseline ID.
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
                /// The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs are separated by commas (,).
                /// </summary>
                [NameInMap("BaselineOwner")]
                [Validation(Required=false)]
                public string BaselineOwner { get; set; }

                /// <summary>
                /// The data timestamp of the baseline instance.
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// The ID of the cycle of the baseline instance. Valid values of the ID of an hour-level cycle: [1,24]. The ID of a day-level cycle is 1.
                /// </summary>
                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                /// <summary>
                /// The ID of the workspace to which the baseline belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The status of the baseline. Valid values:
                /// 
                /// *   ERROR
                /// *   SAFE
                /// *   DANGEROUS
                /// *   OVER
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The type of the alert. Valid values:
            /// 
            /// *   REMIND_ALERT: The alert is a custom alert.
            /// *   TOPIC_ALERT: The alert is an event alert.
            /// *   SLA_ALERT: The alert is a baseline alert.
            /// *   NODE_CYCLE_ALERT: The alert is reported for a node dependency loop.
            /// *   NODE_LONELY_ALERT: The alert is reported for isolated nodes.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The events that triggered alerts. This parameter is returned if the value of the Source parameter is TOPIC_ALERT. This parameter is left empty if the value of the Source parameter is not TOPIC_ALERT.
            /// </summary>
            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataTopics> Topics { get; set; }
            public class GetAlertMessageResponseBodyDataTopics : TeaModel {
                /// <summary>
                /// The ID of the instance that triggered the event.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The ID of the node that triggered the event.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

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
                /// The ID of the Alibaba Cloud account used by the event owner.
                /// </summary>
                [NameInMap("TopicOwner")]
                [Validation(Required=false)]
                public string TopicOwner { get; set; }

                /// <summary>
                /// The status of the event. Valid values:
                /// 
                /// *   IGNORE
                /// *   NEW
                /// *   FIXING
                /// *   RECOVER
                /// </summary>
                [NameInMap("TopicStatus")]
                [Validation(Required=false)]
                public string TopicStatus { get; set; }

            }

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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
