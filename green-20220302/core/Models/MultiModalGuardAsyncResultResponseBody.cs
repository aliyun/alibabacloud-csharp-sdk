// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardAsyncResultResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MultiModalGuardAsyncResultResponseBodyData Data { get; set; }
        public class MultiModalGuardAsyncResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The audio moderation segment results.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public MultiModalGuardAsyncResultResponseBodyDataAudioResult AudioResult { get; set; }
            public class MultiModalGuardAsyncResultResponseBodyDataAudioResult : TeaModel {
                /// <summary>
                /// <para>The segment details.</para>
                /// </summary>
                [NameInMap("SliceDetails")]
                [Validation(Required=false)]
                public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetails> SliceDetails { get; set; }
                public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetails : TeaModel {
                    /// <summary>
                    /// <para>The moderation details.</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetail> Detail { get; set; }
                    public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetail : TeaModel {
                        /// <summary>
                        /// <para>The risk level. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>high: High risk. If a custom keyword library is hit, the risk level defaults to high.</description></item>
                        /// <item><description>medium: Medium risk.</description></item>
                        /// <item><description>low: Low risk.</description></item>
                        /// <item><description>none: No risk detected.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>high</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>The list of moderation results.</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetailResult> Result { get; set; }
                        public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetailResult : TeaModel {
                            /// <summary>
                            /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>90</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The label description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>drugs.</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The extended information of the moderation result.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("Ext")]
                            [Validation(Required=false)]
                            public object Ext { get; set; }

                            /// <summary>
                            /// <para>The label.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>drug</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The risk level. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>high: High risk. If a custom keyword library is hit, the risk level defaults to high.</description></item>
                            /// <item><description>medium: Medium risk.</description></item>
                            /// <item><description>low: Low risk.</description></item>
                            /// <item><description>none: No risk detected.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>high</para>
                            /// </summary>
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                        }

                        /// <summary>
                        /// <para>The recommended action. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>block: Block the content.</description></item>
                        /// <item><description>pass: Allow the content.</description></item>
                        /// <item><description>watch: Manually review the content.</description></item>
                        /// <item><description>mask: Mask the content.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The moderation type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>contentModeration: content compliance moderation</description></item>
                        /// <item><description>promptAttack: prompt attack detection</description></item>
                        /// <item><description>sensitiveData: sensitive content detection</description></item>
                        /// <item><description>modelHallucination: model hallucination detection</description></item>
                        /// <item><description>maliciousFile: malicious file detection</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contentModeration</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The end time of the segment, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the segment, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The recommended action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>block: Block the content.</description></item>
                    /// <item><description>pass: Allow the content.</description></item>
                    /// <item><description>watch: Manually review the content.</description></item>
                    /// <item><description>mask: Mask the content.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The transcribed text of the audio segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The weather is really nice today.</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The temporary URL of the audio segment file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxx.abc.wav">http://xxxx.abc.wav</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The number of segments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SliceNum")]
                [Validation(Required=false)]
                public int? SliceNum { get; set; }

                /// <summary>
                /// <para>The recommended action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <para>The value of dataId passed in the API request. This field is not returned if dataId was not specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The list of video frame capture results.</para>
            /// </summary>
            [NameInMap("FrameResult")]
            [Validation(Required=false)]
            public MultiModalGuardAsyncResultResponseBodyDataFrameResult FrameResult { get; set; }
            public class MultiModalGuardAsyncResultResponseBodyDataFrameResult : TeaModel {
                /// <summary>
                /// <para>The frame moderation results.</para>
                /// </summary>
                [NameInMap("Frames")]
                [Validation(Required=false)]
                public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFrames> Frames { get; set; }
                public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFrames : TeaModel {
                    /// <summary>
                    /// <para>The list of moderation results.</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetail> Detail { get; set; }
                    public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetail : TeaModel {
                        /// <summary>
                        /// <para>The risk level. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>high: High risk. If a custom keyword library is hit, the risk level defaults to high.</description></item>
                        /// <item><description>medium: Medium risk.</description></item>
                        /// <item><description>low: Low risk.</description></item>
                        /// <item><description>none: No risk detected.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>low</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>The moderation result.</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetailResult> Result { get; set; }
                        public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetailResult : TeaModel {
                            /// <summary>
                            /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>80</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The label description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>advertisement.</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The extended information of the moderation result.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("Ext")]
                            [Validation(Required=false)]
                            public object Ext { get; set; }

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
                            /// <para>The risk level. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>high: High risk. If a custom keyword library is hit, the risk level defaults to high.</description></item>
                            /// <item><description>medium: Medium risk.</description></item>
                            /// <item><description>low: Low risk.</description></item>
                            /// <item><description>none: No risk detected.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>loose</para>
                            /// </summary>
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                        }

                        /// <summary>
                        /// <para>The recommended action. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>block: Block the content.</description></item>
                        /// <item><description>pass: Allow the content.</description></item>
                        /// <item><description>watch: Manually review the content.</description></item>
                        /// <item><description>mask: Mask the content.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>watch</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The moderation type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>contentModeration: content compliance moderation</description></item>
                        /// <item><description>promptAttack: prompt attack detection</description></item>
                        /// <item><description>sensitiveData: sensitive content detection</description></item>
                        /// <item><description>modelHallucination: model hallucination detection</description></item>
                        /// <item><description>maliciousFile: malicious file detection</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contentModeration</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>401</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public int? ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>parameter invalid</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>The frame capture position.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public float? Offset { get; set; }

                    /// <summary>
                    /// <para>The recommended action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>block: Block the content.</description></item>
                    /// <item><description>pass: Allow the content.</description></item>
                    /// <item><description>watch: Manually review the content.</description></item>
                    /// <item><description>mask: Mask the content.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The absolute timestamp, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1684559739000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The temporary URL of the segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://xxx.jpeg">https://xxx.jpeg</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The number of segments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SliceNum")]
                [Validation(Required=false)]
                public int? SliceNum { get; set; }

                /// <summary>
                /// <para>The recommended action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>block: Block the content.</description></item>
                /// <item><description>pass: Allow the content.</description></item>
                /// <item><description>watch: Manually review the content.</description></item>
                /// <item><description>mask: Mask the content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

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
            /// <para>The recommended action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>block: Block the content.</description></item>
            /// <item><description>pass: Allow the content.</description></item>
            /// <item><description>watch: Manually review the content.</description></item>
            /// <item><description>mask: Mask the content.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vi_f_xxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
