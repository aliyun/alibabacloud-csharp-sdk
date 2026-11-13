// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetAlertMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlertMessageResponseBodyData Data { get; set; }
        public class GetAlertMessageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            /// <summary>
            /// <para>The sending status of the alert message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>READY_TO_SEND: The message is ready to be sent.</description></item>
            /// <item><description>SEND_FAIL: The message fails to be sent.</description></item>
            /// <item><description>SEND_SUCCESS: The message is sent.</description></item>
            /// <item><description>SEND_OVERLIMIT: The alert limit is exceeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY_TO_SEND</para>
            /// </summary>
            [NameInMap("AlertMessageStatus")]
            [Validation(Required=false)]
            public string AlertMessageStatus { get; set; }

            /// <summary>
            /// <para>The alert notification method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAIL: Email.</description></item>
            /// <item><description>SMS: Text message.</description></item>
            /// <item><description>PHONE: Phone call. This method is supported only in DataWorks Professional Edition or a higher edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SMS</para>
            /// </summary>
            [NameInMap("AlertMethod")]
            [Validation(Required=false)]
            public string AlertMethod { get; set; }

            /// <summary>
            /// <para>The time when the alert is triggered. The value is a 13-digit timestamp, such as <c>1553524393000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the alert message recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527952795****</para>
            /// </summary>
            [NameInMap("AlertUser")]
            [Validation(Required=false)]
            public string AlertUser { get; set; }

            /// <summary>
            /// <para>The content of the alert message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node error</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The list of instances that trigger the custom monitoring rule. This parameter is returned only when the Source parameter is set to REMIND_ALERT. For other alert sources, an empty list is returned.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataInstances> Instances { get; set; }
            public class GetAlertMessageResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12312****</para>
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
                /// <item><description>NOT_RUN: The instance is not run.</description></item>
                /// <item><description>WAIT_TIME: The instance is waiting for the scheduled time.</description></item>
                /// <item><description>WAIT_RESOURCE: The instance is waiting for resources.</description></item>
                /// <item><description>RUNNING: The instance is running.</description></item>
                /// <item><description>CHECKING: The instance is being checked.</description></item>
                /// <item><description>CHECKING_CONDITION: The conditions are being checked.</description></item>
                /// <item><description>FAILURE: The instance failed to run.</description></item>
                /// <item><description>SUCCESS: The instance runs successfully.</description></item>
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
            /// <para>The returned node list varies based on the alert source:
            /// If Source is NODE_CYCLE_ALERT (cyclic node alert), the types of cyclic nodes are returned.
            /// If Source is NODELONELYALERT (isolated node alert), the types of isolated nodes are returned.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataNodes> Nodes { get; set; }
            public class GetAlertMessageResponseBodyDataNodes : TeaModel {
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
            /// <para>The ID of the custom monitoring rule that triggers the alert. This parameter is returned only when the Source parameter is set to REMIND_ALERT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("RemindId")]
            [Validation(Required=false)]
            public long? RemindId { get; set; }

            /// <summary>
            /// <para>The name of the custom monitoring rule that triggers the alert. This parameter is returned only when the Source parameter is set to REMIND_ALERT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom monitoring rule name</para>
            /// </summary>
            [NameInMap("RemindName")]
            [Validation(Required=false)]
            public string RemindName { get; set; }

            /// <summary>
            /// <para>The basic information about the baseline instance that triggers the baseline alert. This parameter is returned only when the Source parameter is set to SLA_ALERT. For other alert sources, this parameter is empty.</para>
            /// </summary>
            [NameInMap("SlaAlert")]
            [Validation(Required=false)]
            public GetAlertMessageResponseBodyDataSlaAlert SlaAlert { get; set; }
            public class GetAlertMessageResponseBodyDataSlaAlert : TeaModel {
                /// <summary>
                /// <para>The baseline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15142123</para>
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
                /// <para>The timestamp of the business date for the baseline instance.</para>
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
                /// <item><description>ERROR: Abnormal.</description></item>
                /// <item><description>SAFE: Safe.</description></item>
                /// <item><description>DANGEROUS: Warning.</description></item>
                /// <item><description>OVER: Broken.</description></item>
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
            /// <para>The source of the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>REMIND_ALERT: Custom alert.</description></item>
            /// <item><description>TOPIC_ALERT: Event alert.</description></item>
            /// <item><description>SLA_ALERT: Baseline alert.</description></item>
            /// <item><description>NODE_CYCLE_ALERT: Node loop alert.</description></item>
            /// <item><description>NODE_LONELY_ALERT: Isolated node alert.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REMIND_ALERT</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The list of events that trigger the alerting. This parameter is returned only when the Source parameter is set to TOPIC_ALERT (global event alerting). For other alerting sources, an empty list is returned.</para>
            /// </summary>
            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataTopics> Topics { get; set; }
            public class GetAlertMessageResponseBodyDataTopics : TeaModel {
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
                /// <para>412431</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <para>The event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
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
                /// <para>The status of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IGNORE: The event is ignored.</description></item>
                /// <item><description>NEW: The event is newly discovered.</description></item>
                /// <item><description>FIXING: The event is being handled.</description></item>
                /// <item><description>RECOVER: The event is recovered.</description></item>
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
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
