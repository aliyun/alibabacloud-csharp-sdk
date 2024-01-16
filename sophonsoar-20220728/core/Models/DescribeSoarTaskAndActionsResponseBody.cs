// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarTaskAndActionsResponseBody : TeaModel {
        /// <summary>
        /// The execution details of each task.
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public DescribeSoarTaskAndActionsResponseBodyDetails Details { get; set; }
        public class DescribeSoarTaskAndActionsResponseBodyDetails : TeaModel {
            /// <summary>
            /// The list of component actions during the running of the playbook.
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<DescribeSoarTaskAndActionsResponseBodyDetailsActions> Actions { get; set; }
            public class DescribeSoarTaskAndActionsResponseBodyDetailsActions : TeaModel {
                /// <summary>
                /// The action name of the component.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The UUID of the component execution record.
                /// </summary>
                [NameInMap("ActionUuid")]
                [Validation(Required=false)]
                public string ActionUuid { get; set; }

                /// <summary>
                /// The name of the asset that is used by the component.
                /// </summary>
                [NameInMap("AssetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                /// <summary>
                /// The component name.
                /// </summary>
                [NameInMap("Component")]
                [Validation(Required=false)]
                public string Component { get; set; }

                /// <summary>
                /// The end of the time range during which the component is run. The value is a 13-digit timestamp.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The custom name of the node in the component.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The request ID of the task. The value is unique.
                /// </summary>
                [NameInMap("RequestUuid")]
                [Validation(Required=false)]
                public string RequestUuid { get; set; }

                /// <summary>
                /// The beginning of the time range during which the component is run. The value is a 13-digit timestamp.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The running result of the component. Valid values:
                /// 
                /// *   **success**
                /// *   **fail**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The name of the task. The value is the same as the playbook UUID.
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// The status of the triggered component action.
                /// 
                /// >  This parameter is disabled and left empty.
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to execute the task.
                /// </summary>
                [NameInMap("TriggerUser")]
                [Validation(Required=false)]
                public string TriggerUser { get; set; }

            }

            /// <summary>
            /// The end of the time range during which the playbook is run. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The error message of the task. If the task is successful, this field is empty.
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// The request parameters of the task.
            /// </summary>
            [NameInMap("RawEventReq")]
            [Validation(Required=false)]
            public string RawEventReq { get; set; }

            /// <summary>
            /// The request ID of the task. The value is unique.
            /// </summary>
            [NameInMap("RequestUuid")]
            [Validation(Required=false)]
            public string RequestUuid { get; set; }

            /// <summary>
            /// The flag of the task. For debugging tasks, the value is **DEBUG**. For other tasks, the parameter is left empty.
            /// </summary>
            [NameInMap("ResultLevel")]
            [Validation(Required=false)]
            public string ResultLevel { get; set; }

            /// <summary>
            /// The returned information about the playbook. You can define the value in the playbook.
            /// </summary>
            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            /// <summary>
            /// The beginning of the time range during which the playbook is run. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The task status. Valid values:
            /// 
            /// *   **success**
            /// *   **fail**
            /// *   **running**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The MD5 value of the playbook.
            /// </summary>
            [NameInMap("TaskFlowMd5")]
            [Validation(Required=false)]
            public string TaskFlowMd5 { get; set; }

            /// <summary>
            /// The name of the task. The value is the same as the playbook UUID.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the task belongs.
            /// </summary>
            [NameInMap("TaskTenantId")]
            [Validation(Required=false)]
            public string TaskTenantId { get; set; }

            /// <summary>
            /// The task type. Valid values:
            /// 
            /// *   **debug**: a debugging task
            /// *   **manual**: a manual task
            /// *   **siem**: an event-triggered task
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that triggers the task.
            /// </summary>
            [NameInMap("TriggerUser")]
            [Validation(Required=false)]
            public string TriggerUser { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
