// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the resolutions of the media streams you want to refresh or prefetch. You can specify multiple resolutions. Separate multiple resolutions with commas (,). If you leave this parameter empty, media streams in all resolutions are refreshed or prefetched by default.</para>
        /// <remarks>
        /// <para> The value must be supported in the <b>Definition</b> section in <a href="https://help.aliyun.com/document_detail/124671.html">Parameters for media assets</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HD, SD</para>
        /// </summary>
        [NameInMap("Definitions")]
        [Validation(Required=false)]
        public string Definitions { get; set; }

        /// <summary>
        /// <para>The formats of the media streams you want to refresh or prefetch. You can specify multiple formats. Separate multiple formats with commas (,). If you leave this parameter empty, media streams in all formats are refreshed or prefetched by default. Valid values:</para>
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
        /// <para>The IDs of the media files that you want to refresh or prefetch. You can specify a maximum of 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to upload media files.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you call to query the media ID after the media file is uploaded.</description></item>
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
        /// <para>Specifies the type of the refresh or prefetch operation. Default value: Single. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Single</b>: Only one latest transcoded stream is refreshed or prefetched for each resolution and format.</description></item>
        /// <item><description><b>Multiple</b>: All transcoded streams are refreshed or prefetched for each resolution and format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>Specifies the number of the playback URLs of the TS files for the M3U8 media stream you want to refresh or prefetch. After you set this parameter, only the playback URLs of the first N TS files will be refreshed or prefetched. Valid values: 1 to 20. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SliceCount")]
        [Validation(Required=false)]
        public int? SliceCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to refresh or prefetch the playback URLs of the TS files of the M3U8 media stream. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SliceFlag")]
        [Validation(Required=false)]
        public bool? SliceFlag { get; set; }

        /// <summary>
        /// <para>Specifies the types of media streams you want to refresh or prefetch. You can specify multiple types. Separate multiple types with commas (,). If you leave this parameter empty, media streams in all types are refreshed or prefetched by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b></description></item>
        /// <item><description><b>audio</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// <para>The type of the task that you want to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Refresh</b></description></item>
        /// <item><description><b>Preload</b></description></item>
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
        /// <para>The custom configurations such as callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see the &quot;UserData: specifies the custom configurations for media upload&quot; section in the <a href="https://help.aliyun.com/document_detail/86952.html">Request parameter</a> topic.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see <a href="https://help.aliyun.com/document_detail/86071.html">Configure callback settings</a>.</description></item>
        /// <item><description>To enable the upload acceleration feature, submit a ticket. For more information, see <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>. For more information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</description></item>
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
