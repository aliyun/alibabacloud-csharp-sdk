// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster for which the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-02T03:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4352AD99-9FF5-41A6-A319-068089******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-30T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// <para>The time when the task was started. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-02T02:39:15Z</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                /// <summary>
                /// <para>The name of the current step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_instance</para>
                /// </summary>
                [NameInMap("CurrentStepName")]
                [Validation(Required=false)]
                public string CurrentStepName { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// <remarks>
                /// <para> This parameter is returned for only the tasks that involve database operations.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The estimated end time of the task. In most cases, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ExpectedFinishTime")]
                [Validation(Required=false)]
                public string ExpectedFinishTime { get; set; }

                /// <summary>
                /// <para>The time when the task was completed. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-02T02:40:15Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The progress of the task in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The description of the task progress. If no progress description is provided for the task, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ProgressInfo")]
                [Validation(Required=false)]
                public string ProgressInfo { get; set; }

                /// <summary>
                /// <para>The estimated remaining duration of the task. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1767</para>
                /// </summary>
                [NameInMap("Remain")]
                [Validation(Required=false)]
                public int? Remain { get; set; }

                /// <summary>
                /// <para>The progress of the subtasks. For example, the value <c>1/4</c> indicates that the task consists of four subtasks and the first subtask is in progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1/4</para>
                /// </summary>
                [NameInMap("StepProgressInfo")]
                [Validation(Required=false)]
                public string StepProgressInfo { get; set; }

                /// <summary>
                /// <para>The details of the subtasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;remain\&quot;:0,\&quot;name\&quot;:\&quot;init_task\&quot;,\&quot;progress\&quot;:100},{\&quot;remain\&quot;:1764,\&quot;name\&quot;:\&quot;create_instance\&quot;,\&quot;progress\&quot;:0},{\&quot;remain\&quot;:1,\&quot;name\&quot;:\&quot;init_cluster\&quot;,\&quot;progress\&quot;:0},{\&quot;remain\&quot;:2,\&quot;name\&quot;:\&quot;create_backup\&quot;,\&quot;progress\&quot;:0}]</para>
                /// </summary>
                [NameInMap("StepsInfo")]
                [Validation(Required=false)]
                public string StepsInfo { get; set; }

                /// <summary>
                /// <para>The API operation that is used by the task. Example: <c>CreateDBInstance</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateDBInstance</para>
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// <para>The error code that is returned when an error occurs.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the task is in the <b>Stop</b> state.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("TaskErrorCode")]
                [Validation(Required=false)]
                public string TaskErrorCode { get; set; }

                /// <summary>
                /// <para>The error message that is returned when an error occurs.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the task is in the <b>Stop</b> state.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("TaskErrorMessage")]
                [Validation(Required=false)]
                public string TaskErrorMessage { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111111</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
