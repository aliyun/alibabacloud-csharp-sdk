// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class BatchGetMediaInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the media assets that do not support the operation typically because you are not authorized to perform the operation. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenMediaIds { get; set; }

        /// <summary>
        /// <para>Details about media assets.</para>
        /// </summary>
        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<BatchGetMediaInfosResponseBodyMediaInfos> MediaInfos { get; set; }
        public class BatchGetMediaInfosResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10a5fa364a5b71ef89246733a78e****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The basic information of the media asset.</para>
            /// </summary>
            [NameInMap("MediaInfo")]
            [Validation(Required=false)]
            public BatchGetMediaInfosResponseBodyMediaInfosMediaInfo MediaInfo { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosMediaInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The ID of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>781111****</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CateName</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The thumbnail URL of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com/****.jpg">https://example.aliyundoc.com/****.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the media asset was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-11-14T09:15:50Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aliyun VOD Video Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the offline download feature is enabled. If you enable the offline download feature, users can download and play videos by using the ApsaraVideo Player on a local PC. For more information, see <a href="https://help.aliyun.com/document_detail/86107.html">Configure download settings</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// <para>The ID of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7753d144efd74d6c45fe0570****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The time when the media asset was last updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-06-26T06:38:48Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The period of time in which the audio file remains in the restored state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T10:14:14Z</para>
                /// </summary>
                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                /// <summary>
                /// <para>The restoration status of the media asset. Valid values:</para>
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
                /// <para>The array of video snapshot URLs.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// <para>The status of the video. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b></description></item>
                /// <item><description><b>UploadFail</b></description></item>
                /// <item><description><b>UploadSucc</b></description></item>
                /// <item><description><b>Transcoding</b></description></item>
                /// <item><description><b>TranscodeFail</b></description></item>
                /// <item><description><b>Blocked</b></description></item>
                /// <item><description><b>Normal</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: All media assets are stored as Standard objects.</description></item>
                /// <item><description><b>IA</b>: All media assets are stored as IA objects.</description></item>
                /// <item><description><b>Archive</b>: All media assets are stored as Archive objects.</description></item>
                /// <item><description><b>ColdArchive</b>: All media assets are stored as Cold Archive objects.</description></item>
                /// <item><description><b>SourceIA</b>: Only the source files are IA objects.</description></item>
                /// <item><description><b>SourceArchive</b>: Only the source files are Archive objects.</description></item>
                /// <item><description><b>SourceColdArchive</b>: Only the source file is stored as a Cold Archive object.</description></item>
                /// <item><description><b>Changing</b>: The storage class of the media asset is being changed.</description></item>
                /// <item><description><b>SourceChanging</b>: The storage class of the media asset is being changed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The storage address of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-***.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags of the media asset. Separate tags with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1,tag2</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b4039216985f4312a5382a4ed****</para>
                /// </summary>
                [NameInMap("TemplateGroupId")]
                [Validation(Required=false)]
                public string TemplateGroupId { get; set; }

                /// <summary>
                /// <para>The title of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aliyun VOD Video Title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The custom parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Extend&quot;:&quot;xxx&quot;,&quot;MessageCallback&quot;:&quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The source file information.</para>
            /// </summary>
            [NameInMap("MezzanineInfo")]
            [Validation(Required=false)]
            public BatchGetMediaInfosResponseBodyMediaInfosMezzanineInfo MezzanineInfo { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosMezzanineInfo : TeaModel {
                /// <summary>
                /// <para>The information about the audio stream.</para>
                /// </summary>
                [NameInMap("AudioStreamList")]
                [Validation(Required=false)]
                public List<BatchGetMediaInfosResponseBodyMediaInfosMezzanineInfoAudioStreamList> AudioStreamList { get; set; }
                public class BatchGetMediaInfosResponseBodyMediaInfosMezzanineInfoAudioStreamList : TeaModel {
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
                    /// <para>The output layout of the audio channels. Valid values:</para>
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
                    /// <para>The number of sound tracks.</para>
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
                    /// <para>The time base of the encoder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/44100</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The duration.</para>
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
                    /// <para>The sampling rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public string SampleRate { get; set; }

                    /// <summary>
                    /// <para>The start time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-01-11T12:00:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time base.</para>
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
                /// <para>The time when the source file was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
                /// <para>The OSS URL of the source file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/27ffc438-164h67f57ef-0005-6884-51a-1****.mp4">http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/27ffc438-164h67f57ef-0005-6884-51a-1****.mp4</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The frame rate of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25.0000</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The height of the file. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>540</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <para>The ID of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1f1a6fc03ca04814031b8a6559e****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The size of the file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096477</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The state of the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b>: The file is being uploaded. This is the initial status.</description></item>
                /// <item><description><b>Normal</b>: The file is uploaded.</description></item>
                /// <item><description><b>UploadFail</b>: The file failed to be uploaded.</description></item>
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
                /// <para>The information about the video streams.</para>
                /// </summary>
                [NameInMap("VideoStreamList")]
                [Validation(Required=false)]
                public List<BatchGetMediaInfosResponseBodyMediaInfosMezzanineInfoVideoStreamList> VideoStreamList { get; set; }
                public class BatchGetMediaInfosResponseBodyMediaInfosMezzanineInfoVideoStreamList : TeaModel {
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
                    /// <para>The bitrate of the file. Unit: Kbit/s.</para>
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
                    /// <para>The time base of the encoder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/60</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The display aspect ratio (DAR).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Dar")]
                    [Validation(Required=false)]
                    public string Dar { get; set; }

                    /// <summary>
                    /// <para>The duration.</para>
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
                    /// <para>Indicates whether the video stream contains bidirectional frames (B-frames).</para>
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
                    /// <para>The sequence number of the video stream. The value identifies the position of the video stream in all video streams.</para>
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
                    /// <para>The pixel format of the video stream.</para>
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
                    /// <para>The rotation angle of the video. Valid values: [0,360).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    /// <summary>
                    /// <para>The sample aspect ratio (SAR).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    /// <summary>
                    /// <para>The start time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-01-11T12:00:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.000000</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                    /// <summary>
                    /// <para>The horizontal resolution of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>568</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>The width of the file. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>960</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

            /// <summary>
            /// <para>The information about the audio or video stream.</para>
            /// </summary>
            [NameInMap("PlayInfoList")]
            [Validation(Required=false)]
            public List<BatchGetMediaInfosResponseBodyMediaInfosPlayInfoList> PlayInfoList { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosPlayInfoList : TeaModel {
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
                /// <para>The short name of the codec.</para>
                /// 
                /// <b>Example:</b>
                /// <para>h264</para>
                /// </summary>
                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                /// <summary>
                /// <para>The creation time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
                /// <para>Indicates whether the media stream was encrypted. Valid values:</para>
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
                /// <item><description><b>License</b>: decryption on local devices.</description></item>
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
                /// <item><description><b>HLSEncryption</b>: HTTP Live Streaming (HLS) encryption</description></item>
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
                /// <para>The frame rate of the media stream. Unit: frames per second (FPS).</para>
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
                /// <para>The update time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
                /// <para>The ID of the transcoding template group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb0716154b21a4ecb5b70a26ccc8****</para>
                /// </summary>
                [NameInMap("TemplateGroupId")]
                [Validation(Required=false)]
                public string TemplateGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a86a4338dd2e83da45154004a541****</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

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
        /// <para>The IDs of the media assets that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E290613-04F4-47F4-795D30732077****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
