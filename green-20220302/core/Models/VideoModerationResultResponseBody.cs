// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VideoModerationResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public VideoModerationResultResponseBodyData Data { get; set; }
        public class VideoModerationResultResponseBodyData : TeaModel {
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataAudioResult AudioResult { get; set; }
            public class VideoModerationResultResponseBodyDataAudioResult : TeaModel {
                [NameInMap("AudioSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultAudioSummarys> AudioSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultAudioSummarys : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                [NameInMap("SliceDetails")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultSliceDetails> SliceDetails { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultSliceDetails : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("EndTimestamp")]
                    [Validation(Required=false)]
                    public long? EndTimestamp { get; set; }

                    [NameInMap("Extend")]
                    [Validation(Required=false)]
                    public string Extend { get; set; }

                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    [NameInMap("RiskTips")]
                    [Validation(Required=false)]
                    public string RiskTips { get; set; }

                    [NameInMap("RiskWords")]
                    [Validation(Required=false)]
                    public string RiskWords { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("StartTimestamp")]
                    [Validation(Required=false)]
                    public long? StartTimestamp { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("FrameResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataFrameResult FrameResult { get; set; }
            public class VideoModerationResultResponseBodyDataFrameResult : TeaModel {
                [NameInMap("FrameNum")]
                [Validation(Required=false)]
                public int? FrameNum { get; set; }

                [NameInMap("FrameSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrameSummarys> FrameSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrameSummarys : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                [NameInMap("Frames")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrames> Frames { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrames : TeaModel {
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public float? Offset { get; set; }

                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public List<VideoModerationResultResponseBodyDataFrameResultFramesResults> Results { get; set; }
                    public class VideoModerationResultResponseBodyDataFrameResultFramesResults : TeaModel {
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsResult> Result { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsResult : TeaModel {
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        [NameInMap("Service")]
                        [Validation(Required=false)]
                        public string Service { get; set; }

                    }

                    [NameInMap("TempUrl")]
                    [Validation(Required=false)]
                    public string TempUrl { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

            }

            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
