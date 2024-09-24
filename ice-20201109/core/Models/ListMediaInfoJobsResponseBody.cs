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
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public ListMediaInfoJobsResponseBodyJobsInput Input { get; set; }
            public class ListMediaInfoJobsResponseBodyJobsInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.f</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>stereo</para>
                    /// </summary>
                    [NameInMap("ChannelLayout")]
                    [Validation(Required=false)]
                    public string ChannelLayout { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AAC (Advanced Audio Coding)</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>aac</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0x000f</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[15][0][0][0]</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/44100</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>403.039989</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>fltp</para>
                    /// </summary>
                    [NameInMap("SampleFmt")]
                    [Validation(Required=false)]
                    public string SampleFmt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public string SampleRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.473556</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/90000</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyFileBasicInfo FileBasicInfo { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>888.563</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>403.039999</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>file.m3u8</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>31737</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_file</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8">http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8</a></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hls,applehttp</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>478</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4765337007f571edbfdf81848c016303</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>848</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                [NameInMap("VideoStreamInfoList")]
                [Validation(Required=false)]
                public List<ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class ListMediaInfoJobsResponseBodyJobsMediaInfoPropertyVideoStreamInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>25.0</para>
                    /// </summary>
                    [NameInMap("Avg_fps")]
                    [Validation(Required=false)]
                    public string AvgFps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>888.563</para>
                    /// </summary>
                    [NameInMap("Bit_rate")]
                    [Validation(Required=false)]
                    public string BitRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                    /// </summary>
                    [NameInMap("Codec_long_name")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>h264</para>
                    /// </summary>
                    [NameInMap("Codec_name")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0x001b</para>
                    /// </summary>
                    [NameInMap("Codec_tag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[27][0][0][0]</para>
                    /// </summary>
                    [NameInMap("Codec_tag_string")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/50</para>
                    /// </summary>
                    [NameInMap("Codec_time_base")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>16:9</para>
                    /// </summary>
                    [NameInMap("Dar")]
                    [Validation(Required=false)]
                    public string Dar { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>403.039989</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>25.0</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Has_b_frames")]
                    [Validation(Required=false)]
                    public string HasBFrames { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>478</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>31</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10040</para>
                    /// </summary>
                    [NameInMap("NumFrames")]
                    [Validation(Required=false)]
                    public string NumFrames { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yuv420p</para>
                    /// </summary>
                    [NameInMap("PixFmt")]
                    [Validation(Required=false)]
                    public string PixFmt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>High</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>478:477</para>
                    /// </summary>
                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.473556</para>
                    /// </summary>
                    [NameInMap("Start_time")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/90000</para>
                    /// </summary>
                    [NameInMap("Time_base")]
                    [Validation(Required=false)]
                    public string TimeBase { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>848</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4879B9DE-E4B6-19DC-91F5-9D5F4DCE4168</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public ListMediaInfoJobsResponseBodyJobsScheduleConfig ScheduleConfig { get; set; }
            public class ListMediaInfoJobsResponseBodyJobsScheduleConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Init</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubmitResultJson")]
            [Validation(Required=false)]
            public Dictionary<string, object> SubmitResultJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user-data</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>019daf5780f74831b0e1a767c9f1c178</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
