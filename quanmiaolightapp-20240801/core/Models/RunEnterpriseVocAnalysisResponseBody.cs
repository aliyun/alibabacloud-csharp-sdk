// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunEnterpriseVocAnalysisResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public RunEnterpriseVocAnalysisResponseBodyHeader Header { get; set; }
        public class RunEnterpriseVocAnalysisResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AccessForbidden</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-finished</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunEnterpriseVocAnalysisResponseBodyPayload Payload { get; set; }
        public class RunEnterpriseVocAnalysisResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunEnterpriseVocAnalysisResponseBodyPayloadOutput Output { get; set; }
            public class RunEnterpriseVocAnalysisResponseBodyPayloadOutput : TeaModel {
                [NameInMap("filterResult")]
                [Validation(Required=false)]
                public RunEnterpriseVocAnalysisResponseBodyPayloadOutputFilterResult FilterResult { get; set; }
                public class RunEnterpriseVocAnalysisResponseBodyPayloadOutputFilterResult : TeaModel {
                    [NameInMap("filterResults")]
                    [Validation(Required=false)]
                    public List<RunEnterpriseVocAnalysisResponseBodyPayloadOutputFilterResultFilterResults> FilterResults { get; set; }
                    public class RunEnterpriseVocAnalysisResponseBodyPayloadOutputFilterResultFilterResults : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("hit")]
                        [Validation(Required=false)]
                        public bool? Hit { get; set; }

                        [NameInMap("tagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                        [NameInMap("tagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("reasonContent")]
                [Validation(Required=false)]
                public string ReasonContent { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunEnterpriseVocAnalysisResponseBodyPayloadUsage Usage { get; set; }
            public class RunEnterpriseVocAnalysisResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>49483FFC-0CB9-5163-8D3E-234E276E6DA8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
