// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetMemoryRuleResponseBody : TeaModel {
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
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMemoryRuleResponseBodyData Data { get; set; }
        public class GetMemoryRuleResponseBodyData : TeaModel {
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
            /// <para>description</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extract long-term preferences explicitly expressed by the user</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>enabled</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>failedTaskCount</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("failedTaskCount")]
            [Validation(Required=false)]
            public long? FailedTaskCount { get; set; }

            /// <summary>
            /// <para>The time when the last execution started, in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00Z</para>
            /// </summary>
            [NameInMap("lastExecutedAt")]
            [Validation(Required=false)]
            public string LastExecutedAt { get; set; }

            /// <summary>
            /// <para>lastTaskId</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("lastTaskId")]
            [Validation(Required=false)]
            public string LastTaskId { get; set; }

            /// <summary>
            /// <para>lastTaskStatus</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("lastTaskStatus")]
            [Validation(Required=false)]
            public string LastTaskStatus { get; set; }

            /// <summary>
            /// <para>memoryStoreId</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ms-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("memoryStoreId")]
            [Validation(Required=false)]
            public string MemoryStoreId { get; set; }

            /// <summary>
            /// <para>name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Long-term preferences</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>ruleId</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>strategy</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("strategy")]
            [Validation(Required=false)]
            public GetMemoryRuleResponseBodyDataStrategy Strategy { get; set; }
            public class GetMemoryRuleResponseBodyDataStrategy : TeaModel {
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
            /// <para>succeededTaskCount</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("succeededTaskCount")]
            [Validation(Required=false)]
            public long? SucceededTaskCount { get; set; }

            /// <summary>
            /// <para>The total number of distinct task IDs that have started execution. Retries are not counted separately.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("taskCount")]
            [Validation(Required=false)]
            public long? TaskCount { get; set; }

            /// <summary>
            /// <para>updatedAt</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

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
        /// <para>message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

    }

}
