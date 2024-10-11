// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the masked live comment data. Value: <b>danmu</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the <c>outputType</c> parameter is set to <c>cdn</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>danmu</para>
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// <para>The validity period of the playback URL. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set OutputType to <b>cdn</b>:</para>
        /// <list type="bullet">
        /// <item><description>The playback URL has a validity period only if URL signing is enabled. Otherwise, the playback URL is permanently valid. For more information about how to enable and configure URL signing, see <a href="https://help.aliyun.com/document_detail/86090.html">URL signing</a>.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: The default validity period that is specified in URL signing is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set OutputType to <b>oss</b>:</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when the ACL of the Object Storage Service (OSS) bucket is private. Otherwise, the playback URL does not expire.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: If the media file is stored in the VOD bucket, the maximum validity period is <b>2592000</b> (30 days). If the media file is stored in an OSS bucket, the maximum validity period is <b>129600</b> (36 hours). This limit is imposed to reduce security risks of the origin server. If you require a longer validity period, set OutputType to <b>cdn</b> and configure URL signing to specify a longer validity period.</description></item>
        /// <item><description>Default value: <b>3600</b>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The quality of the video stream. Separate multiple qualities with commas (,). Valid values:</para>
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
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>By default, ApsaraVideo VOD returns video streams in all the preceding qualities.</description></item>
        /// <item><description>However, video streams for adaptive bitrate streaming are returned only if the PackageSetting parameter is specified in the transcoding template. For more information, see the <a href="~~52839#title-4fk-cg8-gzx~~">PackageSetting parameter in the TranscodeTemplate table</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LD</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The type of the digital watermark. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TraceMark: tracing watermark</description></item>
        /// <item><description>CopyrightMark: copyright watermark</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TraceMark</para>
        /// </summary>
        [NameInMap("DigitalWatermarkType")]
        [Validation(Required=false)]
        public string DigitalWatermarkType { get; set; }

        /// <summary>
        /// <para>The format of the media stream. Separate multiple formats with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mp4</b></description></item>
        /// <item><description><b>m3u8</b></description></item>
        /// <item><description><b>mp3</b></description></item>
        /// <item><description><b>flv</b></description></item>
        /// <item><description><b>mpd</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>By default, ApsaraVideo VOD returns video streams in all the preceding formats.</description></item>
        /// <item><description>However, video streams in the MPD format are returned only if the <c>dash</c> container format is specified in the transcoding template. For more information, see the <a href="~~52839#title-7rr-3hj-gy5~~">Container parameter in the TranscodeTemplate table</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mp4,m3u8</para>
        /// </summary>
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public string Formats { get; set; }

        /// <summary>
        /// <para>The type of the output URL. Default value: oss. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b></description></item>
        /// <item><description><b>cdn</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>The custom playback configuration. The value must be a JSON string. You can specify a domain name for playback. For more information, see <a href="~~86952#section-9g7-s9b-v7z~~">PlayConfig</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not set the PlayConfig parameter or the <c>PlayDomain</c> parameter that is nested under the PlayConfig parameter, the default domain name specified in ApsaraVideo VOD is used in this operation. If no default domain name is specified, the domain names are queried in reverse chronological order based on the time when the domain names were last modified. To prevent domain name issues, we recommend that you perform the following steps to specify the default playback domain name: Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b>. Find the domain name that you want to configure and click <b>Manage</b> in the Actions column. On the page that appears, set the default playback domain name in the <b>Origin Domain Name</b> section.</description></item>
        /// <item><description>If you set the <c>EncryptType</c> parameter nested under the PlayConfig parameter to <c>AliyunVoDEncryption</c>, the playback URLs of videos encrypted by using Alibaba Cloud proprietary cryptography are not automatically returned to ensure video security. To return playback URLs of videos encrypted by using Alibaba Cloud proprietary cryptography, you must set the <c>ResultType</c> parameter to <c>Multiple</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PlayDomain&quot;:&quot;vod.test_domain&quot;,&quot;XForwardedFor&quot;:&quot;yqCD7Fp1uqChoVj/sl/p5Q==&quot;,&quot;PreviewTime&quot;:&quot;20&quot;,&quot;MtsHlsUriToken&quot;:&quot;yqCD7Fp1uqChoVjslp5Q&quot;}</para>
        /// </summary>
        [NameInMap("PlayConfig")]
        [Validation(Required=false)]
        public string PlayConfig { get; set; }

        /// <summary>
        /// <para>The CDN reauthentication configuration. The value must be a JSON string. If CDN reauthentication is enabled, you can use this parameter to specify the <c>UID</c> and <c>rand</c> fields for URL authentication. For more information, see <a href="https://help.aliyun.com/document_detail/2249352.html">URL authentication</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;uid&quot;:&quot;12345&quot;,&quot;rand&quot;:&quot;abckljd&quot;}</para>
        /// </summary>
        [NameInMap("ReAuthInfo")]
        [Validation(Required=false)]
        public string ReAuthInfo { get; set; }

        /// <summary>
        /// <para>The type of the data to return. Default value: Single. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Single</b>: Only one latest transcoded stream is returned for each quality and format.</description></item>
        /// <item><description><b>Multiple</b>: All transcoded streams are returned for each quality and format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>The type of the media stream. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b></description></item>
        /// <item><description><b>audio</b></description></item>
        /// </list>
        /// <para>By default, video and audio streams are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// <para>The custom digital watermark.</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>DigitalWatermarkType</c> to <c>TraceMark</c>, specify this parameter to configure the video tracing watermark and return the video stream that contains the watermark. The value can be up to 1,024 characters in length and can contain letters and digits.</description></item>
        /// <item><description>If you set <c>DigitalWatermarkType</c> to <c>CopyrightMark</c>, specify the <b>watermark text</b> that you created for the watermark template for this parameter.`` You can specify this parameter to query and return the video stream that contains the specified watermark text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test mark</para>
        /// </summary>
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        /// <summary>
        /// <para>The ID of the media file. You can specify only one ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the page that appears, view the media ID.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter in the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you called to upload the audio or video file.</description></item>
        /// <item><description>Obtain the value of VideoId by calling the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation. This method is applicable to files that have been uploaded.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f654b6e91d24d81d44****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
