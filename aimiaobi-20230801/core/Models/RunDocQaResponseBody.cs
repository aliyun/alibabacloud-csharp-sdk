// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocQaResponseBody : TeaModel {
        /// <summary>
        /// <para>response header</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunDocQaResponseBodyHeader Header { get; set; }
        public class RunDocQaResponseBodyHeader : TeaModel {
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
            /// <para>error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>management event</para>
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
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>f5517ee8-dbec-4dc8-bd0a-af084b5e3db1</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Job ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>End-to-end trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>46e5c2b5-0877-4f09-bd91-ab0cf314e48b</para>
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
        public RunDocQaResponseBodyPayload Payload { get; set; }
        public class RunDocQaResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Outputs</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunDocQaResponseBodyPayloadOutput Output { get; set; }
            public class RunDocQaResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Content of the response</para>
                /// 
                /// <b>Example:</b>
                /// <para>回答内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Response content after intervention</para>
                /// 
                /// <b>Example:</b>
                /// <para>干预后的回答内容</para>
                /// </summary>
                [NameInMap("InterveneContent")]
                [Validation(Required=false)]
                public string InterveneContent { get; set; }

                /// <summary>
                /// <para>Indicates whether the request is rejected</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsReject")]
                [Validation(Required=false)]
                public bool? IsReject { get; set; }

                /// <summary>
                /// <para>List of multimodal resource information</para>
                /// </summary>
                [NameInMap("MediaUrlList")]
                [Validation(Required=false)]
                public List<RunDocQaResponseBodyPayloadOutputMediaUrlList> MediaUrlList { get; set; }
                public class RunDocQaResponseBodyPayloadOutputMediaUrlList : TeaModel {
                    /// <summary>
                    /// <para>Array of related video time information</para>
                    /// </summary>
                    [NameInMap("ClipInfos")]
                    [Validation(Required=false)]
                    public List<RunDocQaResponseBodyPayloadOutputMediaUrlListClipInfos> ClipInfos { get; set; }
                    public class RunDocQaResponseBodyPayloadOutputMediaUrlListClipInfos : TeaModel {
                        /// <summary>
                        /// <para>Start time of the video segment</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public double? From { get; set; }

                        /// <summary>
                        /// <para>End time of the video segment</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public double? To { get; set; }

                    }

                    /// <summary>
                    /// <para>File URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://gw.alicdn.com/imgextra/i3/2775676850/O1CN01kdeffE20TM0E7wvpq_!!2775676850.jpg_q60.jpg">https://gw.alicdn.com/imgextra/i3/2775676850/O1CN01kdeffE20TM0E7wvpq_!!2775676850.jpg_q60.jpg</a></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>Media asset type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>video</para>
                    /// </summary>
                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                }

                /// <summary>
                /// <para>Array of recommended content</para>
                /// </summary>
                [NameInMap("Recommends")]
                [Validation(Required=false)]
                public List<RunDocQaResponseBodyPayloadOutputRecommends> Recommends { get; set; }
                public class RunDocQaResponseBodyPayloadOutputRecommends : TeaModel {
                    /// <summary>
                    /// <para>Title of the recommended content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>标题内容</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>URL of the recommended content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>推荐内容url</para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Array of sources for the response content</para>
                /// </summary>
                [NameInMap("References")]
                [Validation(Required=false)]
                public List<RunDocQaResponseBodyPayloadOutputReferences> References { get; set; }
                public class RunDocQaResponseBodyPayloadOutputReferences : TeaModel {
                    /// <summary>
                    /// <para>Published At</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-10-08 18:00</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public string PubTime { get; set; }

                    /// <summary>
                    /// <para>Source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>新浪新闻</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>Source docId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("SourceDocId")]
                    [Validation(Required=false)]
                    public string SourceDocId { get; set; }

                    /// <summary>
                    /// <para>Title of the associated content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>标题内容</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>Article URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxxx">http://xxxxx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>token usage</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunDocQaResponseBodyPayloadUsage Usage { get; set; }
            public class RunDocQaResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Quantity of input tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Number of tokens used in the output</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total number of tokens</para>
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
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
