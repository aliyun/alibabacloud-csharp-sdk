// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The real-time status information of the asynchronous task.</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public GetJobStatusResponseBodyJobStatus JobStatus { get; set; }
        public class GetJobStatusResponseBodyJobStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether the asynchronous task is complete. Valid values: True False</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public string Completed { get; set; }

            /// <summary>
            /// <para>The time when the asynchronous task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729063449802</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned if the asynchronous task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not Found</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C664CDE3-9C0B-5792-B17F-6C543783BBBC</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The type of the asynchronous task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Create</b>: The asynchronous task is used to create an object.</para>
            /// </description></item>
            /// <item><description><para><b>Update</b>: The asynchronous task is used to update an object.</para>
            /// </description></item>
            /// <item><description><para><b>Cancel</b>: The asynchronous task is used to cancel an operation.</para>
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
            /// <para>The status of the asynchronous task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Success</b></para>
            /// </description></item>
            /// <item><description><para><b>Fail</b></para>
            /// </description></item>
            /// <item><description><para><b>Cancel</b></para>
            /// </description></item>
            /// <item><description><para><b>Running</b></para>
            /// </description></item>
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
