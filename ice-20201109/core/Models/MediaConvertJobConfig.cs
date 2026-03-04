// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJobConfig : TeaModel {
        /// <summary>
        /// <para>Inputs.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<MediaConvertJobConfigInputs> Inputs { get; set; }
        public class MediaConvertJobConfigInputs : TeaModel {
            /// <summary>
            /// <para>The input file.</para>
            /// </summary>
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public MediaConvertJobConfigInputsInputFile InputFile { get; set; }
            public class MediaConvertJobConfigInputsInputFile : TeaModel {
                /// <summary>
                /// <para>The URL or ID of the media file.</para>
                /// <list type="bullet">
                /// <item><description>If Type is OSS, this is the file URL (OSS or HTTP). Do not use a signed URL, as it may cause authentication failure.</description></item>
                /// <item><description>If Type is Media, this is the media asset ID. The source stream is used by default.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://bucket.loction.aliyuncs.com/path/to/video.mp4">http://bucket.loction.aliyuncs.com/path/to/video.mp4</a></para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the media file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: an OSS object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the input file. InputRef can reference it in the output configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InputVideo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The task name.</para>
        /// <list type="bullet">
        /// <item><description>Maximum length: 64 bytes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>An array of output group configurations.</para>
        /// </summary>
        [NameInMap("OutputGroups")]
        [Validation(Required=false)]
        public List<MediaConvertJobConfigOutputGroups> OutputGroups { get; set; }
        public class MediaConvertJobConfigOutputGroups : TeaModel {
            /// <summary>
            /// <para>The configuration for this output group.</para>
            /// </summary>
            [NameInMap("GroupConfig")]
            [Validation(Required=false)]
            public MediaConvertJobConfigOutputGroupsGroupConfig GroupConfig { get; set; }
            public class MediaConvertJobConfigOutputGroupsGroupConfig : TeaModel {
                /// <summary>
                /// <para>Configures an extension to an existing manifest file. This allows you to reference an existing manifest and combine it with the results of the current output group to generate a new manifest.</para>
                /// </summary>
                [NameInMap("ManifestExtend")]
                [Validation(Required=false)]
                public MediaConvertJobConfigOutputGroupsGroupConfigManifestExtend ManifestExtend { get; set; }
                public class MediaConvertJobConfigOutputGroupsGroupConfigManifestExtend : TeaModel {
                    /// <summary>
                    /// <para>Specifies streams to exclude from the referenced manifest. Multiple conditions within a single exclusion object are combined using AND logic. Multiple exclusion objects in the array are combined using OR logic.</para>
                    /// </summary>
                    [NameInMap("Excludes")]
                    [Validation(Required=false)]
                    public List<MediaConvertJobConfigOutputGroupsGroupConfigManifestExtendExcludes> Excludes { get; set; }
                    public class MediaConvertJobConfigOutputGroupsGroupConfigManifestExtendExcludes : TeaModel {
                        /// <summary>
                        /// <para>Excludes streams based on their Language field. It must conform to RFC 5646.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>en</para>
                        /// </summary>
                        [NameInMap("Language")]
                        [Validation(Required=false)]
                        public string Language { get; set; }

                        /// <summary>
                        /// <para>Excludes streams based on their Name field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>audio-1</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Excludes streams based on their Type field.</para>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Audio</description></item>
                        /// <item><description>Subtitle</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Audio</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>References the Name of an input that contains the manifest to be extended.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Input-Manifest</para>
                    /// </summary>
                    [NameInMap("InputRef")]
                    [Validation(Required=false)]
                    public string InputRef { get; set; }

                }

                /// <summary>
                /// <para>The name of the manifest file. This parameter is only applicable when Type is set to Hls or Dash.</para>
                /// 
                /// <b>Example:</b>
                /// <para>manifest</para>
                /// </summary>
                [NameInMap("ManifestName")]
                [Validation(Required=false)]
                public string ManifestName { get; set; }

                /// <summary>
                /// <para>The base output directory. All files generated by this OutputGroup are placed in this directory.</para>
                /// </summary>
                [NameInMap("OutputFileBase")]
                [Validation(Required=false)]
                public MediaConvertJobConfigOutputGroupsGroupConfigOutputFileBase OutputFileBase { get; set; }
                public class MediaConvertJobConfigOutputGroupsGroupConfigOutputFileBase : TeaModel {
                    /// <summary>
                    /// <para>The media asset location.</para>
                    /// <list type="bullet">
                    /// <item><description>If Type is OSS, this is the destination URL (OSS or HTTP).</description></item>
                    /// <item><description>If Type is Media, this is the destination media asset ID.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/dir</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// <para>The type of the output file. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>OSS: an OSS object.</description></item>
                    /// <item><description>Media: a media asset.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The type of the output group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>File: An individual file.</description></item>
                /// <item><description>Hls: HLS files for adaptive bitrate streaming.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Hls</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the output group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hls-group</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A list of individual output stream configurations. Each object in this array defines a specific rendition.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<MediaConvertJobConfigOutputGroupsOutputs> Outputs { get; set; }
            public class MediaConvertJobConfigOutputGroupsOutputs : TeaModel {
                /// <summary>
                /// <para>Additional feature parameters. See <a href="https://help.aliyun.com/document_detail/2979993.html">MediaConvertJobFeature</a> for details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Features")]
                [Validation(Required=false)]
                public string Features { get; set; }

                /// <summary>
                /// <para>HLS-specific settings for this stream\&quot;s behavior in the manifest. Effective only when the group Type is Hls.</para>
                /// </summary>
                [NameInMap("HlsGroupConfig")]
                [Validation(Required=false)]
                public MediaConvertJobConfigOutputGroupsOutputsHlsGroupConfig HlsGroupConfig { get; set; }
                public class MediaConvertJobConfigOutputGroupsOutputsHlsGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The audio group this video stream references. Effective when Type is video.</para>
                    /// <para>Default value: audio.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audio</para>
                    /// </summary>
                    [NameInMap("AudioGroup")]
                    [Validation(Required=false)]
                    public string AudioGroup { get; set; }

                    /// <summary>
                    /// <para>Whether this stream should be automatically selected by the player. Effective when Type is audio or subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AutoSelect")]
                    [Validation(Required=false)]
                    public string AutoSelect { get; set; }

                    /// <summary>
                    /// <para>Whether this stream must be played. Effective when Type is audio or subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Forced")]
                    [Validation(Required=false)]
                    public string Forced { get; set; }

                    /// <summary>
                    /// <para>The GROUP-ID attribute for this stream in the HLS manifest. Effective when Type is audio or subtitle.</para>
                    /// <para>Default value: Same as the Type value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audio</para>
                    /// </summary>
                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    /// <summary>
                    /// <para>Whether this is the default stream within its group. Effective when Type is audio or subtitle. Only one stream per group can be the default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public string IsDefault { get; set; }

                    /// <summary>
                    /// <para>The LANGUAGE attribute for this stream in the HLS manifest (must conform to RFC 5646). Effective when Type is audio or subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zh</para>
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// <para>The NAME attribute for this stream in the HLS manifest. <b>Required</b> when Type is audio or subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The subtitle group this video or hybrid stream references. Effective when Type is video or hybrid.</para>
                    /// <para>Default value: subtitle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subtitle</para>
                    /// </summary>
                    [NameInMap("SubtitleGroup")]
                    [Validation(Required=false)]
                    public string SubtitleGroup { get; set; }

                    /// <summary>
                    /// <para>Specifies the stream type.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>video: Video stream.</description></item>
                    /// <item><description>audio: Audio stream.</description></item>
                    /// <item><description>subtitle: Subtitle stream.</description></item>
                    /// <item><description>hybrid: A stream containing both audio and video.</description></item>
                    /// </list>
                    /// <para>Default value: hybrid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hybrid</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>A name to label this output. This is for identification purposes only and does not affect the filename.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group-output</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The filename for this output. It is used in conjunction with OutputFileBase from the GroupConfig.</para>
                /// 
                /// <b>Example:</b>
                /// <para>720p.mp4</para>
                /// </summary>
                [NameInMap("OutputFileName")]
                [Validation(Required=false)]
                public string OutputFileName { get; set; }

                /// <summary>
                /// <para>A JSON string of parameters to override the settings in the specified template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("OverrideParams")]
                [Validation(Required=false)]
                public string OverrideParams { get; set; }

                /// <summary>
                /// <para>The priority of the task, from 1 to 10. A higher value indicates a higher priority. Default: 6.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>96e8864746a0b6f3</b></b></para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

        }

    }

}
