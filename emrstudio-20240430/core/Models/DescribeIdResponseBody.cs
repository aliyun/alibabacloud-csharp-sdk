// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>p-123****</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public DescribeIdResponseBodyData Data { get; set; }
        public class DescribeIdResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>p-123****</para>
            /// </summary>
            [NameInMap("inputId")]
            [Validation(Required=false)]
            public string InputId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROJECT</para>
            /// </summary>
            [NameInMap("inputIdType")]
            [Validation(Required=false)]
            public string InputIdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mt-123****</para>
            /// </summary>
            [NameInMap("manualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mti-123****</para>
            /// </summary>
            [NameInMap("manualTaskInstanceId")]
            [Validation(Required=false)]
            public string ManualTaskInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-123****</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-123****</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ti-123****</para>
            /// </summary>
            [NameInMap("taskInstanceId")]
            [Validation(Required=false)]
            public string TaskInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>w-123****</para>
            /// </summary>
            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wi-123****</para>
            /// </summary>
            [NameInMap("workflowInstanceId")]
            [Validation(Required=false)]
            public string WorkflowInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace-123****</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
