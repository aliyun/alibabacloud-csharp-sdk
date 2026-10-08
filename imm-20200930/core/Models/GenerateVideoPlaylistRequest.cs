// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistRequest : TeaModel {
        /// <summary>
        /// <para><b>Leave this parameter empty unless you have special requirements.</b></para>
        /// <para>The China authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

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
        public Notification Notification { get; set; }

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
        public List<GenerateVideoPlaylistRequestSourceSubtitles> SourceSubtitles { get; set; }
        public class GenerateVideoPlaylistRequestSourceSubtitles : TeaModel {
            /// <summary>
            /// <para>The subtitle language. The standard is ISO 639-2. Default value: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eng</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The OSS URI of the subtitle to embed.</para>
            /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where ${Bucket} is the name of the OSS bucket in the same region as the current project, and ${Object} is the full path of the file.</para>
            /// <remarks>
            /// <para>The <b>MasterURI</b> parameter must not be empty, and the OSS URI <c>oss://${Bucket}/${Object}</c> of the subtitle to embed must be in the same directory as or a subdirectory of the <b>MasterURI</b> parameter.</para>
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
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The array of just-in-time transcoding playlists. Maximum array length: 6. Each Target corresponds to at most one video Media Playlist and one or more subtitle Media Playlists.</para>
        /// <remarks>
        /// <para>If more than one Target is configured, the <b>MasterURI</b> parameter must not be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestTargets> Targets { get; set; }
        public class GenerateVideoPlaylistRequestTargets : TeaModel {
            /// <summary>
            /// <para>The audio processing parameter settings. An empty value (default) indicates that audio processing is disabled and the output TS files do not contain an audio stream.</para>
            /// <remarks>
            /// <para>The Audio and Subtitle fields within the same Target are mutually exclusive. If the Audio field is set, the Subtitle field is ignored. Audio and Video can be set simultaneously, where Audio represents the audio information in the output video. You can also set only Audio to generate audio-only output.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <para>The HLS segment container type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ts (default)</para>
            /// </description></item>
            /// <item><description><para>mp4</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ts</para>
            /// </summary>
            [NameInMap("Container")]
            [Validation(Required=false)]
            public string Container { get; set; }

            /// <summary>
            /// <para>The playback duration of a single TS file. Unit: seconds. Default value: 10. Valid values: [5, 15].</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The array of initial transcoding TS file durations. Maximum array length: 6. Default value: empty. This parameter is independent of the <b>Duration</b> parameter.</para>
            /// </summary>
            [NameInMap("InitialSegments")]
            [Validation(Required=false)]
            public List<float?> InitialSegments { get; set; }

            /// <summary>
            /// <para>The initial transcoding duration. Unit: seconds. Default value: 30.</para>
            /// <list type="bullet">
            /// <item><description>If the value is 0, no pre-transcoding is performed.</description></item>
            /// <item><description>If the value is less than 0 or exceeds the source video length, the entire video is initially transcoded.</description></item>
            /// <item><description>If the specified duration falls in the middle of a TS file, transcoding continues until the end of that TS file.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is mainly used to reduce the wait time for initial video playback and improve the playback experience. If you want to replace traditional VOD business scenarios, try initially transcoding the entire video.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("InitialTranscode")]
            [Validation(Required=false)]
            public float? InitialTranscode { get; set; }

            /// <summary>
            /// <para>The subtitle processing parameter settings.</para>
            /// <remarks>
            /// <para>The Subtitle field is mutually exclusive with the Video or Audio fields within the same Target. Subtitles are generated only when Subtitle is set alone.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            /// <summary>
            /// <para>The OSS object <a href="https://help.aliyun.com/document_detail/106678.html">tags</a> to add to the generated TS files. You can use OSS tags to control the lifecycle of OSS files.</para>
            /// <remarks>
            /// <para>The tag values at this level are merged with the Tags defined at the parent level to form the tag values for the current Target. If a tag with the same name exists, the value at this level takes precedence.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

            /// <summary>
            /// <para>The number of TS files to transcode ahead when just-in-time transcoding is triggered. By default, 2 minutes of video is transcoded ahead.</para>
            /// <list type="bullet">
            /// <item><description>Example: If <b>Duration</b> is 10, the default value of <b>TranscodeAhead</b> is 12. You can specify this parameter to control the number of asynchronous ahead-of-time transcoding files. Valid values: [10, 30].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TranscodeAhead")]
            [Validation(Required=false)]
            public int? TranscodeAhead { get; set; }

            /// <summary>
            /// <para>The OSS URI prefix of the just-in-time transcoding output files, including M3U8 files and TS files.</para>
            /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where ${Bucket} is the name of the OSS bucket in the same region as the current project, and ${Object} is the full path prefix of the file without the file name extension.</para>
            /// <list type="bullet">
            /// <item><description>Example: If URI is oss://test-bucket/test-object/output-video, an oss://test-bucket/test-object/output-video.m3u8 file and multiple oss://test-bucket/test-object/output-video-${token}-${index}.ts files are generated. ${token} is a unique character string generated based on the transcoding parameters and is included in the API response. ${index} is the ordinal number of the TS file starting from 0.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the <b>MasterURI</b> parameter is not empty, the URI must be in the same directory as or a subdirectory of the <b>MasterURI</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object/output-video</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>The video processing parameter settings. An empty value (default) indicates that video processing is disabled and the output TS files do not contain a video stream.</para>
            /// <remarks>
            /// <para>The Video and Subtitle fields within the same Target are mutually exclusive. If the Video field is set, the Subtitle field is ignored.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

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
