// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSyncMediaInfoJobResponseBody : TeaModel {
        /// <summary>
        /// MediaInfoJobDTO
        /// </summary>
        [NameInMap("MediaInfoJob")]
        [Validation(Required=false)]
        public SubmitSyncMediaInfoJobResponseBodyMediaInfoJob MediaInfoJob { get; set; }
        public class SubmitSyncMediaInfoJobResponseBodyMediaInfoJob : TeaModel {
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitSyncMediaInfoJobResponseBodyMediaInfoJobInput Input { get; set; }
            public class SubmitSyncMediaInfoJobResponseBodyMediaInfoJobInput : TeaModel {
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
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("MediaInfoProperty")]
            [Validation(Required=false)]
            public SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoProperty MediaInfoProperty { get; set; }
            public class SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoProperty : TeaModel {
                /// <summary>
                /// 音频流信息
                /// </summary>
                [NameInMap("AudioStreamInfoList")]
                [Validation(Required=false)]
                public List<SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyAudioStreamInfoList : TeaModel {
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
                public SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyFileBasicInfo FileBasicInfo { get; set; }
                public class SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyFileBasicInfo : TeaModel {
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
                public List<SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class SubmitSyncMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyVideoStreamInfoList : TeaModel {
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
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public SubmitSyncMediaInfoJobResponseBodyMediaInfoJobScheduleConfig ScheduleConfig { get; set; }
            public class SubmitSyncMediaInfoJobResponseBodyMediaInfoJobScheduleConfig : TeaModel {
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
            [NameInMap("SubmitResultJson")]
            [Validation(Required=false)]
            public Dictionary<string, string> SubmitResultJson { get; set; }
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

        /// <summary>
        /// 请求 id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
