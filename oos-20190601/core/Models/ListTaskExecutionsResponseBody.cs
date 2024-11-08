// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTaskExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ3NjFENDdB</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDABABABAB-FC28-4D9C-8FB5-68DC6F0486FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution ID of the child node.</para>
        /// </summary>
        [NameInMap("TaskExecutions")]
        [Validation(Required=false)]
        public List<ListTaskExecutionsResponseBodyTaskExecutions> TaskExecutions { get; set; }
        public class ListTaskExecutionsResponseBodyTaskExecutions : TeaModel {
            /// <summary>
            /// <para>The output of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-xxx</para>
            /// </summary>
            [NameInMap("ChildExecutionId")]
            [Validation(Required=false)]
            public string ChildExecutionId { get; set; }

            /// <summary>
            /// <para>The ID of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The execution ID of the parent node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The action of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-44d32b45d2a449e49899</para>
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// <para>The Input parameters of the task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{                     &quot;NotifyNote&quot;:&quot;&quot;                 }</para>
            /// </summary>
            [NameInMap("ExtraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Loop")]
            [Validation(Required=false)]
            public Dictionary<string, object> Loop { get; set; }

            /// <summary>
            /// <para>The status information of the task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LoopBatchNumber")]
            [Validation(Required=false)]
            public int? LoopBatchNumber { get; set; }

            /// <summary>
            /// <para>The time when the execution was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-1234566zxcvvb</para>
            /// </summary>
            [NameInMap("LoopItem")]
            [Validation(Required=false)]
            public string LoopItem { get; set; }

            /// <summary>
            /// <para>The status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;InstanceId&quot;:&quot;i-xxx&quot; }</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-exec-xxx</para>
            /// </summary>
            [NameInMap("ParentTaskExecutionId")]
            [Validation(Required=false)]
            public string ParentTaskExecutionId { get; set; }

            /// <summary>
            /// <para>Queries task executions. Multiple methods are supported to filter task executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Status&quot;:&quot;Running&quot; }</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>The elements in the loop task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The time when the task execution stopped running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The execution ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::Sleep</para>
            /// </summary>
            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            /// <summary>
            /// <para>The time when the execution was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-exec-xxx</para>
            /// </summary>
            [NameInMap("TaskExecutionId")]
            [Validation(Required=false)]
            public string TaskExecutionId { get; set; }

            /// <summary>
            /// <para>The time when the execution started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>describeInstance</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The number of times for which the loop task is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The configuration and statistics information of the loop task. This parameter is returned only for the parent node of the loop task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

    }

}
