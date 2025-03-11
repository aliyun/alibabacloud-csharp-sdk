// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceLevelTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F7F8080-9132-4279-85D0-B7E5C4305162</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The list of returned unfinished tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceLevelTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDrdsInstanceLevelTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceLevelTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDrdsInstanceLevelTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// <para>Indicates whether the task can be canceled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowCancel")]
                [Validation(Required=false)]
                public bool? AllowCancel { get; set; }

                /// <summary>
                /// <para>The error message returned for the task.</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The timestamp when the task is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568705520000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The progress of the task. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The description of the task progress.</para>
                /// </summary>
                [NameInMap("ProgressDescription")]
                [Validation(Required=false)]
                public string ProgressDescription { get; set; }

                /// <summary>
                /// <para>Indicates whether the progress of the task is displayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowProgress")]
                [Validation(Required=false)]
                public bool? ShowProgress { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12312</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public long? TargetId { get; set; }

                /// <summary>
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>upgrade_instance</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The phase of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskPhase")]
                [Validation(Required=false)]
                public string TaskPhase { get; set; }

                /// <summary>
                /// <para>The state of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The task is being executed.</description></item>
                /// <item><description>1: The task is executed.</description></item>
                /// <item><description>2: The task failed to be executed.</description></item>
                /// <item><description>3: The task is canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

                /// <summary>
                /// <para>The type of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

        }

    }

}
