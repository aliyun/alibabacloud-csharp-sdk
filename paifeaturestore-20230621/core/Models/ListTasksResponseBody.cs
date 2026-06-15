// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33E160C-BFCA-5719-B958-942850E949F6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTasks> Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T11:26:09.036+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the task was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T11:26:09.036+08:00</para>
            /// </summary>
            [NameInMap("GmtExecutedTime")]
            [Validation(Required=false)]
            public string GmtExecutedTime { get; set; }

            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T11:26:09.036+08:00</para>
            /// </summary>
            [NameInMap("GmtFinishedTime")]
            [Validation(Required=false)]
            public string GmtFinishedTime { get; set; }

            /// <summary>
            /// <para>The ID of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The type of the object. Valid values:</para>
            /// <para>● ModelFeature: a model feature.</para>
            /// <para>● FeatureView: a feature view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ModelFeature</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project_1</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <para>● Initializing: The task is being initialized.</para>
            /// <para>● Running: The task is in progress.</para>
            /// <para>● Success: The task is successful.</para>
            /// <para>● Failure: The task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <para>● OfflineToOnline: The task synchronizes data from offline to online.</para>
            /// <para>● ExportTrainingSet: The task exports a training set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OfflineToOnline</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
