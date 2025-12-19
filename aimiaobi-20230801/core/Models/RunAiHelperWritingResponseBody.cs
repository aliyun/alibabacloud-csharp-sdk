// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunAiHelperWritingResponseBody : TeaModel {
        /// <summary>
        /// <para>业务处理结果状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>流式响应的头部信息，包含事件类型、状态码等元数据</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunAiHelperWritingResponseBodyHeader Header { get; set; }
        public class RunAiHelperWritingResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>请求错误时的错误码</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>请求错误时的详细错误信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>参数错误</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>SSE事件类型，如：result-generated(生成结果)、task-finished(任务完成)</para>
            /// 
            /// <b>Example:</b>
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>当前写作会话的唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>session-xxxxx</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>HTTP状态码</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>写作任务的唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-xxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>用于问题排查的链路追踪标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>HTTP响应状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>业务处理结果描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>包含写作输出内容和Token使用量统计</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunAiHelperWritingResponseBodyPayload Payload { get; set; }
        public class RunAiHelperWritingResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>AI生成的写作内容</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunAiHelperWritingResponseBodyPayloadOutput Output { get; set; }
            public class RunAiHelperWritingResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>AI生成的文章内容，流式返回时为增量文本</para>
                /// 
                /// <b>Example:</b>
                /// <para>人工智能正在深刻改变我们的生活...</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>返回的写作参数键值对</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;wordCount&quot;: &quot;1000&quot;}</para>
                /// </summary>
                [NameInMap("WritingParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> WritingParams { get; set; }

            }

            /// <summary>
            /// <para>本次请求的Token消耗统计</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunAiHelperWritingResponseBodyPayloadUsage Usage { get; set; }
            public class RunAiHelperWritingResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>输入内容消耗的Token数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>生成内容消耗的Token数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>输入和输出Token的总和</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>本次API请求的唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>请求是否处理成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
