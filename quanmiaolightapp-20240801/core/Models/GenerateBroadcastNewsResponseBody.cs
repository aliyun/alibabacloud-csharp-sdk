// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GenerateBroadcastNewsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GenerateBroadcastNewsResponseBodyData Data { get; set; }
        public class GenerateBroadcastNewsResponseBodyData : TeaModel {
            [NameInMap("hotTopicSummaries")]
            [Validation(Required=false)]
            public List<GenerateBroadcastNewsResponseBodyDataHotTopicSummaries> HotTopicSummaries { get; set; }
            public class GenerateBroadcastNewsResponseBodyDataHotTopicSummaries : TeaModel {
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("hotTopic")]
                [Validation(Required=false)]
                public string HotTopic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-09-13_08</para>
                /// </summary>
                [NameInMap("hotTopicVersion")]
                [Validation(Required=false)]
                public string HotTopicVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("hotValue")]
                [Validation(Required=false)]
                public double? HotValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1458tb3bjo7531kap42a</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("images")]
                [Validation(Required=false)]
                public List<GenerateBroadcastNewsResponseBodyDataHotTopicSummariesImages> Images { get; set; }
                public class GenerateBroadcastNewsResponseBodyDataHotTopicSummariesImages : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://xxx.com/xxx.jpeg">http://xxx.com/xxx.jpeg</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("textSummary")]
                [Validation(Required=false)]
                public string TextSummary { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2bb0ea82dafd48a8817fadc4c90e2b52</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3feb69ed02d9b1a17d0f1a942675d300</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public GenerateBroadcastNewsResponseBodyDataUsage Usage { get; set; }
            public class GenerateBroadcastNewsResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>117F5ABE-CF02-5502-9A3F-E56BC9081A64</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
