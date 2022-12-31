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
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

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

            }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("MediaInfoProperty")]
            [Validation(Required=false)]
            public ListMediaInfoJobsResponseBodyJobsMediaInfoProperty MediaInfoProperty { get; set; }
            public class ListMediaInfoJobsResponseBodyJobsMediaInfoProperty : TeaModel {
                [NameInMap("AudioStreamInfoList")]
                [Validation(Required=false)]
                public List<ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyAudioStreamInfoList : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("ChannelLayout")]
                    [Validation(Required=false)]
                    public string ChannelLayout { get; set; }

                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    [NameInMap("SampleFmt")]
                    [Validation(Required=false)]
                    public string SampleFmt { get; set; }

                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public string SampleRate { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyFileBasicInfo FileBasicInfo { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyFileBasicInfo : TeaModel {
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

                }

                [NameInMap("VideoStreamInfoList")]
                [Validation(Required=false)]
                public List<ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyVideoStreamInfoList : TeaModel {
                    [NameInMap("Avg_fps")]
                    [Validation(Required=false)]
                    public string AvgFps { get; set; }

                    [NameInMap("Bit_rate")]
                    [Validation(Required=false)]
                    public string BitRate { get; set; }

                    [NameInMap("Codec_long_name")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    [NameInMap("Codec_name")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    [NameInMap("Codec_tag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    [NameInMap("Codec_tag_string")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    [NameInMap("Codec_time_base")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    [NameInMap("Dar")]
                    [Validation(Required=false)]
                    public string Dar { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    [NameInMap("Has_b_frames")]
                    [Validation(Required=false)]
                    public string HasBFrames { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("NumFrames")]
                    [Validation(Required=false)]
                    public string NumFrames { get; set; }

                    [NameInMap("PixFmt")]
                    [Validation(Required=false)]
                    public string PixFmt { get; set; }

                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    [NameInMap("Start_time")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Time_base")]
                    [Validation(Required=false)]
                    public string TimeBase { get; set; }

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
            public ListMediaInfoJobsResponseBodyJobsScheduleConfig ScheduleConfig { get; set; }
            public class ListMediaInfoJobsResponseBodyJobsScheduleConfig : TeaModel {
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubmitResultJson")]
            [Validation(Required=false)]
            public Dictionary<string, object> SubmitResultJson { get; set; }

            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
