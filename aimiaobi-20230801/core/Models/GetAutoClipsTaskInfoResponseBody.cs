// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetAutoClipsTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoClipsTaskInfoResponseBodyData Data { get; set; }
        public class GetAutoClipsTaskInfoResponseBodyData : TeaModel {
            [NameInMap("AnalysisResults")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataAnalysisResults> AnalysisResults { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResults : TeaModel {
                [NameInMap("LensInfos")]
                [Validation(Required=false)]
                public List<GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfos> LensInfos { get; set; }
                public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfos : TeaModel {
                    [NameInMap("AnalysisContent")]
                    [Validation(Required=false)]
                    public string AnalysisContent { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosEndTime EndTime { get; set; }
                    public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosEndTime : TeaModel {
                        [NameInMap("Hour")]
                        [Validation(Required=false)]
                        public int? Hour { get; set; }

                        [NameInMap("MillSecond")]
                        [Validation(Required=false)]
                        public int? MillSecond { get; set; }

                        [NameInMap("Minute")]
                        [Validation(Required=false)]
                        public int? Minute { get; set; }

                        [NameInMap("Second")]
                        [Validation(Required=false)]
                        public int? Second { get; set; }

                    }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosStartTime StartTime { get; set; }
                    public class GetAutoClipsTaskInfoResponseBodyDataAnalysisResultsLensInfosStartTime : TeaModel {
                        [NameInMap("Hour")]
                        [Validation(Required=false)]
                        public int? Hour { get; set; }

                        [NameInMap("MillSecond")]
                        [Validation(Required=false)]
                        public int? MillSecond { get; set; }

                        [NameInMap("Minute")]
                        [Validation(Required=false)]
                        public int? Minute { get; set; }

                        [NameInMap("Second")]
                        [Validation(Required=false)]
                        public int? Second { get; set; }

                    }

                }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("MediaName")]
                [Validation(Required=false)]
                public string MediaName { get; set; }

                [NameInMap("MediaUrl")]
                [Validation(Required=false)]
                public string MediaUrl { get; set; }

            }

            [NameInMap("CloseMusic")]
            [Validation(Required=false)]
            public bool? CloseMusic { get; set; }

            [NameInMap("CloseSubtitle")]
            [Validation(Required=false)]
            public bool? CloseSubtitle { get; set; }

            [NameInMap("CloseVoice")]
            [Validation(Required=false)]
            public bool? CloseVoice { get; set; }

            [NameInMap("ClosingCreditsUrl")]
            [Validation(Required=false)]
            public string ClosingCreditsUrl { get; set; }

            [NameInMap("ColorWords")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataColorWords> ColorWords { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataColorWords : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS0002-000008</para>
                /// </summary>
                [NameInMap("EffectColorStyle")]
                [Validation(Required=false)]
                public string EffectColorStyle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TimelineIn")]
                [Validation(Required=false)]
                public int? TimelineIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TimelineOut")]
                [Validation(Required=false)]
                public int? TimelineOut { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CustomVoiceStyle")]
            [Validation(Required=false)]
            public string CustomVoiceStyle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx/xxx.mp4">http://xxx/xxx.mp4</a></para>
            /// </summary>
            [NameInMap("CustomVoiceUrl")]
            [Validation(Required=false)]
            public string CustomVoiceUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CustomVoiceVolume")]
            [Validation(Required=false)]
            public int? CustomVoiceVolume { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("MediaCloudTimeline")]
            [Validation(Required=false)]
            public string MediaCloudTimeline { get; set; }

            [NameInMap("MusicStyle")]
            [Validation(Required=false)]
            public string MusicStyle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://music.mp4">http://music.mp4</a></para>
            /// </summary>
            [NameInMap("MusicUrl")]
            [Validation(Required=false)]
            public string MusicUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MusicVolume")]
            [Validation(Required=false)]
            public int? MusicVolume { get; set; }

            [NameInMap("OpeningCreditsUrl")]
            [Validation(Required=false)]
            public string OpeningCreditsUrl { get; set; }

            [NameInMap("OutputVideoFileKey")]
            [Validation(Required=false)]
            public string OutputVideoFileKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://output.mp4">http://output.mp4</a></para>
            /// </summary>
            [NameInMap("OutputVideoUrl")]
            [Validation(Required=false)]
            public string OutputVideoUrl { get; set; }

            [NameInMap("ReferenceVideo")]
            [Validation(Required=false)]
            public GetAutoClipsTaskInfoResponseBodyDataReferenceVideo ReferenceVideo { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataReferenceVideo : TeaModel {
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                [NameInMap("VideoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

            [NameInMap("SourceVideos")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataSourceVideos> SourceVideos { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataSourceVideos : TeaModel {
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                [NameInMap("VideoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>clips</para>
            /// </summary>
            [NameInMap("Step")]
            [Validation(Required=false)]
            public string Step { get; set; }

            [NameInMap("Stickers")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataStickers> Stickers { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataStickers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DyncFrames")]
                [Validation(Required=false)]
                public int? DyncFrames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimelineIn")]
                [Validation(Required=false)]
                public int? TimelineIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx/xxx.gif">http://xxx/xxx.gif</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SubtitleFontSize")]
            [Validation(Required=false)]
            public int? SubtitleFontSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e5a1a59c82d0454fad6454e8a04d0093</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Timelines")]
            [Validation(Required=false)]
            public List<GetAutoClipsTaskInfoResponseBodyDataTimelines> Timelines { get; set; }
            public class GetAutoClipsTaskInfoResponseBodyDataTimelines : TeaModel {
                [NameInMap("Clips")]
                [Validation(Required=false)]
                public List<GetAutoClipsTaskInfoResponseBodyDataTimelinesClips> Clips { get; set; }
                public class GetAutoClipsTaskInfoResponseBodyDataTimelinesClips : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20774ebd9abc71ef80486632b68f0102</para>
                    /// </summary>
                    [NameInMap("ClipId")]
                    [Validation(Required=false)]
                    public string ClipId { get; set; }

                    [NameInMap("ContentInner")]
                    [Validation(Required=false)]
                    public string ContentInner { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("In")]
                    [Validation(Required=false)]
                    public int? In { get; set; }

                    [NameInMap("InEx")]
                    [Validation(Required=false)]
                    public float? InEx { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Out")]
                    [Validation(Required=false)]
                    public int? Out { get; set; }

                    [NameInMap("OutEx")]
                    [Validation(Required=false)]
                    public float? OutEx { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20774ebd9abc71ef80486632b68f0102</para>
                    /// </summary>
                    [NameInMap("VideoId")]
                    [Validation(Required=false)]
                    public string VideoId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123.mp4</para>
                    /// </summary>
                    [NameInMap("VideoName")]
                    [Validation(Required=false)]
                    public string VideoName { get; set; }

                }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20774ebd9abc71ef80486632b68f0102</para>
                /// </summary>
                [NameInMap("TimelineId")]
                [Validation(Required=false)]
                public string TimelineId { get; set; }

            }

            [NameInMap("VoiceStyle")]
            [Validation(Required=false)]
            public string VoiceStyle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("VoiceVolume")]
            [Validation(Required=false)]
            public int? VoiceVolume { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
