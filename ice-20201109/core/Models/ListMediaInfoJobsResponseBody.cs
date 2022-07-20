// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaInfoJobsResponseBody : TeaModel {
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListMediaInfoJobsResponseBodyJobs> Jobs { get; set; }
        public class ListMediaInfoJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// 是否异步处理
            /// </summary>
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// 任务完成时间
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// 任务输入
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public ListMediaInfoJobsResponseBodyJobsInput Input { get; set; }
            public class ListMediaInfoJobsResponseBodyJobsInput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

            /// <summary>
            /// 任务 id
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 媒体信息详情
            /// </summary>
            [NameInMap("MediaInfoProperty")]
            [Validation(Required=false)]
            public ListMediaInfoJobsResponseBodyJobsMediaInfoProperty MediaInfoProperty { get; set; }
            public class ListMediaInfoJobsResponseBodyJobsMediaInfoProperty : TeaModel {
                [NameInMap("AudioStreamInfoList")]
                [Validation(Required=false)]
                public List<ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyAudioStreamInfoList : TeaModel {
                    public string Bitrate { get; set; }
                    public string ChannelLayout { get; set; }
                    public string Channels { get; set; }
                    public string CodecLongName { get; set; }
                    public string CodecName { get; set; }
                    public string CodecTag { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string Duration { get; set; }
                    public string Index { get; set; }
                    public string Lang { get; set; }
                    public string SampleFmt { get; set; }
                    public string SampleRate { get; set; }
                    public string StartTime { get; set; }
                    public string Timebase { get; set; }
                }
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyFileBasicInfo FileBasicInfo { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyFileBasicInfo : TeaModel {
                    /// <summary>
                    /// 视频码率
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// 视频时长
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// 文件名
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// 文件大小
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// 文件状态
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// 文件类型
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// 文件url
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// 视频格式名称
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// 高
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// 媒资ID
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// 文件所在区域
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// 宽
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }
                [NameInMap("VideoStreamInfoList")]
                [Validation(Required=false)]
                public List<ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyVideoStreamInfoList : TeaModel {
                    public string AvgFps { get; set; }
                    public string BitRate { get; set; }
                    public string CodecLongName { get; set; }
                    public string CodecName { get; set; }
                    public string CodecTag { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string Dar { get; set; }
                    public string Duration { get; set; }
                    public string Fps { get; set; }
                    public string HasBFrames { get; set; }
                    public string Height { get; set; }
                    public string Index { get; set; }
                    public string Lang { get; set; }
                    public string Level { get; set; }
                    public string NumFrames { get; set; }
                    public string PixFmt { get; set; }
                    public string Profile { get; set; }
                    public string Rotate { get; set; }
                    public string Sar { get; set; }
                    public string StartTime { get; set; }
                    public string TimeBase { get; set; }
                    public string Width { get; set; }
                }
            };

            /// <summary>
            /// 任务名字
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 请求 id
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// 调度信息
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public ListMediaInfoJobsResponseBodyJobsScheduleConfig ScheduleConfig { get; set; }
            public class ListMediaInfoJobsResponseBodyJobsScheduleConfig : TeaModel {
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }
            };

            /// <summary>
            /// 任务状态 - Init: 已提交, Success: 成功, Fail: 失败
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 任务提交信息
            /// </summary>
            [NameInMap("SubmitResultJson")]
            [Validation(Required=false)]
            public Dictionary<string, object> SubmitResultJson { get; set; }

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
