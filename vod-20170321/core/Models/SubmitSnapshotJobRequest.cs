// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of snapshots. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The height of each snapshot. Valid values: <c>[8,4096]</c>. By default, the height of the video source is used. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public string Height { get; set; }

        /// <summary>
        /// <para>The snapshot interval. The value must be <b>greater than or equal to 0</b>.</para>
        /// <list type="bullet">
        /// <item><description>Unit: seconds.</description></item>
        /// <item><description>Default value: <b>1</b>.</description></item>
        /// <item><description>If you set this parameter to <b>0</b>, snapshots are captured at even intervals based on the video duration divided by the value of the Count parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot template.</para>
        /// <list type="bullet">
        /// <item><description>We recommend that you create a snapshot template before you specify the template ID. For more information about how to create a snapshot template, see <a href="https://help.aliyun.com/document_detail/99406.html">AddVodTemplate</a>.</description></item>
        /// <item><description>If you set the SnapshotTemplateId parameter, all the other request parameters except the Action and VideoId parameters are ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f5b228fe693bf55bd87b789****</para>
        /// </summary>
        [NameInMap("SnapshotTemplateId")]
        [Validation(Required=false)]
        public string SnapshotTemplateId { get; set; }

        /// <summary>
        /// <para>The point in time when the first snapshot is captured.</para>
        /// <list type="bullet">
        /// <item><description>Unit: milliseconds.</description></item>
        /// <item><description>Default value: <b>0</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpecifiedOffsetTime")]
        [Validation(Required=false)]
        public long? SpecifiedOffsetTime { get; set; }

        /// <summary>
        /// <para>The playback positions at which you want to capture snapshots. Unit: milliseconds. You can specify up to 30 playback positions in a request.</para>
        /// </summary>
        [NameInMap("SpecifiedOffsetTimes")]
        [Validation(Required=false)]
        public List<long?> SpecifiedOffsetTimes { get; set; }

        /// <summary>
        /// <para>The sprite snapshot configuration. If you set this parameter, sprite snapshots are generated. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">SpriteSnapshotConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;CellWidth\&quot;: 120, \&quot;CellHeight\&quot;: 68, \&quot;Columns\&quot;: 3,\&quot;Lines\&quot;: 10, \&quot;Padding\&quot;: 20, \&quot;Margin\&quot;: 50}</para>
        /// </summary>
        [NameInMap("SpriteSnapshotConfig")]
        [Validation(Required=false)]
        public string SpriteSnapshotConfig { get; set; }

        /// <summary>
        /// <para>The custom configurations including the configuration of transparent data transmission and callback configurations. The value must be a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <para> To use the message callback feature, you must specify an HTTP callback URL and the callback events in the ApsaraVideo VOD console. Otherwise, the callback settings do not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;http://.example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;example&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the video. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>After you upload a video in the ApsaraVideo VOD console, you can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the ID of the video.</description></item>
        /// <item><description>Obtain the video ID from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you called to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the video ID from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you called to query media information after the audio or video file is uploaded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d3e680e618708efbf2cae7cc9312****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        /// <summary>
        /// <para>The width of each snapshot. Valid values: <c>[8,4096]</c>. By default, the width of the video source is used. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public string Width { get; set; }

    }

}
