// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetRemindResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the custom alert rule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRemindResponseBodyData Data { get; set; }
        public class GetRemindResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The minimum interval at which alerts are reported. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("AlertInterval")]
            [Validation(Required=false)]
            public int? AlertInterval { get; set; }

            /// <summary>
            /// <para>The notification method.</para>
            /// </summary>
            [NameInMap("AlertMethods")]
            [Validation(Required=false)]
            public List<string> AlertMethods { get; set; }

            /// <summary>
            /// <para>The description of the alert recipient. For more information about alert recipients, see the Receivers parameter.</para>
            /// </summary>
            [NameInMap("AlertTargets")]
            [Validation(Required=false)]
            public List<string> AlertTargets { get; set; }

            /// <summary>
            /// <para>The type of the alert recipient. For more information about alert recipient types, see the Receivers parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OWNER: the task owner</description></item>
            /// <item><description>OTHER: specified personnel</description></item>
            /// <item><description>SHIFT_SCHEDULE: personnel in a shift schedule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OWNER</para>
            /// </summary>
            [NameInMap("AlertUnit")]
            [Validation(Required=false)]
            public string AlertUnit { get; set; }

            /// <summary>
            /// <para>The IDs of the nodes that are added to a whitelist.</para>
            /// </summary>
            [NameInMap("AllowNodes")]
            [Validation(Required=false)]
            public List<long?> AllowNodes { get; set; }

            /// <summary>
            /// <para>The baselines to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BASELINE.</para>
            /// </summary>
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBaselines> Baselines { get; set; }
            public class GetRemindResponseBodyDataBaselines : TeaModel {
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
                /// 
                /// <b>Example:</b>
                /// <para>Baseline name</para>
                /// </summary>
                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

            }

            /// <summary>
            /// <para>The workflows to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BIZPROCESS.</para>
            /// </summary>
            [NameInMap("BizProcesses")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBizProcesses> BizProcesses { get; set; }
            public class GetRemindResponseBodyDataBizProcesses : TeaModel {
                /// <summary>
                /// <para>The ID of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The name of the workflow.</para>
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
            /// <item><description>If the value of the RemindType parameter is FINISHED, this parameter is left empty.</description></item>
            /// <item><description>If the value of the RemindType parameter is UNFINISHED, the trigger conditions are returned as key-value pairs. Example: {&quot;hour&quot;:23,&quot;minu&quot;:59}. Valid values of hour: [0,47]. Valid values of minu: [0,59].</description></item>
            /// <item><description>If the value of the RemindType parameter is ERROR, this parameter is left empty.</description></item>
            /// <item><description>If the value of the RemindType parameter is CYCLE_UNFINISHED, the trigger conditions are returned as key-value pairs. Example: {&quot;1&quot;:&quot;05:50&quot;,&quot;2&quot;:&quot;06:50&quot;,&quot;3&quot;:&quot;07:50&quot;,&quot;4&quot;:&quot;08:50&quot;,&quot;5&quot;:&quot;09:50&quot;,&quot;6&quot;:&quot;10:50&quot;,&quot;7&quot;:&quot;11:50&quot;,&quot;8&quot;:&quot;12:50&quot;,&quot;9&quot;:&quot;13:50&quot;,&quot;10&quot;:&quot;14:50&quot;,&quot;11&quot;:&quot;15:50&quot;,&quot;12&quot;:&quot;16:50&quot;,&quot;13&quot;:&quot;17:50&quot;,&quot;14&quot;:&quot;18:50&quot;,&quot;15&quot;:&quot;19:50&quot;,&quot;16&quot;:&quot;20:50&quot;,&quot;17&quot;:&quot;21:50&quot;,&quot;18&quot;:&quot;22:50&quot;,&quot;19&quot;:&quot;23:50&quot;,&quot;20&quot;:&quot;24:50&quot;,&quot;21&quot;:&quot;25:50&quot;}. The key indicates the ID of the cycle. Valid values: [1,288]. The value indicates the timeout period of the node that is running in the cycle. Specify the value in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</description></item>
            /// <item><description>If the value of the RemindType parameter is TIMEOUT, the timeout period is returned. Unit: seconds. Example: 1800. This value indicates that an alert is reported if the node has run for more than 30 minutes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;hour&quot;:23,&quot;minu&quot;:59}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The end time of the quiet hours. The value is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("DndEnd")]
            [Validation(Required=false)]
            public string DndEnd { get; set; }

            /// <summary>
            /// <para>The start time of the quiet hours. The value is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("DndStart")]
            [Validation(Required=false)]
            public string DndStart { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account used by the creator of the custom alert rule.</para>
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
            /// <para>The nodes to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is NODE.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataNodes> Nodes { get; set; }
            public class GetRemindResponseBodyDataNodes : TeaModel {
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
                /// 
                /// <b>Example:</b>
                /// <para>Node name</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the node owner.</para>
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
            /// <para>The workspaces to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is PROJECT.</para>
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataProjects> Projects { get; set; }
            public class GetRemindResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The information about the alert recipients.</para>
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
                /// <para>The type of the alert recipient. For more information about alert recipients, see the Receivers parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OWNER: indicate the task owner.</description></item>
                /// <item><description>OTHER: indicates specified personnel.</description></item>
                /// <item><description>SHIFT_SCHEDULE: indicates personnel in a shift schedule.</description></item>
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
            /// <para>The custom alert rule ID.</para>
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
            /// <para>The conditions that trigger an alert. Valid values: FINISHED, UNFINISHED, ERROR, CYCLE_UNFINISHED, and TIMEOUT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("RemindType")]
            [Validation(Required=false)]
            public string RemindType { get; set; }

            /// <summary>
            /// <para>The type of the object to which the custom alert rule is applied. Valid values: NODE, BASELINE, PROJECT, and BIZPROCESS. The value NODE indicates a node. The value BASELINE indicates a baseline. The value PROJECT indicates a workspace. The value BIZPROCESS indicates a workflow.</para>
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
                /// <para>Indicates whether all group members are notified when the alert notification is sent to a DingTalk group. Valid values: true and false.</para>
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
            /// <para>Indicates whether the custom alert rule is enabled. Valid values: true and false.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFGH-IJKLMNOPQ</para>
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
