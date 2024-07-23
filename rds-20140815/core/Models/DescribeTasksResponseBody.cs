// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task execution.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyItems Items { get; set; }
        public class DescribeTasksResponseBodyItems : TeaModel {
            [NameInMap("TaskProgressInfo")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyItemsTaskProgressInfo> TaskProgressInfo { get; set; }
            public class DescribeTasksResponseBodyItemsTaskProgressInfo : TeaModel {
                /// <summary>
                /// <para>The start time of the task. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC .</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-20T01:00Z</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                /// <summary>
                /// <para>The name of the subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_instance</para>
                /// </summary>
                [NameInMap("CurrentStepName")]
                [Validation(Required=false)]
                public string CurrentStepName { get; set; }

                /// <summary>
                /// <para>The name of the database. If the task involves a database, the database name is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DBtest</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The estimated end time of the task.</para>
                /// <remarks>
                /// <para>In most cases, this parameter is empty.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ExpectedFinishTime")]
                [Validation(Required=false)]
                public string ExpectedFinishTime { get; set; }

                /// <summary>
                /// <para>The end time of the task. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-20T02:00Z</para>
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
                public string Progress { get; set; }

                /// <summary>
                /// <para>The description of the task progress.</para>
                /// <remarks>
                /// <para>If no progress description is provided for the task, this parameter is empty.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ProgressInfo")]
                [Validation(Required=false)]
                public string ProgressInfo { get; set; }

                /// <summary>
                /// <para>The estimated remaining time of the task. Unit: seconds.</para>
                /// <remarks>
                /// <para> If the task is not running, this parameter is not returned or the returned value is <b>0</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Remain")]
                [Validation(Required=false)]
                public int? Remain { get; set; }

                /// <summary>
                /// <para>The status of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The progress of the subtask. For example, a value of <c>1/4</c> indicates that the task consists of four subtasks and the first subtask is in progress.</para>
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
                /// <para>null</para>
                /// </summary>
                [NameInMap("StepsInfo")]
                [Validation(Required=false)]
                public string StepsInfo { get; set; }

                /// <summary>
                /// <para>The operation that is used by the task, such as <b>CreateDBInstance</b>.</para>
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
                /// <para>This parameter is returned only when an error occurs.</para>
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
                /// <para> This parameter is returned only when an error occurs.</para>
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
                /// <para>3472xxxxx</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A103039D-B1B2-4C57-B989-7D7C0DA95426</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
