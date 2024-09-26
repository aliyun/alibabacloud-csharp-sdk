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
            /// <para>The sending status of the notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>READY_TO_SEND: The notification is waiting to be sent.</description></item>
            /// <item><description>SEND_FAIL: The notification fails to be sent.</description></item>
            /// <item><description>SEND_SUCCESS: The notification is sent.</description></item>
            /// <item><description>SEND_OVERLIMIT: The number of notifications that are sent exceeds the upper limit.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY_TO_SEND</para>
            /// </summary>
            [NameInMap("AlertMessageStatus")]
            [Validation(Required=false)]
            public string AlertMessageStatus { get; set; }

            /// <summary>
            /// <para>The notification method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAIL.</description></item>
            /// <item><description>SMS.</description></item>
            /// <item><description>PHONE. Only DataWorks Professional Edition and more advanced editions support the PHONE notification method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SMS</para>
            /// </summary>
            [NameInMap("AlertMethod")]
            [Validation(Required=false)]
            public string AlertMethod { get; set; }

            /// <summary>
            /// <para>The time when the alert was reported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account used by the alert recipient.</para>
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
            public List<GetAlertMessageResponseBodyDataInstances> Instances { get; set; }
            public class GetAlertMessageResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12312312</para>
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
                /// <para>The status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NOT_RUN</description></item>
                /// <item><description>WAIT_TIME</description></item>
                /// <item><description>WAIT_RESOURCE</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>CHECKING</description></item>
                /// <item><description>CHECKING_CONDITION</description></item>
                /// <item><description>FAILURE</description></item>
                /// <item><description>SUCCESS</description></item>
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
            /// <para>The nodes returned for different alert sources. The nodes that form a loop are returned if the value of the Source parameter is NODE_CYCLE_ALERT. The nodes that are isolated are returned if the value of the Source parameter is NODE_LONELY_ALERT.</para>
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
                /// <para>The status of the baseline. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ERROR</description></item>
                /// <item><description>SAFE</description></item>
                /// <item><description>DANGEROUS</description></item>
                /// <item><description>OVER</description></item>
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
            /// <para>The type of the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>REMIND_ALERT: The alert is a custom alert.</description></item>
            /// <item><description>TOPIC_ALERT: The alert is an event alert.</description></item>
            /// <item><description>SLA_ALERT: The alert is a baseline alert.</description></item>
            /// <item><description>NODE_CYCLE_ALERT: The alert is reported for a node dependency loop.</description></item>
            /// <item><description>NODE_LONELY_ALERT: The alert is reported for isolated nodes.</description></item>
            /// </list>
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
            public List<GetAlertMessageResponseBodyDataTopics> Topics { get; set; }
            public class GetAlertMessageResponseBodyDataTopics : TeaModel {
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
                /// <para>412431</para>
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
                /// <para>The status of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IGNORE</description></item>
                /// <item><description>NEW</description></item>
                /// <item><description>FIXING</description></item>
                /// <item><description>RECOVER</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
