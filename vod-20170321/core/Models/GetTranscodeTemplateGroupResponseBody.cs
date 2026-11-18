// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6730AC93-7B12-4B*****7F-49EE1FE8BC49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data of the transcoding template group.</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroup")]
        [Validation(Required=false)]
        public GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup TranscodeTemplateGroup { get; set; }
        public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the template group was created. The time follows the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-12T10:20:51Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the template group is the default template group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: The default template group.</description></item>
            /// <item><description><b>NotDefault</b>: A non-default template group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotDefault</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>Specifies whether the template group is locked. Valid values:</para>
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
            /// <para>The time when the template group was modified. The time follows the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
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
            /// <para>The ID of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a59b11f697c716*****6ae1502142d0</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// <para>The list of transcoding template configuration information.</para>
            /// </summary>
            [NameInMap("TranscodeTemplateList")]
            [Validation(Required=false)]
            public List<GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList> TranscodeTemplateList { get; set; }
            public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList : TeaModel {
                /// <summary>
                /// <para>The transcoding configuration parameters for the audio stream. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Remove&quot;:&quot;false&quot;,&quot;Bitrate&quot;:&quot;44&quot;,&quot;Samplerate&quot;:&quot;32000&quot;,&quot;Channels&quot;:&quot;2&quot;,&quot;Profile&quot;:&quot;aac_low&quot;}</para>
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public string Audio { get; set; }

                /// <summary>
                /// <para>The video clipping configuration. The value is a JSON string. For example, if you need to extract 5 seconds of content from a video to generate a new video, you can set this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;TimeSpan&quot;:{&quot;Seek&quot;:&quot;1&quot;,&quot;Duration&quot;:&quot;5&quot;}</para>
                /// </summary>
                [NameInMap("Clip")]
                [Validation(Required=false)]
                public string Clip { get; set; }

                /// <summary>
                /// <para>The container format that encapsulates the audio and video streams. The value is a JSON string.</para>
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
                ///     &quot;Content&quot;: &quot;Test copyright watermark text&quot;
                /// }</para>
                /// </summary>
                [NameInMap("CopyrightMark")]
                [Validation(Required=false)]
                public string CopyrightMark { get; set; }

                /// <summary>
                /// <para>The definition tags for standard transcoding templates:</para>
                /// <list type="bullet">
                /// <item><description><b>LD</b> (Smooth)</description></item>
                /// <item><description><b>SD</b> (Standard definition)</description></item>
                /// <item><description><b>HD</b> (High definition)</description></item>
                /// <item><description><b>FHD</b> (Full high definition)</description></item>
                /// <item><description><b>OD</b> (Original definition, which means container format conversion)</description></item>
                /// <item><description><b>2K</b></description></item>
                /// <item><description><b>4K</b></description></item>
                /// <item><description><b>SQ</b> (Standard sound quality)</description></item>
                /// <item><description><b>HQ</b> (High sound quality)</description></item>
                /// </list>
                /// <para>The definition tags for built-in Narrowband HD™ 1.0 transcoding templates:</para>
                /// <list type="bullet">
                /// <item><description><b>LD-NBV1</b> (Smooth)</description></item>
                /// <item><description><b>SD-NBV1</b> (Standard definition)</description></item>
                /// <item><description><b>HD-NBV1</b> (High definition)</description></item>
                /// <item><description><b>FHD-NBV1</b> (Full high definition)</description></item>
                /// <item><description><b>2K-NBV1</b></description></item>
                /// <item><description><b>4K-NBV1</b></description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>You cannot modify the definition tags of transcoding templates.</description></item>
                /// <item><description>The audio and video resolutions, bitrates, and other parameters of Narrowband HD™ 1.0 transcoding templates are built-in and cannot be modified.</description></item>
                /// <item><description>Narrowband HD™ 1.0 transcoding templates support only the FLV, M3U8 (HLS), and MP4 formats.</description></item>
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
                /// <para>The encryption configuration information for transcoding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;EncryptType&quot;:&quot;Private&quot;</para>
                /// </summary>
                [NameInMap("EncryptSetting")]
                [Validation(Required=false)]
                public string EncryptSetting { get; set; }

                /// <summary>
                /// <para>The segment settings for transcoding. This parameter is required for HLS. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Segment&quot;: { &quot;Duration&quot;:&quot;6&quot; }</para>
                /// </summary>
                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public string MuxConfig { get; set; }

                /// <summary>
                /// <para>The packaging configuration. Only HLS adaptive bitrate streaming packaging and DASH packaging are supported. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;PackageType&quot;:&quot;HLSPackage&quot;,&quot;PackageConfig&quot;:{   &quot;BandWidth&quot;:&quot;900000&quot;  }</para>
                /// </summary>
                [NameInMap("PackageSetting")]
                [Validation(Required=false)]
                public string PackageSetting { get; set; }

                /// <summary>
                /// <para>The video rotation parameter. This parameter controls the rotation angle of the video image. For example, if you set this parameter to 180, the video image is upside down. Valid values: <c>[0,360]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                /// <summary>
                /// <para>The subtitle configuration. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;SubtitleUrl&quot;:&quot;<a href="http://outin-test.oss-cn-shanghai.aliyuncs.com/subtitles/c737fece-14f1-4364-b107-d5f7f8edde0e.ass%22,%22CharEncode%22:%22utf-8%22%7D%5D">http://outin-test.oss-cn-shanghai.aliyuncs.com/subtitles/c737fece-14f1-4364-b107-d5f7f8edde0e.ass&quot;,&quot;CharEncode&quot;:&quot;utf-8&quot;}]</a></para>
                /// </summary>
                [NameInMap("SubtitleList")]
                [Validation(Required=false)]
                public string SubtitleList { get; set; }

                /// <summary>
                /// <para>The name of the transcoding template.</para>
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
                /// <para>The conditional transcoding parameters. If you need to make basic logical judgments based on the bitrate and resolution of the source video before outputting the transcoded video, you can set this parameter. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;IsCheckReso&quot;:&quot;true&quot;,&quot;IsCheckResoFail&quot;:&quot;false&quot;,&quot;IsCheckVideoBitrate&quot;:&quot;false&quot;,&quot;IsCheckVideoBitrateFail&quot;:&quot;false&quot;,&quot;IsCheckAudioBitrate&quot;:&quot;false&quot;,&quot;IsCheckAudioBitrateFail&quot;:&quot;false&quot;}</para>
                /// </summary>
                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public string TransConfig { get; set; }

                /// <summary>
                /// <para>The custom output path for transcoding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{MediaId}/transcoce_1</para>
                /// </summary>
                [NameInMap("TranscodeFileRegular")]
                [Validation(Required=false)]
                public string TranscodeFileRegular { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template.</para>
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
                /// <item><description><b>Normal</b> (default): A standard transcoding template. You cannot configure the Settings for the PackageSetting parameter for this type of template.</description></item>
                /// <item><description><b>VideoPackage</b>: A video stream packaging template. This type of template transcodes the video stream first and then builds an adaptive bitrate stream. You must configure the Settings for the PackageSetting parameter.</description></item>
                /// <item><description><b>SubtitlePackage</b>: A subtitle packaging template. This type of template does not transcode the video stream. It only builds the corresponding subtitle information into the adaptive bitrate output file. You must configure the Settings for the PackageSetting parameter. This type of template cannot exist independently in a template group and must be configured together with a VideoPackage template. You can configure only one SubtitlePackage template in a template group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The transcoding configuration parameters for the video stream. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Bitrate&quot;:&quot;900&quot;,&quot;Width&quot;:&quot;960&quot;,&quot;Remove&quot;:&quot;false&quot;,&quot;Fps&quot;:&quot;30&quot;}</para>
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

                /// <summary>
                /// <para>The IDs of the associated image and text watermark templates.</para>
                /// </summary>
                [NameInMap("WatermarkIds")]
                [Validation(Required=false)]
                public List<string> WatermarkIds { get; set; }

            }

        }

    }

}
