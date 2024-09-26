// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about returned alerts.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAlertMessagesResponseBodyData Data { get; set; }
        public class ListAlertMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alerts.</para>
            /// </summary>
            [NameInMap("AlertMessages")]
            [Validation(Required=false)]
            public List<ListAlertMessagesResponseBodyDataAlertMessages> AlertMessages { get; set; }
            public class ListAlertMessagesResponseBodyDataAlertMessages : TeaModel {
                /// <summary>
                /// <para>The alert ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                /// <summary>
                /// <para>The sending status of the notification. Valid values: READY_TO_SEND, SEND_FAIL, SEND_SUCCESS, and SEND_OVERLIMIT. The value READY_TO_SEND indicates that the notification is waiting to be sent. The value SEND_FAIL indicates that the notification fails to be sent. The value SEND_SUCCESS indicates that the notification is sent. The value SEND_OVERLIMIT indicates that the number of notifications that are sent exceeds the upper limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>READY_TO_SEND</para>
                /// </summary>
                [NameInMap("AlertMessageStatus")]
                [Validation(Required=false)]
                public string AlertMessageStatus { get; set; }

                /// <summary>
                /// <para>The notification method. Valid values: MAIL, SMS, and PHONE. Only DataWorks Professional Edition and more advanced editions support the PHONE notification method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMS</para>
                /// </summary>
                [NameInMap("AlertMethod")]
                [Validation(Required=false)]
                public string AlertMethod { get; set; }

                /// <summary>
                /// <para>The timestamp when the alert was reported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("AlertTime")]
                [Validation(Required=false)]
                public long? AlertTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud used by the alert recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527952795****</para>
                /// </summary>
                [NameInMap("AlertUser")]
                [Validation(Required=false)]
                public string AlertUser { get; set; }

                /// <summary>
                /// <para>The content of the alert.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The instances that triggered the custom alert rule. This parameter is returned if the value of the Source parameter is REMIND_ALERT. This parameter is left empty if the value of the Source parameter is not REMIND_ALERT.</para>
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public List<ListAlertMessagesResponseBodyDataAlertMessagesInstances> Instances { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesInstances : TeaModel {
                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public long? NodeId { get; set; }

                    /// <summary>
                    /// <para>The name of the node.</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The ID of the workspace to which the node belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The status of the instance. Valid values: NOT_RUN, WAIT_TIME, WAIT_RESOURCE, RUNNING, CHECKING, CHECKING_CONDITION, FAILURE, and SUCCESS. The value NOT_RUN indicates that the instance is not run. The value WAIT_TIME indicates that the instance is waiting to be run. The value WAIT_RESOURCE indicates that the instance is waiting for resources. The value RUNNING indicates that the instance is running. The value CHECKING indicates that data quality is being checked for the node for which the instance is generated. The value CHECKING_CONDITION indicates that branch conditions are being checked for the node for which the instance is generated. The value FAILURE indicates that the instance fails to run. The value SUCCESS indicates that the instance is successfully run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NOT_RUN</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The nodes returned for different alert sources.</para>
                /// <list type="bullet">
                /// <item><description>The nodes that form a loop are returned if the value of the Source parameter is NODE_CYCLE_ALERT.</description></item>
                /// <item><description>The nodes that are isolated are returned if the value of the Source parameter is NODE_LONELY_ALERT.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<ListAlertMessagesResponseBodyDataAlertMessagesNodes> Nodes { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesNodes : TeaModel {
                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public long? NodeId { get; set; }

                    /// <summary>
                    /// <para>The name of the node.</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The ID of the Alibaba Cloud account used by the node owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>95279527952****</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The ID of the workspace to which the node belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the custom alert rule that was triggered. This parameter is returned if the value of the Source parameter is REMIND_ALERT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("RemindId")]
                [Validation(Required=false)]
                public long? RemindId { get; set; }

                /// <summary>
                /// <para>The name of the custom alert rule that was triggered. This parameter is returned if the value of the Source parameter is REMIND_ALERT.</para>
                /// </summary>
                [NameInMap("RemindName")]
                [Validation(Required=false)]
                public string RemindName { get; set; }

                /// <summary>
                /// <para>The basic information about the baseline instance that triggered an alert. This parameter is returned if the value of the Source parameter is SLA_ALERT. This parameter is left empty if the value of the Source parameter is not SLA_ALERT.</para>
                /// </summary>
                [NameInMap("SlaAlert")]
                [Validation(Required=false)]
                public ListAlertMessagesResponseBodyDataAlertMessagesSlaAlert SlaAlert { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesSlaAlert : TeaModel {
                    /// <summary>
                    /// <para>The baseline ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("BaselineId")]
                    [Validation(Required=false)]
                    public long? BaselineId { get; set; }

                    /// <summary>
                    /// <para>The name of the baseline.</para>
                    /// </summary>
                    [NameInMap("BaselineName")]
                    [Validation(Required=false)]
                    public string BaselineName { get; set; }

                    /// <summary>
                    /// <para>The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs are separated by commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>952795279****</para>
                    /// </summary>
                    [NameInMap("BaselineOwner")]
                    [Validation(Required=false)]
                    public string BaselineOwner { get; set; }

                    /// <summary>
                    /// <para>The data timestamp of the baseline instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1553443200000</para>
                    /// </summary>
                    [NameInMap("Bizdate")]
                    [Validation(Required=false)]
                    public long? Bizdate { get; set; }

                    /// <summary>
                    /// <para>The ID of the cycle of the baseline instance. Valid values of the ID of an hour-level cycle: [1,24]. The ID of a day-level cycle is 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("InGroupId")]
                    [Validation(Required=false)]
                    public int? InGroupId { get; set; }

                    /// <summary>
                    /// <para>The ID of the workspace to which the baseline belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The status of the baseline. Valid values: ERROR, SAFE, DANGEROUS, and OVER. The value ERROR indicates that no nodes are associated with the baseline, or all nodes associated with the baseline are suspended. The value SAFE indicates that nodes are run before the alert duration begins. The value DANGEROUS indicates that nodes are still running after the alert duration ends but the committed completion time does not arrive. The value OVER indicates that nodes are still running after the committed completion time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAFE</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The type of the alert. Valid values: REMIND_ALERT, TOPIC_ALERT, SLA_ALERT, NODE_CYCLE_ALERT, and NODE_LONELY_ALERT. The value REMIND_ALERT indicates that the alert is a custom alert. The value TOPIC_ALERT indicates that the alert is an event alert. The value SLA_ALERT indicates that the alert is a baseline alert. The value NODE_CYCLE_ALERT indicates that the alert is reported for a node dependency loop. The value NODE_LONELY_ALERT indicates that the alert is reported for isolated nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REMIND_ALERT</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The events that triggered alerts. This parameter is returned if the value of the Source parameter is TOPIC_ALERT. This parameter is left empty if the value of the Source parameter is not TOPIC_ALERT.</para>
                /// </summary>
                [NameInMap("Topics")]
                [Validation(Required=false)]
                public List<ListAlertMessagesResponseBodyDataAlertMessagesTopics> Topics { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesTopics : TeaModel {
                    /// <summary>
                    /// <para>The ID of the instance that triggered the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// <para>The ID of the node that triggered the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public long? NodeId { get; set; }

                    /// <summary>
                    /// <para>The event ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("TopicId")]
                    [Validation(Required=false)]
                    public long? TopicId { get; set; }

                    /// <summary>
                    /// <para>The name of the event.</para>
                    /// </summary>
                    [NameInMap("TopicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                    /// <summary>
                    /// <para>The ID of the Alibaba Cloud account used by the event owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9527952795****</para>
                    /// </summary>
                    [NameInMap("TopicOwner")]
                    [Validation(Required=false)]
                    public string TopicOwner { get; set; }

                    /// <summary>
                    /// <para>The status of the event. Valid values: IGNORE, NEW, FIXING, and RECOVER. The value IGNORE indicates that the event is ignored. The value NEW indicates that the event is a new event. The value FIXING indicates that the event is being handled. The value RECOVER indicates that the event is handled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FIXING</para>
                    /// </summary>
                    [NameInMap("TopicStatus")]
                    [Validation(Required=false)]
                    public string TopicStatus { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of alerts returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
