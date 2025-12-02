// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetTextScanResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTextScanResultResponseBodyData Data { get; set; }
        public class GetTextScanResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Data for the current page.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetTextScanResultResponseBodyDataItems> Items { get; set; }
            public class GetTextScanResultResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Bailian Request ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("BailianRequestId")]
                [Validation(Required=false)]
                public string BailianRequestId { get; set; }

                /// <summary>
                /// <para>Content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Feedback information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>miss</para>
                /// </summary>
                [NameInMap("ExtFeedback")]
                [Validation(Required=false)]
                public string ExtFeedback { get; set; }

                /// <summary>
                /// <para>Spare parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extra { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-07-11 14:21:36</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nonLabel</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>Request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>Request time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-07-11 14:21:36</para>
                /// </summary>
                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                /// <summary>
                /// <para>Detection results.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<GetTextScanResultResponseBodyDataItemsResult> Result { get; set; }
                public class GetTextScanResultResponseBodyDataItemsResult : TeaModel {
                    /// <summary>
                    /// <para>Confidence score, ranging from 0 to 100, with two decimal places retained.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25.0</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>Description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似色情内容</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>political_n</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>Risk level, returned based on the set high and low risk scores. The return values include:</para>
                /// <list type="bullet">
                /// <item><description><para>high: High risk</para>
                /// </description></item>
                /// <item><description><para>medium: Medium risk</para>
                /// </description></item>
                /// <item><description><para>low: Low risk</para>
                /// </description></item>
                /// <item><description><para>none: No risk detected</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>Details of the result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ScanResult")]
                [Validation(Required=false)]
                public string ScanResult { get; set; }

                /// <summary>
                /// <para>Score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>Service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nickname_detection</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>Suggestion for handling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>review</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>Task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>txtwkgb******AsYNXoJswy-1Aa1Qk</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Further description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>ID assigned by the backend to uniquely identify a request. It can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success indicator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
