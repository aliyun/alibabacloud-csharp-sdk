// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is 200 when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of sandboxes that meet the filter conditions.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListSandboxesResponseBodyItems> Items { get; set; }
        public class ListSandboxesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of active sessions in the sandbox.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("activeSessionCount")]
            [Validation(Required=false)]
            public int? ActiveSessionCount { get; set; }

            /// <summary>
            /// <para>The time when the sandbox was created. The time is in the RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-29T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The time of the last activity of the sandbox. The time is in the RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-29T00:02:00Z</para>
            /// </summary>
            [NameInMap("lastActiveAt")]
            [Validation(Required=false)]
            public string LastActiveAt { get; set; }

            /// <summary>
            /// <para>The time of the last heartbeat of the sandbox. The time is in the RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-29T00:01:00Z</para>
            /// </summary>
            [NameInMap("lastHeartbeatAt")]
            [Validation(Required=false)]
            public string LastHeartbeatAt { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions allowed for the sandbox. This value is obtained from the auto-scaling configuration that takes effect at runtime. If auto-scaling is disabled or the configuration is unavailable, this value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("maxConcurrentSessions")]
            [Validation(Required=false)]
            public int? MaxConcurrentSessions { get; set; }

            /// <summary>
            /// <para>The current running phase of the sandbox.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The sandbox ID, which can be queried by calling ListSandboxes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sbx-2</para>
            /// </summary>
            [NameInMap("sandboxId")]
            [Validation(Required=false)]
            public string SandboxId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records per page for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message. The value is success when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
