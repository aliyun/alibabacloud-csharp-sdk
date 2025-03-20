// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the audio or video stream.</para>
        /// </summary>
        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyPlayInfoList PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            [NameInMap("PlayInfo")]
            [Validation(Required=false)]
            public List<GetPlayInfoResponseBodyPlayInfoListPlayInfo> PlayInfo { get; set; }
            public class GetPlayInfoResponseBodyPlayInfoListPlayInfo : TeaModel {
                /// <summary>
                /// <para>The color depth. This value is an integer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("BitDepth")]
                [Validation(Required=false)]
                public int? BitDepth { get; set; }

                /// <summary>
                /// <para>The bitrate of the media stream. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>450.878</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The encoding type. The possible values are:</para>
                /// <list type="bullet">
                /// <item><description><para>H264</para>
                /// </description></item>
                /// <item><description><para>H265</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>H264</para>
                /// </summary>
                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                /// <summary>
                /// <para>The time when the audio or video stream was created. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-18T07:37:15Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The quality of the video stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FD</b>: low definition</description></item>
                /// <item><description><b>LD</b>: standard definition</description></item>
                /// <item><description><b>SD</b>: high definition</description></item>
                /// <item><description><b>HD</b>: ultra-high definition</description></item>
                /// <item><description><b>OD</b>: original definition</description></item>
                /// <item><description><b>2K</b></description></item>
                /// <item><description><b>4K</b></description></item>
                /// <item><description><b>SQ</b>: standard sound quality</description></item>
                /// <item><description><b>HQ</b>: high sound quality</description></item>
                /// <item><description><b>AUTO</b>: adaptive bitrate</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LD</para>
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                /// <summary>
                /// <para>The duration of the media stream. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9.0464</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>Indicates whether the media stream is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The media stream is not encrypted.</description></item>
                /// <item><description><b>1</b>: The media stream is encrypted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public long? Encrypt { get; set; }

                /// <summary>
                /// <para>The encryption type of the media stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>License</b>: decryption on local devices</description></item>
                /// </list>
                /// <remarks>
                /// <para> If the encryption type is <b>License</b>, only ApsaraVideo Player SDK can be used to play videos.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>License</para>
                /// </summary>
                [NameInMap("EncryptMode")]
                [Validation(Required=false)]
                public string EncryptMode { get; set; }

                /// <summary>
                /// <para>The encryption type of the media stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AliyunVoDEncryption</b>: Alibaba Cloud proprietary cryptography</description></item>
                /// <item><description><b>HLSEncryption</b>: HTTP-Live-Streaming (HLS) encryption</description></item>
                /// </list>
                /// <remarks>
                /// <para> If the encryption type is AliyunVoDEncryption, only ApsaraVideo Player SDK can be used to play videos.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunVoDEncryption</para>
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                /// <summary>
                /// <para>The format of the media stream.</para>
                /// <list type="bullet">
                /// <item><description>If the media file is a video file, the valid values are <b>mp4</b> and <b>m3u8</b>.</description></item>
                /// <item><description>If the media asset is an audio-only file, the value is <b>mp3</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>m3u8</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The frame rate of the media stream. Unit: frames per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The HDR type of the media stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HDR</description></item>
                /// <item><description>HDR10</description></item>
                /// <item><description>HLG</description></item>
                /// <item><description>DolbyVision</description></item>
                /// <item><description>HDRVivid</description></item>
                /// <item><description>SDR+</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HLG</para>
                /// </summary>
                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                /// <summary>
                /// <para>The height of the media stream. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>640</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <para>The custom watermark information of the copyright watermark. This parameter is returned if you set <c>JobType</c> to <c>2</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CopyrightMarkTest</para>
                /// </summary>
                [NameInMap("JobExt")]
                [Validation(Required=false)]
                public string JobExt { get; set; }

                /// <summary>
                /// <para>The job ID for transcoding the media stream. This ID uniquely identifies a media stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80e9c6580e754a798c3c19c59b16****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The type of the digital watermark. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: user-tracing watermark</description></item>
                /// <item><description><b>2</b>: copyright watermark</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public int? JobType { get; set; }

                /// <summary>
                /// <para>The time when the audio or video file was last updated. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-20T06:32:19Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The transcoding type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: regular transcoding</description></item>
                /// <item><description><b>1.0</b>: Narrowband HD™ 1.0 transcoding</description></item>
                /// <item><description><b>2.0</b>: Narrowband HD™ 2.0 transcoding</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NarrowBandType")]
                [Validation(Required=false)]
                public string NarrowBandType { get; set; }

                /// <summary>
                /// <para>The playback URL of the video stream.</para>
                /// </summary>
                [NameInMap("PlayURL")]
                [Validation(Required=false)]
                public string PlayURL { get; set; }

                /// <summary>
                /// <para>The size of the media stream. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>418112</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The specifications of transcoded audio and video streams. For more information about the valid values, see <a href="~~124671#section-6bv-l0g-opq~~">Output specifications</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H264.LD</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The status of the audio or video stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The latest transcoded stream in each quality and format is in the Normal status.</description></item>
                /// <item><description><b>Invisible</b>: If multiple streams are transcoded in the same quality and format, the latest transcoded stream is in the Normal status and other streams are in the Invisible status.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the media stream. If the media stream is a video stream, the value is <b>video</b>. If the media stream is an audio-only stream, the value is <b>audio</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// <para>The ID of the watermark that is associated with the media stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dgfn26457856****</para>
                /// </summary>
                [NameInMap("WatermarkId")]
                [Validation(Required=false)]
                public string WatermarkId { get; set; }

                /// <summary>
                /// <para>The width of the media stream. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F552E596-967D-5500-842F-17E6364****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The basic information about the audio or video file.</para>
        /// </summary>
        [NameInMap("VideoBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyVideoBase VideoBase { get; set; }
        public class GetPlayInfoResponseBodyVideoBase : TeaModel {
            /// <summary>
            /// <para>The thumbnail URL of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/sample.jpg?auth_key=2333232-atb">http://example.aliyundoc.com/sample.jpg?auth_key=2333232-atb</a>****</para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The time when the audio or video file was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-06-26T06:38:48Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The URL of the masked live comment data.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/****?auth_key=abdf2123-6783232">http://example.aliyundoc.com/****?auth_key=abdf2123-6783232</a>****</para>
            /// </summary>
            [NameInMap("DanMuURL")]
            [Validation(Required=false)]
            public string DanMuURL { get; set; }

            /// <summary>
            /// <para>The duration of the audio or video file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.1667</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The type of the media file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b></description></item>
            /// <item><description><b>audio</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <para>The status of the media file. For more information about the value range and description, see the <a href="~~52839#title-vqg-8cz-7p8~~">Status</a> table.</para>
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
            /// <item><description><b>SourceColdArchive</b>: Only the source file is stored as a Cold Archive object.</description></item>
            /// <item><description><b>Changing</b>: The storage class of the video file is being changed.</description></item>
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
            /// <para>The title of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ApsaraVideo VOD</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The ID of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93ab850b4f654b6e91d24d81d44****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
