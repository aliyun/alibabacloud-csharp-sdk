// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputDetailFileMeta : TeaModel {
        /// <summary>
        /// <para>The audio stream information.</para>
        /// </summary>
        [NameInMap("AudioStreamInfoList")]
        [Validation(Required=false)]
        public List<MediaConvertOutputDetailFileMetaAudioStreamInfoList> AudioStreamInfoList { get; set; }
        public class MediaConvertOutputDetailFileMetaAudioStreamInfoList : TeaModel {
            /// <summary>
            /// <para>The bitrate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.f</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The layout of the audio channels.</para>
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
            /// <para>The short name of the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aac</para>
            /// </summary>
            [NameInMap("CodecName")]
            [Validation(Required=false)]
            public string CodecName { get; set; }

            /// <summary>
            /// <para>The tag of the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x000f</para>
            /// </summary>
            [NameInMap("CodecTag")]
            [Validation(Required=false)]
            public string CodecTag { get; set; }

            /// <summary>
            /// <para>The tag of the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[15][0][0][0]</para>
            /// </summary>
            [NameInMap("CodecTagString")]
            [Validation(Required=false)]
            public string CodecTagString { get; set; }

            /// <summary>
            /// <para>The time base used by the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/44100</para>
            /// </summary>
            [NameInMap("CodecTimeBase")]
            [Validation(Required=false)]
            public string CodecTimeBase { get; set; }

            /// <summary>
            /// <para>The duration of the stream. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403.039989</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The index of this stream within the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// <para>The language code for the stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The audio sample format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fltp</para>
            /// </summary>
            [NameInMap("SampleFmt")]
            [Validation(Required=false)]
            public string SampleFmt { get; set; }

            /// <summary>
            /// <para>The sample rate. Unit: Hz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44100</para>
            /// </summary>
            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public string SampleRate { get; set; }

            /// <summary>
            /// <para>The start time of the stream. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.473556</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The time base of the stream\&quot;s presentation timestamps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/90000</para>
            /// </summary>
            [NameInMap("Timebase")]
            [Validation(Required=false)]
            public string Timebase { get; set; }

        }

        /// <summary>
        /// <para>The basic information of the media file.</para>
        /// </summary>
        [NameInMap("FileBasicInfo")]
        [Validation(Required=false)]
        public MediaConvertOutputDetailFileMetaFileBasicInfo FileBasicInfo { get; set; }
        public class MediaConvertOutputDetailFileMetaFileBasicInfo : TeaModel {
            /// <summary>
            /// <para>The video bitrate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>888.563</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The total duration of the media file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403.039999</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file.m3u8</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31737</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <para>The status of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("FileStatus")]
            [Validation(Required=false)]
            public string FileStatus { get; set; }

            /// <summary>
            /// <para>Indicates if this is the source or a transcoded output. Valid values: source_file and transcode_file.</para>
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
            /// <para>The container format name.</para>
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
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9066406c306771f0bfa35107e0c90102</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The storage region of the file.</para>
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
        /// <para>The video stream information.</para>
        /// </summary>
        [NameInMap("VideoStreamInfoList")]
        [Validation(Required=false)]
        public List<MediaConvertOutputDetailFileMetaVideoStreamInfoList> VideoStreamInfoList { get; set; }
        public class MediaConvertOutputDetailFileMetaVideoStreamInfoList : TeaModel {
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
            /// <para>The bitrate.</para>
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
            /// <para>The short name of the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h264</para>
            /// </summary>
            [NameInMap("Codec_name")]
            [Validation(Required=false)]
            public string CodecName { get; set; }

            /// <summary>
            /// <para>The tag of the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x001b</para>
            /// </summary>
            [NameInMap("Codec_tag")]
            [Validation(Required=false)]
            public string CodecTag { get; set; }

            /// <summary>
            /// <para>The tag of the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[27][0][0][0]</para>
            /// </summary>
            [NameInMap("Codec_tag_string")]
            [Validation(Required=false)]
            public string CodecTagString { get; set; }

            /// <summary>
            /// <para>The time base used by the codec.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/50</para>
            /// </summary>
            [NameInMap("Codec_time_base")]
            [Validation(Required=false)]
            public string CodecTimeBase { get; set; }

            /// <summary>
            /// <para>The display aspect ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16:9</para>
            /// </summary>
            [NameInMap("Dar")]
            [Validation(Required=false)]
            public string Dar { get; set; }

            /// <summary>
            /// <para>The duration of the stream. Unit: seconds.</para>
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
            /// <para>Indicates whether the video stream contains B-frames. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>0: None.</description></item>
            /// <item><description>1: One B-frame.</description></item>
            /// <item><description>2: Multiple consecutive B-frames.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Has_b_frames")]
            [Validation(Required=false)]
            public string HasBFrames { get; set; }

            /// <summary>
            /// <para>The height of the video stream, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>478</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// <para>The index of this stream within the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// <para>The language code for the stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
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
            /// <para>The rotation angle applied to the video. Valid values: 0, 90, 180, and 270. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Rotate")]
            [Validation(Required=false)]
            public string Rotate { get; set; }

            /// <summary>
            /// <para>The sample aspect ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>478:477</para>
            /// </summary>
            [NameInMap("Sar")]
            [Validation(Required=false)]
            public string Sar { get; set; }

            /// <summary>
            /// <para>The start time of the stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.473556</para>
            /// </summary>
            [NameInMap("Start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The time base of the stream\&quot;s presentation timestamps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/90000</para>
            /// </summary>
            [NameInMap("Time_base")]
            [Validation(Required=false)]
            public string TimeBase { get; set; }

            /// <summary>
            /// <para>The width of the video stream, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>848</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

    }

}
