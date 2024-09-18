// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetRemindResponseBody : TeaModel {
        /// <summary>
        /// The details of the custom alert rule.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRemindResponseBodyData Data { get; set; }
        public class GetRemindResponseBodyData : TeaModel {
            /// <summary>
            /// The minimum interval at which alerts are reported. Unit: seconds.
            /// </summary>
            [NameInMap("AlertInterval")]
            [Validation(Required=false)]
            public int? AlertInterval { get; set; }

            [NameInMap("AlertMethods")]
            [Validation(Required=false)]
            public List<string> AlertMethods { get; set; }

            [NameInMap("AlertTargets")]
            [Validation(Required=false)]
            public List<string> AlertTargets { get; set; }

            /// <summary>
            /// The recipient of the alert. Valid values: OWNER and OTHER. The value OWNER indicates the node owner. The value OTHER indicates a specified user.
            /// </summary>
            [NameInMap("AlertUnit")]
            [Validation(Required=false)]
            public string AlertUnit { get; set; }

            [NameInMap("AllowNodes")]
            [Validation(Required=false)]
            public List<long?> AllowNodes { get; set; }

            /// <summary>
            /// The baselines to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BASELINE.
            /// </summary>
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBaselines> Baselines { get; set; }
            public class GetRemindResponseBodyDataBaselines : TeaModel {
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

            }

            /// <summary>
            /// The workflows to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BIZPROCESS.
            /// </summary>
            [NameInMap("BizProcesses")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBizProcesses> BizProcesses { get; set; }
            public class GetRemindResponseBodyDataBizProcesses : TeaModel {
                /// <summary>
                /// The workflow ID.
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// The name of the workflow.
                /// </summary>
                [NameInMap("BizProcessName")]
                [Validation(Required=false)]
                public string BizProcessName { get; set; }

            }

            /// <summary>
            /// *   If the value of the RemindType parameter is FINISHED, this parameter is left empty.
            /// *   If the value of the RemindType parameter is UNFINISHED, the trigger conditions are returned as key-value pairs. Example: {"hour":23,"minu":59}. Valid values of hour: [0,47]. Valid values of minu: [0,59].
            /// *   If the value of the RemindType parameter is ERROR, this parameter is left empty.
            /// *   If the value of the RemindType parameter is CYCLE_UNFINISHED, the trigger conditions are returned as key-value pairs. Example: {"1":"05:50","2":"06:50","3":"07:50","4":"08:50","5":"09:50","6":"10:50","7":"11:50","8":"12:50","9":"13:50","10":"14:50","11":"15:50","12":"16:50","13":"17:50","14":"18:50","15":"19:50","16":"20:50","17":"21:50","18":"22:50","19":"23:50","20":"24:50","21":"25:50"}. The key indicates the ID of the cycle. Valid values: [1,288]. The value indicates the timeout period of the node that is running in the cycle. Specify the value in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].
            /// *   If the value of the RemindType parameter is TIMEOUT, the timeout period is returned. Unit: seconds. Example: 1800. This value indicates that an alert is reported if the node has run for more than 30 minutes.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The end time of the quiet hours. The value is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].
            /// </summary>
            [NameInMap("DndEnd")]
            [Validation(Required=false)]
            public string DndEnd { get; set; }

            /// <summary>
            /// The start time of the quiet hours. The value is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].
            /// </summary>
            [NameInMap("DndStart")]
            [Validation(Required=false)]
            public string DndStart { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the creator of the custom alert rule.
            /// </summary>
            [NameInMap("Founder")]
            [Validation(Required=false)]
            public string Founder { get; set; }

            /// <summary>
            /// The maximum number of alerts.
            /// </summary>
            [NameInMap("MaxAlertTimes")]
            [Validation(Required=false)]
            public int? MaxAlertTimes { get; set; }

            /// <summary>
            /// The nodes to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is NODE.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataNodes> Nodes { get; set; }
            public class GetRemindResponseBodyDataNodes : TeaModel {
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
            /// The workspaces to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is PROJECT.
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataProjects> Projects { get; set; }
            public class GetRemindResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// The workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataReceivers> Receivers { get; set; }
            public class GetRemindResponseBodyDataReceivers : TeaModel {
                [NameInMap("AlertTargets")]
                [Validation(Required=false)]
                public List<string> AlertTargets { get; set; }

                [NameInMap("AlertUnit")]
                [Validation(Required=false)]
                public string AlertUnit { get; set; }

            }

            /// <summary>
            /// The custom alert rule ID.
            /// </summary>
            [NameInMap("RemindId")]
            [Validation(Required=false)]
            public long? RemindId { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RemindName")]
            [Validation(Required=false)]
            public string RemindName { get; set; }

            /// <summary>
            /// The conditions that trigger an alert. Valid values: FINISHED, UNFINISHED, ERROR, CYCLE_UNFINISHED, and TIMEOUT.
            /// </summary>
            [NameInMap("RemindType")]
            [Validation(Required=false)]
            public string RemindType { get; set; }

            /// <summary>
            /// The type of the object to which the custom alert rule is applied. Valid values: NODE, BASELINE, PROJECT, and BIZPROCESS. The value NODE indicates a node. The value BASELINE indicates a baseline. The value PROJECT indicates a workspace. The value BIZPROCESS indicates a workflow.
            /// </summary>
            [NameInMap("RemindUnit")]
            [Validation(Required=false)]
            public string RemindUnit { get; set; }

            /// <summary>
            /// The webhook URLs of the DingTalk chatbots.
            /// </summary>
            [NameInMap("Robots")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataRobots> Robots { get; set; }
            public class GetRemindResponseBodyDataRobots : TeaModel {
                /// <summary>
                /// Indicates whether all group members are notified when the alert notification is sent to a DingTalk group. Valid values: true and false.
                /// </summary>
                [NameInMap("AtAll")]
                [Validation(Required=false)]
                public bool? AtAll { get; set; }

                /// <summary>
                /// The webhook URL of the DingTalk chatbot.
                /// </summary>
                [NameInMap("WebUrl")]
                [Validation(Required=false)]
                public string WebUrl { get; set; }

            }

            /// <summary>
            /// Indicates whether the custom alert rule is enabled. Valid values: true and false.
            /// </summary>
            [NameInMap("Useflag")]
            [Validation(Required=false)]
            public bool? Useflag { get; set; }

            [NameInMap("Webhooks")]
            [Validation(Required=false)]
            public List<string> Webhooks { get; set; }

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
        /// The request ID. You can use the ID to troubleshoot issues.
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
