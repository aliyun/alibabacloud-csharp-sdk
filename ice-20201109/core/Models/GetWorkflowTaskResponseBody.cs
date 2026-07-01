// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetWorkflowTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>0C-7870-15FE-B96F-8880BB</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the workflow task.</para>
        /// </summary>
        [NameInMap("WorkflowTask")]
        [Validation(Required=false)]
        public GetWorkflowTaskResponseBodyWorkflowTask WorkflowTask { get; set; }
        public class GetWorkflowTaskResponseBodyWorkflowTask : TeaModel {
            /// <summary>
            /// <para>The results for all nodes of the workflow task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Json格式，内容根据工作流配置有变化。</para>
            /// </summary>
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public string ActivityResults { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-04T02:05:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the task was complete. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-04T02:06:19Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The task state.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Init: The task is being initialized.</para>
            /// </description></item>
            /// <item><description><para>Failed: The task failed.</para>
            /// </description></item>
            /// <item><description><para>Canceled: The task is canceled.</para>
            /// </description></item>
            /// <item><description><para>Processing: The task is in progress.</para>
            /// </description></item>
            /// <item><description><para>Succeed: The task is successful.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the workflow task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>4215e042b3966ca5441e</b></b></b></para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The input of the workflow task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;Type&quot;: &quot;Media&quot;,
            ///       &quot;Media&quot;: &quot;<b><b><b>30706071edbfe290b488</b></b></b>&quot;
            /// }</para>
            /// </summary>
            [NameInMap("TaskInput")]
            [Validation(Required=false)]
            public string TaskInput { get; set; }

            /// <summary>
            /// <para>The user-defined field that was specified when the workflow task was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The workflow Information.</para>
            /// </summary>
            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public GetWorkflowTaskResponseBodyWorkflowTaskWorkflow Workflow { get; set; }
            public class GetWorkflowTaskResponseBodyWorkflowTaskWorkflow : TeaModel {
                /// <summary>
                /// <para>The time when the workflow was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-27T10:02:12Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-29T02:06:19Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The workflow name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Super-resolution transcoding workflow</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The workflow state.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Active</para>
                /// </description></item>
                /// <item><description><para>Inactive</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The workflow type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Customize: custom workflow.</para>
                /// </description></item>
                /// <item><description><para>System: system workflow.</para>
                /// </description></item>
                /// <item><description><para>Common: user-created workflow.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Common</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b><b>63dca94c609de02ac0d1</b></b></b></para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public string WorkflowId { get; set; }

            }

        }

    }

}
