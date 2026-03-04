// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetYikeAssetMediaInfoResponseBody : TeaModel {
        [NameInMap("MediaInfo")]
        [Validation(Required=false)]
        public GetYikeAssetMediaInfoResponseBodyMediaInfo MediaInfo { get; set; }
        public class GetYikeAssetMediaInfoResponseBodyMediaInfo : TeaModel {
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public GetYikeAssetMediaInfoResponseBodyMediaInfoBizData BizData { get; set; }
            public class GetYikeAssetMediaInfoResponseBodyMediaInfoBizData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Label</para>
                /// </summary>
                [NameInMap("AuditBlockedLabel")]
                [Validation(Required=false)]
                public string AuditBlockedLabel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Status</para>
                /// </summary>
                [NameInMap("AuditStatus")]
                [Validation(Required=false)]
                public string AuditStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("CreationJobId")]
                [Validation(Required=false)]
                public string CreationJobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fd-CBMEJaa2fA</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsFavorite")]
                [Validation(Required=false)]
                public string IsFavorite { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsLogicalDeleted")]
                [Validation(Required=false)]
                public string IsLogicalDeleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SubType</para>
                /// </summary>
                [NameInMap("MediaAssetSubType")]
                [Validation(Required=false)]
                public string MediaAssetSubType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Type</para>
                /// </summary>
                [NameInMap("MediaAssetType")]
                [Validation(Required=false)]
                public string MediaAssetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("ProductionId")]
                [Validation(Required=false)]
                public string ProductionId { get; set; }

                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f4a26390f02371f0a1f4e6e7c758****</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SourceName</para>
                /// </summary>
                [NameInMap("SourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MainBody</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoList> FileInfoList { get; set; }
            public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoList : TeaModel {
                [NameInMap("AudioStreamInfoList")]
                [Validation(Required=false)]
                public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>192.0</para>
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
                    /// <para>0x6134706d</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mp4a</para>
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
                    /// <para>16.2</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("NumFrames")]
                    [Validation(Required=false)]
                    public string NumFrames { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>High</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

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
                    /// <para>2026-02-04T02:13:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/44100</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-12-26T04:11:08Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>16.2</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>example.mp4</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>27007</para>
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
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mp4</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>540</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-12-26T04:11:10Z</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>960</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                [NameInMap("SubtitleStreamInfoList")]
                [Validation(Required=false)]
                public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList> SubtitleStreamInfoList { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SubRip Text</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>srt</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>unicode</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>unicode</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>29.97</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
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
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-03-07T01:30Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                [NameInMap("VideoStreamInfoList")]
                [Validation(Required=false)]
                public List<GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class GetYikeAssetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>24.0</para>
                    /// </summary>
                    [NameInMap("AvgFPS")]
                    [Validation(Required=false)]
                    public string AvgFPS { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>h264</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0x0000</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[0][0][0][0]</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/48</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Dar")]
                    [Validation(Required=false)]
                    public string Dar { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>216.206706</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>24.0</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("HasBFrames")]
                    [Validation(Required=false)]
                    public string HasBFrames { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>540</para>
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
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5184</para>
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
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.081706</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/12288</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>960</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetYikeAssetMediaInfoResponseBodyMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetYikeAssetMediaInfoResponseBodyMediaInfoMediaBasicInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AiSaas</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3048</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cateName</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>category</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:15Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:10Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123-1234</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;32&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>83ec44d58b2069def2e</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-shanghai&quot;,&quot;snapshotRegular&quot;:&quot;example/example-{Count}.jpg&quot;,&quot;spriteRegular&quot;:&quot;example/example-{TileCount}.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e438b14ff39293eaec25</b></b></b>&quot;,&quot;tileCount&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ThumbURL240P</para>
                /// </summary>
                [NameInMap("ThumbURL240P")]
                [Validation(Required=false)]
                public string ThumbURL240P { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ThumbURLWebp</para>
                /// </summary>
                [NameInMap("ThumbURLWebp")]
                [Validation(Required=false)]
                public string ThumbURLWebp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v6l82k_176822379****.jpeg</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UserData</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
