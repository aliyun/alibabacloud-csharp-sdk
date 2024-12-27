// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistRequest : TeaModel {
        /// <summary>
        /// <para><b>If you do not have special requirements, leave this parameter empty.</b></para>
        /// <para>The authorization chain settings. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

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
        public Notification Notification { get; set; }

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
        public List<GenerateVideoPlaylistRequestSourceSubtitles> SourceSubtitles { get; set; }
        public class GenerateVideoPlaylistRequestSourceSubtitles : TeaModel {
            /// <summary>
            /// <para>The subtitle language. If you configure this parameter, the value must comply with the ISO 639-2 standard. By default, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eng</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The OSS path of the subtitle file.</para>
            /// <para>The OSS path must be in the oss://${Bucket}/${Object} format. ${Bucket} specifies the name of the OSS bucket that is in the same region as the current project. ${Object} specifies the full path of the file.</para>
            /// <remarks>
            /// <para> The <b>MasterURI</b> parameter cannot be left empty, and the OSS path <c>oss://${Bucket}/${Object}</c> of a subtitle file must be in the directory specified by the <b>MasterURI</b> parameter or its subdirectory.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object/subtitle/eng.vtt</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

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
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The live transcoding playlists. Up to 6 playlists are supported. Each output corresponds to at most one video media playlist and one or more subtitle media playlists.</para>
        /// <remarks>
        /// <para> If more than one output is configured, the <b>MasterURI</b> parameter is required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestTargets> Targets { get; set; }
        public class GenerateVideoPlaylistRequestTargets : TeaModel {
            /// <summary>
            /// <para>The audio processing configuration. If you set this parameter to null (default), audio processing is disabled. The generated TS files do not contain audio streams.</para>
            /// <remarks>
            /// <para> The Audio and Subtitle parameters in the same output are mutually exclusive. If the Audio parameter is configured, the Subtitle parameter is ignored. The Audio and Video parameters can be configured at the same time. You can also configure only the Audio parameter to generate only audio information.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <para>The playback duration of a single TS file. Unit: seconds. Default value: 10. Valid values: 5 to 15.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The array of the durations of the pre-transcoded TS files. The array can contain the durations of up to six pre-transcoded TS files. By default, this parameter is left empty. This parameter is independent of the <b>Duration</b> parameter.</para>
            /// </summary>
            [NameInMap("InitialSegments")]
            [Validation(Required=false)]
            public List<float?> InitialSegments { get; set; }

            /// <summary>
            /// <para>The pre-transcoding duration. Unit: seconds. Default value: 30.</para>
            /// <list type="bullet">
            /// <item><description>If you set this parameter to 0, pre-transcoding is disabled.</description></item>
            /// <item><description>If you set this parameter to a value that is less than 0 or greater than the duration of a source video, the entire video is pre-transcoded.</description></item>
            /// <item><description>If you set this parameter to a value that is within the middle of the playback duration of a TS file, the transcoding continues until the end of the playback duration.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is used to reduce the time spent in waiting for the initial playback of a video and improve the playback experience. If you want to replace the traditional video on demand (VOD) business scenario, you can try to pre-transcode the entire video.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30.0</para>
            /// </summary>
            [NameInMap("InitialTranscode")]
            [Validation(Required=false)]
            public float? InitialTranscode { get; set; }

            /// <summary>
            /// <para>The subtitle processing configuration.</para>
            /// <remarks>
            /// <para> The Subtitle and Video or Audio parameters in the same output are mutually exclusive. You must configure the Subtitle parameter independently to generate subtitles.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            /// <summary>
            /// <para>The <a href="https://help.aliyun.com/document_detail/106678.html">tags</a> that you want to add to a TS file in OSS. You can use tags to manage the lifecycles of TS files in OSS.</para>
            /// <remarks>
            /// <para> The combination of the value of the Tags parameter and the value of the Tags parameter in the upper level is used as the tag value of the current output. If the value of the Tags parameter in the current level is the same as the value of the Tags parameter in the upper level, use the value of the Tags parameter in the current level.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

            /// <summary>
            /// <para>The number of TS files that are pre-transcoded when the live transcoding is triggered. By default, a 2-minute video is pre-transcoded.</para>
            /// <list type="bullet">
            /// <item><description>Example: If you set the <b>Duration</b> parameter to 10, the value of the <b>TranscodeAhead</b> parameter is 12 by default. You can configure this parameter to manage the number of pre-transcoded files in an asynchronous manner. Valid values: 10 to 30.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TranscodeAhead")]
            [Validation(Required=false)]
            public int? TranscodeAhead { get; set; }

            /// <summary>
            /// <para>The prefix of the OSS path that is used to store the live transcoding files. The live transcoding files include a M3U8 file and multiple TS files.</para>
            /// <para>The OSS path must be in the oss://${Bucket}/${Object} format. ${Bucket} specifies the name of the OSS bucket that is in the same region as the current project. ${Object} specifies the prefix of the full path of the file that does not contain the file name extension.</para>
            /// <list type="bullet">
            /// <item><description>Example: If the URI is oss://test-bucket/test-object/output-video, the output-video.m3u8 file and multiple output-video-${token}-${index}.ts files are generated in the oss://test-bucket/test-object/ directory. ${token} is a unique string generated based on the transcoding parameters. The ${token} parameter is included in the response of the operation. ${index} is the serial number of the generated TS files that are numbered starting from 0.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the <b>MasterURI</b> parameter is not left empty, the URI specified by this parameter must be in the directory specified by the <b>MasterURI</b> parameter or its subdirectory.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>oss://imm-test/testcases/video</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>The video processing configuration. If you set this parameter to null (default), video processing is disabled. The generated TS files do not contain video streams.</para>
            /// <remarks>
            /// <para> The Video and Subtitle parameters in the same output are mutually exclusive. If the Video parameter is configured, the Subtitle parameter is ignored.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

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
