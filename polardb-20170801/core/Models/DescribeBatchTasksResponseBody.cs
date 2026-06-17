// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBatchTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned results.</para>
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
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>925B84D9-CA72-432C-95CF-738C22******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task list.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeBatchTasksResponseBodyTaskList> TaskList { get; set; }
        public class DescribeBatchTasksResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcb-xxx</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

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
            /// <para>The number of successfully completed subtasks in the batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The task start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-06 20:51:44</para>
            /// </summary>
            [NameInMap("TaskBegin")]
            [Validation(Required=false)]
            public string TaskBegin { get; set; }

            /// <summary>
            /// <para>The task end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-06 22:43:26</para>
            /// </summary>
            [NameInMap("TaskEnd")]
            [Validation(Required=false)]
            public string TaskEnd { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>batch_task_test</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarclaw_install_skills</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total number of subtasks in the batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The total number of tasks that match the query, ignoring pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
