// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class QueryAuditTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAuditTaskResponseBodyData Data { get; set; }
        public class QueryAuditTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-13 12:12:12</para>
            /// </summary>
            [NameInMap("AuditTime")]
            [Validation(Required=false)]
            public string AuditTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>审核时的原文</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Response")]
            [Validation(Required=false)]
            public QueryAuditTaskResponseBodyDataResponse Response { get; set; }
            public class QueryAuditTaskResponseBodyDataResponse : TeaModel {
                [NameInMap("Header")]
                [Validation(Required=false)]
                public QueryAuditTaskResponseBodyDataResponseHeader Header { get; set; }
                public class QueryAuditTaskResponseBodyDataResponseHeader : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DataNotExists</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>数据不存在</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>task-failed</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>49eab783-9172-487a-b9df-c6372c47392c</para>
                    /// </summary>
                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public string SessionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>896b733535274d28b1a61c78bc145217</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                [NameInMap("Payload")]
                [Validation(Required=false)]
                public QueryAuditTaskResponseBodyDataResponsePayload Payload { get; set; }
                public class QueryAuditTaskResponseBodyDataResponsePayload : TeaModel {
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public QueryAuditTaskResponseBodyDataResponsePayloadOutput Output { get; set; }
                    public class QueryAuditTaskResponseBodyDataResponsePayloadOutput : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>x\&quot;x\&quot;x</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public QueryAuditTaskResponseBodyDataResponsePayloadUsage Usage { get; set; }
                    public class QueryAuditTaskResponseBodyDataResponsePayloadUsage : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("InputTokens")]
                        [Validation(Required=false)]
                        public int? InputTokens { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("OutputTokens")]
                        [Validation(Required=false)]
                        public int? OutputTokens { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>300</para>
                        /// </summary>
                        [NameInMap("TotalTokens")]
                        [Validation(Required=false)]
                        public int? TotalTokens { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
