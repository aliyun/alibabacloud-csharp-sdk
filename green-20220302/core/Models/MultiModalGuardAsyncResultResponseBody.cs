// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardAsyncResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public MultiModalGuardAsyncResultResponseBodyData Data { get; set; }
        public class MultiModalGuardAsyncResultResponseBodyData : TeaModel {
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public MultiModalGuardAsyncResultResponseBodyDataAudioResult AudioResult { get; set; }
            public class MultiModalGuardAsyncResultResponseBodyDataAudioResult : TeaModel {
                [NameInMap("SliceDetails")]
                [Validation(Required=false)]
                public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetails> SliceDetails { get; set; }
                public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetails : TeaModel {
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetail> Detail { get; set; }
                    public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetail : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>high</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetailResult> Result { get; set; }
                        public class MultiModalGuardAsyncResultResponseBodyDataAudioResultSliceDetailsDetailResult : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>90</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("Ext")]
                            [Validation(Required=false)]
                            public object Ext { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>drug</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>high</para>
                            /// </summary>
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>contentModeration</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxx.abc.wav">http://xxxx.abc.wav</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SliceNum")]
                [Validation(Required=false)]
                public int? SliceNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("FrameResult")]
            [Validation(Required=false)]
            public MultiModalGuardAsyncResultResponseBodyDataFrameResult FrameResult { get; set; }
            public class MultiModalGuardAsyncResultResponseBodyDataFrameResult : TeaModel {
                [NameInMap("Frames")]
                [Validation(Required=false)]
                public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFrames> Frames { get; set; }
                public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFrames : TeaModel {
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetail> Detail { get; set; }
                    public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetail : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>low</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetailResult> Result { get; set; }
                        public class MultiModalGuardAsyncResultResponseBodyDataFrameResultFramesDetailResult : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>80</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("Ext")]
                            [Validation(Required=false)]
                            public object Ext { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>ad</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>loose</para>
                            /// </summary>
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>watch</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>contentModeration</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public float? Offset { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1684559739000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://xxx.jpeg">https://xxx.jpeg</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SliceNum")]
                [Validation(Required=false)]
                public int? SliceNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>liveId</para>
            /// </summary>
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vi_f_xxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
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
