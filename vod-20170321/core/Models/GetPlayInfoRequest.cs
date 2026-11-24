// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the live comment mask data. Valid value: <b>danmu</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when OutputType is set to cdn.</para>
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
        /// <item><description><para>When OutputType is set to <b>cdn</b>:</para>
        /// <list type="bullet">
        /// <item><description>The playback URL expires periodically only if URL authentication is enabled. Otherwise, the URL is permanently valid. For more information about how to enable and configure URL authentication, refer to <a href="https://help.aliyun.com/document_detail/86090.html">URL authentication</a>.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the default validity period configured for URL authentication is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When OutputType is set to <b>oss</b>:</para>
        /// <list type="bullet">
        /// <item><description>The playback URL expires periodically only if the storage permission is set to private. Otherwise, the URL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: To reduce security risks of the origin server, the maximum value is <b>604800</b> (7 days) when the audio or video file is stored in an ApsaraVideo VOD bucket, and <b>129600</b> (36 hours) when the file is stored in a user-owned OSS bucket. If the maximum value does not meet your requirements, you can set OutputType to <b>cdn</b> and configure URL authentication to set a longer validity period.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the value is <b>3600</b>.</description></item>
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
        /// <para>The codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>H264</para>
        /// </summary>
        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        /// <summary>
        /// <para>The definition of the video stream. Separate multiple definitions with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FD</b>: fluent.</description></item>
        /// <item><description><b>LD</b>: standard definition.</description></item>
        /// <item><description><b>SD</b>: high definition.</description></item>
        /// <item><description><b>HD</b>: ultra-high definition.</description></item>
        /// <item><description><b>OD</b>: original definition.</description></item>
        /// <item><description><b>2K</b>: 2K.</description></item>
        /// <item><description><b>4K</b>: 4K.</description></item>
        /// <item><description><b>SQ</b>: standard sound quality.</description></item>
        /// <item><description><b>HQ</b>: high sound quality.</description></item>
        /// <item><description><b>AUTO</b>: adaptive bitrate.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>By default, streams of all definitions are retrieved.</description></item>
        /// <item><description>When a tracing watermark is generated, this parameter is required and must be consistent with the definition configured for tracing watermark transcoding.</description></item>
        /// <item><description>The AUTO format is output only when transcoding packaging is configured in the transcoding template. For more information, refer to <a href="~~52839#title-4fk-cg8-gzx~~">PackageSetting: transcoding packaging settings</a>.</description></item>
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
        /// <para>The digital watermarking type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TraceMark: tracing watermark.</description></item>
        /// <item><description>CopyrightMark: copyright watermark.</description></item>
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
        /// <item><description>By default, streams of all formats are retrieved.</description></item>
        /// <item><description>The mpd format is output only when the dash container format is configured in the transcoding template. For more information, refer to <a href="~~52839#title-7rr-3hj-gy5~~">Container: container format</a>.</description></item>
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
        /// <para>The type of the output URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b>: the back-to-origin URL.</description></item>
        /// <item><description><b>cdn</b> (default): the accelerated URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>The custom playback settings. The value is a JSON string. You can specify the domain name for playback. For more information about how to construct the parameter, refer to <a href="~~86952#section-9g7-s9b-v7z~~">PlayConfig</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If PlayConfig is not specified or the PlayDomain field in PlayConfig is not specified, the operation uses the default domain name configured in ApsaraVideo VOD by default. If no default domain name is configured, the operation queries domain names in descending order of modification time and uses the most recently modified domain name as the playback domain name. To prevent an unexpected domain name from being returned, we recommend that you configure a default playback domain name. You can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Asset Management Configuration</b> &gt; <b>Storage Management</b> &gt; <b>Manage</b> &gt; <b>Domain Names that Route Back-to-origin Traffic to This Storage Address</b> to configure the default playback domain name.</description></item>
        /// <item><description>When the EncryptType parameter in PlayConfig is set to AliyunVoDEncryption, the playback URL of the private encrypted stream is not returned by default to ensure video security. To return the playback URL of the private encrypted stream, you must also set the ResultType parameter to Multiple.</description></item>
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
        /// <para>The CDN reauthentication parameter, which is a JSON string. When type A signing of URL authentication is enabled, you can use this parameter to set the uid and rand values of the authenticated URL. For more information, refer to <a href="https://help.aliyun.com/document_detail/2249352.html">Type A signing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;uid&quot;:&quot;12345&quot;,&quot;rand&quot;:&quot;abckljd&quot;}</para>
        /// </summary>
        [NameInMap("ReAuthInfo")]
        [Validation(Required=false)]
        public string ReAuthInfo { get; set; }

        /// <summary>
        /// <para>The custom ID. The ID must be 6 to 64 characters in length and can contain only lowercase letters, uppercase letters, digits, hyphens (-), and underscores (_). The ID must be unique per user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The type of the returned data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Single</b> (default): returns only the latest transcoded stream for each definition and format.</description></item>
        /// <item><description><b>Multiple</b>: returns all transcoded streams for each definition and format.</description></item>
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
        /// <item><description><b>video</b>: video.</description></item>
        /// <item><description><b>audio</b>: audio.</description></item>
        /// </list>
        /// <para>By default, streams of all types are retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// <para>The custom digital watermarking information.</para>
        /// <list type="bullet">
        /// <item><description>When DigitalWatermarkType is set to TraceMark, you can pass this parameter to set the tracing watermark information for the video and return the video stream that contains the watermark information. Only English letters, digits, and Chinese characters are supported. A maximum of 1,024 characters are supported.</description></item>
        /// <item><description>When DigitalWatermarkType is set to CopyrightMark, Trace corresponds to the <b>Watermark Text</b> set when the watermark template is created. By passing this parameter, you can query and return the video stream with the specified watermark text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test mark</para>
        /// </summary>
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        /// <summary>
        /// <para>The ID of the audio or video file. You can specify only one ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For an audio or video file uploaded in the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Library</b> &gt; <b>Audio/Video</b> to view the ID.</description></item>
        /// <item><description>When you upload an audio or video file by calling the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation, the ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After an audio or video file is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f654b6e91d24d81d44****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
