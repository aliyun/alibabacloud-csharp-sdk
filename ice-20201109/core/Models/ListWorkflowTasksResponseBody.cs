// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListWorkflowTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned in this response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****8EqYpQbZ6Eh7+Zz8DxVYoQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0C02296-113C-5838-8FE9-8F3A32998DDC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The media workflow tasks.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<ListWorkflowTasksResponseBodyTaskList> TaskList { get; set; }
        public class ListWorkflowTasksResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The time the task was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-15T09:45:48Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time the task was completed. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-07T10:53:45Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The task state.</para>
            /// <para><b>Valid values</b>:</para>
            /// <list type="bullet">
            /// <item><description>Init: Initializing</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Canceled</description></item>
            /// <item><description>Processing</description></item>
            /// <item><description>Succeed</description></item>
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
            /// <para><em><b><b>4c93d2f404f8345b16a965</b></b></em></para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The input data for the workflow task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Type\&quot;:\&quot;Media\&quot;,\&quot;Media\&quot;:\&quot;<b><b>8b40884171efb0d9e7f7f458</b></b>\&quot;}</para>
            /// </summary>
            [NameInMap("TaskInput")]
            [Validation(Required=false)]
            public string TaskInput { get; set; }

            /// <summary>
            /// <para>The custom data that was passed when the task was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The information about the workflow template.</para>
            /// </summary>
            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public ListWorkflowTasksResponseBodyTaskListWorkflow Workflow { get; set; }
            public class ListWorkflowTasksResponseBodyTaskListWorkflow : TeaModel {
                /// <summary>
                /// <para>The creation time of the workflow template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-21T01:48:49Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The source of the media file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: an OSS object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The last modification time of the workflow template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-23 10:19:37 +0800</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The name of the workflow template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-workflow-***</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the workflow template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the workflow template.</para>
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
                /// <para><b><b><b>2491c84dce913da9fe65</b></b></b></para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public string WorkflowId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned. By default, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
