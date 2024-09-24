// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetWorkflowTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>0C-7870-15FE-B96F-8880BB</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkflowTask")]
        [Validation(Required=false)]
        public GetWorkflowTaskResponseBodyWorkflowTask WorkflowTask { get; set; }
        public class GetWorkflowTaskResponseBodyWorkflowTask : TeaModel {
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public string ActivityResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-04T02:05:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-04T02:06:19Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b><b>4215e042b3966ca5441e</b></b></b></para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public GetWorkflowTaskResponseBodyWorkflowTaskWorkflow Workflow { get; set; }
            public class GetWorkflowTaskResponseBodyWorkflowTaskWorkflow : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-11-27T10:02:12Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-11-29T02:06:19Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Common</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
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
