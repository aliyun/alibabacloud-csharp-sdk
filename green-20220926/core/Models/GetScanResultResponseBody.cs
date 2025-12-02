// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetScanResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code, consistent with HTTP status.</para>
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
        public GetScanResultResponseBodyData Data { get; set; }
        public class GetScanResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page.</para>
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
            public List<GetScanResultResponseBodyDataItems> Items { get; set; }
            public class GetScanResultResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Automated review labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("ApiLabels")]
                [Validation(Required=false)]
                public string ApiLabels { get; set; }

                /// <summary>
                /// <para>Machine review time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755501226</para>
                /// </summary>
                [NameInMap("ApiRequestTime")]
                [Validation(Required=false)]
                public string ApiRequestTime { get; set; }

                /// <summary>
                /// <para>Automated review risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("ApiRiskLevel")]
                [Validation(Required=false)]
                public string ApiRiskLevel { get; set; }

                /// <summary>
                /// <para>Automated review service</para>
                /// 
                /// <b>Example:</b>
                /// <para>basecheckLine</para>
                /// </summary>
                [NameInMap("ApiService")]
                [Validation(Required=false)]
                public string ApiService { get; set; }

                /// <summary>
                /// <para>Automated review task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ApiTaskId")]
                [Validation(Required=false)]
                public string ApiTaskId { get; set; }

                /// <summary>
                /// <para>Attack level, returned based on the set high and low risk scores. The return values include:</para>
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
                [NameInMap("AttackLevel")]
                [Validation(Required=false)]
                public string AttackLevel { get; set; }

                /// <summary>
                /// <para>Content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Data Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f27b8cc7c4544cb90b41882a5b36326</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>Segment end time (in seconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Feedback information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ExtFeedback")]
                [Validation(Required=false)]
                public string ExtFeedback { get; set; }

                /// <summary>
                /// <para>Additional parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extra { get; set; }

                /// <summary>
                /// <para>Frame count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("FrameCount")]
                [Validation(Required=false)]
                public long? FrameCount { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-11 09:00:19</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Multimodal file URLs.</para>
                /// </summary>
                [NameInMap("GuardFileUrls")]
                [Validation(Required=false)]
                public List<string> GuardFileUrls { get; set; }

                /// <summary>
                /// <para>Multimodal image URLs.</para>
                /// </summary>
                [NameInMap("GuardImageUrls")]
                [Validation(Required=false)]
                public List<string> GuardImageUrls { get; set; }

                /// <summary>
                /// <para>Image labels.</para>
                /// </summary>
                [NameInMap("ImageLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> ImageLabels { get; set; }

                /// <summary>
                /// <para>Image service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("ImageService")]
                [Validation(Required=false)]
                public string ImageService { get; set; }

                /// <summary>
                /// <para>URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

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
                /// <para>Malicious file risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("MaliciousFileLevel")]
                [Validation(Required=false)]
                public string MaliciousFileLevel { get; set; }

                /// <summary>
                /// <para>Malicious URL risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("MaliciousUrlLevel")]
                [Validation(Required=false)]
                public string MaliciousUrlLevel { get; set; }

                /// <summary>
                /// <para>Whether it is a pure manual review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ManualOnly")]
                [Validation(Required=false)]
                public bool? ManualOnly { get; set; }

                /// <summary>
                /// <para>No labels</para>
                /// </summary>
                [NameInMap("NoLabels")]
                [Validation(Required=false)]
                public List<string> NoLabels { get; set; }

                /// <summary>
                /// <para>Frame offset value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public long? Offset { get; set; }

                /// <summary>
                /// <para>Page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public long? PageNum { get; set; }

                /// <summary>
                /// <para>Request source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online_test</para>
                /// </summary>
                [NameInMap("RequestFrom")]
                [Validation(Required=false)]
                public string RequestFrom { get; set; }

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
                /// <para>2023-08-11 09:00:19</para>
                /// </summary>
                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                /// <summary>
                /// <para>Resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>Return collection.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<GetScanResultResponseBodyDataItemsResult> Result { get; set; }
                public class GetScanResultResponseBodyDataItemsResult : TeaModel {
                    /// <summary>
                    /// <para>Confidence score, ranging from 0 to 100, with two decimal places.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50.0</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public string Confidence { get; set; }

                    /// <summary>
                    /// <para>Description of the Label field.</para>
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
                    /// <para>politics</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>Review labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("ReviewLabels")]
                [Validation(Required=false)]
                public string ReviewLabels { get; set; }

                /// <summary>
                /// <para>Review status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("ReviewRiskLevel")]
                [Validation(Required=false)]
                public string ReviewRiskLevel { get; set; }

                /// <summary>
                /// <para>Review time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755501226</para>
                /// </summary>
                [NameInMap("ReviewTime")]
                [Validation(Required=false)]
                public string ReviewTime { get; set; }

                /// <summary>
                /// <para>Reviewer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("ReviewUid")]
                [Validation(Required=false)]
                public string ReviewUid { get; set; }

                /// <summary>
                /// <para>Whether it has been reviewed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Reviewed")]
                [Validation(Required=false)]
                public bool? Reviewed { get; set; }

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
                /// <para>Details of the detected risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>色情服务</para>
                /// </summary>
                [NameInMap("RiskTips")]
                [Validation(Required=false)]
                public string RiskTips { get; set; }

                /// <summary>
                /// <para>Keywords of the detected risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>色情_低俗词</para>
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

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
                /// <para>25</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>Sensitive level, returned based on the set high and low risk scores. The return values include:</para>
                /// <list type="bullet">
                /// <item><description><b>S1</b>: Indicates low sensitivity.</description></item>
                /// <item><description><b>S2</b>: Indicates medium sensitivity.</description></item>
                /// <item><description><b>S3</b>: Indicates high sensitivity.</description></item>
                /// <item><description><b>S4</b>: Indicates very high sensitivity.</description></item>
                /// <item><description><b>S0</b>: Indicates no sensitivity.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>S0</para>
                /// </summary>
                [NameInMap("SensitiveLevel")]
                [Validation(Required=false)]
                public string SensitiveLevel { get; set; }

                /// <summary>
                /// <para>Service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>Segment start time (in seconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Suggestion.</para>
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
                /// <para>vi_s_EbrXb716LyBpkfwxyX5xyh-1A6RY9</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>Text labels.</para>
                /// </summary>
                [NameInMap("TextLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> TextLabels { get; set; }

                /// <summary>
                /// <para>Thumbnail URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                /// <summary>
                /// <para>Timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:40-00:00:42</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>Task URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Voice labels.</para>
                /// </summary>
                [NameInMap("VoiceLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VoiceLabels { get; set; }

                /// <summary>
                /// <para>Whether audio detection is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("VoiceScanOpened")]
                [Validation(Required=false)]
                public bool? VoiceScanOpened { get; set; }

                /// <summary>
                /// <para>Voice service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>live_stream_detection</para>
                /// </summary>
                [NameInMap("VoiceService")]
                [Validation(Required=false)]
                public string VoiceService { get; set; }

            }

            /// <summary>
            /// <para>Number of items per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
        /// <para>ID assigned by the backend to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success indicator</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
