// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VideoModerationResultResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VideoModerationResultResponseBodyData Data { get; set; }
        public class VideoModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// The voice moderation results. The moderation results contain a structure.
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataAudioResult AudioResult { get; set; }
            public class VideoModerationResultResponseBodyDataAudioResult : TeaModel {
                /// <summary>
                /// Summary of voice labels.
                /// </summary>
                [NameInMap("AudioSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultAudioSummarys> AudioSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultAudioSummarys : TeaModel {
                    /// <summary>
                    /// Voice label.
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The number of times that the label is matched.
                    /// </summary>
                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// The details about the text in the moderated voice. The value is a JSON array that contains one or more elements. Each element corresponds to a text entry.
                /// </summary>
                [NameInMap("SliceDetails")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultSliceDetails> SliceDetails { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultSliceDetails : TeaModel {
                    /// <summary>
                    /// The end time of the text after voice-to-text conversion. Unit: seconds.
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// The end timestamp of the segment. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("EndTimestamp")]
                    [Validation(Required=false)]
                    public long? EndTimestamp { get; set; }

                    /// <summary>
                    /// A reserved parameter.
                    /// </summary>
                    [NameInMap("Extend")]
                    [Validation(Required=false)]
                    public string Extend { get; set; }

                    /// <summary>
                    /// The details of the labels.
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// Subcategory labels. Multiple labels are separated by commas (,).
                    /// </summary>
                    [NameInMap("RiskTips")]
                    [Validation(Required=false)]
                    public string RiskTips { get; set; }

                    /// <summary>
                    /// The risk words that are hit. Multiple words are separated by commas (,).
                    /// </summary>
                    [NameInMap("RiskWords")]
                    [Validation(Required=false)]
                    public string RiskWords { get; set; }

                    /// <summary>
                    /// Risk score, default range 0-99.
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// The start time of the text after voice-to-text conversion. Unit: seconds.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// The start timestamp of the segment. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("StartTimestamp")]
                    [Validation(Required=false)]
                    public long? StartTimestamp { get; set; }

                    /// <summary>
                    /// The text converted from voice.
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// If the moderation object is a voice stream, this parameter indicates the temporary access URL of the voice stream to which the text entry corresponds. The validity period of the URL is 30 minutes. You must prepare another URL to store the audio stream at the earliest opportunity.
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// The ID of the moderated object.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// The image moderation results. If the call is successful, the HTTP status code 200 and moderation results are returned. The moderation results contain a structure.
            /// </summary>
            [NameInMap("FrameResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataFrameResult FrameResult { get; set; }
            public class VideoModerationResultResponseBodyDataFrameResult : TeaModel {
                /// <summary>
                /// The number of captured frames that are returned for the video file.
                /// </summary>
                [NameInMap("FrameNum")]
                [Validation(Required=false)]
                public int? FrameNum { get; set; }

                /// <summary>
                /// The summary of the labels against which captured frames are matched.
                /// </summary>
                [NameInMap("FrameSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrameSummarys> FrameSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrameSummarys : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The label against which a captured frame is matched.
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The number of times that the label is matched.
                    /// </summary>
                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                /// <summary>
                /// The information about the frames that match the labels.
                /// </summary>
                [NameInMap("Frames")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrames> Frames { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrames : TeaModel {
                    /// <summary>
                    /// The interval between the start of the video file and the captured frame. Unit: seconds.
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public float? Offset { get; set; }

                    /// <summary>
                    /// The results of frame moderation parameters such as the label parameter and the confidence parameter.
                    /// </summary>
                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public List<VideoModerationResultResponseBodyDataFrameResultFramesResults> Results { get; set; }
                    public class VideoModerationResultResponseBodyDataFrameResultFramesResults : TeaModel {
                        /// <summary>
                        /// If a custom image library is hit, information about the hit custom image library is returned.
                        /// </summary>
                        [NameInMap("CustomImage")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsCustomImage> CustomImage { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsCustomImage : TeaModel {
                            /// <summary>
                            /// The ID of the hit custom image.
                            /// </summary>
                            [NameInMap("ImageId")]
                            [Validation(Required=false)]
                            public string ImageId { get; set; }

                            /// <summary>
                            /// The custom image library ID of the hit.
                            /// </summary>
                            [NameInMap("LibId")]
                            [Validation(Required=false)]
                            public string LibId { get; set; }

                        }

                        /// <summary>
                        /// If the video contains a specific person, the recognized person code is returned.
                        /// </summary>
                        [NameInMap("PublicFigure")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigure> PublicFigure { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigure : TeaModel {
                            /// <summary>
                            /// Identified person coding information.
                            /// </summary>
                            [NameInMap("FigureId")]
                            [Validation(Required=false)]
                            public string FigureId { get; set; }

                        }

                        /// <summary>
                        /// The results of frame moderation parameters such as the label parameter and the confidence parameter.
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsResult> Result { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsResult : TeaModel {
                            /// <summary>
                            /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// The label returned after a frame is moderated. Multiple risk labels and the corresponding scores of confidence levels may be returned for a frame.
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The moderation service that is called.
                        /// </summary>
                        [NameInMap("Service")]
                        [Validation(Required=false)]
                        public string Service { get; set; }

                        /// <summary>
                        /// Returns the text information in the hit image.
                        /// </summary>
                        [NameInMap("TextInImage")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> TextInImage { get; set; }

                    }

                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// The temporary URL of a captured frame. This URL is valid for 30 minutes.
                    /// </summary>
                    [NameInMap("TempUrl")]
                    [Validation(Required=false)]
                    public string TempUrl { get; set; }

                    /// <summary>
                    /// The absolute timestamp. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// The unique ID of the live stream.
            /// </summary>
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The message that is returned in response to the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
