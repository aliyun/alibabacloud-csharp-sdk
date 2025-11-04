// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAIWorkflowTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the workflow task.</para>
        /// </summary>
        [NameInMap("WorkflowTask")]
        [Validation(Required=false)]
        public GetAIWorkflowTaskResponseBodyWorkflowTask WorkflowTask { get; set; }
        public class GetAIWorkflowTaskResponseBodyWorkflowTask : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-28T02:17:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the task was complete. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-19T02:28:22Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The input parameters of the workflow task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;source_language_id\&quot;:\&quot;en\&quot;,\&quot;live_id\&quot;:123,\&quot;live_url\&quot;:{\&quot;url\&quot;:\&quot;rtmp://test.com.cn/video/638d9088fe4f15ce\&quot;}}</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

            /// <summary>
            /// <para>The results of the workflow nodes. The structure of this JSON varies based on the workflow\&quot;s configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{...}</para>
            /// </summary>
            [NameInMap("NodeResults")]
            [Validation(Required=false)]
            public string NodeResults { get; set; }

            /// <summary>
            /// <para>The node output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            /// &quot;result&quot;:&quot;test&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The task state.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running</description></item>
            /// <item><description>stopped</description></item>
            /// <item><description>failed</description></item>
            /// <item><description>partial-succeeded</description></item>
            /// <item><description>succeeded</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the workflow task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b><b>-67fd-43aa-9cc1-3e7f</b></b></b></b></para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The user-defined data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The version of the workflow template that was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>ec0a-e3b9-40b1-abf2-6549d00e</b></b></para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The workflow template information.</para>
            /// </summary>
            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public GetAIWorkflowTaskResponseBodyWorkflowTaskWorkflow Workflow { get; set; }
            public class GetAIWorkflowTaskResponseBodyWorkflowTaskWorkflow : TeaModel {
                /// <summary>
                /// <para>The time when the template was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-08-20T01:35:04Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The workflow\&quot;s topological structure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                /// &quot;nodes&quot;:[...],
                /// &quot;edges&quot;:[...]
                /// }</para>
                /// </summary>
                [NameInMap("Graph")]
                [Validation(Required=false)]
                public string Graph { get; set; }

                /// <summary>
                /// <para>The time when the template was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-08-20T01:35:04Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The name of the workflow template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RealtimeTranslation</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Workflow template status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Draft</description></item>
                /// <item><description>Published</description></item>
                /// <item><description>Editing</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Draft</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The scenario type of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Live</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The template version.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>ec0a-e3b9-40b1-abf2-6549d00e</b></b></para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The ID of the workflow template.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>3f44-f1f6-477e-9364-c5e6c49e</b></b></para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public string WorkflowId { get; set; }

            }

        }

    }

}
