// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VideoModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The moderation result data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VideoModerationResultResponseBodyData Data { get; set; }
        public class VideoModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The segmented results of video audio moderation.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataAudioResult AudioResult { get; set; }
            public class VideoModerationResultResponseBodyDataAudioResult : TeaModel {
                /// <summary>
                /// <para>The audio label summary.</para>
                /// </summary>
                [NameInMap("AudioSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultAudioSummarys> AudioSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultAudioSummarys : TeaModel {
                    /// <summary>
                    /// <para>The label descriptions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似违禁内容</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The video audio label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>profanity</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The number of times the label was detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                /// <summary>
                /// <para>The risk level, returned based on the configured high and low risk score thresholds. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>high: High risk.</para>
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
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The list of audio segments.</para>
                /// </summary>
                [NameInMap("SliceDetails")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataAudioResultSliceDetails> SliceDetails { get; set; }
                public class VideoModerationResultResponseBodyDataAudioResultSliceDetails : TeaModel {
                    /// <summary>
                    /// <para>The label descriptions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似违禁内容</para>
                    /// </summary>
                    [NameInMap("Descriptions")]
                    [Validation(Required=false)]
                    public string Descriptions { get; set; }

                    /// <summary>
                    /// <para>The end time of the segment, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The end timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1685245261939</para>
                    /// </summary>
                    [NameInMap("EndTimestamp")]
                    [Validation(Required=false)]
                    public long? EndTimestamp { get; set; }

                    /// <summary>
                    /// <para>The extended field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;consoleProduct\&quot;:\&quot;slbnext\&quot;}</para>
                    /// </summary>
                    [NameInMap("Extend")]
                    [Validation(Required=false)]
                    public string Extend { get; set; }

                    /// <summary>
                    /// <para>The violated labels that were hit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    /// <summary>
                    /// <para>The text detection result.</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public List<VideoModerationResultResponseBodyDataAudioResultSliceDetailsResult> Result { get; set; }
                    public class VideoModerationResultResponseBodyDataAudioResultSliceDetailsResult : TeaModel {
                        /// <summary>
                        /// <para>The confidence level.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>99.9</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The list of hit custom libraries.</para>
                        /// </summary>
                        [NameInMap("CustomizedHit")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataAudioResultSliceDetailsResultCustomizedHit> CustomizedHit { get; set; }
                        public class VideoModerationResultResponseBodyDataAudioResultSliceDetailsResultCustomizedHit : TeaModel {
                            /// <summary>
                            /// <para>The custom keywords.</para>
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
                            /// <para>备用词库02</para>
                            /// </summary>
                            [NameInMap("LibName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                        }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>疑似违禁内容</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>profanity</para>
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
                        /// <para>The list of risk positions.</para>
                        /// </summary>
                        [NameInMap("RiskPositions")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataAudioResultSliceDetailsResultRiskPositions> RiskPositions { get; set; }
                        public class VideoModerationResultResponseBodyDataAudioResultSliceDetailsResultRiskPositions : TeaModel {
                            /// <summary>
                            /// <para>The end position.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
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
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("StartPos")]
                            [Validation(Required=false)]
                            public int? StartPos { get; set; }

                        }

                        /// <summary>
                        /// <para>The hit risk content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fxxk</para>
                        /// </summary>
                        [NameInMap("RiskWords")]
                        [Validation(Required=false)]
                        public string RiskWords { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk level, returned based on the configured high and low risk score thresholds. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>high: High risk.</para>
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
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The details of the hit risk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("RiskTips")]
                    [Validation(Required=false)]
                    public string RiskTips { get; set; }

                    /// <summary>
                    /// <para>The risk keywords that were hit.</para>
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
                    /// <para>The start time of the segment, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The start timestamp, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1659935002123</para>
                    /// </summary>
                    [NameInMap("StartTimestamp")]
                    [Validation(Required=false)]
                    public long? StartTimestamp { get; set; }

                    /// <summary>
                    /// <para>The transcribed text of the audio segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>今天天气真不错</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The temporary URL of the audio segment file.</para>
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
            /// <para>The value of dataId passed in the API request. This field is not returned if dataId was not specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product_content-2055763</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataExt Ext { get; set; }
            public class VideoModerationResultResponseBodyDataExt : TeaModel {
                /// <summary>
                /// <para>The AIGC metadata detection result.</para>
                /// </summary>
                [NameInMap("AigcData")]
                [Validation(Required=false)]
                public VideoModerationResultResponseBodyDataExtAigcData AigcData { get; set; }
                public class VideoModerationResultResponseBodyDataExtAigcData : TeaModel {
                    /// <summary>
                    /// <para>The AIGC metadata.</para>
                    /// </summary>
                    [NameInMap("AIGC")]
                    [Validation(Required=false)]
                    public VideoModerationResultResponseBodyDataExtAigcDataAIGC AIGC { get; set; }
                    public class VideoModerationResultResponseBodyDataExtAigcDataAIGC : TeaModel {
                        /// <summary>
                        /// <para>The code or name of the service provider, used to identify the content producer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>001191******M000100Y43</para>
                        /// </summary>
                        [NameInMap("ContentProducer")]
                        [Validation(Required=false)]
                        public string ContentProducer { get; set; }

                        /// <summary>
                        /// <para>The name, code, or identifier of the propagation platform. For services that provide artificial intelligence-generated content, this value can be the same as ContentProducer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>001191******M000100Y43</para>
                        /// </summary>
                        [NameInMap("ContentPropagator")]
                        [Validation(Required=false)]
                        public string ContentPropagator { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the content is generated by artificial intelligence (AI). Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>1: The content is AI-generated content (AIGC).</para>
                        /// </description></item>
                        /// <item><description><para>2: (Propagation platforms only) The content may be AI-generated content generation.</para>
                        /// </description></item>
                        /// <item><description><para>3: (Propagation platforms only) The content is suspected to be AI-generated content generation.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The content production ID, a unique identifier used by the production platform to trace synthesized content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123******456</para>
                        /// </summary>
                        [NameInMap("ProduceID")]
                        [Validation(Required=false)]
                        public string ProduceID { get; set; }

                        /// <summary>
                        /// <para>The content propagation ID, a unique identifier assigned by the propagation platform to the distributed AI-generated content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123******456</para>
                        /// </summary>
                        [NameInMap("PropagateID")]
                        [Validation(Required=false)]
                        public string PropagateID { get; set; }

                        /// <summary>
                        /// <para>A reserved field.</para>
                        /// <para>This field can store information used by the content generation service provider for self-initiated security protection and content/identifier integrity assurance. A hashing mechanism based on ContentProducer and ProduceID can be used to securely store and verify critical information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d41d**********427e</para>
                        /// </summary>
                        [NameInMap("ReservedCode1")]
                        [Validation(Required=false)]
                        public string ReservedCode1 { get; set; }

                        /// <summary>
                        /// <para>A reserved field.</para>
                        /// <para>This field can be used by the content propagation service provider for self-initiated security protection and content/identifier integrity assurance. A hashing mechanism based on ContentProducer and ProduceID can be used to securely store and verify critical information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d41d**********427e</para>
                        /// </summary>
                        [NameInMap("ReservedCode2")]
                        [Validation(Required=false)]
                        public string ReservedCode2 { get; set; }

                    }

                    /// <summary>
                    /// <para>The detection result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of video frame capture results.</para>
            /// </summary>
            [NameInMap("FrameResult")]
            [Validation(Required=false)]
            public VideoModerationResultResponseBodyDataFrameResult FrameResult { get; set; }
            public class VideoModerationResultResponseBodyDataFrameResult : TeaModel {
                /// <summary>
                /// <para>The number of result frames.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FrameNum")]
                [Validation(Required=false)]
                public int? FrameNum { get; set; }

                /// <summary>
                /// <para>The video frame label summary.</para>
                /// </summary>
                [NameInMap("FrameSummarys")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrameSummarys> FrameSummarys { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrameSummarys : TeaModel {
                    /// <summary>
                    /// <para>The description of the Label field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未检测出风险</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The video frame label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>violent_armedForces</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The number of times the label was detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("LabelSum")]
                    [Validation(Required=false)]
                    public int? LabelSum { get; set; }

                }

                /// <summary>
                /// <para>The information about video frames that contain hit labels.</para>
                /// </summary>
                [NameInMap("Frames")]
                [Validation(Required=false)]
                public List<VideoModerationResultResponseBodyDataFrameResultFrames> Frames { get; set; }
                public class VideoModerationResultResponseBodyDataFrameResultFrames : TeaModel {
                    /// <summary>
                    /// <para>The offset of the captured frame.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>338</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public float? Offset { get; set; }

                    /// <summary>
                    /// <para>The frame detection result details.</para>
                    /// </summary>
                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public List<VideoModerationResultResponseBodyDataFrameResultFramesResults> Results { get; set; }
                    public class VideoModerationResultResponseBodyDataFrameResultFramesResults : TeaModel {
                        /// <summary>
                        /// <para>The custom image library information returned when a custom image library is hit.</para>
                        /// </summary>
                        [NameInMap("CustomImage")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsCustomImage> CustomImage { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsCustomImage : TeaModel {
                            /// <summary>
                            /// <para>The ID of the hit custom image.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1234</para>
                            /// </summary>
                            [NameInMap("ImageId")]
                            [Validation(Required=false)]
                            public string ImageId { get; set; }

                            /// <summary>
                            /// <para>The ID of the hit custom image library.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>12345678</para>
                            /// </summary>
                            [NameInMap("LibId")]
                            [Validation(Required=false)]
                            public string LibId { get; set; }

                        }

                        /// <summary>
                        /// <para>The logo information returned when a logo is detected in the video.</para>
                        /// </summary>
                        [NameInMap("LogoData")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoData> LogoData { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoData : TeaModel {
                            /// <summary>
                            /// <para>The text line and coordinate information.</para>
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
                                /// <para>The distance from the upper-left corner of the text area to the y-axis, with the upper-left corner of the image as the origin. Unit: pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>111</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <para>The distance from the upper-left corner of the text area to the x-axis, with the upper-left corner of the image as the origin. Unit: pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>222</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            /// <summary>
                            /// <para>The logo information.</para>
                            /// </summary>
                            [NameInMap("Logo")]
                            [Validation(Required=false)]
                            public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoDataLogo> Logo { get; set; }
                            public class VideoModerationResultResponseBodyDataFrameResultFramesResultsLogoDataLogo : TeaModel {
                                /// <summary>
                                /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>99.1</para>
                                /// </summary>
                                [NameInMap("confidence")]
                                [Validation(Required=false)]
                                public long? Confidence { get; set; }

                                /// <summary>
                                /// <para>The hit label.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>pt_logotoSocialNetwork</para>
                                /// </summary>
                                [NameInMap("label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>The logo name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>**卫视</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The identified public figure codes returned when the video contains specific public figures.</para>
                        /// </summary>
                        [NameInMap("PublicFigure")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigure> PublicFigure { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigure : TeaModel {
                            /// <summary>
                            /// <para>The code of the identified public figure.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>xxx001</para>
                            /// </summary>
                            [NameInMap("FigureId")]
                            [Validation(Required=false)]
                            public string FigureId { get; set; }

                            /// <summary>
                            /// <para>The name of the identified public figure.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>张三</para>
                            /// </summary>
                            [NameInMap("FigureName")]
                            [Validation(Required=false)]
                            public string FigureName { get; set; }

                            /// <summary>
                            /// <para>The location of the identified public figure.</para>
                            /// </summary>
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigureLocation> Location { get; set; }
                            public class VideoModerationResultResponseBodyDataFrameResultFramesResultsPublicFigureLocation : TeaModel {
                                /// <summary>
                                /// <para>The height.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>222</para>
                                /// </summary>
                                [NameInMap("H")]
                                [Validation(Required=false)]
                                public int? H { get; set; }

                                /// <summary>
                                /// <para>The width.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>111</para>
                                /// </summary>
                                [NameInMap("W")]
                                [Validation(Required=false)]
                                public int? W { get; set; }

                                /// <summary>
                                /// <para>The x-coordinate of the starting point.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>111</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <para>The y-coordinate of the starting point.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>222</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The hit result details.</para>
                        /// </summary>
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<VideoModerationResultResponseBodyDataFrameResultFramesResultsResult> Result { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsResult : TeaModel {
                            /// <summary>
                            /// <para>The confidence score, ranging from 0 to 100, rounded to two decimal places.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <para>The description of the Label field.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>未检测出风险</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The classification of the detection result.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>bloody</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// <para>The image moderation service type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tonalityImprove</para>
                        /// </summary>
                        [NameInMap("Service")]
                        [Validation(Required=false)]
                        public string Service { get; set; }

                        /// <summary>
                        /// <para>The text information detected in the hit image.</para>
                        /// </summary>
                        [NameInMap("TextInImage")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> TextInImage { get; set; }

                        /// <summary>
                        /// <para>The large model result.</para>
                        /// </summary>
                        [NameInMap("VlContent")]
                        [Validation(Required=false)]
                        public VideoModerationResultResponseBodyDataFrameResultFramesResultsVlContent VlContent { get; set; }
                        public class VideoModerationResultResponseBodyDataFrameResultFramesResultsVlContent : TeaModel {
                            /// <summary>
                            /// <para>The output text from the large model.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>in the picture XXX</para>
                            /// </summary>
                            [NameInMap("OutputText")]
                            [Validation(Required=false)]
                            public string OutputText { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The risk level, returned based on the configured high and low risk score thresholds. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>high: High risk.</para>
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
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The temporary access URL of the captured frame image.</para>
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
                /// <para>The risk level, returned based on the configured high and low risk score thresholds. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>high: High risk.</para>
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

            /// <summary>
            /// <para>The manual review task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>The risk level, returned based on the configured high and low risk score thresholds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>high: High risk.</para>
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
        /// <para>The return message.</para>
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
