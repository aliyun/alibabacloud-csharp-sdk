// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6730AC93-7B12-4B*****7F-49EE1FE8BC49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transcoding template group data.</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroup")]
        [Validation(Required=false)]
        public GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup TranscodeTemplateGroup { get; set; }
        public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the template group was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-12T10:20:51Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the template group is the default one. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: The template group is the default one.</description></item>
            /// <item><description><b>NotDefault</b>: The template group is not the default one.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotDefault</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>Indicates whether the template group is locked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Disabled</b>: Not locked.</description></item>
            /// <item><description><b>Enabled</b>: Locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            /// <summary>
            /// <para>The time when the template group was last modified. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-12T11:20:51Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The transcoding template group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a59b11f697c716*****6ae1502142d0</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// <para>The list of transcoding template configurations.</para>
            /// </summary>
            [NameInMap("TranscodeTemplateList")]
            [Validation(Required=false)]
            public List<GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList> TranscodeTemplateList { get; set; }
            public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList : TeaModel {
                /// <summary>
                /// <para>The audio stream transcoding configuration parameters (JSON string).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Remove&quot;:&quot;false&quot;,&quot;Bitrate&quot;:&quot;44&quot;,&quot;Samplerate&quot;:&quot;32000&quot;,&quot;Channels&quot;:&quot;2&quot;,&quot;Profile&quot;:&quot;aac_low&quot;}</para>
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public string Audio { get; set; }

                /// <summary>
                /// <para>The video clipping configuration (JSON string). For example, set this parameter if you want to extract 5 seconds of content from a video to generate a new video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;TimeSpan&quot;:{&quot;Seek&quot;:&quot;1&quot;,&quot;Duration&quot;:&quot;5&quot;}</para>
                /// </summary>
                [NameInMap("Clip")]
                [Validation(Required=false)]
                public string Clip { get; set; }

                /// <summary>
                /// <para>The container format for encapsulating audio and video streams (JSON string).</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Format&quot;:&quot;m3u8&quot;</para>
                /// </summary>
                [NameInMap("Container")]
                [Validation(Required=false)]
                public string Container { get; set; }

                /// <summary>
                /// <para>The copyright watermark information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                /// &quot;Content&quot;: &quot;Test copyright watermark text&quot;
                /// }</para>
                /// </summary>
                [NameInMap("CopyrightMark")]
                [Validation(Required=false)]
                public string CopyrightMark { get; set; }

                /// <summary>
                /// <para>The definition mark for normal transcoding templates:</para>
                /// <list type="bullet">
                /// <item><description><b>LD</b> (low definition)</description></item>
                /// <item><description><b>SD</b> (standard definition)</description></item>
                /// <item><description><b>HD</b> (high definition)</description></item>
                /// <item><description><b>FHD</b> (full high definition)</description></item>
                /// <item><description><b>OD</b> (original definition, container format conversion)</description></item>
                /// <item><description><b>2K</b></description></item>
                /// <item><description><b>4K</b></description></item>
                /// <item><description><b>SQ</b> (standard audio quality)</description></item>
                /// <item><description><b>HQ</b> (high audio quality)</description></item>
                /// </list>
                /// <para>The definition mark for Narrowband HD 1.0 built-in transcoding templates:</para>
                /// <list type="bullet">
                /// <item><description><b>LD-NBV1</b> (low definition)</description></item>
                /// <item><description><b>SD-NBV1</b> (standard definition)</description></item>
                /// <item><description><b>HD-NBV1</b> (high definition)</description></item>
                /// <item><description><b>FHD-NBV1</b> (full high definition)</description></item>
                /// <item><description><b>2K-NBV1</b></description></item>
                /// <item><description><b>4K-NBV1</b></description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The definition mark of transcoding templates cannot be modified.</description></item>
                /// <item><description>The audio and video resolution, bitrate, and other parameters of Narrowband HD 1.0 transcoding templates are built into the system and cannot be modified.</description></item>
                /// <item><description>Narrowband HD 1.0 transcoding templates can only be created in FLV, M3U8 (HLS), or MP4 format.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SD</para>
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                /// <summary>
                /// <para>The transcoding encryption configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;EncryptType&quot;:&quot;Private&quot;</para>
                /// </summary>
                [NameInMap("EncryptSetting")]
                [Validation(Required=false)]
                public string EncryptSetting { get; set; }

                /// <summary>
                /// <para>The segment setting parameters for transcoding. Required for HLS (JSON string).</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Segment&quot;: { &quot;Duration&quot;:&quot;6&quot; }</para>
                /// </summary>
                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public string MuxConfig { get; set; }

                /// <summary>
                /// <para>The packaging configuration. Only HLS adaptive bitrate streaming packaging and DASH packaging are supported (JSON string).</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;PackageType&quot;:&quot;HLSPackage&quot;,&quot;PackageConfig&quot;:{   &quot;BandWidth&quot;:&quot;900000&quot;  }</para>
                /// </summary>
                [NameInMap("PackageSetting")]
                [Validation(Required=false)]
                public string PackageSetting { get; set; }

                /// <summary>
                /// <para>The video rotation parameter. Controls the rotation angle of the video. For example, if set to 180, the video is flipped upside down. Value range: <c>[0,360]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                /// <summary>
                /// <para>The subtitle configuration (JSON string).</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;SubtitleUrl&quot;:&quot;<a href="http://outin-test.oss-cn-shanghai.aliyuncs.com/subtitles/c737fece-14f1-4364-b107-d5f7f8edde0e.ass%22,%22CharEncode%22:%22utf-8%22%7D%5D">http://outin-test.oss-cn-shanghai.aliyuncs.com/subtitles/c737fece-14f1-4364-b107-d5f7f8edde0e.ass&quot;,&quot;CharEncode&quot;:&quot;utf-8&quot;}]</a></para>
                /// </summary>
                [NameInMap("SubtitleList")]
                [Validation(Required=false)]
                public string SubtitleList { get; set; }

                /// <summary>
                /// <para>The transcoding template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The tracing watermark information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;Enable&quot;: true
                /// }</para>
                /// </summary>
                [NameInMap("TraceMark")]
                [Validation(Required=false)]
                public string TraceMark { get; set; }

                /// <summary>
                /// <para>The conditional transcoding parameters. Set this parameter if you want to perform basic logic checks based on the bitrate or resolution of the source file before outputting the transcoded video (JSON string).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;IsCheckReso&quot;:&quot;true&quot;,&quot;IsCheckResoFail&quot;:&quot;false&quot;,&quot;IsCheckVideoBitrate&quot;:&quot;false&quot;,&quot;IsCheckVideoBitrateFail&quot;:&quot;false&quot;,&quot;IsCheckAudioBitrate&quot;:&quot;false&quot;,&quot;IsCheckAudioBitrateFail&quot;:&quot;false&quot;}</para>
                /// </summary>
                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public string TransConfig { get; set; }

                /// <summary>
                /// <para>The custom transcoding output path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{MediaId}/transcoce_1</para>
                /// </summary>
                [NameInMap("TranscodeFileRegular")]
                [Validation(Required=false)]
                public string TranscodeFileRegular { get; set; }

                /// <summary>
                /// <para>The transcoding template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>696d29a11erc057*****a3acc398d02f4</para>
                /// </summary>
                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

                /// <summary>
                /// <para>The templatetype. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b> (default): a normal transcoding template. The PackageSetting parameter cannot be configured in Settings for this type of template.</description></item>
                /// <item><description><b>VideoPackage</b>: a video stream packaging template. This type of template first transcodes and then builds adaptive bitrate streaming. The PackageSetting parameter must be configured in Settings for this type of template.</description></item>
                /// <item><description><b>SubtitlePackage</b>: a subtitle packaging template. This type of template does not transcode but only builds the corresponding subtitle information into the adaptive bitrate streaming output file. The PackageSetting parameter must be configured in Settings for this type of template. This type of template cannot exist alone in a template group and must be configured together with a VideoPackage type template. Only one SubtitlePackage template can be configured in a template group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The video stream transcoding configuration parameters (JSON string).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Bitrate&quot;:&quot;900&quot;,&quot;Width&quot;:&quot;960&quot;,&quot;Remove&quot;:&quot;false&quot;,&quot;Fps&quot;:&quot;30&quot;}</para>
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

                /// <summary>
                /// <para>The IDs of associated image and text watermark templates.</para>
                /// </summary>
                [NameInMap("WatermarkIds")]
                [Validation(Required=false)]
                public List<string> WatermarkIds { get; set; }

            }

        }

    }

}
