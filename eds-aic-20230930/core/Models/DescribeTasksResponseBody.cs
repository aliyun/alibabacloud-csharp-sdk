// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTasksResponseBodyData> Data { get; set; }
        public class DescribeTasksResponseBodyData : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("FailedChildCount")]
            [Validation(Required=false)]
            public int? FailedChildCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-10-11T08:53:32Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>B8ED2BA9-0C6A-5643-818F-B5D60A64****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            [NameInMap("ParentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-25nt4kk9whhok****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("RunningChildCount")]
            [Validation(Required=false)]
            public int? RunningChildCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-10-11T08:53:32Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("SuccessChildCount")]
            [Validation(Required=false)]
            public int? SuccessChildCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Processing</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>StartInstance</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("TotalChildCount")]
            [Validation(Required=false)]
            public int? TotalChildCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B8ED2BA9-0C6A-5643-818F-B5D60A64****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
