// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocIntroductionResponseBody : TeaModel {
        /// <summary>
        /// <para>response header</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunDocIntroductionResponseBodyHeader Header { get; set; }
        public class RunDocIntroductionResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Type of management event</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-started</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Description of the management event</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型生成事件</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>20247a52-23e2-46fb-943d-309cdee2bc6d</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Job ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>8a9cecb7-6d20-32db-8823-5882c217b647</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>End-to-end trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>0bd58ea2-dc38-45da-ac02-17f05cb9040b</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>response body</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunDocIntroductionResponseBodyPayload Payload { get; set; }
        public class RunDocIntroductionResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Outputs</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunDocIntroductionResponseBodyPayloadOutput Output { get; set; }
            public class RunDocIntroductionResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Array of segment introductions</para>
                /// </summary>
                [NameInMap("Introductions")]
                [Validation(Required=false)]
                public List<RunDocIntroductionResponseBodyPayloadOutputIntroductions> Introductions { get; set; }
                public class RunDocIntroductionResponseBodyPayloadOutputIntroductions : TeaModel {
                    /// <summary>
                    /// <para>Array of position information</para>
                    /// </summary>
                    [NameInMap("Blocks")]
                    [Validation(Required=false)]
                    public List<RunDocIntroductionResponseBodyPayloadOutputIntroductionsBlocks> Blocks { get; set; }
                    public class RunDocIntroductionResponseBodyPayloadOutputIntroductionsBlocks : TeaModel {
                        /// <summary>
                        /// <para>Start Time of the segment</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BeginTime")]
                        [Validation(Required=false)]
                        public long? BeginTime { get; set; }

                        /// <summary>
                        /// <para>End Time of the segment</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1200</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <para>Height of the text block</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>600</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        /// <summary>
                        /// <para>Page number where the text block is located</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("PageId")]
                        [Validation(Required=false)]
                        public int? PageId { get; set; }

                        /// <summary>
                        /// <para>Width of the text block</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>600</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                        /// <summary>
                        /// <para>X coordinate of the top-left corner of the block</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>Y coordinate of the top-left corner of the block</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>Starting page number of multiple text blocks</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("StartPageId")]
                    [Validation(Required=false)]
                    public int? StartPageId { get; set; }

                    /// <summary>
                    /// <para>Summary of this segment</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>本段摘要内容</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>Title of this segment</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>本段标题内容</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>Key point content</para>
                /// 
                /// <b>Example:</b>
                /// <para>要点1；要点2；</para>
                /// </summary>
                [NameInMap("KeyPoint")]
                [Validation(Required=false)]
                public string KeyPoint { get; set; }

                /// <summary>
                /// <para>Outline summary</para>
                /// 
                /// <b>Example:</b>
                /// <para>大纲摘要内容</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            /// <summary>
            /// <para>token usage</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunDocIntroductionResponseBodyPayloadUsage Usage { get; set; }
            public class RunDocIntroductionResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Input token quantity</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Output token quantity</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total token quantity</para>
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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9B5BEA6-E8C4-5861-BE37-D906D516510E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
