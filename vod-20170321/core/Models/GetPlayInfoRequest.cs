// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>Obtains the URL of the China-accessible bullet screen mask data. Valid values: <b>danmu</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>outputType</c> is set to <c>cdn</c>.</para>
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
        /// <item><description><para>If OutputType is set to <b>cdn</b>:</para>
        /// <list type="bullet">
        /// <item><description>The playback URL expires periodically only when URL authentication is enabled. Otherwise, the URL is permanently valid. For information about how to enable and configure URL authentication, refer to <a href="https://help.aliyun.com/document_detail/86090.html">URL authentication</a>.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the default validity period configured in URL authentication is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If OutputType is set to <b>oss</b>:</para>
        /// <list type="bullet">
        /// <item><description>The playback URL expires periodically only when the storage permission is private. Otherwise, the URL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: To reduce security risks to the origin server, when audio or video files are stored in an ApsaraVideo VOD system bucket, the maximum value is <b>604800</b> (7 days). When audio or video files are stored in your own OSS bucket, the maximum value is <b>129600</b> (36 hours). If the maximum value does not meet your requirements, set OutputType to <b>cdn</b> and configure URL authentication to set a longer validity period.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the default value is <b>3600</b>.</description></item>
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
        /// <b>Example:</b>
        /// <para>H264</para>
        /// </summary>
        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        /// <summary>
        /// <para>The definition of the video stream. Separate multiple definitions with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FD</b>: low definition.</description></item>
        /// <item><description><b>LD</b>: standard definition.</description></item>
        /// <item><description><b>SD</b>: high definition.</description></item>
        /// <item><description><b>HD</b>: ultra-high definition.</description></item>
        /// <item><description><b>OD</b>: original definition.</description></item>
        /// <item><description><b>2K</b>: 2K.</description></item>
        /// <item><description><b>4K</b>: 4K.</description></item>
        /// <item><description><b>SQ</b>: standard sound quality.</description></item>
        /// <item><description><b>HQ</b>: high sound quality.</description></item>
        /// <item><description><b>AUTO</b>: adaptive bitrate streaming.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>By default, streams of all definitions are returned.</description></item>
        /// <item><description>When generating tracing watermarks, this parameter is required and must be consistent with the definition configured during tracing watermark transcoding.</description></item>
        /// <item><description>The AUTO definition is returned only when transcoding packaging is configured in the transcoding template. For more information, refer to <a href="~~52839#title-4fk-cg8-gzx~~">PackageSetting: transcoding packaging settings</a>.</description></item>
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
        /// <para>The media stream format. Separate multiple formats with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mp4</b></description></item>
        /// <item><description><b>m3u8</b></description></item>
        /// <item><description><b>mp3</b></description></item>
        /// <item><description><b>flv</b></description></item>
        /// <item><description><b>mpd</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>By default, streams in all formats are returned.</description></item>
        /// <item><description>The mpd format is returned only when the <c>dash</c> container format is configured in the transcoding template. For more information, refer to <a href="~~52839#title-7rr-3hj-gy5~~">Container: container format</a>.</description></item>
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
        /// <item><description><b>oss</b>: back-to-origin URL.</description></item>
        /// <item><description><b>cdn</b> (default): accelerated URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>The custom playback settings. The value is a JSON string that supports specifying domain name playback settings. For details about parameter construction, refer to <a href="~~86952#section-9g7-s9b-v7z~~">PlayConfig</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If PlayConfig is not set or <c>PlayDomain</c> within it is not set, the operation uses the default domain name configured in ApsaraVideo VOD. If no default domain name is configured, the most recently modified domain name is used as the playback domain name based on reverse chronological order of modification time. To prevent an unexpected domain name from being returned, set a default playback domain name. Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b> &gt; <b>Manage</b> &gt; <b>Domain names that perform origin fetch from this storage address</b> to set the default playback domain name.</description></item>
        /// <item><description>When the <c>EncryptType</c> parameter in PlayConfig is set to <c>AliyunVoDEncryption</c>, the playback URL of the privately encrypted stream is not returned by default to ensure video security. To return the playback URL of the privately encrypted stream, set the <c>ResultType</c> parameter to <c>Multiple</c>.</description></item>
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
        /// <para>The CDN reauthentication parameter. The value is a JSON string. When type A signing is enabled for URL authentication, you can use this parameter to set the <c>uid</c> and <c>rand</c> of the authentication URL. For more information, refer to <a href="https://help.aliyun.com/document_detail/2249352.html">Type A signing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;uid&quot;:&quot;12345&quot;,&quot;rand&quot;:&quot;abckljd&quot;}</para>
        /// </summary>
        [NameInMap("ReAuthInfo")]
        [Validation(Required=false)]
        public string ReAuthInfo { get; set; }

        /// <summary>
        /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. The length is 6 to 64 characters. The ID is unique per user.</para>
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
        /// <para>The media stream type. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b>: video.</description></item>
        /// <item><description><b>audio</b>: audio.</description></item>
        /// </list>
        /// <para>By default, streams of all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// <para>The custom digital watermarking settings.</para>
        /// <list type="bullet">
        /// <item><description>When <c>DigitalWatermarkType</c> is set to <c>TraceMark</c>, pass in this parameter to set the tracing watermark information for the video and return the video stream that contains the watermark information. Only English letters, digits, and Chinese characters are supported. A maximum of 1024 characters are supported.</description></item>
        /// <item><description>When <c>DigitalWatermarkType</c> is set to <c>CopyrightMark</c>, <c>Trace</c> corresponds to the <b>watermark text</b> configured when the watermark template was created. Pass in this parameter to query and return the video stream with the specified watermark text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test mark</para>
        /// </summary>
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        /// <summary>
        /// <para>The audio or video ID. Only a single audio or video ID is supported. You can obtain the ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the audio or video ID.</description></item>
        /// <item><description>When uploading audio or video files by calling the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation, the audio or video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After the audio or video file is uploaded, call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the audio or video ID, which is the value of the VideoId response parameter.</description></item>
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
