// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is 200 if the request is successful.</para>
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
            /// <para>The time when the sandbox was created, in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-29T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The tag of the actual observed image of the currently returned instance. This parameter is empty if the tag cannot be parsed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202611031754</para>
            /// </summary>
            [NameInMap("harnessVersion")]
            [Validation(Required=false)]
            public string HarnessVersion { get; set; }

            /// <summary>
            /// <para>The time of the last activity of the sandbox, in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-29T00:02:00Z</para>
            /// </summary>
            [NameInMap("lastActiveAt")]
            [Validation(Required=false)]
            public string LastActiveAt { get; set; }

            /// <summary>
            /// <para>The time of the last heartbeat of the sandbox, in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-29T00:01:00Z</para>
            /// </summary>
            [NameInMap("lastHeartbeatAt")]
            [Validation(Required=false)]
            public string LastHeartbeatAt { get; set; }

            /// <summary>
            /// <para>Used to continue calling GetSandboxRebuildOperation to query the overall result after a page refresh. This parameter is empty if there is no historical rebuild. Do not use the ID of a subsequently created task instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01a19f98-906d-7e82-96aa-8b7ea1d1a29d</para>
            /// </summary>
            [NameInMap("lastRebuildOperationId")]
            [Validation(Required=false)]
            public string LastRebuildOperationId { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions allowed for the sandbox, which is obtained from the effective auto-scaling configuration at runtime. This parameter is empty if auto-scaling is disabled or the configuration is unavailable.</para>
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

            /// <summary>
            /// <para>The server compares the actual image tag of the instance with the target image tag of the pool. The value is true if the tags are different during the RUNNING, HIBERNATED, or FAILED phase. The value is false if the tags are the same or during other known phases. This parameter is empty if the tag or phase cannot be confirmed, and it cannot be treated as false. The version sequence is not determined by the tag size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("updateAvailable")]
            [Validation(Required=false)]
            public bool? UpdateAvailable { get; set; }

            /// <summary>
            /// <para>A value of true indicates that the most recent rebuild corresponding to the current instance generation failed as a whole. A value of false indicates that there is no historical rebuild or the rebuild succeeded as a whole. This parameter is empty if the rebuild is in progress, canceled, replaced, the generation does not match, or the result cannot be confirmed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("updateFailed")]
            [Validation(Required=false)]
            public bool? UpdateFailed { get; set; }

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
        /// <para>The response message. The value is success if the request is successful.</para>
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
