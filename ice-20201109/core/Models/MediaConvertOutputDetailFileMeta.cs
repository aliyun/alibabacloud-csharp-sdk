// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputDetailFileMeta : TeaModel {
        [NameInMap("AudioStreamInfoList")]
        [Validation(Required=false)]
        public List<MediaConvertOutputDetailFileMetaAudioStreamInfoList> AudioStreamInfoList { get; set; }
        public class MediaConvertOutputDetailFileMetaAudioStreamInfoList : TeaModel {
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
        public MediaConvertOutputDetailFileMetaFileBasicInfo FileBasicInfo { get; set; }
        public class MediaConvertOutputDetailFileMetaFileBasicInfo : TeaModel {
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
        public List<MediaConvertOutputDetailFileMetaVideoStreamInfoList> VideoStreamInfoList { get; set; }
        public class MediaConvertOutputDetailFileMetaVideoStreamInfoList : TeaModel {
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

}
