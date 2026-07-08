// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetAutoClipsTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoClipsTaskInfoResponseBodyData Data { get; set; }
        public class GetAutoClipsTaskInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of video understanding results.</para>
            /// </summary>
            [NameInMap("AnalysisResults")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataAnalysisResults> AnalysisResults { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResults : TeaModel {
                /// <summary>
                /// <para>List of shot information.</para>
                /// </summary>
                [NameInMap("LensInfos")]
                [Validation(Required=false)]
                public List<GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfos> LensInfos { get; set; }
                public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfos : TeaModel {
                    /// <summary>
                    /// <para>Content analysis</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>视频理解内容</para>
                    /// </summary>
                    [NameInMap("AnalysisContent")]
                    [Validation(Required=false)]
                    public string AnalysisContent { get; set; }

                    /// <summary>
                    /// <para>End time.</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosEndTime EndTime { get; set; }
                    public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosEndTime : TeaModel {
                        /// <summary>
                        /// <para>Hour.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Hour")]
                        [Validation(Required=false)]
                        public int? Hour { get; set; }

                        /// <summary>
                        /// <para>Millisecond.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MillSecond")]
                        [Validation(Required=false)]
                        public int? MillSecond { get; set; }

                        /// <summary>
                        /// <para>Minute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Minute")]
                        [Validation(Required=false)]
                        public int? Minute { get; set; }

                        /// <summary>
                        /// <para>Second.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Second")]
                        [Validation(Required=false)]
                        public int? Second { get; set; }

                    }

                    /// <summary>
                    /// <para>Start time.</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosStartTime StartTime { get; set; }
                    public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosStartTime : TeaModel {
                        /// <summary>
                        /// <para>Hour.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Hour")]
                        [Validation(Required=false)]
                        public int? Hour { get; set; }

                        /// <summary>
                        /// <para>Millisecond.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MillSecond")]
                        [Validation(Required=false)]
                        public int? MillSecond { get; set; }

                        /// <summary>
                        /// <para>Minute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Minute")]
                        [Validation(Required=false)]
                        public int? Minute { get; set; }

                        /// <summary>
                        /// <para>Second.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Second")]
                        [Validation(Required=false)]
                        public int? Second { get; set; }

                    }

                }

                /// <summary>
                /// <para>Video ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>975e1d91a8d057e132cc5d88e4d5b360</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>Video name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video001.mp4</para>
                /// </summary>
                [NameInMap("MediaName")]
                [Validation(Required=false)]
                public string MediaName { get; set; }

                /// <summary>
                /// <para>Video URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
                /// </summary>
                [NameInMap("MediaUrl")]
                [Validation(Required=false)]
                public string MediaUrl { get; set; }

            }

            /// <summary>
            /// <para>Disable background music.</para>
            /// </summary>
            [NameInMap("CloseMusic")]
            [Validation(Required=false)]
            public bool? CloseMusic { get; set; }

            /// <summary>
            /// <para>Disable subtitles.</para>
            /// </summary>
            [NameInMap("CloseSubtitle")]
            [Validation(Required=false)]
            public bool? CloseSubtitle { get; set; }

            /// <summary>
            /// <para>Disable voiceover.</para>
            /// </summary>
            [NameInMap("CloseVoice")]
            [Validation(Required=false)]
            public bool? CloseVoice { get; set; }

            /// <summary>
            /// <para>URL of the closing credits video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
            /// </summary>
            [NameInMap("ClosingCreditsUrl")]
            [Validation(Required=false)]
            public string ClosingCreditsUrl { get; set; }

            /// <summary>
            /// <para>Array of decorative text elements.</para>
            /// </summary>
            [NameInMap("ColorWords")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataColorWords> ColorWords { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataColorWords : TeaModel {
                /// <summary>
                /// <para>Text content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>花字内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Visual effect of the decorative text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS0002-000008</para>
                /// </summary>
                [NameInMap("EffectColorStyle")]
                [Validation(Required=false)]
                public string EffectColorStyle { get; set; }

                /// <summary>
                /// <para>Font size of the decorative text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <para>Start time of the decorative text in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TimelineIn")]
                [Validation(Required=false)]
                public int? TimelineIn { get; set; }

                /// <summary>
                /// <para>End time of the decorative text in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TimelineOut")]
                [Validation(Required=false)]
                public int? TimelineOut { get; set; }

                /// <summary>
                /// <para>X-coordinate of the decorative text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>Y-coordinate of the decorative text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

            /// <summary>
            /// <para>Full voiceover script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>口播内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Voice style for CosyVoice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longxian_normal</para>
            /// </summary>
            [NameInMap("CustomVoiceStyle")]
            [Validation(Required=false)]
            public string CustomVoiceStyle { get; set; }

            /// <summary>
            /// <para>URL of the custom audio track file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
            /// </summary>
            [NameInMap("CustomVoiceUrl")]
            [Validation(Required=false)]
            public string CustomVoiceUrl { get; set; }

            /// <summary>
            /// <para>Volume of the custom audio track.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CustomVoiceVolume")]
            [Validation(Required=false)]
            public int? CustomVoiceVolume { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>ApsaraVideo timeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>视频云格式timeline</para>
            /// </summary>
            [NameInMap("MediaCloudTimeline")]
            [Validation(Required=false)]
            public string MediaCloudTimeline { get; set; }

            /// <summary>
            /// <para>Recommended music style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>国风</para>
            /// </summary>
            [NameInMap("MusicStyle")]
            [Validation(Required=false)]
            public string MusicStyle { get; set; }

            /// <summary>
            /// <para>URL of the background music.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://music.mp4">http://music.mp4</a></para>
            /// </summary>
            [NameInMap("MusicUrl")]
            [Validation(Required=false)]
            public string MusicUrl { get; set; }

            /// <summary>
            /// <para>Volume of the background music.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MusicVolume")]
            [Validation(Required=false)]
            public int? MusicVolume { get; set; }

            /// <summary>
            /// <para>URL of the opening credits video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
            /// </summary>
            [NameInMap("OpeningCreditsUrl")]
            [Validation(Required=false)]
            public string OpeningCreditsUrl { get; set; }

            /// <summary>
            /// <para>File key of the output video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://xxx/xxx.mp4</para>
            /// </summary>
            [NameInMap("OutputVideoFileKey")]
            [Validation(Required=false)]
            public string OutputVideoFileKey { get; set; }

            /// <summary>
            /// <para>URL of the final video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://output.mp4">http://output.mp4</a></para>
            /// </summary>
            [NameInMap("OutputVideoUrl")]
            [Validation(Required=false)]
            public string OutputVideoUrl { get; set; }

            /// <summary>
            /// <para>Reference video information.</para>
            /// </summary>
            [NameInMap("ReferenceVideo")]
            [Validation(Required=false)]
            public GetAutoClipsTaskInfoResponseBodyDataReferenceVideo ReferenceVideo { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataReferenceVideo : TeaModel {
                /// <summary>
                /// <para>Video ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90ca686b11c371f08339752281ed0102</para>
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                /// <summary>
                /// <para>Video name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video001.mp4</para>
                /// </summary>
                [NameInMap("VideoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

                /// <summary>
                /// <para>Video URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
                /// </summary>
                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

            /// <summary>
            /// <para>List of video sources used for editing.</para>
            /// </summary>
            [NameInMap("SourceVideos")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataSourceVideos> SourceVideos { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataSourceVideos : TeaModel {
                /// <summary>
                /// <para>Video ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fdaswe</para>
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                /// <summary>
                /// <para>Video name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video001.mp4</para>
                /// </summary>
                [NameInMap("VideoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

                /// <summary>
                /// <para>Video URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
                /// </summary>
                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

            /// <summary>
            /// <para>Status</para>
            /// 
            /// <b>Example:</b>
            /// <para>0-待执行、1-执行中、2-执行成功、3-暂停、4-执行失败-可重试、5-执行失败-不可重试,6-任务取消</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Current step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clips</para>
            /// </summary>
            [NameInMap("Step")]
            [Validation(Required=false)]
            public string Step { get; set; }

            /// <summary>
            /// <para>Array of stickers.</para>
            /// </summary>
            [NameInMap("Stickers")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataStickers> Stickers { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataStickers : TeaModel {
                /// <summary>
                /// <para>Duration of the sticker display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>Height of the sticker</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DyncFrames")]
                [Validation(Required=false)]
                public int? DyncFrames { get; set; }

                /// <summary>
                /// <para>Height of the sticker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>Start time of the sticker in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimelineIn")]
                [Validation(Required=false)]
                public int? TimelineIn { get; set; }

                /// <summary>
                /// <para>URL of the sticker GIF file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx/xxx.gif">http://xxx/xxx.gif</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Width of the sticker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <para>X-coordinate of the sticker position.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>Y-coordinate of the sticker position.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

            /// <summary>
            /// <para>Font size of subtitles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SubtitleFontSize")]
            [Validation(Required=false)]
            public int? SubtitleFontSize { get; set; }

            /// <summary>
            /// <para>Unique ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e5a1a59c82d0454fad6454e8a04d0093</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Array of voiceover timelines.</para>
            /// </summary>
            [NameInMap("Timelines")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataTimelines> Timelines { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataTimelines : TeaModel {
                /// <summary>
                /// <para>Array of video clips.</para>
                /// </summary>
                [NameInMap("Clips")]
                [Validation(Required=false)]
                public List<GetAutoClipsTaskInfoResponseBodyDataTimelinesClips> Clips { get; set; }
                public class GetAutoClipsTaskInfoResponseBodyDataTimelinesClips : TeaModel {
                    /// <summary>
                    /// <para>ID of the clip.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20774ebd9abc71ef80486632b68f0102</para>
                    /// </summary>
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    /// <summary>
                    /// <para>Segmented voiceover script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>口播分段内容</para>
                    /// </summary>
                    [NameInMap("ContentInner")]
                    [Validation(Required=false)]
                    public string ContentInner { get; set; }

                    /// <summary>
                    /// <para>Start time of the clip in seconds. This field is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("In")]
                    [Validation(Required=false)]
                    public int? In { get; set; }

                    /// <summary>
                    /// <para>Start time of the clip in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.33</para>
                    /// </summary>
                    [NameInMap("InEx")]
                    [Validation(Required=false)]
                    public float? InEx { get; set; }

                    /// <summary>
                    /// <para>End time of the clip in seconds. This field is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Out")]
                    [Validation(Required=false)]
                    public int? Out { get; set; }

                    /// <summary>
                    /// <para>End time of the clip in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3.45</para>
                    /// </summary>
                    [NameInMap("OutEx")]
                    [Validation(Required=false)]
                    public float? OutEx { get; set; }

                    /// <summary>
                    /// <para>ID of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20774ebd9abc71ef80486632b68f0102</para>
                    /// </summary>
                    [NameInMap("VideoId")]
                    [Validation(Required=false)]
                    public string VideoId { get; set; }

                    /// <summary>
                    /// <para>Name of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123.mp4</para>
                    /// </summary>
                    [NameInMap("VideoName")]
                    [Validation(Required=false)]
                    public string VideoName { get; set; }

                }

                /// <summary>
                /// <para>Voiceover script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>口播内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>ID of the timeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20774ebd9abc71ef80486632b68f0102</para>
                /// </summary>
                [NameInMap("TimelineId")]
                [Validation(Required=false)]
                public string TimelineId { get; set; }

            }

            /// <summary>
            /// <para>Voice style for voiceover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>温柔女声</para>
            /// </summary>
            [NameInMap("VoiceStyle")]
            [Validation(Required=false)]
            public string VoiceStyle { get; set; }

            /// <summary>
            /// <para>Volume of the voiceover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("VoiceVolume")]
            [Validation(Required=false)]
            public int? VoiceVolume { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
