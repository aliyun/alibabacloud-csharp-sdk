// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GetTagMiningAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTagMiningAnalysisTaskResponseBodyData Data { get; set; }
        public class GetTagMiningAnalysisTaskResponseBodyData : TeaModel {
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("results")]
            [Validation(Required=false)]
            public List<GetTagMiningAnalysisTaskResponseBodyDataResults> Results { get; set; }
            public class GetTagMiningAnalysisTaskResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("customId")]
                [Validation(Required=false)]
                public string CustomId { get; set; }

                [NameInMap("header")]
                [Validation(Required=false)]
                public GetTagMiningAnalysisTaskResponseBodyDataResultsHeader Header { get; set; }
                public class GetTagMiningAnalysisTaskResponseBodyDataResultsHeader : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DataNotExists</para>
                    /// </summary>
                    [NameInMap("errorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

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
                    /// <para>085BE2D2-BB7E-59A6-B688-F2CB32124E7F</para>
                    /// </summary>
                    [NameInMap("requestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                }

                [NameInMap("payload")]
                [Validation(Required=false)]
                public GetTagMiningAnalysisTaskResponseBodyDataResultsPayload Payload { get; set; }
                public class GetTagMiningAnalysisTaskResponseBodyDataResultsPayload : TeaModel {
                    [NameInMap("output")]
                    [Validation(Required=false)]
                    public GetTagMiningAnalysisTaskResponseBodyDataResultsPayloadOutput Output { get; set; }
                    public class GetTagMiningAnalysisTaskResponseBodyDataResultsPayloadOutput : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public GetTagMiningAnalysisTaskResponseBodyDataResultsPayloadUsage Usage { get; set; }
                    public class GetTagMiningAnalysisTaskResponseBodyDataResultsPayloadUsage : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("inputToken")]
                        [Validation(Required=false)]
                        public long? InputToken { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("outputToken")]
                        [Validation(Required=false)]
                        public long? OutputToken { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>300</para>
                        /// </summary>
                        [NameInMap("totalToken")]
                        [Validation(Required=false)]
                        public long? TotalToken { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNIN</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>085BE2D2-BB7E-59A6-B688-F2CB32124E7F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
