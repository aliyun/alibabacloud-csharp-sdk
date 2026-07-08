// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunVideoScriptGenerateResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates a normal response. This field is returned when the \<c>Content-Type\\</c> is \<c>json\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoPermission</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunVideoScriptGenerateResponseBodyHeader Header { get; set; }
        public class RunVideoScriptGenerateResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScriptNumberExceed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>脚本篇数超限</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b057f2fa-2277-477b-babf-cbc062307828</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2150451a17191950923411783e2927</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. This field is returned when the \<c>Content-Type\\</c> is \<c>json\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error description. This field is returned when the \<c>Content-Type\\</c> is \<c>json\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this action.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunVideoScriptGenerateResponseBodyPayload Payload { get; set; }
        public class RunVideoScriptGenerateResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The output content object.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunVideoScriptGenerateResponseBodyPayloadOutput Output { get; set; }
            public class RunVideoScriptGenerateResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>The text generation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大家好，我是[xxx]。今天带大家走进黄山，感受奇松、怪石、云海、温泉的绝美风光。首站迎客松，800年历史，枝干如臂，热情迎接每一位游客。接着登光明顶，360度全景尽收眼底。再探秘西海大峡谷，体验原始自然的震撼。最后，在温泉中放松身心，享受旅途的美好。希望这次旅行能给你留下难忘的记忆。我是[你的名字]，感谢观看，我们下次再见！&quot;,&quot;91522b25a4f440189320c9ede8ae6c85&quot;:&quot;大家好，我是[您的名字]，今天带大家探索黄山的奇妙之旅。首先，我们将见到黄山的象征——迎客松，感受它800年的历史与欢迎。随后攀登光明顶，迎接壮丽的日出；漫步西海大峡谷，体验险峻之美；最后，在温泉中放松身心。希望这次旅行能让你爱上黄山。谢谢观看！&quot;,&quot;1c23af4a899e4b908bdcffa7d8d0ddc9&quot;:&quot;大家好，欢迎来到黄山！这里以奇松、怪石、云海、温泉四绝闻名。从云谷寺开始，感受古朴氛围；挑战百步云梯，体验攀登乐趣；漫步西海大峡谷，领略壮丽景色；最后在玉屏楼迎接日出，享受心灵的宁静。希望这次旅行给你留下美好回忆！</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunVideoScriptGenerateResponseBodyPayloadUsage Usage { get; set; }
            public class RunVideoScriptGenerateResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens used for the input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of tokens for the output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The total number of tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique ID of the request. This field is returned when the \<c>Content-Type\\</c> is \<c>json\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2F366D6-E9FE-1006-BB70-2C650896AAB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. \<c>true\\</c> indicates success. \<c>false\\</c> indicates failure. This field is returned when the \<c>Content-Type\\</c> is \<c>json\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
