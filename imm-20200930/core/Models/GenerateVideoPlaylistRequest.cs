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
        /// <para>The chained authorization configuration. This parameter is not required. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The OSS URI of the Master Playlist.</para>
        /// <para>The OSS URI must be in the format of oss\://${Bucket}/${Object}. ${Bucket} is the name of the OSS bucket that is in the same region as the current project. ${Object} is the full path of the file with the .m3u8 file name extension.</para>
        /// <remarks>
        /// <para>If the playlist has subtitle inputs or multiple target outputs, MasterURI is required. The subtitle URI or target URI must be in the same directory as or a subdirectory of the directory specified by MasterURI.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object/master.m3u8</para>
        /// </summary>
        [NameInMap("MasterURI")]
        [Validation(Required=false)]
        public string MasterURI { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For more information, click Notification. For more information about the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The policy to overwrite an existing Media Playlist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>overwrite (default): Overwrites the existing Media Playlist.</para>
        /// </description></item>
        /// <item><description><para>skip-existing: Skips the generation and retains the existing Media Playlist.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>overwrite</para>
        /// </summary>
        [NameInMap("OverwritePolicy")]
        [Validation(Required=false)]
        public string OverwritePolicy { get; set; }

        /// <summary>
        /// <para>The project name. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The duration for which the playlist is generated. Unit: seconds (s). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default) or empty: continues to the end of the source video.</para>
        /// </description></item>
        /// <item><description><para>Greater than 0: lasts for the specified duration from the start time.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the specified duration extends beyond the end of the source video, the default value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceDuration")]
        [Validation(Required=false)]
        public float? SourceDuration { get; set; }

        /// <summary>
        /// <para>The start time for generating the playlist. Unit: seconds (s). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 (default) or empty: starts from the beginning of the source video.</para>
        /// </description></item>
        /// <item><description><para>Greater than 0: starts from the specified time point in the source video.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can set this parameter together with the <b>SourceDuration</b> parameter to generate a playlist for a specific part of the source video.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceStartTime")]
        [Validation(Required=false)]
        public float? SourceStartTime { get; set; }

        /// <summary>
        /// <para>The list of subtitles to add. The default value is empty. You can add up to two subtitles.</para>
        /// </summary>
        [NameInMap("SourceSubtitles")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestSourceSubtitles> SourceSubtitles { get; set; }
        public class GenerateVideoPlaylistRequestSourceSubtitles : TeaModel {
            /// <summary>
            /// <para>The language of the subtitle. The value must comply with the ISO 639-2 standard. The default value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eng</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The OSS URI of the subtitle file to embed.</para>
            /// <para>The OSS URI must be in the format of oss\://${Bucket}/${Object}. ${Bucket} is the name of the OSS bucket that is in the same region as the current project. ${Object} is the full path of the file.</para>
            /// <remarks>
            /// <para>The <b>MasterURI</b> parameter must not be empty. The OSS URI of the subtitle file to embed, <c>oss://${Bucket}/${Object}</c>, must be in the same directory as or a subdirectory of the directory specified by <b>MasterURI</b>.</para>
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
        /// <para>The OSS URI must be in the format of oss\://${Bucket}/${Object}. ${Bucket} is the name of the OSS bucket that is in the same region as the current project. ${Object} is the full path of the file, including the file name extension.</para>
        /// <remarks>
        /// <para>Only OSS Standard storage buckets are supported. Buckets with hotlink protection whitelists are not supported.</para>
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
        /// <para>Adds OSS object <a href="https://help.aliyun.com/document_detail/106678.html">tags</a> to the generated TS files. You can use tags to control the lifecycle of OSS files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;value1&quot;, &quot;key2&quot;: &quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>An array of live transcoding playlists. The maximum array length is 6. Each target corresponds to a maximum of one video Media Playlist and one or more subtitle Media Playlists.</para>
        /// <remarks>
        /// <para>If you configure more than one target, the <b>MasterURI</b> parameter must not be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestTargets> Targets { get; set; }
        public class GenerateVideoPlaylistRequestTargets : TeaModel {
            /// <summary>
            /// <para>The parameter settings for audio processing. An empty value (default) disables audio processing. The output TS file will not contain an audio stream.</para>
            /// <remarks>
            /// <para>The Audio and Subtitle fields within the same target are mutually exclusive. If the Audio field is set, the Subtitle field is ignored. You can set both Audio and Video. Audio specifies the audio information in the output video. You can also set only Audio to generate only audio information.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            /// <summary>
            /// <para>The playback duration of a single TS file. Unit: seconds (s). Default value: 10. Value range: [5, 15].</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>An array of durations for the initial transcoded TS files. The maximum array length is 6. The default value is empty. This parameter is independent of the <b>Duration</b> parameter.</para>
            /// </summary>
            [NameInMap("InitialSegments")]
            [Validation(Required=false)]
            public List<float?> InitialSegments { get; set; }

            /// <summary>
            /// <para>The initial transcoding duration. Unit: seconds (s). Default value: 30.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set this parameter to 0, pre-transcoding is not performed.</para>
            /// </description></item>
            /// <item><description><para>If you set this parameter to a value less than 0 or a value that exceeds the source video length, the entire video is initially transcoded.</para>
            /// </description></item>
            /// <item><description><para>If the specified duration ends in the middle of a TS file, transcoding continues to the end of that TS file.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is mainly used to reduce the waiting time for the first playback and improve the user experience. To replace a traditional VOD scenario, you can try initially transcoding the entire video.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("InitialTranscode")]
            [Validation(Required=false)]
            public float? InitialTranscode { get; set; }

            /// <summary>
            /// <para>The parameter settings for subtitle processing.</para>
            /// <remarks>
            /// <para>The Subtitle field is mutually exclusive with the Video and Audio fields within the same target. Subtitles can be generated only when the Subtitle field is set independently.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            /// <summary>
            /// <para>Adds OSS object <a href="https://help.aliyun.com/document_detail/106678.html">tags</a> to the generated TS files. You can use OSS tags to control the lifecycle of OSS files.</para>
            /// <remarks>
            /// <para>The tags for the current target are the union of the tags defined at this level and the tags defined at the parent level. If a tag has the same name, the value at the current level is used.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

            /// <summary>
            /// <para>The number of TS files to transcode ahead when live transcoding is triggered. By default, 2 minutes of video is transcoded ahead.</para>
            /// <list type="bullet">
            /// <item><description>Example: If <b>Duration</b> is 10, the default value of <b>TranscodeAhead</b> is 12. You can specify this parameter to control the number of asynchronous forward transcodes. The value must be in the range of [10, 30].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TranscodeAhead")]
            [Validation(Required=false)]
            public int? TranscodeAhead { get; set; }

            /// <summary>
            /// <para>The OSS URI prefix for the output files of live transcoding. The output files include M3U8 files and TS files.</para>
            /// <para>The OSS URI must be in the format of oss\://${Bucket}/${Object}. ${Bucket} is the name of the OSS bucket that is in the same region as the current project. ${Object} is the prefix of the full path of the file, without the file name extension.</para>
            /// <list type="bullet">
            /// <item><description>Example: If URI is oss\://test-bucket/test-object/output-video, one oss\://test-bucket/test-object/output-video.m3u8 file and multiple oss\://test-bucket/test-object/output-video-${token}-${index}.ts files are generated. ${token} is a unique string generated based on the transcoding parameters and is included in the API response. ${index} is the sequence number of the generated TS file, starting from 0.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the <b>MasterURI</b> parameter is not empty, the URI must be in the same directory as or a subdirectory of the directory specified by <b>MasterURI</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object/output-video</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>The parameter settings for video processing. An empty value (default) disables video processing. The output TS file will not contain a video stream.</para>
            /// <remarks>
            /// <para>The Video and Subtitle fields within the same target are mutually exclusive. If the Video field is set, the Subtitle field is ignored.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

        /// <summary>
        /// <para>The custom information. This information is returned in the asynchronous notification message to help you associate the message with your services. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
