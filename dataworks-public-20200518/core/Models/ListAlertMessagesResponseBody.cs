// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListAlertMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned alert messages.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAlertMessagesResponseBodyData Data { get; set; }
        public class ListAlertMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of alert messages.</para>
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
                /// <para>The sending status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>READY_TO_SEND: Ready to send.</description></item>
                /// <item><description>SEND_FAIL: Failed to send.</description></item>
                /// <item><description>SEND_SUCCESS: Sent successfully.</description></item>
                /// <item><description>SEND_OVERLIMIT: Alert limit exceeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>READY_TO_SEND</para>
                /// </summary>
                [NameInMap("AlertMessageStatus")]
                [Validation(Required=false)]
                public string AlertMessageStatus { get; set; }

                /// <summary>
                /// <para>The alert notification method. Valid values: MAIL (email), SMS (text message), and PHONE (phone call, supported only in DataWorks Professional Edition and more advanced editions).</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMS</para>
                /// </summary>
                [NameInMap("AlertMethod")]
                [Validation(Required=false)]
                public string AlertMethod { get; set; }

                /// <summary>
                /// <para>The timestamp of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531401000</para>
                /// </summary>
                [NameInMap("AlertTime")]
                [Validation(Required=false)]
                public long? AlertTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527952795****</para>
                /// </summary>
                [NameInMap("AlertUser")]
                [Validation(Required=false)]
                public string AlertUser { get; set; }

                /// <summary>
                /// <para>The content of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node error</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The list of instances that triggered the custom monitoring rule. This field is returned when Source is REMIND_ALERT (custom alert). It is empty for other alert sources.</para>
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
                    /// <para>The node name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Node name</para>
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
                    /// <para>The instance status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>NOT_RUN: Not run.</description></item>
                    /// <item><description>WAIT_TIME: Waiting for the scheduled time.</description></item>
                    /// <item><description>WAIT_RESOURCE: Waiting for resources.</description></item>
                    /// <item><description>RUNNING: Running.</description></item>
                    /// <item><description>CHECKING: Checking.</description></item>
                    /// <item><description>CHECKING_CONDITION: Checking conditions.</description></item>
                    /// <item><description>FAILURE: Failed.</description></item>
                    /// <item><description>SUCCESS: Successful.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NOT_RUN</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The list of nodes returned varies based on the alert source:</para>
                /// <list type="bullet">
                /// <item><description><para>If Source (alert source) is NODE_CYCLE_ALERT (node cycle alert), the types of nodes that form a cycle are returned.</para>
                /// </description></item>
                /// <item><description><para>If Source (alert source) is NODE_LONELY_ALERT (isolated node alert), the types of isolated nodes are returned.</para>
                /// </description></item>
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
                    /// <para>The node name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Node name</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud UID of the node owner.</para>
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
                /// <para>The ID of the triggered custom monitoring rule. This field is returned when Source is REMIND_ALERT (custom alert).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("RemindId")]
                [Validation(Required=false)]
                public long? RemindId { get; set; }

                /// <summary>
                /// <para>The name of the triggered custom monitoring rule. This field is returned when Source is REMIND_ALERT (custom alert).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom monitoring rule name</para>
                /// </summary>
                [NameInMap("RemindName")]
                [Validation(Required=false)]
                public string RemindName { get; set; }

                /// <summary>
                /// <para>The basic instance information that triggered the baseline alert. This field is returned when Source is SLA_ALERT (baseline alert). It is empty for other alert sources.</para>
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
                    /// <para>The baseline name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Baseline name</para>
                    /// </summary>
                    [NameInMap("BaselineName")]
                    [Validation(Required=false)]
                    public string BaselineName { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud UIDs of the baseline owners. Multiple UIDs are separated by commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>952795279****</para>
                    /// </summary>
                    [NameInMap("BaselineOwner")]
                    [Validation(Required=false)]
                    public string BaselineOwner { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the business date of the baseline instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1553443200000</para>
                    /// </summary>
                    [NameInMap("Bizdate")]
                    [Validation(Required=false)]
                    public long? Bizdate { get; set; }

                    /// <summary>
                    /// <para>The cycle number of the baseline instance. The value is 1 for daily baselines and ranges from 1 to 24 for hourly baselines.</para>
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
                    /// <para>The baseline status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ERROR: Error.</description></item>
                    /// <item><description>SAFE: Safe.</description></item>
                    /// <item><description>DANGROUS: Warning.</description></item>
                    /// <item><description>OVER: Exceeded.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAFE</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The alert source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>REMIND_ALERT: Custom alerting.</description></item>
                /// <item><description>TOPIC_ALERT: Event alerting.</description></item>
                /// <item><description>SLA_ALERT: Baseline alerting.</description></item>
                /// <item><description>NODE_CYCLE_ALERT: Node loop alerting.</description></item>
                /// <item><description>NODE_LONELY_ALERT: Isolated node alerting.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>REMIND_ALERT</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The list of events that triggered the alert. This field is returned when Source is TOPIC_ALERT (global event alert). It is empty for other alert sources.</para>
                /// </summary>
                [NameInMap("Topics")]
                [Validation(Required=false)]
                public List<ListAlertMessagesResponseBodyDataAlertMessagesTopics> Topics { get; set; }
                public class ListAlertMessagesResponseBodyDataAlertMessagesTopics : TeaModel {
                    /// <summary>
                    /// <para>The instance ID associated with the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// <para>The ID of the node associated with the event.</para>
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
                    /// <para>The event name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9527 error</para>
                    /// </summary>
                    [NameInMap("TopicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud UID of the event owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9527952795****</para>
                    /// </summary>
                    [NameInMap("TopicOwner")]
                    [Validation(Required=false)]
                    public string TopicOwner { get; set; }

                    /// <summary>
                    /// <para>The event status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>IGNORE: Ignored.</description></item>
                    /// <item><description>NEW: New.</description></item>
                    /// <item><description>FIXING: Fixing.</description></item>
                    /// <item><description>RECOVER: Recovered.</description></item>
                    /// </list>
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
            /// <para>The current page number.</para>
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
            /// <para>The total number of alert messages.</para>
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
        /// <para>The unique ID of the request. You can use the ID to troubleshoot issues.</para>
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
