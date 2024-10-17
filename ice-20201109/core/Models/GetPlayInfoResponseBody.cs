// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the media asset.</para>
        /// </summary>
        [NameInMap("MediaBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyMediaBase MediaBase { get; set; }
        public class GetPlayInfoResponseBodyMediaBase : TeaModel {
            /// <summary>
            /// <para>The category ID. You can use one of the following methods to obtain the ID:</para>
            /// <list type="bullet">
            /// <item><description>Log on to the <a href="https://ims.console.aliyun.com">Intelligent Media Services (IMS) console</a> and choose <b>Media Asset Management</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
            /// <item><description>View the value of the CateId parameter returned by the AddCategory operation that you called to create a category.</description></item>
            /// <item><description>View the value of the CateId parameter returned by the GetCategories operation that you called to query a category.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4220</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The URL of the thumbnail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://***.oss-cn-shanghai.aliyuncs.com/cover/281c64d6-b5fb-4c57-97cd-84da56a8b151_large_cover_url.jpg</para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The time when the media asset was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-22T10:07:31+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The content description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2eea77a61c7b4ddd95bec34a6f65b***</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// <list type="bullet">
            /// <item><description>Up to 16 tags are supported.</description></item>
            /// <item><description>Multiple tags are separated by commas (,).</description></item>
            /// <item><description>Each tag can be up to 32 bytes in length.</description></item>
            /// <item><description>The value is encoded in UTF-8.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test,ccc</para>
            /// </summary>
            [NameInMap("MediaTags")]
            [Validation(Required=false)]
            public string MediaTags { get; set; }

            /// <summary>
            /// <para>The type of the media asset. Valid values:</para>
            /// <para>video audio</para>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <para>The resource status. Valid values:</para>
            /// <para>Init: the initial state, which indicates that the source file is not ready.</para>
            /// <para>Preparing: The source file is being prepared. For example, the file is being uploaded or edited.</para>
            /// <para>PrepareFail: The source file failed to be prepared. For example, the information of the source file failed to be obtained.</para>
            /// <para>Normal: The source file is ready.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTitle</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The information about the audio or video stream.</para>
        /// </summary>
        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public List<GetPlayInfoResponseBodyPlayInfoList> PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            /// <summary>
            /// <para>The color depth.</para>
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The time when the media stream was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-10T02:28:49Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The quality of the media stream. Valid values:</para>
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
            /// <para>HD</para>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("Encrypt")]
            [Validation(Required=false)]
            public long? Encrypt { get; set; }

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
            /// <para>The OSS URL of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://outin-***.oss-cn-shanghai.aliyuncs.com/sv/43a68ee9-181809b6aba/43a68ee9-181809b6aba.mpeg">http://outin-***.oss-cn-shanghai.aliyuncs.com/sv/43a68ee9-181809b6aba/43a68ee9-181809b6aba.mpeg</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The format of the media stream.</para>
            /// <list type="bullet">
            /// <item><description>If the media asset is a video file, the valid values are <b>mp4</b> and <b>m3u8</b>.</description></item>
            /// <item><description>If the media asset is an audio-only file, the value is <b>mp3</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mp4</para>
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
            /// <para>The high dynamic range (HDR) type of the media stream. Valid values:</para>
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
            /// <para>HDR</para>
            /// </summary>
            [NameInMap("HDRType")]
            [Validation(Required=false)]
            public string HDRType { get; set; }

            /// <summary>
            /// <para>The height of the media stream. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36c9d38e70bf43ed9f7f8f48d6356***</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The time when the media stream was updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-13T11:39:41.714+08:00</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The type of Narrowband HD™ transcoding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: standard transcoding</description></item>
            /// <item><description><b>1.0</b>: Narrowband HD™ 1.0 transcoding</description></item>
            /// <item><description><b>2.0</b>: Narrowband HD™ 2.0 transcoding</description></item>
            /// </list>
            /// <para>This parameter is returned only when a definition that is available in the built-in Narrowband HD™ 1.0 transcoding template is specified. For more information, see the <a href="https://help.aliyun.com/document_detail/52839.html">Definition parameter in TranscodeTemplate</a> table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NarrowBandType")]
            [Validation(Required=false)]
            public string NarrowBandType { get; set; }

            /// <summary>
            /// <para>The playback URL of the media stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://***.aliyuncdn.com/sv/756bee1-17f980f0945/756bee1-17f980f0945.mp4</para>
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
            /// <para>The status of the media stream. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>Invisible</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the media stream, which are used to identify the transcoding type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;ims.audioServiceType\&quot;: \&quot;AudioEnhancement\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("StreamTags")]
            [Validation(Required=false)]
            public string StreamTags { get; set; }

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
            /// <para>The type of the transcoding template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: standard transcoding</description></item>
            /// <item><description>AudioTranscode: audio transcoding</description></item>
            /// <item><description>Remux: container format conversion</description></item>
            /// <item><description>NarrowBandV1: Narrowband HD™ 1.0</description></item>
            /// <item><description>NarrowBandV2: Narrowband HD™ 2.0</description></item>
            /// <item><description>UHD: audio and video enhancement (ultra-high definition)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("TransTemplateType")]
            [Validation(Required=false)]
            public string TransTemplateType { get; set; }

            /// <summary>
            /// <para>The ID of the watermark that is associated with the media stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5bed88672b1e2520ead228935ed51***</para>
            /// </summary>
            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }

            /// <summary>
            /// <para>The width of the media stream. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
