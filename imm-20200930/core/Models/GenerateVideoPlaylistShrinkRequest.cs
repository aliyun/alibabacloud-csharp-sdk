// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>If you do not have special requirements, leave this parameter empty.</b></para>
        /// <para>The authorization chain settings. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The OSS path of the master playlist.</para>
        /// <para>The OSS path must be in the oss://${Bucket}/${Object} format. ${Bucket} specifies the name of the OSS bucket that is in the same region as the current project. ${Object} specifies the full path of the file that is suffixed with .m3u8.</para>
        /// <remarks>
        /// <para> If a playlist contains subtitles or multiple outputs, the MasterURI parameter is required and the URI of subtitle files or outputs must be in the directory specified by the MasterURI parameter or its subdirectory.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/object/master.m3u8</para>
        /// </summary>
        [NameInMap("MasterURI")]
        [Validation(Required=false)]
        public string MasterURI { get; set; }

        /// <summary>
        /// <para>The notification settings. To view details, click Notification. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The overwrite policy when the media playlist exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>overwrite (default): overwrites an existing media playlist.</description></item>
        /// <item><description>skip-existing: skips generation and retains the existing media playlist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>overwrite</para>
        /// </summary>
        [NameInMap("OverwritePolicy")]
        [Validation(Required=false)]
        public string OverwritePolicy { get; set; }

        /// <summary>
        /// <para>The project name.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The period of time during which the playlist is generated. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to 0 (default) or leave this parameter empty, a playlist is generated until the end time of the source video.</description></item>
        /// <item><description>If you set this parameter to a value greater than 0, a playlist is generated for the specified period of time from the start time that you specify.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to a value that exceeds the end time of a source video, use the default value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceDuration")]
        [Validation(Required=false)]
        public float? SourceDuration { get; set; }

        /// <summary>
        /// <para>The time when the playlist starts to generate. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to 0 (default) or leave this parameter empty, the start time of the source video is used as the time when a playlist starts to generate.</description></item>
        /// <item><description>If you set this parameter to a value greater than 0, the time when a playlist starts to generate is the specified point in time.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you use this parameter together with the <b>SourceDuration</b> parameter, a playlist can be generated based on the partial content of a source video.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceStartTime")]
        [Validation(Required=false)]
        public float? SourceStartTime { get; set; }

        /// <summary>
        /// <para>The subtitle files. By default, this parameter is left empty. Up to two subtitle files are supported.</para>
        /// </summary>
        [NameInMap("SourceSubtitles")]
        [Validation(Required=false)]
        public string SourceSubtitlesShrink { get; set; }

        /// <summary>
        /// <para>The OSS path of the video file.</para>
        /// <para>The OSS path must be in the oss://${Bucket}/${Object} format. ${Bucket} specifies the name of the OSS bucket that is in the same region as the current project. ${Object} specifies the full path of the file that contains the file name extension.</para>
        /// <remarks>
        /// <para> Only OSS buckets of the Standard storage class are supported. OSS buckets for which hotlink protection whitelists are configured are not supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/testcases/video.mp4</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/106678.html">tags</a> that you want to add to a TS file in OSS. You can use tags to manage the lifecycles of TS files in OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The live transcoding playlists. Up to 6 playlists are supported. Each output corresponds to at most one video media playlist and one or more subtitle media playlists.</para>
        /// <remarks>
        /// <para> If more than one output is configured, the <b>MasterURI</b> parameter is required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public string TargetsShrink { get; set; }

        /// <summary>
        /// <para>The custom user information, which is returned in asynchronous notifications to help you handle the notifications in the system. The maximum length of a notification is 2048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
