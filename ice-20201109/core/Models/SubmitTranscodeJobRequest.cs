// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobRequest : TeaModel {
        /// <summary>
        /// 任务输入组 (目前只支持一个)
        /// </summary>
        [NameInMap("InputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestInputGroup> InputGroup { get; set; }
        public class SubmitTranscodeJobRequestInputGroup : TeaModel {
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

        /// <summary>
        /// 任务名字
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 任务输出组
        /// </summary>
        [NameInMap("OutputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestOutputGroup> OutputGroup { get; set; }
        public class SubmitTranscodeJobRequestOutputGroup : TeaModel {
            /// <summary>
            /// 输出媒体配置
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupOutput Output { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupOutput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

            /// <summary>
            /// 任务处理配置
            /// </summary>
            [NameInMap("ProcessConfig")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupProcessConfig ProcessConfig { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupProcessConfig : TeaModel {
                [NameInMap("ImageWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks : TeaModel {
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                        /// <summary>
                        /// 水印位置，x
                        /// </summary>
                        [NameInMap("Dx")]
                        [Validation(Required=false)]
                        public string Dx { get; set; }

                        /// <summary>
                        /// 水印位置，y
                        /// </summary>
                        [NameInMap("Dy")]
                        [Validation(Required=false)]
                        public string Dy { get; set; }

                        /// <summary>
                        /// 水印文件oss路径
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                            [NameInMap("Media")]
                            [Validation(Required=false)]
                            public string Media { get; set; }
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }
                        };

                        /// <summary>
                        /// 高
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// 参考位置: TopLeft, TopRight, BottomLeft, BottomRight  default: TopLeft
                        /// </summary>
                        [NameInMap("ReferPos")]
                        [Validation(Required=false)]
                        public string ReferPos { get; set; }

                        /// <summary>
                        /// 显示时间设置
                        /// </summary>
                        [NameInMap("Timeline")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }
                        };

                        /// <summary>
                        /// 宽
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }
                    public string TemplateId { get; set; }
                }
                [NameInMap("Subtitles")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles : TeaModel {
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
                        /// <summary>
                        /// 文件 encoding 格式
                        /// </summary>
                        [NameInMap("CharEnc")]
                        [Validation(Required=false)]
                        public string CharEnc { get; set; }

                        /// <summary>
                        /// 字幕文件
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                            [NameInMap("Media")]
                            [Validation(Required=false)]
                            public string Media { get; set; }
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }
                        };

                        /// <summary>
                        /// 字幕文件格式
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }
                    public string TemplateId { get; set; }
                }
                [NameInMap("TextWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks : TeaModel {
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                        /// <summary>
                        /// 根据输出视频大小调整字体 size。 true / false, default: false
                        /// </summary>
                        [NameInMap("Adaptive")]
                        [Validation(Required=false)]
                        public string Adaptive { get; set; }

                        /// <summary>
                        /// 边框颜色
                        /// </summary>
                        [NameInMap("BorderColor")]
                        [Validation(Required=false)]
                        public string BorderColor { get; set; }

                        /// <summary>
                        /// 边框宽度
                        /// </summary>
                        [NameInMap("BorderWidth")]
                        [Validation(Required=false)]
                        public int? BorderWidth { get; set; }

                        /// <summary>
                        /// 水印文本，不需要 base64 encode，字符串需要 utf-8 编码
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// 透明度
                        /// </summary>
                        [NameInMap("FontAlpha")]
                        [Validation(Required=false)]
                        public string FontAlpha { get; set; }

                        /// <summary>
                        /// 颜色
                        /// </summary>
                        [NameInMap("FontColor")]
                        [Validation(Required=false)]
                        public string FontColor { get; set; }

                        /// <summary>
                        /// 字体
                        /// </summary>
                        [NameInMap("FontName")]
                        [Validation(Required=false)]
                        public string FontName { get; set; }

                        /// <summary>
                        /// 字体大小
                        /// </summary>
                        [NameInMap("FontSize")]
                        [Validation(Required=false)]
                        public int? FontSize { get; set; }

                        /// <summary>
                        /// 水印位置，距离左边距离
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public string Left { get; set; }

                        /// <summary>
                        /// 水印位置，距离上边距离
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public string Top { get; set; }

                    }
                    public string TemplateId { get; set; }
                }
                [NameInMap("Transcode")]
                [Validation(Required=false)]
                public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode Transcode { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode : TeaModel {
                    /// <summary>
                    /// 覆盖参数, 若填写会覆盖模板对应参数
                    /// </summary>
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                            /// <summary>
                            /// 输出文件的音频码率。
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// 声道数。
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            /// <summary>
                            /// 音频编解码格式，AAC、MP3、VORBIS、FLAC。
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// 音频编码预置。
                            /// </summary>
                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            /// <summary>
                            /// 是否删除音频流。
                            /// </summary>
                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            /// <summary>
                            /// 采样率。
                            /// </summary>
                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            /// <summary>
                            /// 音量控制
                            /// </summary>
                            [NameInMap("Volume")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                [NameInMap("IntegratedLoudnessTarget")]
                                [Validation(Required=false)]
                                public string IntegratedLoudnessTarget { get; set; }
                                [NameInMap("LoudnessRangeTarget")]
                                [Validation(Required=false)]
                                public string LoudnessRangeTarget { get; set; }
                                [NameInMap("Method")]
                                [Validation(Required=false)]
                                public string Method { get; set; }
                                [NameInMap("TruePeak")]
                                [Validation(Required=false)]
                                public string TruePeak { get; set; }
                            };

                        }
                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                            /// <summary>
                            /// 容器格式
                            /// </summary>
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }
                        [NameInMap("MuxConfig")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                            /// <summary>
                            /// 切片设置
                            /// </summary>
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }
                                [NameInMap("ForceSegTime")]
                                [Validation(Required=false)]
                                public string ForceSegTime { get; set; }
                            };

                        }
                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                            [NameInMap("AbrMax")]
                            [Validation(Required=false)]
                            public string AbrMax { get; set; }

                            /// <summary>
                            /// 视频平均码率。
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// 缓冲区大小
                            /// </summary>
                            [NameInMap("Bufsize")]
                            [Validation(Required=false)]
                            public string Bufsize { get; set; }

                            /// <summary>
                            /// 编码格式
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// 码率-质量控制因子。
                            /// </summary>
                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }

                            /// <summary>
                            /// 视频画面裁切
                            /// </summary>
                            [NameInMap("Crop")]
                            [Validation(Required=false)]
                            public string Crop { get; set; }

                            /// <summary>
                            /// 帧率。
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// 关键帧间最大帧数。
                            /// </summary>
                            [NameInMap("Gop")]
                            [Validation(Required=false)]
                            public string Gop { get; set; }

                            /// <summary>
                            /// 高。
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// 是否开启横竖屏自适应（即：长短边模式）
                            /// </summary>
                            [NameInMap("LongShortMode")]
                            [Validation(Required=false)]
                            public string LongShortMode { get; set; }

                            /// <summary>
                            /// 视频码率峰值
                            /// </summary>
                            [NameInMap("Maxrate")]
                            [Validation(Required=false)]
                            public string Maxrate { get; set; }

                            /// <summary>
                            /// 视频贴黑边
                            /// </summary>
                            [NameInMap("Pad")]
                            [Validation(Required=false)]
                            public string Pad { get; set; }

                            /// <summary>
                            /// 视频颜色格式。
                            /// </summary>
                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            /// <summary>
                            /// 只有H264支持该参数
                            /// </summary>
                            [NameInMap("Preset")]
                            [Validation(Required=false)]
                            public string Preset { get; set; }

                            /// <summary>
                            /// 编码级别。
                            /// </summary>
                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            /// <summary>
                            /// 是否去掉视频
                            /// </summary>
                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            /// <summary>
                            /// 扫描模式。
                            /// </summary>
                            [NameInMap("ScanMode")]
                            [Validation(Required=false)]
                            public string ScanMode { get; set; }

                            /// <summary>
                            /// 宽。
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }
                    };

                    /// <summary>
                    /// 模板 id
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }
            };

        }

        /// <summary>
        /// 任务调度信息
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitTranscodeJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitTranscodeJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
        };

        /// <summary>
        /// 用户数据
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
