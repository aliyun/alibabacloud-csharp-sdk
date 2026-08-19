// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitSnapshotJobShrinkRequest : TeaModel {
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
        /// <para>The snapshot height. Valid values: <c>[8,4096]</c>. Default value: the source video height. Unit: px.</para>
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
        /// <item><description>If Interval is set to <b>0</b>, snapshots are evenly captured based on the value of Count and the video duration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. Length: 6 to 64 characters. The value must be unique at the user level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The snapshot template ID.</para>
        /// <list type="bullet">
        /// <item><description>We recommend that you create a snapshot template first and then pass the snapshot template ID. For more information about how to create a snapshot template, see <a href="https://help.aliyun.com/document_detail/99406.html">Add a snapshot template</a>.</description></item>
        /// <item><description>If you pass the snapshot template ID, all request parameters except Action and VideoId are ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f5b228fe693bf55bd87b789****</para>
        /// </summary>
        [NameInMap("SnapshotTemplateId")]
        [Validation(Required=false)]
        public string SnapshotTemplateId { get; set; }

        /// <summary>
        /// <para>The start time for the snapshot.</para>
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
        /// <para>The points in time at which snapshots are captured. Unit: milliseconds. You can specify up to 30 points in time at a time.</para>
        /// </summary>
        [NameInMap("SpecifiedOffsetTimes")]
        [Validation(Required=false)]
        public string SpecifiedOffsetTimesShrink { get; set; }

        /// <summary>
        /// <para>The sprite configuration. If this parameter is not empty, a sprite is generated. For more information about the parameter structure, see <a href="https://help.aliyun.com/document_detail/86952.html">SpriteSnapshotConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;CellWidth\&quot;: 120, \&quot;CellHeight\&quot;: 68, \&quot;Columns\&quot;: 3,\&quot;Lines\&quot;: 10, \&quot;Padding\&quot;: 20, \&quot;Margin\&quot;: 50}</para>
        /// </summary>
        [NameInMap("SpriteSnapshotConfig")]
        [Validation(Required=false)]
        public string SpriteSnapshotConfig { get; set; }

        /// <summary>
        /// <para>The custom settings. Only JSON strings are supported. You can use this parameter to pass through custom data and specify callback URL settings. For more information about the parameter structure, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <para>To use the message callback in this parameter, configure the HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;http://.example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;example&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The video ID. You can obtain the video ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the video ID from the value of the VideoId response parameter when you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential.</description></item>
        /// <item><description>After the video is uploaded, call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the video ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d3e680e618708efbf2cae7cc9312****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        /// <summary>
        /// <para>The snapshot width. Valid values: <c>[8,4096]</c>. Default value: the source video width. Unit: px.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public string Width { get; set; }

    }

}
