// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The media asset information.</para>
        /// </summary>
        [NameInMap("MediaBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyMediaBase MediaBase { get; set; }
        public class GetPlayInfoResponseBodyMediaBase : TeaModel {
            /// <summary>
            /// <para>The category ID. You can obtain the category ID by using the following methods:</para>
            /// <list type="bullet">
            /// <item><description>Log on to the <a href="https://ims.console.aliyun.com">IMS console</a> and choose <b>Media Asset Management</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
            /// <item><description>When you create a category by calling the create category operation, the category ID is the value of CateId in the response.</description></item>
            /// <item><description>When you query a category by calling the get category operation, the category ID is the value of CateId in the response.</description></item>
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
            /// <para>The creation time.</para>
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
            /// <item><description><para>A maximum of 16 tags are supported.</para>
            /// </description></item>
            /// <item><description><para>Separate multiple tags with commas (,).</para>
            /// </description></item>
            /// <item><description><para>Each tag can be up to 32 bytes in length.</para>
            /// </description></item>
            /// <item><description><para>UTF-8 encoding is used.</para>
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
            /// <para>The media file type. Valid values:</para>
            /// <para>video: video.
            /// audio: audio only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <para>The resource status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Init: The source file is not ready.</para>
            /// </description></item>
            /// <item><description><para>Preparing: The source file is being prepared, for example, being uploaded or composed.</para>
            /// </description></item>
            /// <item><description><para>PrepareFail: The source file failed to be prepared, for example, failed to obtain source file information.</para>
            /// </description></item>
            /// <item><description><para>Normal: The source file is ready.</para>
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
        /// <para>The audio or video playback information (stream information).</para>
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
            /// <para>The bitrate of the media stream. Unit: Kbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <para>The creation time. The time follows the format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
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
            /// <item><description><b>FD</b>: low definition.</description></item>
            /// <item><description><b>LD</b>: standard definition.</description></item>
            /// <item><description><b>SD</b>: high definition.</description></item>
            /// <item><description><b>HD</b>: ultra-high definition.</description></item>
            /// <item><description><b>OD</b>: original quality.</description></item>
            /// <item><description><b>2K</b>: 2K.</description></item>
            /// <item><description><b>4K</b>: 4K.</description></item>
            /// <item><description><b>SQ</b>: standard sound quality.</description></item>
            /// <item><description><b>HQ</b>: high sound quality.</description></item>
            /// <item><description><b>AUTO</b>: adaptive bitrate.</description></item>
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
            /// <item><description><b>0</b>: not encrypted.</description></item>
            /// <item><description><b>1</b>: encrypted.</description></item>
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
            /// <item><description><b>AliyunVoDEncryption</b>: Alibaba Cloud video encryption.</description></item>
            /// <item><description><b>HLSEncryption</b>: HLS standard encryption.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the encryption type is <b>AliyunVoDEncryption</b>, only the Alibaba Cloud Player SDK can be used for playback.</para>
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
            /// <item><description>If the media file is a video, valid values are <b>mp4</b> and <b>m3u8</b>.</description></item>
            /// <item><description>If the media file is audio only, the value is <b>mp3</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mp4</para>
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
            /// <para>HDR</para>
            /// </summary>
            [NameInMap("HDRType")]
            [Validation(Required=false)]
            public string HDRType { get; set; }

            /// <summary>
            /// <para>The height of the media stream. Unit: px.</para>
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
            /// <para>The modification time. The time follows the format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
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
            /// <item><description><b>0</b>: normal.</description></item>
            /// <item><description><b>1.0</b>: Narrowband HD 1.0.</description></item>
            /// <item><description><b>2.0</b>: Narrowband HD 2.0.</description></item>
            /// </list>
            /// <para>This parameter takes effect only when the definition of a Narrowband HD 1.0 built-in transcoding template is configured. For more information, see <a href="https://help.aliyun.com/document_detail/52839.html">Transcoding template configuration - Definition</a>.</para>
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
            /// <para>The size of the media stream. Unit: bytes.</para>
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
            /// <item><description><b>Normal</b>: normal.</description></item>
            /// <item><description><b>Invisible</b>: invisible.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The stream tag that identifies the transcoding processing type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;ims.audioServiceType\&quot;: \&quot;AudioEnhancement\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("StreamTags")]
            [Validation(Required=false)]
            public string StreamTags { get; set; }

            /// <summary>
            /// <para>The media stream type. If the media stream is a video, the value is <b>video</b>. If the media stream is audio only, the value is <b>audio</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public string StreamType { get; set; }

            /// <summary>
            /// <para>The transcoding templatetype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: normal template.</description></item>
            /// <item><description>AudioTranscode: audio transcoding.</description></item>
            /// <item><description>Remux: encapsulation conversion.</description></item>
            /// <item><description>NarrowBandV1: Narrowband HD 1.0.</description></item>
            /// <item><description>NarrowBandV2: Narrowband HD 2.0.</description></item>
            /// <item><description>UHD: audio and video enhancement (ultra-high definition).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("TransTemplateType")]
            [Validation(Required=false)]
            public string TransTemplateType { get; set; }

            /// <summary>
            /// <para>The watermark ID associated with the current media stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5bed88672b1e2520ead228935ed51***</para>
            /// </summary>
            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }

            /// <summary>
            /// <para>The width of the media stream. Unit: px.</para>
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
