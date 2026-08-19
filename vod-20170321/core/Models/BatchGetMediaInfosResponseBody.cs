// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class BatchGetMediaInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of media asset IDs that are forbidden. This is typically because you do not have permissions for multi-application operations. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application</a>.</para>
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenMediaIds { get; set; }

        /// <summary>
        /// <para>The media asset list.</para>
        /// </summary>
        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<BatchGetMediaInfosResponseBodyMediaInfos> MediaInfos { get; set; }
        public class BatchGetMediaInfosResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// <para>The media asset ID.</para>
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
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>781111****</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate1</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The thumbnail URL of the audio/video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com/****.jpg">https://example.aliyundoc.com/****.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the audio/video file was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-11-14T09:15:50Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the audio/video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD video description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The status of the offline download switch. After the offline download feature is enabled, mobile users can cache videos to their local devices for viewing by using ApsaraVideo Player. For more information, see <a href="https://help.aliyun.com/document_detail/86107.html">Offline download</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: Offline download is enabled.</description></item>
                /// <item><description><b>off</b>: Offline download is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("DownloadSwitch")]
                [Validation(Required=false)]
                public string DownloadSwitch { get; set; }

                /// <summary>
                /// <para>The media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7753d144efd74d6c45fe0570****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The last time when the audio/video file was updated. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-06-26T06:38:48Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. The ID must be 6 to 64 characters in length and is unique at the user level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-123</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>The expiration time of the media asset restoration.</para>
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
                /// <item><description><b>Processing</b>: The media asset is being restored.</description></item>
                /// <item><description><b>Success</b>: The media asset is restored.</description></item>
                /// <item><description><b>Failed</b>: The media asset failed to be restored.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// <para>The video snapshot URL array.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<string> Snapshots { get; set; }

                /// <summary>
                /// <para>The video status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b>: The video is being uploaded.</description></item>
                /// <item><description><b>UploadFail</b>: The video failed to be uploaded.</description></item>
                /// <item><description><b>UploadSucc</b>: The video has been uploaded.</description></item>
                /// <item><description><b>Transcoding</b>: The video is being transcoded.</description></item>
                /// <item><description><b>TranscodeFail</b>: The video failed to be transcoded.</description></item>
                /// <item><description><b>Blocked</b>: The video is blocked.</description></item>
                /// <item><description><b>Normal</b>: The video is in a normal state.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the media asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: standard.</description></item>
                /// <item><description><b>IA</b>: Infrequent Access for media assets.</description></item>
                /// <item><description><b>Archive</b>: Archive for media assets.</description></item>
                /// <item><description><b>ColdArchive</b>: Cold Archive for media assets.</description></item>
                /// <item><description><b>SourceIA</b>: Infrequent Access for source files.</description></item>
                /// <item><description><b>SourceArchive</b>: Archive for source files.</description></item>
                /// <item><description><b>SourceColdArchive</b>: Cold Archive for source files.</description></item>
                /// <item><description><b>Changing</b>: The storage class of the media asset is being changed.</description></item>
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
                /// <para>The storage address of the audio/video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-***.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags of the audio/video file. Multiple tags are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1, tag2</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The transcoding template group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b4039216985f4312a5382a4ed****</para>
                /// </summary>
                [NameInMap("TemplateGroupId")]
                [Validation(Required=false)]
                public string TemplateGroupId { get; set; }

                /// <summary>
                /// <para>The title of the audio/video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud VOD Video Title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The custom parameter.</para>
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
                /// <para>The audio stream information.</para>
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
                    /// <para>The channel layout. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>mono</b>: mono.</description></item>
                    /// <item><description><b>stereo</b>: stereo.</description></item>
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
                    /// <para>The codec tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x6134706d</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The codec tag string.</para>
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
                    /// <para>The duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3.227574</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The sequence number of the audio stream, which identifies the position of the audio stream in the overall media stream.</para>
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
                    /// <para>The sample format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fltp</para>
                    /// </summary>
                    [NameInMap("SampleFmt")]
                    [Validation(Required=false)]
                    public string SampleFmt { get; set; }

                    /// <summary>
                    /// <para>The sample rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public string SampleRate { get; set; }

                    /// <summary>
                    /// <para>The start time. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
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
                /// <para>The bitrate of the file. Unit: Kbps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>771.2280</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The time when the file was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
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
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>27ffc438-164h67f57ef-0005-6884-51a-1****.mp4</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The URL of the source file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/27ffc438-164h67f57ef-0005-6884-51a-1****.mp4">http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/27ffc438-164h67f57ef-0005-6884-51a-1****.mp4</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The frame rate of the file, in frames per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25.0000</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The height of the file. Unit: px.</para>
                /// 
                /// <b>Example:</b>
                /// <para>540</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <para>The media asset ID.</para>
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
                /// <para>The file status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b>: The file is being uploaded. This is the initial status of the file.</description></item>
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
                /// <para>The video stream information.</para>
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
                    /// <para>The bitrate of the file. Unit: Kbps.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The full name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

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
                    /// <para>The codec tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x31637661</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The codec tag string.</para>
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
                    /// <para>The display aspect ratio.</para>
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
                    /// <para>The target frame rate.</para>
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
                    /// <para>The height of the video resolution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>320</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The sequence number of the video stream, which identifies the position of the video stream in the overall media stream.</para>
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
                    /// <para>The video rotation angle. Valid values: [0, 360).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    /// <summary>
                    /// <para>The sample aspect ratio.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    /// <summary>
                    /// <para>The start time. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
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
                    /// <para>The width of the video resolution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>568</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>The width of the file. Unit: px.</para>
                /// 
                /// <b>Example:</b>
                /// <para>960</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

            /// <summary>
            /// <para>The playback information (stream information) of the audio/video file.</para>
            /// </summary>
            [NameInMap("PlayInfoList")]
            [Validation(Required=false)]
            public List<BatchGetMediaInfosResponseBodyMediaInfosPlayInfoList> PlayInfoList { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosPlayInfoList : TeaModel {
                /// <summary>
                /// <para>The color bit depth. The value is an integer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("BitDepth")]
                [Validation(Required=false)]
                public int? BitDepth { get; set; }

                /// <summary>
                /// <para>The bitrate of the media stream. Unit: Kbps.</para>
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
                /// <para>The time when the stream was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-18T07:37:15Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The definition of the video stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FD</b>: low definition.</description></item>
                /// <item><description><b>LD</b>: standard definition.</description></item>
                /// <item><description><b>SD</b>: high definition.</description></item>
                /// <item><description><b>HD</b>: ultra high definition.</description></item>
                /// <item><description><b>OD</b>: original quality.</description></item>
                /// <item><description><b>2K</b>: 2K.</description></item>
                /// <item><description><b>4K</b>: 4K.</description></item>
                /// <item><description><b>SQ</b>: standard sound quality.</description></item>
                /// <item><description><b>HQ</b>: high sound quality.</description></item>
                /// <item><description><b>AUTO</b>: adaptive bitrate streaming.</description></item>
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
                /// <item><description><b>0</b>: The stream is not encrypted.</description></item>
                /// <item><description><b>1</b>: The stream is encrypted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public long? Encrypt { get; set; }

                /// <summary>
                /// <para>The encryption mode of the media stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>License</b>: local decryption mode.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If the encryption mode is <b>License</b>, only ApsaraVideo Player SDK can be used for playback.</para>
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
                /// <item><description><b>AliyunVoDEncryption</b>: Alibaba Cloud video encryption.</description></item>
                /// <item><description><b>HLSEncryption</b>: HLS encryption.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If the encryption type is <b>AliyunVoDEncryption</b>, only ApsaraVideo Player SDK can be used for playback.</para>
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
                /// <item><description>If the media file is a video, valid values are <b>mp4</b> and <b>m3u8</b>.</description></item>
                /// <item><description>If the media file is audio-only, the value is <b>mp3</b>.</description></item>
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
                /// <para>The height of the media stream. Unit: px.</para>
                /// 
                /// <b>Example:</b>
                /// <para>640</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <para>The custom watermark information of the copyright watermark. This field is returned only when <c>JobType</c> is <c>2</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CopyrightMarkTest</para>
                /// </summary>
                [NameInMap("JobExt")]
                [Validation(Required=false)]
                public string JobExt { get; set; }

                /// <summary>
                /// <para>The job ID of the media stream transcoding. This value serves as the unique identifier of the media stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80e9c6580e754a798c3c19c59b16****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The digital watermarking type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: tracing watermark.</description></item>
                /// <item><description><b>2</b>: copyright watermark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public int? JobType { get; set; }

                /// <summary>
                /// <para>The time when the stream was last updated. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
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
                /// <item><description><b>0</b>: standard transcoding.</description></item>
                /// <item><description><b>1.0</b>: Narrowband HD 1.0 transcoding.</description></item>
                /// <item><description><b>2.0</b>: Narrowband HD 2.0 transcoding.</description></item>
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
                /// <para>The output specification of the audio/video transcoding. For more information about valid values and descriptions, see <a href="~~124671#section-6bv-l0g-opq~~">Output specifications: Specification</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H264.LD</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The status of the media stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The stream is in a normal state. This value indicates the status of the latest transcoded stream for each definition and format.</description></item>
                /// <item><description><b>Invisible</b>: The stream is invisible. When multiple duplicate transcoded streams exist for each definition and format, only the latest stream is marked as Normal, and the other streams are marked as Invisible.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the media stream.
                /// If the media stream is a video, the value is <b>video</b>. If the media stream is audio-only, the value is <b>audio</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// <para>The transcoding template group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb0716154b21a4ecb5b70a26ccc8****</para>
                /// </summary>
                [NameInMap("TemplateGroupId")]
                [Validation(Required=false)]
                public string TemplateGroupId { get; set; }

                /// <summary>
                /// <para>The transcoding template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a86a4338dd2e83da45154004a541****</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The watermark template ID associated with the current media stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dgfn26457856****</para>
                /// </summary>
                [NameInMap("WatermarkId")]
                [Validation(Required=false)]
                public string WatermarkId { get; set; }

                /// <summary>
                /// <para>The width of the media stream. Unit: px.</para>
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
        /// <para>The list of media asset IDs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// <para>The list of custom IDs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistReferenceIds")]
        [Validation(Required=false)]
        public List<string> NonExistReferenceIds { get; set; }

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
