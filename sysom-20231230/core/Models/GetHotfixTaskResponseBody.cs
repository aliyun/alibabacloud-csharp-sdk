// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotfixTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code</c> is <c>Success</c>, the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization failed. If the authorization fails, check the <c>message</c> field for the detailed fault information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHotfixTaskResponseBodyData Data { get; set; }
        public class GetHotfixTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-13T08:14:40</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>CVE ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2026-31431</para>
            /// </summary>
            [NameInMap("cveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-13T08:14:40</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The list of instance tasks.</para>
            /// </summary>
            [NameInMap("jobs")]
            [Validation(Required=false)]
            public List<GetHotfixTaskResponseBodyDataJobs> Jobs { get; set; }
            public class GetHotfixTaskResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// <para>The unified error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSTANCE_NOT_EXISTS</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The specified instance does not exist</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The hotfix status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONFLICT</para>
                /// </summary>
                [NameInMap("hotfixStatus")]
                [Validation(Required=false)]
                public string HotfixStatus { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zehme0rs1tc090fdl3n</para>
                /// </summary>
                [NameInMap("instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The status of the instance task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The operation type of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Install</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hotfix-da3dcc0b-5019-4b59-b12f-2e500da9083c</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code</c> is <c>Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
