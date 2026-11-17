// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMemoryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>httpStatusCode</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>items</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListMemoryTasksResponseBodyItems> Items { get; set; }
        public class ListMemoryTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>changes</para>
            /// </summary>
            [NameInMap("changes")]
            [Validation(Required=false)]
            public List<ListMemoryTasksResponseBodyItemsChanges> Changes { get; set; }
            public class ListMemoryTasksResponseBodyItemsChanges : TeaModel {
                /// <summary>
                /// <para>memoryId</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mem-2f5f9c5a8d0e4c3b</para>
                /// </summary>
                [NameInMap("memoryId")]
                [Validation(Required=false)]
                public string MemoryId { get; set; }

                /// <summary>
                /// <para>operation</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADD</para>
                /// </summary>
                [NameInMap("operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

            }

            /// <summary>
            /// <para>createdAt</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>error</para>
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public ListMemoryTasksResponseBodyItemsError Error { get; set; }
            public class ListMemoryTasksResponseBodyItemsError : TeaModel {
                /// <summary>
                /// <para>code</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>message</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The format of the event content is incorrect</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>finishedAt</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:01Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>inputMessageCount</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("inputMessageCount")]
            [Validation(Required=false)]
            public long? InputMessageCount { get; set; }

            /// <summary>
            /// <para>inputTokenCount</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("inputTokenCount")]
            [Validation(Required=false)]
            public long? InputTokenCount { get; set; }

            /// <summary>
            /// <para>memories</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("memories")]
            [Validation(Required=false)]
            public List<ListMemoryTasksResponseBodyItemsMemories> Memories { get; set; }
            public class ListMemoryTasksResponseBodyItemsMemories : TeaModel {
                /// <summary>
                /// <para>memoryId</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mem-2f5f9c5a8d0e4c3b</para>
                /// </summary>
                [NameInMap("memoryId")]
                [Validation(Required=false)]
                public string MemoryId { get; set; }

            }

            /// <summary>
            /// <para>startedAt</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00Z</para>
            /// </summary>
            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            /// <summary>
            /// <para>status</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>strategyConfig</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("strategyConfig")]
            [Validation(Required=false)]
            public ListMemoryTasksResponseBodyItemsStrategyConfig StrategyConfig { get; set; }
            public class ListMemoryTasksResponseBodyItemsStrategyConfig : TeaModel {
                /// <summary>
                /// <para>The strategy-level instruction. It takes effect together with the store-level instruction. If a conflict occurs, this field takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Retain only long-term preferences explicitly expressed by the user</para>
                /// </summary>
                [NameInMap("instruction")]
                [Validation(Required=false)]
                public string Instruction { get; set; }

                /// <summary>
                /// <para>type</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>taskId</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>triggerType</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <para>maxResults</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>nextToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>success</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>totalCount</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
