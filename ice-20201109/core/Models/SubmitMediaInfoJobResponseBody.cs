// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaInfoJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The media information job.</para>
        /// </summary>
        [NameInMap("MediaInfoJob")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobResponseBodyMediaInfoJob MediaInfoJob { get; set; }
        public class SubmitMediaInfoJobResponseBodyMediaInfoJob : TeaModel {
            /// <summary>
            /// <para>Indicates whether to process the job asynchronously.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <para>The time when the job was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The job input.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobInput Input { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobInput : TeaModel {
                /// <summary>
                /// <para>The value of the media object. This value depends on the <c>Type</c> parameter.</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>Type</c> is <c>OSS</c>, this parameter is the URL of the media file. Both the <c>oss://</c> and HTTPS protocols are supported.</para>
                /// </description></item>
                /// <item><description><para>If <c>Type</c> is <c>Media</c>, this parameter is the media ID.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of input media. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>OSS</c>: An Object Storage Service (OSS) file.</para>
                /// </description></item>
                /// <item><description><para><c>Media</c>: A media ID.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Details of the media information.</para>
            /// </summary>
            [NameInMap("MediaInfoProperty")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoProperty MediaInfoProperty { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoProperty : TeaModel {
                /// <summary>
                /// <para>A list of audio stream details.</para>
                /// </summary>
                [NameInMap("AudioStreamInfoList")]
                [Validation(Required=false)]
                public List<SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyAudioStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The bitrate of the stream.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.f</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The channel layout.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>stereo</para>
                    /// </summary>
                    [NameInMap("ChannelLayout")]
                    [Validation(Required=false)]
                    public string ChannelLayout { get; set; }

                    /// <summary>
                    /// <para>The number of audio channels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    /// <summary>
                    /// <para>The full name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AAC (Advanced Audio Coding)</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <para>The stream\&quot;s codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aac</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <para>The codec tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x000f</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The codec tag string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[15][0][0][0]</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <para>The time base of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/44100</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The duration of the stream, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>403.039989</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The stream index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <para>The stream\&quot;s language.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>us</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <para>The sample format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fltp</para>
                    /// </summary>
                    [NameInMap("SampleFmt")]
                    [Validation(Required=false)]
                    public string SampleFmt { get; set; }

                    /// <summary>
                    /// <para>The sample rate, in Hz.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public string SampleRate { get; set; }

                    /// <summary>
                    /// <para>The start time of the stream, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.473556</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The stream\&quot;s time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/90000</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                /// <summary>
                /// <para>Basic information about the file.</para>
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyFileBasicInfo FileBasicInfo { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <para>The video bitrate, in Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>888.563</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The duration of the video, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>403.039999</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>file.m3u8</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The file size, in bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>31737</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <para>The file status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// <para>The file type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source_file</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <para>The URL of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8">http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8</a></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>The name of the video format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hls,applehttp</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <para>The height of the video, in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>478</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The media ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2b36bd19c13f4145b094c0cad80dbce5</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The region where the file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The width of the video, in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>848</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>A list of video stream details.</para>
                /// </summary>
                [NameInMap("VideoStreamInfoList")]
                [Validation(Required=false)]
                public List<SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobMediaInfoPropertyVideoStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The average frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25.0</para>
                    /// </summary>
                    [NameInMap("Avg_fps")]
                    [Validation(Required=false)]
                    public string AvgFps { get; set; }

                    /// <summary>
                    /// <para>The bitrate of the stream, in Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>888.563</para>
                    /// </summary>
                    [NameInMap("Bit_rate")]
                    [Validation(Required=false)]
                    public string BitRate { get; set; }

                    /// <summary>
                    /// <para>The full name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                    /// </summary>
                    [NameInMap("Codec_long_name")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <para>The stream\&quot;s codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>h264</para>
                    /// </summary>
                    [NameInMap("Codec_name")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <para>The codec tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x001b</para>
                    /// </summary>
                    [NameInMap("Codec_tag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The codec tag string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[27][0][0][0]</para>
                    /// </summary>
                    [NameInMap("Codec_tag_string")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <para>The time base of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/50</para>
                    /// </summary>
                    [NameInMap("Codec_time_base")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The display aspect ratio (DAR).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16:9</para>
                    /// </summary>
                    [NameInMap("Dar")]
                    [Validation(Required=false)]
                    public string Dar { get; set; }

                    /// <summary>
                    /// <para>The duration of the stream, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>403.039989</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25.0</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the stream contains B-frames. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>0</c>: The stream does not contain B-frames.</para>
                    /// </description></item>
                    /// <item><description><para><c>1</c>: The stream contains one B-frame.</para>
                    /// </description></item>
                    /// <item><description><para><c>2</c>: The stream contains two or more consecutive B-frames.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Has_b_frames")]
                    [Validation(Required=false)]
                    public string HasBFrames { get; set; }

                    /// <summary>
                    /// <para>The height of the video, in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>478</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The stream index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <para>The stream\&quot;s language.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <para>The codec level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>31</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The total number of frames.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10040</para>
                    /// </summary>
                    [NameInMap("NumFrames")]
                    [Validation(Required=false)]
                    public string NumFrames { get; set; }

                    /// <summary>
                    /// <para>The pixel format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yuv420p</para>
                    /// </summary>
                    [NameInMap("PixFmt")]
                    [Validation(Required=false)]
                    public string PixFmt { get; set; }

                    /// <summary>
                    /// <para>The codec profile.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>High</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <para>The rotation angle of the video, in degrees.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    /// <summary>
                    /// <para>The sample aspect ratio (SAR).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>478:477</para>
                    /// </summary>
                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    /// <summary>
                    /// <para>The start time of the stream, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.473556</para>
                    /// </summary>
                    [NameInMap("Start_time")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The stream\&quot;s time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/90000</para>
                    /// </summary>
                    [NameInMap("Time_base")]
                    [Validation(Required=false)]
                    public string TimeBase { get; set; }

                    /// <summary>
                    /// <para>The width of the video, in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>848</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4879B9DE-E4B6-19DC-91F5-9D5F4DCE4168</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The scheduling configuration.</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobScheduleConfig ScheduleConfig { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The pipeline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The job priority. Higher values indicate higher priority. Valid values range from 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Init</c>: Submitted.</para>
            /// </description></item>
            /// <item><description><para><c>Success</c>: Successful.</para>
            /// </description></item>
            /// <item><description><para><c>Fail</c>: Failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Init</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job submission details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("SubmitResultJson")]
            [Validation(Required=false)]
            public Dictionary<string, object> SubmitResultJson { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The source of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>API</c>: The job was submitted by calling an API operation.</para>
            /// </description></item>
            /// <item><description><para><c>WorkFlow</c>: The job was triggered by a workflow.</para>
            /// </description></item>
            /// <item><description><para><c>Console</c>: The job was submitted in the console.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <para>The user data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-data</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
