// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The real-time result of the task status.</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public GetJobStatusResponseBodyJobStatus JobStatus { get; set; }
        public class GetJobStatusResponseBodyJobStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether the operation is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: The current job has been completed.</description></item>
            /// <item><description>False: The current job is still running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public string Completed { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The value is a 13-digit number, such as <c>1729063449802</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729063449802</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The task failure information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not Found</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The asynchronous task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C664CDE3-9C0B-5792-B17F-6C543783BBBC</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Create</b>: A creation task.</para>
            /// </description></item>
            /// <item><description><para><b>Update</b>: An update task.</para>
            /// </description></item>
            /// <item><description><para><b>Cancel</b>: A cancellation task.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Create</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: succeeded.</description></item>
            /// <item><description><b>Fail</b>: failed.</description></item>
            /// <item><description><b>Cancel</b>: canceled.</description></item>
            /// <item><description><b>Running</b>: running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E2BFE96-C0E0-5A98-85C8-633EC803198D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
