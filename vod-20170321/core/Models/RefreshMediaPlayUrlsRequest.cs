// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the definitions of the streams that you want to purge or prefetch. You can specify multiple definitions. Separate multiple definitions with commas (,). If you do not specify this parameter, <b>streams in all definitions are purged or prefetched by default</b>.</para>
        /// <remarks>
        /// <para>The value must be one of the values defined in <b>Definition</b> in <a href="https://help.aliyun.com/document_detail/124671.html">Metric description for media assets</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HD, SD</para>
        /// </summary>
        [NameInMap("Definitions")]
        [Validation(Required=false)]
        public string Definitions { get; set; }

        /// <summary>
        /// <para>The streaming formats that you want to refresh or prefetch. You can specify multiple formats. Separate multiple formats with commas (,). If you do not specify this parameter, <b>streams in all formats are refreshed or prefetched by default</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mp4</b></description></item>
        /// <item><description><b>m3u8</b></description></item>
        /// <item><description><b>mp3</b></description></item>
        /// <item><description><b>flv</b></description></item>
        /// <item><description><b>webm</b></description></item>
        /// <item><description><b>ts</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mp4,m3u8</para>
        /// </summary>
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public string Formats { get; set; }

        /// <summary>
        /// <para>The IDs of the audio or video files that you want to refresh or prefetch. You can specify one or more IDs. Separate multiple IDs with commas (,). You can specify up to 20 IDs.
        /// You can obtain audio or video IDs by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the audio or video ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential, the audio or video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After the audio or video file is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the audio or video ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e4957b658067095869****, a6e49sfgd23p5g9ja7095863****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The result type of the refresh or prefetch task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Single</b> (default): Only the latest transcoded stream for each definition and format is refreshed or prefetched.</description></item>
        /// <item><description><b>Multiple</b>: All transcoded streams for each definition and format are refreshed or prefetched.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>The number of TS file playback URLs to refresh or prefetch for M3U8 streams. Only the first N TS file playback URLs of each M3U8 stream are refreshed or prefetched. Valid values: 1 to 20. <b>Default value: 5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SliceCount")]
        [Validation(Required=false)]
        public int? SliceCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to refresh or prefetch the playback URLs of TS files in M3U8 streams. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): No.</description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SliceFlag")]
        [Validation(Required=false)]
        public bool? SliceFlag { get; set; }

        /// <summary>
        /// <para>The types of the streams that you want to refresh or prefetch. You can specify multiple stream types. Separate multiple stream types with commas (,). If you do not specify this parameter, <b>all stream types are refreshed or prefetched by default</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b>: video.</description></item>
        /// <item><description><b>audio</b>: audio.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Refresh</b>: purge.</description></item>
        /// <item><description><b>Preload</b>: prefetch.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Preload</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string that supports settings such as message callbacks and upload acceleration. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To use message callbacks in this parameter, configure an HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect. For information about how to configure HTTP callbacks in the console, see <a href="https://help.aliyun.com/document_detail/86071.html">Callback settings</a>.</description></item>
        /// <item><description>To use the upload acceleration feature, submit a ticket to activate it. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Upload instructions</a>. For information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D">http://example.aliyundoc.com&quot;}</a>, &quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
