// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeCommitContainerTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the task.</para>
        /// </summary>
        [NameInMap("CommitTasks")]
        [Validation(Required=false)]
        public List<DescribeCommitContainerTaskResponseBodyCommitTasks> CommitTasks { get; set; }
        public class DescribeCommitContainerTaskResponseBodyCommitTasks : TeaModel {
            /// <summary>
            /// <para>The information about the phase that the task arrives.</para>
            /// </summary>
            [NameInMap("CommitPhaseInfos")]
            [Validation(Required=false)]
            public List<DescribeCommitContainerTaskResponseBodyCommitTasksCommitPhaseInfos> CommitPhaseInfos { get; set; }
            public class DescribeCommitContainerTaskResponseBodyCommitTasksCommitPhaseInfos : TeaModel {
                /// <summary>
                /// <para>The message about the phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pull base image for container container-1 successfully</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The phase name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PullBaseImage: Pull the original container image.</description></item>
                /// <item><description>CommitContainer: Commit the container to generate an image.</description></item>
                /// <item><description>PushCommittedImage: Push the image to Container Registry.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PullBaseImage</para>
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <para>The record time of the phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-05T14:06:40.920005316+08:00</para>
                /// </summary>
                [NameInMap("RecordTime")]
                [Validation(Required=false)]
                public string RecordTime { get; set; }

                /// <summary>
                /// <para>The state of the phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The container name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker0</para>
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// <para>The message about the state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Commit container -xxxxxx</para>
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The time when the task was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-06T08:22:40Z</para>
            /// </summary>
            [NameInMap("TaskCreationTime")]
            [Validation(Required=false)]
            public string TaskCreationTime { get; set; }

            /// <summary>
            /// <para>The time when the task was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-06T08:23:40Z</para>
            /// </summary>
            [NameInMap("TaskFinishedTime")]
            [Validation(Required=false)]
            public string TaskFinishedTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-2zej6nstkg744qc3****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The progress of the task in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50%</para>
            /// </summary>
            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public string TaskProgress { get; set; }

            /// <summary>
            /// <para>The state of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running</description></item>
            /// <item><description>Succeeded</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The query token that is returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D5B0AD-3B00-4A9B-9911-6D5303B06712</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
