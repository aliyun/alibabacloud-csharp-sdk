// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTranscodeJobsResponseBody : TeaModel {
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListTranscodeJobsResponseBodyJobs> Jobs { get; set; }
        public class ListTranscodeJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// 任务创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 任务结束时间
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// 任务输入组 (目前只支持单个输入)
            /// </summary>
            [NameInMap("InputGroup")]
            [Validation(Required=false)]
            public List<ListTranscodeJobsResponseBodyJobsInputGroup> InputGroup { get; set; }
            public class ListTranscodeJobsResponseBodyJobsInputGroup : TeaModel {
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
            /// 子任务数量
            /// </summary>
            [NameInMap("JobCount")]
            [Validation(Required=false)]
            public int? JobCount { get; set; }

            /// <summary>
            /// 任务名
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 任务输出组
            /// </summary>
            [NameInMap("OutputGroup")]
            [Validation(Required=false)]
            public List<ListTranscodeJobsResponseBodyJobsOutputGroup> OutputGroup { get; set; }
            public class ListTranscodeJobsResponseBodyJobsOutputGroup : TeaModel {
                /// <summary>
                /// 输出媒体配置
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public ListTranscodeJobsResponseBodyJobsOutputGroupOutput Output { get; set; }
                public class ListTranscodeJobsResponseBodyJobsOutputGroupOutput : TeaModel {
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
                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfig ProcessConfig { get; set; }
                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfig : TeaModel {
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks : TeaModel {
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
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
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
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
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
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
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles : TeaModel {
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
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
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
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
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks : TeaModel {
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
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
                    public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscode Transcode { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscode : TeaModel {
                        /// <summary>
                        /// 覆盖参数, 若填写会覆盖模板对应参数
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
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
                                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                                /// <summary>
                                /// 容器格式
                                /// </summary>
                                [NameInMap("Format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                            }
                            [NameInMap("MuxConfig")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                /// <summary>
                                /// 切片设置
                                /// </summary>
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
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
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
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
            /// 主任务 id
            /// </summary>
            [NameInMap("ParentJobId")]
            [Validation(Required=false)]
            public string ParentJobId { get; set; }

            /// <summary>
            /// 任务完成百分比
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// 提交任务时请求 id
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// 任务调度配置
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public ListTranscodeJobsResponseBodyJobsScheduleConfig ScheduleConfig { get; set; }
            public class ListTranscodeJobsResponseBodyJobsScheduleConfig : TeaModel {
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }
            };

            /// <summary>
            /// 任务状态 Success: 有子任务成功, Fail: 所有子任务失败
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 任务提交时间
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// 任务来源 - API, WorkFlow, Console
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// 用户数据
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// 请求 id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
