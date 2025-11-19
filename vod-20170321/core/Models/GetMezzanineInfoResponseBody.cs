// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMezzanineInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the source file.</para>
        /// </summary>
        [NameInMap("Mezzanine")]
        [Validation(Required=false)]
        public GetMezzanineInfoResponseBodyMezzanine Mezzanine { get; set; }
        public class GetMezzanineInfoResponseBodyMezzanine : TeaModel {
            /// <summary>
            /// <para>The codec time base.</para>
            /// </summary>
            [NameInMap("AudioStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineAudioStreamList> AudioStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineAudioStreamList : TeaModel {
                /// <summary>
                /// <para>The bitrate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62.885</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The output layout of the sound channels. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mono</b></description></item>
                /// <item><description><b>stereo</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mono</para>
                /// </summary>
                [NameInMap("ChannelLayout")]
                [Validation(Required=false)]
                public string ChannelLayout { get; set; }

                /// <summary>
                /// <para>The number of sound channels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// <para>The full name of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AAC (Advanced Audio Coding)</para>
                /// </summary>
                [NameInMap("CodecLongName")]
                [Validation(Required=false)]
                public string CodecLongName { get; set; }

                /// <summary>
                /// <para>The short name of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aac</para>
                /// </summary>
                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                /// <summary>
                /// <para>The tag of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0x6134706d</para>
                /// </summary>
                [NameInMap("CodecTag")]
                [Validation(Required=false)]
                public string CodecTag { get; set; }

                /// <summary>
                /// <para>The tag string of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp4a</para>
                /// </summary>
                [NameInMap("CodecTagString")]
                [Validation(Required=false)]
                public string CodecTagString { get; set; }

                /// <summary>
                /// <para>The codec time base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1/44100</para>
                /// </summary>
                [NameInMap("CodecTimeBase")]
                [Validation(Required=false)]
                public string CodecTimeBase { get; set; }

                /// <summary>
                /// <para>The duration of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.227574</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The sequence number of the audio stream. The value indicates the position of the audio stream in all audio streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>und</para>
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// <para>The total number of frames.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NumFrames")]
                [Validation(Required=false)]
                public string NumFrames { get; set; }

                /// <summary>
                /// <para>The sampling format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fltp</para>
                /// </summary>
                [NameInMap("SampleFmt")]
                [Validation(Required=false)]
                public string SampleFmt { get; set; }

                /// <summary>
                /// <para>The sampling rate of the audio stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44100</para>
                /// </summary>
                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public string SampleRate { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-01-11T12:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The time base of the audio stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.000000</para>
                /// </summary>
                [NameInMap("Timebase")]
                [Validation(Required=false)]
                public string Timebase { get; set; }

            }

            /// <summary>
            /// <para>The bitrate of the file. Unit: Kbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>771.2280</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The time when the file was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-14T09:15:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The duration of the file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42.4930</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("FileMD5")]
            [Validation(Required=false)]
            public string FileMD5 { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27ffc438-164h67f57ef-0005-6884-51a-1****.mp4</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The URL of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/27ffc438-164h67f57ef-0005-6884-51a-1****.mp4">http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/27ffc438-164h67f57ef-0005-6884-51a-1****.mp4</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The frame rate of the file. Unit: frames per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25.0000</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <para>The height of the file. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>540</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <para>The type of the mezzanine file URL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>oss</b>: OSS URL</description></item>
            /// <item><description><b>cdn</b> (default): CDN URL</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify an OSS URL for the video stream, the video stream must be in the MP4 format.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("OutputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }

            /// <summary>
            /// <para>The preprocess status od the media.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UnPreprocess</para>
            /// </summary>
            [NameInMap("PreprocessStatus")]
            [Validation(Required=false)]
            public string PreprocessStatus { get; set; }

            /// <summary>
            /// <para>The period of time in which the object remains in the restored state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-30T10:14:14Z</para>
            /// </summary>
            [NameInMap("RestoreExpiration")]
            [Validation(Required=false)]
            public string RestoreExpiration { get; set; }

            /// <summary>
            /// <para>The restoration status of the audio or video file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Processing</b></description></item>
            /// <item><description><b>Success</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("RestoreStatus")]
            [Validation(Required=false)]
            public string RestoreStatus { get; set; }

            /// <summary>
            /// <para>The size of the file. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096477</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The status of the file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uploading</b>: The file is being uploaded. This is the initial status.</description></item>
            /// <item><description><b>Normal</b>: The file is uploaded.</description></item>
            /// <item><description><b>UploadFail</b>: The file fails to be uploaded.</description></item>
            /// <item><description><b>Deleted</b>: The file is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage class of the audio file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Standard</b>: All media resources are stored as Standard objects.</description></item>
            /// <item><description><b>IA</b>: All media resources are stored as IA objects.</description></item>
            /// <item><description><b>Archive</b>: All media resources are stored as Archive objects.</description></item>
            /// <item><description><b>ColdArchive</b>: All media resources are stored as Cold Archive objects.</description></item>
            /// <item><description><b>SourceIA</b>: Only the source files are IA objects.</description></item>
            /// <item><description><b>SourceArchive</b>: Only the source files are Archive objects.</description></item>
            /// <item><description><b>SourceColdArchive</b>: Only the source files are Cold Archive objects.</description></item>
            /// <item><description><b>Changing</b>: The storage class of the audio file is being changed.</description></item>
            /// <item><description><b>SourceChanging</b>: The storage class of the source file is being changed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <para>The ID of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1f1a6fc03ca04814031b8a6559e****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            /// <summary>
            /// <para>The HDR type of the video stream.</para>
            /// </summary>
            [NameInMap("VideoStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineVideoStreamList> VideoStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineVideoStreamList : TeaModel {
                /// <summary>
                /// <para>The average frame rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30.0</para>
                /// </summary>
                [NameInMap("AvgFPS")]
                [Validation(Required=false)]
                public string AvgFPS { get; set; }

                /// <summary>
                /// <para>The bitrate. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The full name of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                /// </summary>
                [NameInMap("CodecLongName")]
                [Validation(Required=false)]
                public string CodecLongName { get; set; }

                /// <summary>
                /// <para>The short name of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>h264</para>
                /// </summary>
                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                /// <summary>
                /// <para>The tag of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0x31637661</para>
                /// </summary>
                [NameInMap("CodecTag")]
                [Validation(Required=false)]
                public string CodecTag { get; set; }

                /// <summary>
                /// <para>The tag string of the encoding format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>avc1</para>
                /// </summary>
                [NameInMap("CodecTagString")]
                [Validation(Required=false)]
                public string CodecTagString { get; set; }

                /// <summary>
                /// <para>The codec time base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1/60</para>
                /// </summary>
                [NameInMap("CodecTimeBase")]
                [Validation(Required=false)]
                public string CodecTimeBase { get; set; }

                /// <summary>
                /// <para>The display aspect ratio (DAR) of the video stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0:1</para>
                /// </summary>
                [NameInMap("Dar")]
                [Validation(Required=false)]
                public string Dar { get; set; }

                /// <summary>
                /// <para>The duration of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.166667</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The frame rate of the output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30.0</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The HDR type of the video stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HDR</para>
                /// </summary>
                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                /// <summary>
                /// <para>Indicates whether the video stream contains B-frames.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HasBFrames")]
                [Validation(Required=false)]
                public string HasBFrames { get; set; }

                /// <summary>
                /// <para>The height of the video stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>320</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The sequence number of the video stream. The value indicates the position of the video stream in all video streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>und</para>
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// <para>The codec level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The total number of frames.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>Main</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The rotation angle of the video. Valid values: <b>[0,360)</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                /// <summary>
                /// <para>The sample aspect ratio (SAR) of the video stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0:1</para>
                /// </summary>
                [NameInMap("Sar")]
                [Validation(Required=false)]
                public string Sar { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which the data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-01-11T12:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The time base of the audio stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.000000</para>
                /// </summary>
                [NameInMap("Timebase")]
                [Validation(Required=false)]
                public string Timebase { get; set; }

                /// <summary>
                /// <para>The width of the video in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>568</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <para>The width of the file. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
