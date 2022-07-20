// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobResponseBody : TeaModel {
        /// <summary>
        /// 请求 id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// TranscodeParentJobWithSubJobDTO
        /// </summary>
        [NameInMap("TranscodeParentJob")]
        [Validation(Required=false)]
        public SubmitTranscodeJobResponseBodyTranscodeParentJob TranscodeParentJob { get; set; }
        public class SubmitTranscodeJobResponseBodyTranscodeParentJob : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }
            [NameInMap("InputGroup")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobInputGroup> InputGroup { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobInputGroup : TeaModel {
                public string Media { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("JobCount")]
            [Validation(Required=false)]
            public int? JobCount { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("OutputGroup")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroup> OutputGroup { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroup : TeaModel {
                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput Output { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput : TeaModel {
                    /// <summary>
                    /// 媒体值：
                    ///       type 为 OSS 时，为 url, 支持 oss 协议和 http 协议；
                    ///       type 为 Media 时，为媒资 id。
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// 媒体对象类型 - OSS: oss文件, Media: 媒资 ID
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig ProcessConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig : TeaModel {
                    /// <summary>
                    /// 图片水印配置
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// 覆盖参数, 若填写会覆盖模板对应参数
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }
                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }
                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// 媒体值：
                                ///       type 为 OSS 时，为 url, 支持 oss 协议和 http 协议；
                                ///       type 为 Media 时，为媒资 id。
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// 媒体对象类型 - OSS: oss文件, Media: 媒资 ID
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                /// <summary>
                                /// 显示时长，秒数 或者 "ToEND"
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// 开始时间
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }
                        };

                        /// <summary>
                        /// 模板 id
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// 字幕压制配置
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// 覆盖参数, 若填写会覆盖模板对应参数
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
                            [NameInMap("CharEnc")]
                            [Validation(Required=false)]
                            public string CharEnc { get; set; }
                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// 媒体值：
                                ///       type 为 OSS 时，为 url, 支持 oss 协议和 http 协议；
                                ///       type 为 Media 时，为媒资 id。
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// 媒体对象类型 - OSS: oss文件, Media: 媒资 ID
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }
                        };

                        /// <summary>
                        /// 模板 id
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// 文字水印配置
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// 覆盖参数, 若填写会覆盖模板对应参数
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }
                            [NameInMap("BorderWidth")]
                            [Validation(Required=false)]
                            public int? BorderWidth { get; set; }
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }
                            [NameInMap("FontAlpha")]
                            [Validation(Required=false)]
                            public string FontAlpha { get; set; }
                            [NameInMap("FontColor")]
                            [Validation(Required=false)]
                            public string FontColor { get; set; }
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public string Left { get; set; }
                            [NameInMap("Top")]
                            [Validation(Required=false)]
                            public string Top { get; set; }
                        };

                        /// <summary>
                        /// 模板 id
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// 转码配置
                    /// </summary>
                    [NameInMap("Transcode")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscode Transcode { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscode : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                            /// <summary>
                            /// audio 设置
                            /// </summary>
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }
                                [NameInMap("Channels")]
                                [Validation(Required=false)]
                                public string Channels { get; set; }
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }
                                [NameInMap("Samplerate")]
                                [Validation(Required=false)]
                                public string Samplerate { get; set; }
                                [NameInMap("Volume")]
                                [Validation(Required=false)]
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                    /// <summary>
                                    /// 目标音量
                                    /// </summary>
                                    [NameInMap("IntegratedLoudnessTarget")]
                                    [Validation(Required=false)]
                                    public string IntegratedLoudnessTarget { get; set; }

                                    /// <summary>
                                    /// 音量范围
                                    /// </summary>
                                    [NameInMap("LoudnessRangeTarget")]
                                    [Validation(Required=false)]
                                    public string LoudnessRangeTarget { get; set; }

                                    /// <summary>
                                    /// 音量调整方式
                                    /// </summary>
                                    [NameInMap("Method")]
                                    [Validation(Required=false)]
                                    public string Method { get; set; }

                                    /// <summary>
                                    /// 最大峰值
                                    /// </summary>
                                    [NameInMap("TruePeak")]
                                    [Validation(Required=false)]
                                    public string TruePeak { get; set; }

                                }
                            };

                            /// <summary>
                            /// 封装格式设置
                            /// </summary>
                            [NameInMap("Container")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                                [NameInMap("Format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }
                            };

                            /// <summary>
                            /// 封装设置
                            /// </summary>
                            [NameInMap("MuxConfig")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
                                    /// <summary>
                                    /// 切片时长
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// 强制切片时间点
                                    /// </summary>
                                    [NameInMap("ForceSegTime")]
                                    [Validation(Required=false)]
                                    public string ForceSegTime { get; set; }

                                }
                            };

                            /// <summary>
                            /// video 设置
                            /// </summary>
                            [NameInMap("Video")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                                [NameInMap("AbrMax")]
                                [Validation(Required=false)]
                                public string AbrMax { get; set; }
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }
                                [NameInMap("Bufsize")]
                                [Validation(Required=false)]
                                public string Bufsize { get; set; }
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }
                                [NameInMap("Crf")]
                                [Validation(Required=false)]
                                public string Crf { get; set; }
                                [NameInMap("Crop")]
                                [Validation(Required=false)]
                                public string Crop { get; set; }
                                [NameInMap("Fps")]
                                [Validation(Required=false)]
                                public string Fps { get; set; }
                                [NameInMap("Gop")]
                                [Validation(Required=false)]
                                public string Gop { get; set; }
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }
                                [NameInMap("LongShortMode")]
                                [Validation(Required=false)]
                                public string LongShortMode { get; set; }
                                [NameInMap("Maxrate")]
                                [Validation(Required=false)]
                                public string Maxrate { get; set; }
                                [NameInMap("Pad")]
                                [Validation(Required=false)]
                                public string Pad { get; set; }
                                [NameInMap("PixFmt")]
                                [Validation(Required=false)]
                                public string PixFmt { get; set; }
                                [NameInMap("Preset")]
                                [Validation(Required=false)]
                                public string Preset { get; set; }
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }
                                [NameInMap("ScanMode")]
                                [Validation(Required=false)]
                                public string ScanMode { get; set; }
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }
                            };

                        }
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }
                    };

                }
            }
            [NameInMap("ParentJobId")]
            [Validation(Required=false)]
            public string ParentJobId { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public SubmitTranscodeJobResponseBodyTranscodeParentJobScheduleConfig ScheduleConfig { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobScheduleConfig : TeaModel {
                /// <summary>
                /// 管道 id
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// 任务优先级，取值范围：1~10
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }
            [NameInMap("TranscodeJobList")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList> TranscodeJobList { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList : TeaModel {
                public string CreateTime { get; set; }
                public string FinishTime { get; set; }
                public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup> InputGroup { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup : TeaModel {
                    public string Media { get; set; }
                    public string Type { get; set; }
                }
                public string JobId { get; set; }
                public int? JobIndex { get; set; }
                public string Name { get; set; }
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta OutFileMeta { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta : TeaModel {
                    /// <summary>
                    /// 音频流信息
                    /// </summary>
                    [NameInMap("AudioStreamInfoList")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaAudioStreamInfoList> AudioStreamInfoList { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaAudioStreamInfoList : TeaModel {
                        /// <summary>
                        /// 码率
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// 声道布局
                        /// </summary>
                        [NameInMap("ChannelLayout")]
                        [Validation(Required=false)]
                        public string ChannelLayout { get; set; }

                        /// <summary>
                        /// 声道数
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public string Channels { get; set; }

                        /// <summary>
                        /// 编码格式名
                        /// </summary>
                        [NameInMap("CodecLongName")]
                        [Validation(Required=false)]
                        public string CodecLongName { get; set; }

                        /// <summary>
                        /// 编码格式
                        /// </summary>
                        [NameInMap("CodecName")]
                        [Validation(Required=false)]
                        public string CodecName { get; set; }

                        /// <summary>
                        /// 编码器标签
                        /// </summary>
                        [NameInMap("CodecTag")]
                        [Validation(Required=false)]
                        public string CodecTag { get; set; }

                        /// <summary>
                        /// 编码器标签名
                        /// </summary>
                        [NameInMap("CodecTagString")]
                        [Validation(Required=false)]
                        public string CodecTagString { get; set; }

                        /// <summary>
                        /// 编码器时间基
                        /// </summary>
                        [NameInMap("CodecTimeBase")]
                        [Validation(Required=false)]
                        public string CodecTimeBase { get; set; }

                        /// <summary>
                        /// 时长
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// 流序号
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        /// <summary>
                        /// 语言
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

                        [NameInMap("SampleFmt")]
                        [Validation(Required=false)]
                        public string SampleFmt { get; set; }

                        /// <summary>
                        /// 采样率
                        /// </summary>
                        [NameInMap("SampleRate")]
                        [Validation(Required=false)]
                        public string SampleRate { get; set; }

                        /// <summary>
                        /// 开始时间
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// 时间基
                        /// </summary>
                        [NameInMap("Timebase")]
                        [Validation(Required=false)]
                        public string Timebase { get; set; }

                    }

                    /// <summary>
                    /// 基础文件信息
                    /// </summary>
                    [NameInMap("FileBasicInfo")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaFileBasicInfo FileBasicInfo { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaFileBasicInfo : TeaModel {
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }
                        [NameInMap("FileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }
                        [NameInMap("FileStatus")]
                        [Validation(Required=false)]
                        public string FileStatus { get; set; }
                        [NameInMap("FileType")]
                        [Validation(Required=false)]
                        public string FileType { get; set; }
                        [NameInMap("FileUrl")]
                        [Validation(Required=false)]
                        public string FileUrl { get; set; }
                        [NameInMap("FormatName")]
                        [Validation(Required=false)]
                        public string FormatName { get; set; }
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }
                        [NameInMap("MediaId")]
                        [Validation(Required=false)]
                        public string MediaId { get; set; }
                        [NameInMap("Region")]
                        [Validation(Required=false)]
                        public string Region { get; set; }
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }
                    };

                    /// <summary>
                    /// 视频流信息
                    /// </summary>
                    [NameInMap("VideoStreamInfoList")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaVideoStreamInfoList> VideoStreamInfoList { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaVideoStreamInfoList : TeaModel {
                        [NameInMap("Avg_fps")]
                        [Validation(Required=false)]
                        public string AvgFps { get; set; }

                        [NameInMap("Bit_rate")]
                        [Validation(Required=false)]
                        public string BitRate { get; set; }

                        /// <summary>
                        /// 编码格式名
                        /// </summary>
                        [NameInMap("Codec_long_name")]
                        [Validation(Required=false)]
                        public string CodecLongName { get; set; }

                        /// <summary>
                        /// 编码格式
                        /// </summary>
                        [NameInMap("Codec_name")]
                        [Validation(Required=false)]
                        public string CodecName { get; set; }

                        /// <summary>
                        /// 编码格式标记
                        /// </summary>
                        [NameInMap("Codec_tag")]
                        [Validation(Required=false)]
                        public string CodecTag { get; set; }

                        /// <summary>
                        /// 编码格式标记文本
                        /// </summary>
                        [NameInMap("Codec_tag_string")]
                        [Validation(Required=false)]
                        public string CodecTagString { get; set; }

                        [NameInMap("Codec_time_base")]
                        [Validation(Required=false)]
                        public string CodecTimeBase { get; set; }

                        /// <summary>
                        /// 图像显示宽高比
                        /// </summary>
                        [NameInMap("Dar")]
                        [Validation(Required=false)]
                        public string Dar { get; set; }

                        /// <summary>
                        /// 时长
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// 帧率
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        [NameInMap("Has_b_frames")]
                        [Validation(Required=false)]
                        public string HasBFrames { get; set; }

                        /// <summary>
                        /// 高
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// 流序号
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        /// <summary>
                        /// 语言
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

                        /// <summary>
                        /// 编码等级
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// 总帧数
                        /// </summary>
                        [NameInMap("NumFrames")]
                        [Validation(Required=false)]
                        public string NumFrames { get; set; }

                        /// <summary>
                        /// 颜色存储格式
                        /// </summary>
                        [NameInMap("PixFmt")]
                        [Validation(Required=false)]
                        public string PixFmt { get; set; }

                        /// <summary>
                        /// 编码器预设
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// 视频画面旋转角度
                        /// </summary>
                        [NameInMap("Rotate")]
                        [Validation(Required=false)]
                        public string Rotate { get; set; }

                        /// <summary>
                        /// 采集点数宽高比
                        /// </summary>
                        [NameInMap("Sar")]
                        [Validation(Required=false)]
                        public string Sar { get; set; }

                        /// <summary>
                        /// 起始时间
                        /// </summary>
                        [NameInMap("Start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("Time_base")]
                        [Validation(Required=false)]
                        public string TimeBase { get; set; }

                        /// <summary>
                        /// 宽
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput Output { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput : TeaModel {
                    /// <summary>
                    /// 媒体值：
                    ///       type 为 OSS 时，为 url, 支持 oss 协议和 http 协议；
                    ///       type 为 Media 时，为媒资 id。
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// 媒体对象类型 - OSS: oss文件, Media: 媒资 ID
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
                public string ParentJobId { get; set; }
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig ProcessConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig : TeaModel {
                    /// <summary>
                    /// 图片水印配置
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// 覆盖参数, 若填写会覆盖模板对应参数
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }
                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }
                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// 媒体值：
                                ///       type 为 OSS 时，为 url, 支持 oss 协议和 http 协议；
                                ///       type 为 Media 时，为媒资 id。
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// 媒体对象类型 - OSS: oss文件, Media: 媒资 ID
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                /// <summary>
                                /// 显示时长，秒数 或者 "ToEND"
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// 开始时间
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }
                        };

                        /// <summary>
                        /// 模板 id
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// 字幕压制配置
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles> Subtitles { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// 覆盖参数, 若填写会覆盖模板对应参数
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams : TeaModel {
                            [NameInMap("CharEnc")]
                            [Validation(Required=false)]
                            public string CharEnc { get; set; }
                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// 媒体值：
                                ///       type 为 OSS 时，为 url, 支持 oss 协议和 http 协议；
                                ///       type 为 Media 时，为媒资 id。
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// 媒体对象类型 - OSS: oss文件, Media: 媒资 ID
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }
                        };

                        /// <summary>
                        /// 模板 id
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// 文字水印配置
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// 覆盖参数, 若填写会覆盖模板对应参数
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }
                            [NameInMap("BorderWidth")]
                            [Validation(Required=false)]
                            public int? BorderWidth { get; set; }
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }
                            [NameInMap("FontAlpha")]
                            [Validation(Required=false)]
                            public string FontAlpha { get; set; }
                            [NameInMap("FontColor")]
                            [Validation(Required=false)]
                            public string FontColor { get; set; }
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public string Left { get; set; }
                            [NameInMap("Top")]
                            [Validation(Required=false)]
                            public string Top { get; set; }
                        };

                        /// <summary>
                        /// 模板 id
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// 转码配置
                    /// </summary>
                    [NameInMap("Transcode")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscode Transcode { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscode : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParams : TeaModel {
                            /// <summary>
                            /// audio 设置
                            /// </summary>
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }
                                [NameInMap("Channels")]
                                [Validation(Required=false)]
                                public string Channels { get; set; }
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }
                                [NameInMap("Samplerate")]
                                [Validation(Required=false)]
                                public string Samplerate { get; set; }
                                [NameInMap("Volume")]
                                [Validation(Required=false)]
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                    /// <summary>
                                    /// 目标音量
                                    /// </summary>
                                    [NameInMap("IntegratedLoudnessTarget")]
                                    [Validation(Required=false)]
                                    public string IntegratedLoudnessTarget { get; set; }

                                    /// <summary>
                                    /// 音量范围
                                    /// </summary>
                                    [NameInMap("LoudnessRangeTarget")]
                                    [Validation(Required=false)]
                                    public string LoudnessRangeTarget { get; set; }

                                    /// <summary>
                                    /// 音量调整方式
                                    /// </summary>
                                    [NameInMap("Method")]
                                    [Validation(Required=false)]
                                    public string Method { get; set; }

                                    /// <summary>
                                    /// 最大峰值
                                    /// </summary>
                                    [NameInMap("TruePeak")]
                                    [Validation(Required=false)]
                                    public string TruePeak { get; set; }

                                }
                            };

                            /// <summary>
                            /// 封装格式设置
                            /// </summary>
                            [NameInMap("Container")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                                [NameInMap("Format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }
                            };

                            /// <summary>
                            /// 封装设置
                            /// </summary>
                            [NameInMap("MuxConfig")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
                                    /// <summary>
                                    /// 切片时长
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// 强制切片时间点
                                    /// </summary>
                                    [NameInMap("ForceSegTime")]
                                    [Validation(Required=false)]
                                    public string ForceSegTime { get; set; }

                                }
                            };

                            /// <summary>
                            /// video 设置
                            /// </summary>
                            [NameInMap("Video")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                                [NameInMap("AbrMax")]
                                [Validation(Required=false)]
                                public string AbrMax { get; set; }
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }
                                [NameInMap("Bufsize")]
                                [Validation(Required=false)]
                                public string Bufsize { get; set; }
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }
                                [NameInMap("Crf")]
                                [Validation(Required=false)]
                                public string Crf { get; set; }
                                [NameInMap("Crop")]
                                [Validation(Required=false)]
                                public string Crop { get; set; }
                                [NameInMap("Fps")]
                                [Validation(Required=false)]
                                public string Fps { get; set; }
                                [NameInMap("Gop")]
                                [Validation(Required=false)]
                                public string Gop { get; set; }
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }
                                [NameInMap("LongShortMode")]
                                [Validation(Required=false)]
                                public string LongShortMode { get; set; }
                                [NameInMap("Maxrate")]
                                [Validation(Required=false)]
                                public string Maxrate { get; set; }
                                [NameInMap("Pad")]
                                [Validation(Required=false)]
                                public string Pad { get; set; }
                                [NameInMap("PixFmt")]
                                [Validation(Required=false)]
                                public string PixFmt { get; set; }
                                [NameInMap("Preset")]
                                [Validation(Required=false)]
                                public string Preset { get; set; }
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }
                                [NameInMap("ScanMode")]
                                [Validation(Required=false)]
                                public string ScanMode { get; set; }
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }
                            };

                        }
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }
                    };

                }
                public string RequestId { get; set; }
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig ScheduleConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig : TeaModel {
                    /// <summary>
                    /// 管道 id
                    /// </summary>
                    [NameInMap("PipelineId")]
                    [Validation(Required=false)]
                    public string PipelineId { get; set; }

                    /// <summary>
                    /// 任务优先级，取值范围：1~10
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                }
                public string Status { get; set; }
                public Dictionary<string, string> SubmitResultJson { get; set; }
                public string SubmitTime { get; set; }
                public string UserData { get; set; }
            }
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

    }

}
