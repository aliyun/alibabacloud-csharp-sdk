// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VideoModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The moderation results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VideoModerationResultResponseBodyData Data { get; set; }
        public class VideoModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The voice moderation results. The moderation results contain a structure.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataAudioResult AudioResult { get; set; }
            public class VideoModerationResultResponseBodyDataAudioResult : TeaModel {
                /// <summary>
                /// <para>Summary of voice labels.</para>
                /// </summary>
                [NameInMap("AudioSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultAudioSummarys> AudioSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultAudioSummarys : TeaModel {
                    /// <summary>
                    /// <para>The description of the labels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>no risk</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The voice label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>profanity</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The number of times that the label is matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                /// <summary>
                /// <para>Risk Level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The details about the text in the moderated voice. The value is a JSON array that contains one or more elements. Each element corresponds to a text entry.</para>
                /// </summary>
                [NameInMap("SliceDetails")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultSliceDetails> SliceDetails { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultSliceDetails : TeaModel {
                    /// <summary>
                    /// <para>The description of the labels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>no risk</para>
                    /// </summary>
                    [NameInMap("Descriptions")]
                    [Validation(Required=false)]
                    public string Descriptions { get; set; }

                    /// <summary>
                    /// <para>The end time of the text after voice-to-text conversion. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The end timestamp of the segment. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1685245261939</para>
                    /// </summary>
                    [NameInMap("EndTimestamp")]
                    [Validation(Required=false)]
                    public long? EndTimestamp { get; set; }

                    /// <summary>
                    /// <para>A reserved parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;consoleProduct\&quot;:\&quot;slbnext\&quot;}</para>
                    /// </summary>
                    [NameInMap("Extend")]
                    [Validation(Required=false)]
                    public string Extend { get; set; }

                    /// <summary>
                    /// <para>The details of the labels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    /// <summary>
                    /// <para>Risk Level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>Subcategory labels. Multiple labels are separated by commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("RiskTips")]
                    [Validation(Required=false)]
                    public string RiskTips { get; set; }

                    /// <summary>
                    /// <para>The risk words that are hit. Multiple words are separated by commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("RiskWords")]
                    [Validation(Required=false)]
                    public string RiskWords { get; set; }

                    /// <summary>
                    /// <para>The risk score. Default range: 0 to 99.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// <para>The start time of the text after voice-to-text conversion. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The start timestamp of the segment. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1659935002123</para>
                    /// </summary>
                    [NameInMap("StartTimestamp")]
                    [Validation(Required=false)]
                    public long? StartTimestamp { get; set; }

                    /// <summary>
                    /// <para>The text converted from voice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Disgusting</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>If the moderation object is a voice stream, this parameter indicates the temporary access URL of the voice stream to which the text entry corresponds. The validity period of the URL is 30 minutes. You must prepare another URL to store the voice stream at the earliest opportunity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxx.abc.img">http://xxxx.abc.img</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The value of dataId that is specified in the API request. If this parameter is not specified in the API request, the dataId field is not available in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product_content-2055763</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The image moderation results. If the call is successful, the HTTP status code 200 and moderation results are returned. The moderation results contain a structure.</para>
            /// </summary>
            [NameInMap("FrameResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataFrameResult FrameResult { get; set; }
            public class VideoModerationResultResponseBodyDataFrameResult : TeaModel {
                /// <summary>
                /// <para>The number of captured frames that are returned for the video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FrameNum")]
                [Validation(Required=false)]
                public int? FrameNum { get; set; }

                /// <summary>
                /// <para>The summary of the labels against which captured frames are matched.</para>
                /// </summary>
                [NameInMap("FrameSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrameSummarys> FrameSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrameSummarys : TeaModel {
                    /// <summary>
                    /// <para>The description of the result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>no risk</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label against which a captured frame is matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>violent_armedForces</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The number of times that the label is matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                /// <summary>
                /// <para>The information about the frames that match the labels.</para>
                /// </summary>
                [NameInMap("Frames")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrames> Frames { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrames : TeaModel {
                    /// <summary>
                    /// <para>The interval between the start of the video file and the captured frame. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>338</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public float? Offset { get; set; }

                    /// <summary>
                    /// <para>The results of frame moderation parameters such as the label parameter and the confidence parameter.</para>
                    /// </summary>
                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public List<VideoModerationResultResponseBodyDataFrameResultFramesResults> Results { get; set; }
                    public class VideoModerationResultResponseBodyDataFrameResultFramesResults : TeaModel {
                        /// <summary>
                        /// <para>If a custom image library is hit, information about the custom image library is returned.</para>
                        /// </summary>
                        [NameInMap("CustomImage")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsCustomImage> CustomImage { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsCustomImage : TeaModel {
                            /// <summary>
                            /// <para>The ID of the custom image that is hit.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1234</para>
                            /// </summary>
                            [NameInMap("ImageId")]
                            [Validation(Required=false)]
                            public string ImageId { get; set; }

                            /// <summary>
                            /// <para>The ID of the custom image library that is hit.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>12345678</para>
                            /// </summary>
                            [NameInMap("LibId")]
                            [Validation(Required=false)]
                            public string LibId { get; set; }

                        }

                        /// <summary>
                        /// <para>Returns logo information when the video contains a logo.</para>
                        /// </summary>
                        [NameInMap("LogoData")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoData> LogoData { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoData : TeaModel {
                            /// <summary>
                            /// <para>The location of the logo.</para>
                            /// </summary>
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoDataLocation Location { get; set; }
                            public class VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoDataLocation : TeaModel {
                                /// <summary>
                                /// <para>The height of the text area. Unit: pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>111</para>
                                /// </summary>
                                [NameInMap("H")]
                                [Validation(Required=false)]
                                public int? H { get; set; }

                                /// <summary>
                                /// <para>The width of the text area. Unit: pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>111</para>
                                /// </summary>
                                [NameInMap("W")]
                                [Validation(Required=false)]
                                public int? W { get; set; }

                                /// <summary>
                                /// <para>The distance from the top-left corner of the text area to the y-axis, with the top-left corner of the image as the origin. Unit: pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>111</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <para>The distance from the top-left corner of the text area to the x-axis, with the top-left corner of the image as the origin. Unit: pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>222</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            /// <summary>
                            /// <para>Logo information.</para>
                            /// </summary>
                            [NameInMap("Logo")]
                            [Validation(Required=false)]
                            public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoDataLogo> Logo { get; set; }
                            public class VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoDataLogo : TeaModel {
                                /// <summary>
                                /// <para>Confidence score, ranging from 0 to 100, with two decimal places.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>99.10</para>
                                /// </summary>
                                [NameInMap("confidence")]
                                [Validation(Required=false)]
                                public long? Confidence { get; set; }

                                /// <summary>
                                /// <para>label</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>pt_logotoSocialNetwork</para>
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>Logo name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>**logo</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>If the video contains a specific figure, the code of the identified figure is returned.</para>
                        /// </summary>
                        [NameInMap("PublicFigure")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigure> PublicFigure { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigure : TeaModel {
                            /// <summary>
                            /// <para>The information about the code of the identified figure.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>xxx001</para>
                            /// </summary>
                            [NameInMap("FigureId")]
                            [Validation(Required=false)]
                            public string FigureId { get; set; }

                            [NameInMap("FigureName")]
                            [Validation(Required=false)]
                            public string FigureName { get; set; }

                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigureLocation> Location { get; set; }
                            public class VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigureLocation : TeaModel {
                                [NameInMap("H")]
                                [Validation(Required=false)]
                                public int? H { get; set; }

                                [NameInMap("W")]
                                [Validation(Required=false)]
                                public int? W { get; set; }

                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The results of frame moderation parameters such as the label parameter and the confidence parameter.</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsResult> Result { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsResult : TeaModel {
                            /// <summary>
                            /// <para>The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The description of the result.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>no risk</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The label returned after a frame is moderated. Multiple risk labels and the corresponding scores of confidence levels may be returned for a frame.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>bloody</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// <para>The moderation service that is called.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tonalityImprove</para>
                        /// </summary>
                        [NameInMap("Service")]
                        [Validation(Required=false)]
                        public string Service { get; set; }

                        /// <summary>
                        /// <para>The information about the text hit in the image is returned.</para>
                        /// </summary>
                        [NameInMap("TextInImage")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> TextInImage { get; set; }

                    }

                    /// <summary>
                    /// <para>Risk Level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The temporary URL of a captured frame.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxx.abc.jpg">http://xxxx.abc.jpg</a></para>
                    /// </summary>
                    [NameInMap("TempUrl")]
                    [Validation(Required=false)]
                    public string TempUrl { get; set; }

                    /// <summary>
                    /// <para>The absolute timestamp. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1684559739000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <para>Risk Level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

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

            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>Risk Level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success finished</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
