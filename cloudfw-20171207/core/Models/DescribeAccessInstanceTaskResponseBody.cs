// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAccessInstanceTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the task exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFound")]
        [Validation(Required=false)]
        public bool? IsFound { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the task was completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17151381075</para>
        /// </summary>
        [NameInMap("TaskFinishTimestamp")]
        [Validation(Required=false)]
        public long? TaskFinishTimestamp { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3c9d576f-fce0-4caa-9116-15033509bdb6</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create an ACK cluster connector</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17151361285</para>
        /// </summary>
        [NameInMap("TaskStartTimestamp")]
        [Validation(Required=false)]
        public long? TaskStartTimestamp { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The steps of the task.</para>
        /// </summary>
        [NameInMap("TaskSteps")]
        [Validation(Required=false)]
        public List<DescribeAccessInstanceTaskResponseBodyTaskSteps> TaskSteps { get; set; }
        public class DescribeAccessInstanceTaskResponseBodyTaskSteps : TeaModel {
            /// <summary>
            /// <para>The name of the step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Obtain ACK cluster information</para>
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// <para>The progress of the step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("StepProgress")]
            [Validation(Required=false)]
            public string StepProgress { get; set; }

            /// <summary>
            /// <para>The status of the step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

        }

    }

}
