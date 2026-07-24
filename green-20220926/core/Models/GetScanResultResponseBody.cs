// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetScanResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code, which is consistent with the HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScanResultResponseBodyData Data { get; set; }
        public class GetScanResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The data on the current page.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetScanResultResponseBodyDataItems> Items { get; set; }
            public class GetScanResultResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The AccountId input parameter from the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>accountIdtest123</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The machine-assisted moderation labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("ApiLabels")]
                [Validation(Required=false)]
                public string ApiLabels { get; set; }

                /// <summary>
                /// <para>The machine-assisted moderation time. The value is a Unix/POSIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755501226</para>
                /// </summary>
                [NameInMap("ApiRequestTime")]
                [Validation(Required=false)]
                public string ApiRequestTime { get; set; }

                /// <summary>
                /// <para>The machine-assisted moderation risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("ApiRiskLevel")]
                [Validation(Required=false)]
                public string ApiRiskLevel { get; set; }

                /// <summary>
                /// <para>The machine-assisted moderation service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>basecheckLine</para>
                /// </summary>
                [NameInMap("ApiService")]
                [Validation(Required=false)]
                public string ApiService { get; set; }

                /// <summary>
                /// <para>The machine-assisted moderation task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ApiTaskId")]
                [Validation(Required=false)]
                public string ApiTaskId { get; set; }

                /// <summary>
                /// <para>appId</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent_01</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The attack level, returned based on the configured risk score thresholds. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>high: high risk.</para>
                /// </description></item>
                /// <item><description><para>medium: medium risk.</para>
                /// </description></item>
                /// <item><description><para>low: low risk.</para>
                /// </description></item>
                /// <item><description><para>none: no risk detected.</para>
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
                /// <para>The Bailian request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>93a2f484-ac61-9b2e-9765-88600c83c1ea</para>
                /// </summary>
                [NameInMap("BailianRequestId")]
                [Validation(Required=false)]
                public string BailianRequestId { get; set; }

                /// <summary>
                /// <para>The content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>dataId</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f27b8cc7c4544cb90b41882a5b36326</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The segment end time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The extended information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>multiImage</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public string Ext { get; set; }

                /// <summary>
                /// <para>The feedback information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ExtFeedback")]
                [Validation(Required=false)]
                public string ExtFeedback { get; set; }

                /// <summary>
                /// <para>The reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extra { get; set; }

                /// <summary>
                /// <para>The frame count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("FrameCount")]
                [Validation(Required=false)]
                public long? FrameCount { get; set; }

                /// <summary>
                /// <para>The creation time. Format: YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-11 09:00:19</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The multimodal file URLs.</para>
                /// </summary>
                [NameInMap("GuardFileUrls")]
                [Validation(Required=false)]
                public List<string> GuardFileUrls { get; set; }

                /// <summary>
                /// <para>The multimodal image URLs.</para>
                /// </summary>
                [NameInMap("GuardImageUrls")]
                [Validation(Required=false)]
                public List<string> GuardImageUrls { get; set; }

                /// <summary>
                /// <para>The image labels.</para>
                /// </summary>
                [NameInMap("ImageLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> ImageLabels { get; set; }

                /// <summary>
                /// <para>The image service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("ImageService")]
                [Validation(Required=false)]
                public string ImageService { get; set; }

                /// <summary>
                /// <para>url</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>imageUrls</para>
                /// </summary>
                [NameInMap("ImageUrls")]
                [Validation(Required=false)]
                public List<string> ImageUrls { get; set; }

                /// <summary>
                /// <para>The labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nonLabel</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The LiveId input parameter from the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveIdtest123</para>
                /// </summary>
                [NameInMap("LiveId")]
                [Validation(Required=false)]
                public string LiveId { get; set; }

                /// <summary>
                /// <para>The risk level of the malicious file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("MaliciousFileLevel")]
                [Validation(Required=false)]
                public string MaliciousFileLevel { get; set; }

                /// <summary>
                /// <para>The risk level of the malicious URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("MaliciousUrlLevel")]
                [Validation(Required=false)]
                public string MaliciousUrlLevel { get; set; }

                /// <summary>
                /// <para>Indicates whether only manual review is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ManualOnly")]
                [Validation(Required=false)]
                public bool? ManualOnly { get; set; }

                /// <summary>
                /// <para>No labels.</para>
                /// </summary>
                [NameInMap("NoLabels")]
                [Validation(Required=false)]
                public List<string> NoLabels { get; set; }

                /// <summary>
                /// <para>The frame capture offset value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public long? Offset { get; set; }

                /// <summary>
                /// <para>The page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public long? PageNum { get; set; }

                /// <summary>
                /// <para>The request source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online_test</para>
                /// </summary>
                [NameInMap("RequestFrom")]
                [Validation(Required=false)]
                public string RequestFrom { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The request time. Format: YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-11 09:00:19</para>
                /// </summary>
                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The result set.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<GetScanResultResponseBodyDataItemsResult> Result { get; set; }
                public class GetScanResultResponseBodyDataItemsResult : TeaModel {
                    /// <summary>
                    /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50.0</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public string Confidence { get; set; }

                    /// <summary>
                    /// <para>The description of the Label field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似色情内容</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The labels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>politics</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>The review labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("ReviewLabels")]
                [Validation(Required=false)]
                public string ReviewLabels { get; set; }

                /// <summary>
                /// <para>The review status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("ReviewRiskLevel")]
                [Validation(Required=false)]
                public string ReviewRiskLevel { get; set; }

                /// <summary>
                /// <para>The review time. The value is a Unix/POSIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755501226</para>
                /// </summary>
                [NameInMap("ReviewTime")]
                [Validation(Required=false)]
                public string ReviewTime { get; set; }

                /// <summary>
                /// <para>The reviewer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("ReviewUid")]
                [Validation(Required=false)]
                public string ReviewUid { get; set; }

                /// <summary>
                /// <para>Indicates whether the content has been reviewed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Reviewed")]
                [Validation(Required=false)]
                public bool? Reviewed { get; set; }

                /// <summary>
                /// <para>The risk level, returned based on the configured risk score thresholds. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>high: high risk.</para>
                /// </description></item>
                /// <item><description><para>medium: medium risk.</para>
                /// </description></item>
                /// <item><description><para>low: low risk.</para>
                /// </description></item>
                /// <item><description><para>none: no risk detected.</para>
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
                /// <para>The details of the matched risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>色情服务</para>
                /// </summary>
                [NameInMap("RiskTips")]
                [Validation(Required=false)]
                public string RiskTips { get; set; }

                /// <summary>
                /// <para>The matched risk keywords.</para>
                /// 
                /// <b>Example:</b>
                /// <para>色情_低俗词</para>
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

                /// <summary>
                /// <para>The result details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ScanResult")]
                [Validation(Required=false)]
                public string ScanResult { get; set; }

                /// <summary>
                /// <para>The score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>The sensitivity level, returned based on the configured risk score thresholds. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>S1</b>: Low sensitivity.</description></item>
                /// <item><description><b>S2</b>: Medium sensitivity.</description></item>
                /// <item><description><b>S3</b>: Moderately high sensitivity.</description></item>
                /// <item><description><b>S4</b>: High sensitivity.</description></item>
                /// <item><description><b>S0</b>: Not sensitive.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>S0</para>
                /// </summary>
                [NameInMap("SensitiveLevel")]
                [Validation(Required=false)]
                public string SensitiveLevel { get; set; }

                /// <summary>
                /// <para>The service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>The segment start time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>review</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vi_s_EbrXb716LyBpkfwxyX5xyh-1A6RY9</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The text labels.</para>
                /// </summary>
                [NameInMap("TextLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> TextLabels { get; set; }

                /// <summary>
                /// <para>The thumbnail URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                /// <summary>
                /// <para>The timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:40-00:00:42</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The task URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The audio labels.</para>
                /// </summary>
                [NameInMap("VoiceLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VoiceLabels { get; set; }

                /// <summary>
                /// <para>Indicates whether audio detection is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("VoiceScanOpened")]
                [Validation(Required=false)]
                public bool? VoiceScanOpened { get; set; }

                /// <summary>
                /// <para>The audio service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>live_stream_detection</para>
                /// </summary>
                [NameInMap("VoiceService")]
                [Validation(Required=false)]
                public string VoiceService { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The further description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend that uniquely identifies a request. You can use this ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The success flag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
