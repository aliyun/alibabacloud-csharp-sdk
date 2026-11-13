// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetRemindResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the custom monitoring rule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRemindResponseBodyData Data { get; set; }
        public class GetRemindResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The minimum alert interval, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("AlertInterval")]
            [Validation(Required=false)]
            public int? AlertInterval { get; set; }

            /// <summary>
            /// <para>The alert methods.</para>
            /// </summary>
            [NameInMap("AlertMethods")]
            [Validation(Required=false)]
            public List<string> AlertMethods { get; set; }

            /// <summary>
            /// <para>The alert recipients. For multiple types of alert recipients, refer to the Receivers response parameter.</para>
            /// </summary>
            [NameInMap("AlertTargets")]
            [Validation(Required=false)]
            public List<string> AlertTargets { get; set; }

            /// <summary>
            /// <para>The alert recipient type. For multiple types of alert recipients, refer to the Receivers response parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OWNER: task owner.</description></item>
            /// <item><description>OTHER: specified user.</description></item>
            /// <item><description>SHIFT_SCHEDULE: duty roster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OWNER</para>
            /// </summary>
            [NameInMap("AlertUnit")]
            [Validation(Required=false)]
            public string AlertUnit { get; set; }

            /// <summary>
            /// <para>The alert allowlist.</para>
            /// </summary>
            [NameInMap("AllowNodes")]
            [Validation(Required=false)]
            public List<long?> AllowNodes { get; set; }

            /// <summary>
            /// <para>The list of baselines for monitoring by the rule when the RemindUnit object type is BASELINE.</para>
            /// </summary>
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBaselines> Baselines { get; set; }
            public class GetRemindResponseBodyDataBaselines : TeaModel {
                /// <summary>
                /// <para>The ID of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The name of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Baseline name</para>
                /// </summary>
                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

            }

            /// <summary>
            /// <para>The list of business flows for monitoring by the rule when the RemindUnit object type is BIZPROCESS.</para>
            /// </summary>
            [NameInMap("BizProcesses")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBizProcesses> BizProcesses { get; set; }
            public class GetRemindResponseBodyDataBizProcesses : TeaModel {
                /// <summary>
                /// <para>The ID of the business flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The name of the business flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business process name</para>
                /// </summary>
                [NameInMap("BizProcessName")]
                [Validation(Required=false)]
                public string BizProcessName { get; set; }

            }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>If the RemindType trigger condition is FINISHED, an empty value is returned.</para>
            /// </description></item>
            /// <item><description><para>If the RemindType trigger condition is UNFINISHED, the value is returned in the {&quot;hour&quot;:23,&quot;minu&quot;:59} format. The value of hour ranges from 0 to 47, and the value of minu ranges from 0 to 59.</para>
            /// </description></item>
            /// <item><description><para>If the RemindType trigger condition is ERROR, an empty value is returned.</para>
            /// </description></item>
            /// <item><description><para>If the RemindType trigger condition is CYCLE_UNFINISHED, the value is returned in the {&quot;1&quot;:&quot;05:50&quot;,&quot;2&quot;:&quot;06:50&quot;,&quot;3&quot;:&quot;07:50&quot;,&quot;4&quot;:&quot;08:50&quot;,&quot;5&quot;:&quot;09:50&quot;,&quot;6&quot;:&quot;10:50&quot;,&quot;7&quot;:&quot;11:50&quot;,&quot;8&quot;:&quot;12:50&quot;,&quot;9&quot;:&quot;13:50&quot;,&quot;10&quot;:&quot;14:50&quot;,&quot;11&quot;:&quot;15:50&quot;,&quot;12&quot;:&quot;16:50&quot;,&quot;13&quot;:&quot;17:50&quot;,&quot;14&quot;:&quot;18:50&quot;,&quot;15&quot;:&quot;19:50&quot;,&quot;16&quot;:&quot;20:50&quot;,&quot;17&quot;:&quot;21:50&quot;,&quot;18&quot;:&quot;22:50&quot;,&quot;19&quot;:&quot;23:50&quot;,&quot;20&quot;:&quot;24:50&quot;,&quot;21&quot;:&quot;25:50&quot;} format. The key in the JSON string is the cycle number, which ranges from 1 to 288. The value is the time by which the cycle must be completed for the cycle, in the hh:mm format. The value of hh ranges from 0 to 47, and the value of mm ranges from 0 to 59.</para>
            /// </description></item>
            /// <item><description><para>If the RemindType trigger condition is TIMEOUT, the value is returned in seconds, such as 1800. This indicates that an alert is triggered if the node runs for more than 30 minutes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;hour&quot;:23,&quot;minu&quot;:59}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The end time of the do-not-disturb period, in the hh:mm format. The value of hh ranges from 0 to 23, and the value of mm ranges from 0 to 59.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("DndEnd")]
            [Validation(Required=false)]
            public string DndEnd { get; set; }

            /// <summary>
            /// <para>The start time of the do-not-disturb period, in the hh:mm format. The value of hh ranges from 0 to 23, and the value of mm ranges from 0 to 59.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("DndStart")]
            [Validation(Required=false)]
            public string DndStart { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the user who created the custom monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527951795****</para>
            /// </summary>
            [NameInMap("Founder")]
            [Validation(Required=false)]
            public string Founder { get; set; }

            /// <summary>
            /// <para>The maximum number of alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxAlertTimes")]
            [Validation(Required=false)]
            public int? MaxAlertTimes { get; set; }

            /// <summary>
            /// <para>The list of nodes for monitoring by the rule when the RemindUnit object type is NODE.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataNodes> Nodes { get; set; }
            public class GetRemindResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
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
                /// <para>9527951795****</para>
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
            /// <para>The list of workspaces for monitoring by the rule when the RemindUnit object type is PROJECT.</para>
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataProjects> Projects { get; set; }
            public class GetRemindResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// <para>The ID of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The alert recipient information.</para>
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataReceivers> Receivers { get; set; }
            public class GetRemindResponseBodyDataReceivers : TeaModel {
                /// <summary>
                /// <para>The alert recipient.</para>
                /// </summary>
                [NameInMap("AlertTargets")]
                [Validation(Required=false)]
                public List<string> AlertTargets { get; set; }

                /// <summary>
                /// <para>The alert recipient type. For multiple types of alert recipients, refer to the Receivers response parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OWNER: task owner.</description></item>
                /// <item><description>OTHER: specified user.</description></item>
                /// <item><description>SHIFT_SCHEDULE: duty roster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("AlertUnit")]
                [Validation(Required=false)]
                public string AlertUnit { get; set; }

            }

            /// <summary>
            /// <para>The ID of the custom monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("RemindId")]
            [Validation(Required=false)]
            public long? RemindId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rule name</para>
            /// </summary>
            [NameInMap("RemindName")]
            [Validation(Required=false)]
            public string RemindName { get; set; }

            /// <summary>
            /// <para>The trigger condition. Valid values: FINISHED (completed), UNFINISHED (not completed), ERROR (error occurred), CYCLE_UNFINISHED (epoch uncompleted), and TIMEOUT (timeout).</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("RemindType")]
            [Validation(Required=false)]
            public string RemindType { get; set; }

            /// <summary>
            /// <para>The type of the monitored object. Valid values: NODE (node), BASELINE (baseline), PROJECT (workspace), and BIZPROCESS (business flow).</para>
            /// 
            /// <b>Example:</b>
            /// <para>NODE</para>
            /// </summary>
            [NameInMap("RemindUnit")]
            [Validation(Required=false)]
            public string RemindUnit { get; set; }

            /// <summary>
            /// <para>The webhook URLs of the DingTalk chatbots.</para>
            /// </summary>
            [NameInMap("Robots")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataRobots> Robots { get; set; }
            public class GetRemindResponseBodyDataRobots : TeaModel {
                /// <summary>
                /// <para>Specifies whether to mention all members. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: yes.</description></item>
                /// <item><description>false: no.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AtAll")]
                [Validation(Required=false)]
                public bool? AtAll { get; set; }

                /// <summary>
                /// <para>The webhook URL of the DingTalk chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=">https://oapi.dingtalk.com/robot/send?access_token=</a>******************************</para>
                /// </summary>
                [NameInMap("WebUrl")]
                [Validation(Required=false)]
                public string WebUrl { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the custom monitoring rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Useflag")]
            [Validation(Required=false)]
            public bool? Useflag { get; set; }

            /// <summary>
            /// <para>WebHook URL</para>
            /// </summary>
            [NameInMap("Webhooks")]
            [Validation(Required=false)]
            public List<string> Webhooks { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
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
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues if an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFGH-IJK****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
