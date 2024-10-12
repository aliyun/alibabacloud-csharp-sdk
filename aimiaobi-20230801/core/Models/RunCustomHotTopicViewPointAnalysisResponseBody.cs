// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCustomHotTopicViewPointAnalysisResponseBody : TeaModel {
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunCustomHotTopicViewPointAnalysisResponseBodyHeader Header { get; set; }
        public class RunCustomHotTopicViewPointAnalysisResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>错误码</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-started</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>全链路ID</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunCustomHotTopicViewPointAnalysisResponseBodyPayload Payload { get; set; }
        public class RunCustomHotTopicViewPointAnalysisResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutput Output { get; set; }
            public class RunCustomHotTopicViewPointAnalysisResponseBodyPayloadOutput : TeaModel {
                [NameInMap("AskUser")]
                [Validation(Required=false)]
                public List<string> AskUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>异步任务ID</para>
                /// </summary>
                [NameInMap("AsyncTaskId")]
                [Validation(Required=false)]
                public string AsyncTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>模型生成的自定义选题视角的观点</para>
                /// </summary>
                [NameInMap("Attitude")]
                [Validation(Required=false)]
                public string Attitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
                /// </summary>
                [NameInMap("CustomViewPointId")]
                [Validation(Required=false)]
                public string CustomViewPointId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>话题ID</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunCustomHotTopicViewPointAnalysisResponseBodyPayloadUsage Usage { get; set; }
            public class RunCustomHotTopicViewPointAnalysisResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>79</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>130</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
