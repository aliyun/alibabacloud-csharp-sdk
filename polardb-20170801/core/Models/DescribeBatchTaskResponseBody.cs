// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBatchTaskResponseBody : TeaModel {
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The ID of the batch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcb-xxx</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25C70FF3-D49B-594D-BECE-0DE2BA1D8BBB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A list of subtasks.</para>
        /// </summary>
        [NameInMap("SubTasks")]
        [Validation(Required=false)]
        public List<DescribeBatchTaskResponseBodySubTasks> SubTasks { get; set; }
        public class DescribeBatchTaskResponseBodySubTasks : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliuid:1422133474238823 assumeOssRole not exist,serviceName:aliyunesarealtimelogpushossrole</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-pz5f6mvi1p84t35d7</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the subtask started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026/05/28T17:38:20Z</para>
            /// </summary>
            [NameInMap("TaskBegin")]
            [Validation(Required=false)]
            public string TaskBegin { get; set; }

            /// <summary>
            /// <para>The time when the subtask ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026/05/28T20:38:20Z</para>
            /// </summary>
            [NameInMap("TaskEnd")]
            [Validation(Required=false)]
            public string TaskEnd { get; set; }

            /// <summary>
            /// <para>The ID of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>629271331</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The number of successful subtasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The time when the task started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026/05/28T16:38:20Z</para>
        /// </summary>
        [NameInMap("TaskBegin")]
        [Validation(Required=false)]
        public string TaskBegin { get; set; }

        /// <summary>
        /// <para>The time when the task ended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026/05/28T15:23:47Z</para>
        /// </summary>
        [NameInMap("TaskEnd")]
        [Validation(Required=false)]
        public string TaskEnd { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch_task_test</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarclaw_install_skills</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The total number of subtasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
