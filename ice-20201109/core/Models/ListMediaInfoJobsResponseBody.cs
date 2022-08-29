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
            };

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
            };

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
