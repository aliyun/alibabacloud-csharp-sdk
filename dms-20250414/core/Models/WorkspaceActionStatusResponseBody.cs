// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class WorkspaceActionStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public WorkspaceActionStatusResponseBodyData Data { get; set; }
        public class WorkspaceActionStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>action failed</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-13T14:30:20.582182728+08:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-13T14:30:20.582182728+08:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;phase\&quot;: \&quot;Created\&quot;, \&quot;latestExecError\&quot;: {\&quot;message\&quot;: \&quot;\&quot;, \&quot;code\&quot;: \&quot;\&quot;, \&quot;requestId\&quot;: \&quot;\&quot;, \&quot;extraInfo\&quot;: \&quot;\&quot;, \&quot;title\&quot;: \&quot;\&quot;}}</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This record is being collected, please wait for a moment.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
