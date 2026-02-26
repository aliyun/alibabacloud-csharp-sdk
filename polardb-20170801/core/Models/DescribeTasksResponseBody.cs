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

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeTasksResponseBodyTasksTask : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                [NameInMap("CurrentStepName")]
                [Validation(Required=false)]
                public string CurrentStepName { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("ExpectedFinishTime")]
                [Validation(Required=false)]
                public string ExpectedFinishTime { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("ProgressInfo")]
                [Validation(Required=false)]
                public string ProgressInfo { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public int? Remain { get; set; }

                [NameInMap("StepProgressInfo")]
                [Validation(Required=false)]
                public string StepProgressInfo { get; set; }

                [NameInMap("StepsInfo")]
                [Validation(Required=false)]
                public string StepsInfo { get; set; }

                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                [NameInMap("TaskErrorCode")]
                [Validation(Required=false)]
                public string TaskErrorCode { get; set; }

                [NameInMap("TaskErrorMessage")]
                [Validation(Required=false)]
                public string TaskErrorMessage { get; set; }

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
