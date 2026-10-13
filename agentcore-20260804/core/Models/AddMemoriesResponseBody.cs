// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class AddMemoriesResponseBody : TeaModel {
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
        /// <para>The write result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AddMemoriesResponseBodyData Data { get; set; }
        public class AddMemoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The memory references returned only when sync is set to true. An empty array is allowed. This parameter is not returned together with taskId.</para>
            /// </summary>
            [NameInMap("memories")]
            [Validation(Required=false)]
            public List<AddMemoriesResponseBodyDataMemories> Memories { get; set; }
            public class AddMemoriesResponseBodyDataMemories : TeaModel {
                /// <summary>
                /// <para>The long-term memory ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mem-2f5f9c5a8d0e4c3b</para>
                /// </summary>
                [NameInMap("memoryId")]
                [Validation(Required=false)]
                public string MemoryId { get; set; }

            }

            /// <summary>
            /// <para>The task ID returned only when sync is set to false. This parameter is not returned together with memories.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
