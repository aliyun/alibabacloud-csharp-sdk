// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetMemoryStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The MemoryStore details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMemoryStoreResponseBodyData Data { get; set; }
        public class GetMemoryStoreResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The MemoryStore description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used to save long-term user preferences</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The custom extraction instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extract only long-term preferences explicitly expressed by the user</para>
            /// </summary>
            [NameInMap("extractInstructions")]
            [Validation(Required=false)]
            public string ExtractInstructions { get; set; }

            /// <summary>
            /// <para>The MemoryStore ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ms-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("memoryStoreId")]
            [Validation(Required=false)]
            public string MemoryStoreId { get; set; }

            /// <summary>
            /// <para>The MemoryStore name. It cannot be modified after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer-memory</para>
            /// </summary>
            [NameInMap("memoryStoreName")]
            [Validation(Required=false)]
            public string MemoryStoreName { get; set; }

            /// <summary>
            /// <para>The MemoryStore lifecycle state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The AgentCore workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
