// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesResponseBody : TeaModel {
        /// <summary>
        /// The information about returned alerts.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAlertMessagesResponseBodyData Data { get; set; }
        public class ListAlertMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// The alerts.
            /// </summary>
            [NameInMap("AlertMessages")]
            [Validation(Required=false)]
            public List<ListAlertMessagesResponseBodyDataAlertMessages> AlertMessages { get; set; }
            public class ListAlertMessagesResponseBodyDataAlertMessages : TeaModel {
                /// <summary>
                /// The ID of the alert.
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                /// <summary>
                /// The sending status of the notification. Valid values: READY_TO_SEND, SEND_FAIL, SEND_SUCCESS, and SEND_OVERLIMIT. The value READY_TO_SEND indicates that the notification is waiting to be sent. The value SEND_FAIL indicates that the notification fails to be sent. The value SEND_SUCCESS indicates that the notification is sent. The value SEND_OVERLIMIT indicates that the number of notifications that are sent exceeds the upper limit.
                /// </summary>
                [NameInMap("AlertMessageStatus")]
                [Validation(Required=false)]
                public string AlertMessageStatus { get; set; }

                /// <summary>
                /// The notification method. Valid values: MAIL, SMS, and PHONE. The value MAIL indicates that the notification is sent by email. The value SMS indicates that the notification is sent by text message. The value PHONE indicates that the notification is sent by phone call. Only DataWorks Professional Edition and more advanced editions support the PHONE notification method.
                /// </summary>
                [NameInMap("AlertMethod")]
                [Validation(Required=false)]
                public string AlertMethod { get; set; }

                /// <summary>
                /// The timestamp when the alert was reported.
                /// </summary>
                [NameInMap("AlertTime")]
                [Validation(Required=false)]
                public long? AlertTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud used by the alert recipient.
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
                public List<ListAlertMessagesResponseBodyDataAlertMessagesInstances> Instances { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesInstances : TeaModel {
                    /// <summary>
                    /// The ID of the instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// The ID of the node.
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
                    /// The status of the instance. Valid values: NOT_RUN, WAIT_TIME, WAIT_RESOURCE, RUNNING, CHECKING, CHECKING_CONDITION, FAILURE, and SUCCESS. The value NOT_RUN indicates that the instance is not run. The value WAIT_TIME indicates that the instance is waiting to be run. The value WAIT_RESOURCE indicates that the instance is waiting for resources. The value RUNNING indicates that the instance is running. The value CHECKING indicates that data quality is being checked for the node. The value CHECKING_CONDITION indicates that branch conditions are being checked for the node. The value FAILURE indicates that the instance fails to run. The value SUCCESS indicates that the instance is successfully run.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The nodes returned for different alert sources.
                /// 
                /// *   The nodes that form a loop are returned if the value of the Source parameter is NODE_CYCLE_ALERT.
                /// *   The nodes that are isolated are returned if the value of the Source parameter is NODE_LONELY_ALERT.
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<ListAlertMessagesResponseBodyDataAlertMessagesNodes> Nodes { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesNodes : TeaModel {
                    /// <summary>
                    /// The ID of the node.
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
                    /// The ID of the Alibaba Cloud account used by the owner of the node.
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
                public ListAlertMessagesResponseBodyDataAlertMessagesSlaAlert SlaAlert { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesSlaAlert : TeaModel {
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
                    /// The ID of the cycle of the baseline instance. Valid values of the ID of an hour-level cycle: 1 to 24. The ID of a day-level cycle is 1.
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
                    /// The status of the baseline. Valid values: ERROR, SAFE, DANGROUS, and OVER. The value ERROR indicates that no nodes are associated with the baseline, or all nodes associated with the baseline are suspended. The value SAFE indicates that nodes are run before the alert duration begins. The value DANGROUS indicates that nodes are still running after the alert duration ends but the committed time does not arrive. The value OVER indicates that nodes are still running after the committed time.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The type of the alert. Valid values: REMIND_ALERT, TOPIC_ALERT, SLA_ALERT, NODE_CYCLE_ALERT, and NODE_LONELY_ALERT. The value REMIND_ALERT indicates that the alert is a custom alert. The value TOPIC_ALERT indicates that the alert is an event alert. The value SLA_ALERT indicates that the alert is a baseline alert. The value NODE_CYCLE_ALERT indicates that the alert is reported for a node dependency loop. The value NODE_LONELY_ALERT indicates that the alert is reported for isolated nodes.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The events that triggered alerts. This parameter is returned if the value of the Source parameter is TOPIC_ALERT. This parameter is left empty if the value of the Source parameter is not TOPIC_ALERT.
                /// </summary>
                [NameInMap("Topics")]
                [Validation(Required=false)]
                public List<ListAlertMessagesResponseBodyDataAlertMessagesTopics> Topics { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesTopics : TeaModel {
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
                    /// The ID of the event.
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
                    /// The status of the event. Valid values: IGNORE, NEW, FIXING, and RECOVER. The value IGNORE indicates that the event is ignored. The value NEW indicates that the event is a new event. The value FIXING indicates that the event is being handled. The value RECOVER indicates that the event is handled.
                    /// </summary>
                    [NameInMap("TopicStatus")]
                    [Validation(Required=false)]
                    public string TopicStatus { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// The total number of returned alerts.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

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
