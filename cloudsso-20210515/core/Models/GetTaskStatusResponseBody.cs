// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005F4623-AE53-504D-830F-44825F7DC211</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status information about the task.</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public GetTaskStatusResponseBodyTaskStatus TaskStatus { get; set; }
        public class GetTaskStatusResponseBodyTaskStatus : TeaModel {
            /// <summary>
            /// <para>The end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-05T02:58:08Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The cause of the task failure.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of <c>Status</c> is <c>Failed</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>No Permission.</para>
            /// </summary>
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            /// <summary>
            /// <para>The start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-05T02:58:07Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InProgress: The task is running.</description></item>
            /// <item><description>Success: The task is successful.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-shfqw1u1edszvxw5****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProvisionAccessConfiguration: An access configuration is provisioned.</description></item>
            /// <item><description>DeprovisionAccessConfiguration: An access configuration is de-provisioned.</description></item>
            /// <item><description>CreateAccessAssignment: Access permissions on an account in the resource directory are assigned.</description></item>
            /// <item><description>DeleteAccessAssignment: Access permissions on an account in the resource directory are removed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DeleteAccessAssignment</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
