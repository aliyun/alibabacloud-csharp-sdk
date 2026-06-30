// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VoiceModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VoiceModerationResultResponseBodyData Data { get; set; }
        public class VoiceModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The value of the <c>dataId</c> parameter you specified in the request. This parameter is returned only if you specified it in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The unique ID of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveId</para>
            /// </summary>
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

            /// <summary>
            /// <para>The ID of the manual review task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>The risk level, which is determined based on the configured thresholds for high and low risk scores. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>high</c>: high risk</para>
            /// </description></item>
            /// <item><description><para><c>medium</c>: medium risk</para>
            /// </description></item>
            /// <item><description><para><c>low</c>: low risk</para>
            /// </description></item>
            /// <item><description><para><c>none</c>: no risk detected</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The slice results.</para>
            /// </summary>
            [NameInMap("SliceDetails")]
            [Validation(Required=false)]
            public List<VoiceModerationResultResponseBodyDataSliceDetails> SliceDetails { get; set; }
            public class VoiceModerationResultResponseBodyDataSliceDetails : TeaModel {
                /// <summary>
                /// <para>The description of the label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>疑似违禁内容</para>
                /// </summary>
                [NameInMap("Descriptions")]
                [Validation(Required=false)]
                public string Descriptions { get; set; }

                /// <summary>
                /// <para>The end time of the slice, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The end timestamp of the slice, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678854649720</para>
                /// </summary>
                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// <para>Extended information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;riskWords\&quot;:\&quot;色情服务\&quot;,&quot;adNums&quot;:&quot;\&quot;,&quot;riskTips&quot;:&quot;涉政_人物，涉政_红歌&quot;}</para>
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// <para>The matched violation labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sexual_sounds</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>A reserved field.</para>
                /// </summary>
                [NameInMap("OriginAlgoResult")]
                [Validation(Required=false)]
                public Dictionary<string, object> OriginAlgoResult { get; set; }

                /// <summary>
                /// <para>The text detection results.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<VoiceModerationResultResponseBodyDataSliceDetailsResult> Result { get; set; }
                public class VoiceModerationResultResponseBodyDataSliceDetailsResult : TeaModel {
                    /// <summary>
                    /// <para>The confidence score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The matched custom libraries.</para>
                    /// </summary>
                    [NameInMap("CustomizedHit")]
                    [Validation(Required=false)]
                    public List<VoiceModerationResultResponseBodyDataSliceDetailsResultCustomizedHit> CustomizedHit { get; set; }
                    public class VoiceModerationResultResponseBodyDataSliceDetailsResultCustomizedHit : TeaModel {
                        /// <summary>
                        /// <para>The custom keyword.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fxxk</para>
                        /// </summary>
                        [NameInMap("KeyWords")]
                        [Validation(Required=false)]
                        public string KeyWords { get; set; }

                        /// <summary>
                        /// <para>The name of the custom library.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>insultLib</para>
                        /// </summary>
                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>profanity</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ad</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>A list of risk positions.</para>
                    /// </summary>
                    [NameInMap("RiskPositions")]
                    [Validation(Required=false)]
                    public List<VoiceModerationResultResponseBodyDataSliceDetailsResultRiskPositions> RiskPositions { get; set; }
                    public class VoiceModerationResultResponseBodyDataSliceDetailsResultRiskPositions : TeaModel {
                        /// <summary>
                        /// <para>The end position.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("EndPos")]
                        [Validation(Required=false)]
                        public int? EndPos { get; set; }

                        /// <summary>
                        /// <para>The detected sensitive word.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fxxk</para>
                        /// </summary>
                        [NameInMap("RiskWord")]
                        [Validation(Required=false)]
                        public string RiskWord { get; set; }

                        /// <summary>
                        /// <para>The start position.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("StartPos")]
                        [Validation(Required=false)]
                        public int? StartPos { get; set; }

                    }

                    /// <summary>
                    /// <para>The matched risky content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>XX</para>
                    /// </summary>
                    [NameInMap("RiskWords")]
                    [Validation(Required=false)]
                    public string RiskWords { get; set; }

                }

                /// <summary>
                /// <para>The risk level, which is determined based on the configured thresholds for high and low risk scores. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>high</c>: high risk</para>
                /// </description></item>
                /// <item><description><para><c>medium</c>: medium risk</para>
                /// </description></item>
                /// <item><description><para><c>low</c>: low risk</para>
                /// </description></item>
                /// <item><description><para><c>none</c>: no risk detected</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>Details about the matched risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>涉政_人物</para>
                /// </summary>
                [NameInMap("RiskTips")]
                [Validation(Required=false)]
                public string RiskTips { get; set; }

                /// <summary>
                /// <para>The matched risk keywords.</para>
                /// 
                /// <b>Example:</b>
                /// <para>色情服务</para>
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

                /// <summary>
                /// <para>The risk score. The value ranges from 0 to 99.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87.01</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>The start time of the slice, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The start timestamp of the slice, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678854649720</para>
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// <para>The transcribed text of the audio slice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>今天天气真不错</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The temporary URL of the audio slice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>暂无</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kw24ihd0WGkdi5nniVZM@qOj-1x5Ibb</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>暂无</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2881AD4F-638B-52A3-BA20-F74C5B1CEAE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
