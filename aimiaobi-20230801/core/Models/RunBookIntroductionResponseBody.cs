// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunBookIntroductionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunBookIntroductionResponseBodyHeader Header { get; set; }
        public class RunBookIntroductionResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型生成事件</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>411c4dfa-2168-4379-a902-675d67f453f8</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46e5c2b5-0877-4f09-bd91-ab0cf314e48b</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The payload.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunBookIntroductionResponseBodyPayload Payload { get; set; }
        public class RunBookIntroductionResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The generated content.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunBookIntroductionResponseBodyPayloadOutput Output { get; set; }
            public class RunBookIntroductionResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>A list of generated introductions for each part of the book.</para>
                /// </summary>
                [NameInMap("Introductions")]
                [Validation(Required=false)]
                public List<RunBookIntroductionResponseBodyPayloadOutputIntroductions> Introductions { get; set; }
                public class RunBookIntroductionResponseBodyPayloadOutputIntroductions : TeaModel {
                    /// <summary>
                    /// <para>A list of content blocks within this section.</para>
                    /// </summary>
                    [NameInMap("Blocks")]
                    [Validation(Required=false)]
                    public List<RunBookIntroductionResponseBodyPayloadOutputIntroductionsBlocks> Blocks { get; set; }
                    public class RunBookIntroductionResponseBodyPayloadOutputIntroductionsBlocks : TeaModel {
                        /// <summary>
                        /// <para>The start timestamp of the content block.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BeginTime")]
                        [Validation(Required=false)]
                        public long? BeginTime { get; set; }

                        /// <summary>
                        /// <para>The end timestamp of the content block.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1200</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <para>The height of the content block.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>600</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        /// <summary>
                        /// <para>The ID of the page where the content block is located.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("PageId")]
                        [Validation(Required=false)]
                        public int? PageId { get; set; }

                        /// <summary>
                        /// <para>The width of the content block.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>600</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                        /// <summary>
                        /// <para>The x-coordinate of the content block\&quot;s top-left corner on the page.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>The y-coordinate of the content block\&quot;s top-left corner on the page.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>A summary of this section.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>本段摘要内容</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>The title of this section.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>本段标题内容</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The book\&quot;s key points.</para>
                /// 
                /// <b>Example:</b>
                /// <para>卖点内容</para>
                /// </summary>
                [NameInMap("KeyPoint")]
                [Validation(Required=false)]
                public string KeyPoint { get; set; }

                /// <summary>
                /// <para>The book summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>简介内容</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            /// <summary>
            /// <para>Token usage details for the request.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunBookIntroductionResponseBodyPayloadUsage Usage { get; set; }
            public class RunBookIntroductionResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of output tokens.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
