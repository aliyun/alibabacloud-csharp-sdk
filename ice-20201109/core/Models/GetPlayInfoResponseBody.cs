// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic information about the media asset.</para>
        /// </summary>
        [NameInMap("MediaBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyMediaBase MediaBase { get; set; }
        public class GetPlayInfoResponseBodyMediaBase : TeaModel {
            /// <summary>
            /// <para>The category ID. You can obtain the category ID in one of the following ways:</para>
            /// <list type="bullet">
            /// <item><description><para>Log on to the <a href="https://ims.console.aliyun.com">IMS console</a> and choose <b>media asset management</b> &gt; <b>category management</b> to view the category ID.</para>
            /// </description></item>
            /// <item><description><para>The create category operation returns the category ID in the <c>CateId</c> parameter.</para>
            /// </description></item>
            /// <item><description><para>The get category operation returns the category ID in the <c>CateId</c> parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4220</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The cover URL.</para>
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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The media asset ID.</para>
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
            /// <item><description><para>You can add up to 16 tags.</para>
            /// </description></item>
            /// <item><description><para>Separate multiple tags with commas (,).</para>
            /// </description></item>
            /// <item><description><para>The maximum length of a tag is 32 bytes.</para>
            /// </description></item>
            /// <item><description><para>Tags must be UTF-8 encoded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test,ccc</para>
            /// </summary>
            [NameInMap("MediaTags")]
            [Validation(Required=false)]
            public string MediaTags { get; set; }

            /// <summary>
            /// <para>The type of the media file. Valid values:</para>
            /// <para><c>video</c>: A video file. <c>audio</c>: An audio-only file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <para>The status of the media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Init</c>: The source file is not ready.</para>
            /// </description></item>
            /// <item><description><para><c>Preparing</c>: The source file is being prepared. This process may involve uploading or compositing.</para>
            /// </description></item>
            /// <item><description><para><c>PrepareFail</c>: Preparation of the source file failed. For example, the system failed to retrieve the source file metadata.</para>
            /// </description></item>
            /// <item><description><para><c>Normal</c>: The source file is ready.</para>
            /// </description></item>
            /// </list>
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
        /// <para>A list of audio or video playback streams.</para>
        /// </summary>
        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public List<GetPlayInfoResponseBodyPlayInfoList> PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            /// <summary>
            /// <para>The color bit depth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("BitDepth")]
            [Validation(Required=false)]
            public int? BitDepth { get; set; }

            /// <summary>
            /// <para>The bitrate of the media stream in Kbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-10T02:28:49Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The definition of the video stream. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>FD</b>: fluent</para>
            /// </description></item>
            /// <item><description><para><b>LD</b>: standard definition</para>
            /// </description></item>
            /// <item><description><para><b>SD</b>: high definition</para>
            /// </description></item>
            /// <item><description><para><b>HD</b>: ultra-high definition</para>
            /// </description></item>
            /// <item><description><para><b>OD</b>: original</para>
            /// </description></item>
            /// <item><description><para><b>2K</b></para>
            /// </description></item>
            /// <item><description><para><b>4K</b></para>
            /// </description></item>
            /// <item><description><para><b>SQ</b>: standard-quality audio</para>
            /// </description></item>
            /// <item><description><para><b>HQ</b>: high-quality audio</para>
            /// </description></item>
            /// <item><description><para><b>AUTO</b>: adaptive bitrate</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HD</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>The duration of the media stream in seconds.</para>
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
            /// <item><description><para><b>0</b>: No.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Yes.</para>
            /// </description></item>
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
            /// <item><description><para><b>AliyunVoDEncryption</b>: Alibaba Cloud VoD Encryption.</para>
            /// </description></item>
            /// <item><description><para><b>HLSEncryption</b>: HLS standard encryption.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If a stream is encrypted with <b>AliyunVoDEncryption</b>, you can play it only with the Alibaba Cloud Player SDK.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunVoDEncryption</para>
            /// </summary>
            [NameInMap("EncryptType")]
            [Validation(Required=false)]
            public string EncryptType { get; set; }

            /// <summary>
            /// <para>The OSS file URL.</para>
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
            /// <item><description><para>For video streams, valid values are <b>mp4</b> and <b>m3u8</b>.</para>
            /// </description></item>
            /// <item><description><para>For audio-only streams, the value is <b>mp3</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mp4</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The frame rate of the media stream in frames per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <para>The High Dynamic Range (HDR) type of the media stream. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>HDR</para>
            /// </description></item>
            /// <item><description><para>HDR10</para>
            /// </description></item>
            /// <item><description><para>HLG</para>
            /// </description></item>
            /// <item><description><para>DolbyVision</para>
            /// </description></item>
            /// <item><description><para>HDRVivid</para>
            /// </description></item>
            /// <item><description><para>SDR+</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HDR</para>
            /// </summary>
            [NameInMap("HDRType")]
            [Validation(Required=false)]
            public string HDRType { get; set; }

            /// <summary>
            /// <para>The height of the media stream in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36c9d38e70bf43ed9f7f8f48d6356***</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The last modification time. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-13T11:39:41.714+08:00</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The Narrowband HD type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: regular.</para>
            /// </description></item>
            /// <item><description><para><b>1.0</b>: Narrowband HD 1.0.</para>
            /// </description></item>
            /// <item><description><para><b>2.0</b>: Narrowband HD 2.0.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter applies only if a definition is configured in the built-in transcoding template for Narrowband HD 1.0. For more information, see <a href="https://help.aliyun.com/document_detail/52839.html">Configure transcoding templates - Definition</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NarrowBandType")]
            [Validation(Required=false)]
            public string NarrowBandType { get; set; }

            /// <summary>
            /// <para>The playback URL of the video stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://***.aliyuncdn.com/sv/756bee1-17f980f0945/756bee1-17f980f0945.mp4</para>
            /// </summary>
            [NameInMap("PlayURL")]
            [Validation(Required=false)]
            public string PlayURL { get; set; }

            /// <summary>
            /// <para>The size of the media stream in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>418112</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The media stream status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The stream is available.</para>
            /// </description></item>
            /// <item><description><para><b>Invisible</b>: The stream is not visible.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The stream tags, which are used to identify the transcoding type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;ims.audioServiceType\&quot;: \&quot;AudioEnhancement\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("StreamTags")]
            [Validation(Required=false)]
            public string StreamTags { get; set; }

            /// <summary>
            /// <para>The type of the media stream. The value is <b>video</b> for video streams or <b>audio</b> for audio-only streams.</para>
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
            /// <item><description><para><c>Normal</c>: regular transcoding</para>
            /// </description></item>
            /// <item><description><para><c>AudioTranscode</c>: audio transcoding</para>
            /// </description></item>
            /// <item><description><para><c>Remux</c>: remuxing</para>
            /// </description></item>
            /// <item><description><para><c>NarrowBandV1</c>: Narrowband HD 1.0</para>
            /// </description></item>
            /// <item><description><para><c>NarrowBandV2</c>: Narrowband HD 2.0</para>
            /// </description></item>
            /// <item><description><para><c>UHD</c>: audio and video enhancement (ultra-high definition)</para>
            /// </description></item>
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
            /// <para>The width of the media stream in pixels.</para>
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
