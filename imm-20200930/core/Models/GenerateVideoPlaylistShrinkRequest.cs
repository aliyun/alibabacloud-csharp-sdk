// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>Leave this parameter empty unless you have special requirements.</b></para>
        /// <para>The China authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The OSS URI of the Master Playlist.</para>
        /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where ${Bucket} is the name of the OSS bucket in the same region as the current project, and ${Object} is the full path of the file with the &quot;.m3u8&quot; extension.</para>
        /// <remarks>
        /// <para>If the playlist has subtitle input or multiple Target outputs, MasterURI is required. The subtitle URI or Target URI must be in the same directory as or a subdirectory of MasterURI.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object/master.m3u8</para>
        /// </summary>
        [NameInMap("MasterURI")]
        [Validation(Required=false)]
        public string MasterURI { get; set; }

        /// <summary>
        /// <para>The message notification configuration. Click Notification for details. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The overwrite policy when the Media Playlist already exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>overwrite (default): Overwrites the existing Media Playlist.</description></item>
        /// <item><description>skip-existing: Skips generation and retains the existing Media Playlist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>overwrite</para>
        /// </summary>
        [NameInMap("OverwritePolicy")]
        [Validation(Required=false)]
        public string OverwritePolicy { get; set; }

        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The duration for generating the playlist. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default) or empty: continues until the end of the source video.</para>
        /// </description></item>
        /// <item><description><para>Greater than 0: continues for the specified duration from the start time of the playlist generation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the time point corresponding to the specified parameter exceeds the end of the source video, the default value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceDuration")]
        [Validation(Required=false)]
        public float? SourceDuration { get; set; }

        /// <summary>
        /// <para>The start time for generating the playlist. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default) or empty: starts from the beginning of the source video.</para>
        /// </description></item>
        /// <item><description><para>Greater than 0: starts from the specified time point in the source video.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can use this parameter together with <b>SourceDuration</b> to generate a playlist for a specific portion of the source video.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceStartTime")]
        [Validation(Required=false)]
        public float? SourceStartTime { get; set; }

        /// <summary>
        /// <para>The list of subtitles to add. Default value: empty. Maximum number of subtitles: 2.</para>
        /// </summary>
        [NameInMap("SourceSubtitles")]
        [Validation(Required=false)]
        public string SourceSubtitlesShrink { get; set; }

        /// <summary>
        /// <para>The OSS URI of the video.</para>
        /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where ${Bucket} is the name of the OSS bucket in the same area (Region) as the current project, and ${Object} is the full path of the file including the file name extension.</para>
        /// <remarks>
        /// <para>Only OSS buckets with Standard storage class are supported.
        /// Buckets with hotlink protection whitelist access settings are not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-source-object/video.mp4</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The OSS object <a href="https://help.aliyun.com/document_detail/106678.html">tags</a> to add to the generated TS files. You can use tags to control the lifecycle of OSS files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The array of just-in-time transcoding playlists. Maximum array length: 6. Each Target corresponds to at most one video Media Playlist and one or more subtitle Media Playlists.</para>
        /// <remarks>
        /// <para>If more than one Target is configured, the <b>MasterURI</b> parameter must not be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public string TargetsShrink { get; set; }

        /// <summary>
        /// <para>The custom information that is returned in asynchronous message notifications, which helps you associate message notifications within your system. Maximum length: 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
