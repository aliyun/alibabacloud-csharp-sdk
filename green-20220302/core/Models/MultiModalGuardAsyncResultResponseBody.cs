// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardAsyncResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MultiModalGuardAsyncResultResponseBodyData Data { get; set; }
        public class MultiModalGuardAsyncResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The audio moderation result.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public MultiModalGuardAsyncResultResponseBodyDataAudioResult AudioResult { get; set; }
            public class MultiModalGuardAsyncResultResponseBodyDataAudioResult : TeaModel {
                /// <summary>
                /// <para>Details for each audio slice.</para>
                /// </summary>
                [NameInMap("SliceDetails")]
                [Validation(Required=false)]
                public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetails> SliceDetails { get; set; }
                public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetails : TeaModel {
                    /// <summary>
                    /// <para>Detection details for the audio slice.</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetail> Detail { get; set; }
                    public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetail : TeaModel {
                        /// <summary>
                        /// <para>The risk level. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>high</c>: High risk. If the content matches an entry in a custom keyword library, the risk level defaults to high.</para>
                        /// </description></item>
                        /// <item><description><para><c>medium</c>: Medium risk.</para>
                        /// </description></item>
                        /// <item><description><para><c>low</c>: Low risk.</para>
                        /// </description></item>
                        /// <item><description><para><c>none</c>: No risk detected.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>high</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>A list of detection results.</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetailResult> Result { get; set; }
                        public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetailResult : TeaModel {
                            /// <summary>
                            /// <para>The confidence score, ranging from 0 to 100, accurate to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>90</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The description of the label.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>毒品</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>Additional information about the detection result.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("Ext")]
                            [Validation(Required=false)]
                            public object Ext { get; set; }

                            /// <summary>
                            /// <para>The label of the detection result.</para>
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
                            /// <item><description><para><c>high</c>: High risk. If the content matches an entry in a custom keyword library, the risk level defaults to high.</para>
                            /// </description></item>
                            /// <item><description><para><c>medium</c>: Medium risk.</para>
                            /// </description></item>
                            /// <item><description><para><c>low</c>: Low risk.</para>
                            /// </description></item>
                            /// <item><description><para><c>none</c>: No risk detected.</para>
                            /// </description></item>
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
                        /// <item><description><para><c>block</c>: Block the content.</para>
                        /// </description></item>
                        /// <item><description><para><c>pass</c>: Pass the content.</para>
                        /// </description></item>
                        /// <item><description><para><c>watch</c>: The content requires review.</para>
                        /// </description></item>
                        /// <item><description><para><c>mask</c>: Mask the content.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The detection type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>contentModeration</c>: Content moderation.</para>
                        /// </description></item>
                        /// <item><description><para><c>promptAttack</c>: Prompt attack detection.</para>
                        /// </description></item>
                        /// <item><description><para><c>sensitiveData</c>: Sensitive data detection.</para>
                        /// </description></item>
                        /// <item><description><para><c>modelHallucination</c>: Model hallucination.</para>
                        /// </description></item>
                        /// <item><description><para><c>maliciousFile</c>: Malicious file detection.</para>
                        /// </description></item>
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
                    /// <para>The end time of the audio slice, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the audio slice, in seconds.</para>
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
                    /// <item><description><para><c>block</c>: Block the content.</para>
                    /// </description></item>
                    /// <item><description><para><c>pass</c>: Pass the content.</para>
                    /// </description></item>
                    /// <item><description><para><c>watch</c>: The content requires review.</para>
                    /// </description></item>
                    /// <item><description><para><c>mask</c>: Mask the content.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The speech-to-text transcript of the audio slice.</para>
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
                    /// <para><a href="http://xxxx.abc.wav">http://xxxx.abc.wav</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The slice count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SliceNum")]
                [Validation(Required=false)]
                public int? SliceNum { get; set; }

                /// <summary>
                /// <para>The overall recommended action for the audio content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <para>The value of the <c>dataId</c> parameter from the request. This field is omitted if <c>dataId</c> was not provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The video frame moderation result.</para>
            /// </summary>
            [NameInMap("FrameResult")]
            [Validation(Required=false)]
            public MultiModalGuardAsyncResultResponseBodyDataFrameResult FrameResult { get; set; }
            public class MultiModalGuardAsyncResultResponseBodyDataFrameResult : TeaModel {
                /// <summary>
                /// <para>The moderation results for video frames.</para>
                /// </summary>
                [NameInMap("Frames")]
                [Validation(Required=false)]
                public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFrames> Frames { get; set; }
                public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFrames : TeaModel {
                    /// <summary>
                    /// <para>A list of detection results.</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetail> Detail { get; set; }
                    public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetail : TeaModel {
                        /// <summary>
                        /// <para>The risk level. Valid values include:</para>
                        /// <list type="bullet">
                        /// <item><description><para>high: High risk. If a match is found in a custom dictionary, the risk level defaults to high.</para>
                        /// </description></item>
                        /// <item><description><para>medium: Medium risk.</para>
                        /// </description></item>
                        /// <item><description><para>low: Low risk.</para>
                        /// </description></item>
                        /// <item><description><para>none: No risk detected.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>low</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>A list of detection results.</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetailResult> Result { get; set; }
                        public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetailResult : TeaModel {
                            /// <summary>
                            /// <para>The confidence score, ranging from 0 to 100, accurate to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>80</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The description of the label.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>广告</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>Additional information about the detection result.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("Ext")]
                            [Validation(Required=false)]
                            public object Ext { get; set; }

                            /// <summary>
                            /// <para>The label of the detection result.</para>
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
                            /// <item><description><para><c>high</c>: High risk. If the content matches an entry in a custom keyword library, the risk level defaults to high.</para>
                            /// </description></item>
                            /// <item><description><para><c>medium</c>: Medium risk.</para>
                            /// </description></item>
                            /// <item><description><para><c>low</c>: Low risk.</para>
                            /// </description></item>
                            /// <item><description><para><c>none</c>: No risk detected.</para>
                            /// </description></item>
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
                        /// <para>Suggestion</para>
                        /// <list type="bullet">
                        /// <item><description><para>block: A suggestion to block.</para>
                        /// </description></item>
                        /// <item><description><para>pass: A suggestion to pass.</para>
                        /// </description></item>
                        /// <item><description><para>watch: A suggestion to watch.</para>
                        /// </description></item>
                        /// <item><description><para>mask: A suggestion to mask.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>watch</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The detection type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>contentModeration</c>: Content moderation.</para>
                        /// </description></item>
                        /// <item><description><para><c>promptAttack</c>: Prompt attack detection.</para>
                        /// </description></item>
                        /// <item><description><para><c>sensitiveData</c>: Sensitive data detection.</para>
                        /// </description></item>
                        /// <item><description><para><c>modelHallucination</c>: Model hallucination.</para>
                        /// </description></item>
                        /// <item><description><para><c>maliciousFile</c>: Malicious file detection.</para>
                        /// </description></item>
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
                    /// <para>The time offset of the frame in the video, in seconds.</para>
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
                    /// <item><description><para><c>block</c>: Block the content.</para>
                    /// </description></item>
                    /// <item><description><para><c>pass</c>: Pass the content.</para>
                    /// </description></item>
                    /// <item><description><para><c>watch</c>: The content requires review.</para>
                    /// </description></item>
                    /// <item><description><para><c>mask</c>: Mask the content.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The absolute timestamp of the frame, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1684559739000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The temporary URL of the video frame.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://xxx.jpeg">https://xxx.jpeg</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The frame count.</para>
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
                /// <item><description><para><c>block</c>: Block the content.</para>
                /// </description></item>
                /// <item><description><para><c>pass</c>: Pass the content.</para>
                /// </description></item>
                /// <item><description><para><c>watch</c>: The content requires review.</para>
                /// </description></item>
                /// <item><description><para><c>mask</c>: Mask the content.</para>
                /// </description></item>
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
            /// <para>The unique identifier for the live stream.</para>
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
            /// <item><description><para><c>block</c>: Block the content.</para>
            /// </description></item>
            /// <item><description><para><c>pass</c>: Pass the content.</para>
            /// </description></item>
            /// <item><description><para><c>watch</c>: The content requires review.</para>
            /// </description></item>
            /// <item><description><para><c>mask</c>: Mask the content.</para>
            /// </description></item>
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
