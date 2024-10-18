// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetScanResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScanResultResponseBodyData Data { get; set; }
        public class GetScanResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetScanResultResponseBodyDataItems> Items { get; set; }
            public class GetScanResultResponseBodyDataItems : TeaModel {
                /// <summary>
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
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ExtFeedback")]
                [Validation(Required=false)]
                public string ExtFeedback { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extra { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("FrameCount")]
                [Validation(Required=false)]
                public long? FrameCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-08-11 09:00:19</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("ImageLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> ImageLabels { get; set; }

                /// <summary>
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
                /// <b>Example:</b>
                /// <para>nonLabel</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                [NameInMap("NoLabels")]
                [Validation(Required=false)]
                public List<string> NoLabels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public long? Offset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public long? PageNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-08-11 09:00:19</para>
                /// </summary>
                [NameInMap("RequestTime")]
                [Validation(Required=false)]
                public string RequestTime { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<GetScanResultResponseBodyDataItemsResult> Result { get; set; }
                public class GetScanResultResponseBodyDataItemsResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50.0</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public string Confidence { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>politics</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                [NameInMap("RiskTips")]
                [Validation(Required=false)]
                public string RiskTips { get; set; }

                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ScanResult")]
                [Validation(Required=false)]
                public string ScanResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>review</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vi_s_EbrXb716LyBpkfwxyX5xyh-1A6RY9</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TextLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> TextLabels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00:00:40-00:00:42</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyuncs.com/xxx.png">https://www.aliyuncs.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("VoiceLabels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VoiceLabels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("VoiceScanOpened")]
                [Validation(Required=false)]
                public bool? VoiceScanOpened { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>live_stream_detection</para>
                /// </summary>
                [NameInMap("VoiceService")]
                [Validation(Required=false)]
                public string VoiceService { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
