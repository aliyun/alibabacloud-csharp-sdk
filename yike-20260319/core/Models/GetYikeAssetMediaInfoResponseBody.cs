// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class GetYikeAssetMediaInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The media asset information.</para>
        /// </summary>
        [NameInMap("MediaInfo")]
        [Validation(Required=false)]
        public GetYikeAssetMediaInfoResponseBodyMediaInfo MediaInfo { get; set; }
        public class GetYikeAssetMediaInfoResponseBodyMediaInfo : TeaModel {
            /// <summary>
            /// <para>The custom business information.</para>
            /// </summary>
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public GetYikeAssetMediaInfoResponseBodyMediaInfoBizData BizData { get; set; }
            public class GetYikeAssetMediaInfoResponseBodyMediaInfoBizData : TeaModel {
                /// <summary>
                /// <para>The audit label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Label</para>
                /// </summary>
                [NameInMap("AuditBlockedLabel")]
                [Validation(Required=false)]
                public string AuditBlockedLabel { get; set; }

                /// <summary>
                /// <para>The audit status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Status</para>
                /// </summary>
                [NameInMap("AuditStatus")]
                [Validation(Required=false)]
                public string AuditStatus { get; set; }

                /// <summary>
                /// <para>The ID of the creation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("CreationJobId")]
                [Validation(Required=false)]
                public string CreationJobId { get; set; }

                /// <summary>
                /// <para>The folder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fd-CBMEJaa2fA</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>Indicates whether the media asset is marked as a favorite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsFavorite")]
                [Validation(Required=false)]
                public string IsFavorite { get; set; }

                /// <summary>
                /// <para>Indicates whether the media asset is logically deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsLogicalDeleted")]
                [Validation(Required=false)]
                public string IsLogicalDeleted { get; set; }

                /// <summary>
                /// <para>The media asset subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SubType</para>
                /// </summary>
                [NameInMap("MediaAssetSubType")]
                [Validation(Required=false)]
                public string MediaAssetSubType { get; set; }

                /// <summary>
                /// <para>The media asset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Type</para>
                /// </summary>
                [NameInMap("MediaAssetType")]
                [Validation(Required=false)]
                public string MediaAssetType { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("ProductionId")]
                [Validation(Required=false)]
                public string ProductionId { get; set; }

                /// <summary>
                /// <para>The prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>请为上述内容生成一段摘要，字数必须限制在70字以内包含标点符号</para>
                /// </summary>
                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <para>The source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f4a26390f02371f0a1f4e6e7c758****</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SourceName</para>
                /// </summary>
                [NameInMap("SourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MainBody</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

            /// <summary>
            /// <para>FileInfos</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoList> FileInfoList { get; set; }
            public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoList : TeaModel {
                /// <summary>
                /// <para>The audio stream information. A media asset may contain multiple audio streams.</para>
                /// </summary>
                [NameInMap("AudioStreamInfoList")]
                [Validation(Required=false)]
                public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0</para>
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
                    /// <para>The number of channels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    /// <summary>
                    /// <para>The long name of the codec.</para>
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
                    /// <para>16.2</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The audio frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>The index of the audio stream.</para>
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
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <para>The total number of frames.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("NumFrames")]
                    [Validation(Required=false)]
                    public string NumFrames { get; set; }

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
                    /// <para>The start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-02-04T02:13:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/44100</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                /// <summary>
                /// <para>The basic file information, including duration and size.</para>
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <para>The bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The time when the file was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-26T04:11:08Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16.2</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.mp4</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The file size, in bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>27007</para>
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
                    /// <para>The OSS URL of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>The container format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mp4</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <para>The height.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>540</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The time when the file was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-26T04:11:10Z</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

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
                    /// <para>The width.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>960</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>The subtitle stream information. A media asset may contain multiple subtitle streams.</para>
                /// </summary>
                [NameInMap("SubtitleStreamInfoList")]
                [Validation(Required=false)]
                public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList> SubtitleStreamInfoList { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The long name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SubRip Text</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <para>The short name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>srt</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <para>The codec tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unicode</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The codec tag string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unicode</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <para>The codec time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>29.97</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The index of the audio stream.</para>
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
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <para>The start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-03-07T01:30Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                /// <summary>
                /// <para>The video stream information. A media asset may contain multiple video streams.</para>
                /// </summary>
                [NameInMap("VideoStreamInfoList")]
                [Validation(Required=false)]
                public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The average frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24.0</para>
                    /// </summary>
                    [NameInMap("AvgFPS")]
                    [Validation(Required=false)]
                    public string AvgFPS { get; set; }

                    /// <summary>
                    /// <para>The bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The long name of the codec.</para>
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
                    /// <para>0x0000</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The codec tag string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[0][0][0][0]</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <para>The codec time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/48</para>
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
                    /// <para>216.206706</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The video frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24.0</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the video stream contains B-frames.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("HasBFrames")]
                    [Validation(Required=false)]
                    public string HasBFrames { get; set; }

                    /// <summary>
                    /// <para>The height.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>540</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The index of the video stream.</para>
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
                    /// <para>zh</para>
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
                    /// <para>5184</para>
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
                    /// <para>The rotation angle.</para>
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
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    /// <summary>
                    /// <para>The start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-08-04T12:00:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/12288</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                    /// <summary>
                    /// <para>The width.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>960</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>BasicInfo</para>
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetYikeAssetMediaInfoResponseBodyMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetYikeAssetMediaInfoResponseBodyMediaInfoMediaBasicInfo : TeaModel {
                /// <summary>
                /// <para>The business to which the media asset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AiSaas</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <para>The business type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3048</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cateName</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>category</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The cover URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://dtlive-vip.oss-cn-shanghai.aliyuncs.com/cover/4e88a055-75fc-4ff5-8b8a-f32224917514_open_live_cover.jpg">https://dtlive-vip.oss-cn-shanghai.aliyuncs.com/cover/4e88a055-75fc-4ff5-8b8a-f32224917514_open_live_cover.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the media asset was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the media asset was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <para>The content description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The address of the media asset to be registered in the corresponding system.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <para>The media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// <para>The media type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The time when the media asset was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. The value must be 6 to 64 characters in length and is unique for each user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-1234</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>The snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The sprite images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;32&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>83ec44d58b2069def2e</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-shanghai&quot;,&quot;snapshotRegular&quot;:&quot;example/example-{Count}.jpg&quot;,&quot;spriteRegular&quot;:&quot;example/example-{TileCount}.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e438b14ff39293eaec25</b></b></b>&quot;,&quot;tileCount&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                /// <summary>
                /// <para>The resource status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The thumbnail with a height of 240 pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ThumbURL240P</para>
                /// </summary>
                [NameInMap("ThumbURL240P")]
                [Validation(Required=false)]
                public string ThumbURL240P { get; set; }

                /// <summary>
                /// <para>The thumbnail encoded in WebP format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ThumbURLWebp</para>
                /// </summary>
                [NameInMap("ThumbURLWebp")]
                [Validation(Required=false)]
                public string ThumbURLWebp { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v6l82k_176822379****.jpeg</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The upload source of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                /// <summary>
                /// <para>The user data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserData</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The media asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
