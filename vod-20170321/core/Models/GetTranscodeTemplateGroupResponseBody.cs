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
        /// <para>The information about the transcoding template group.</para>
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
            /// <para>The time when the transcoding template group was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
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
            /// <item><description><b>Default</b></description></item>
            /// <item><description><b>NotDefault</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotDefault</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>Indicates whether the transcoding template group is locked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Disabled</b>: The template group is not locked.</description></item>
            /// <item><description><b>Enabled</b>: The template group is locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            /// <summary>
            /// <para>The time when the transcoding template group was last modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-12T11:20:51Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the transcoding template group.</para>
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
            /// <para>The information about the transcoding templates.</para>
            /// </summary>
            [NameInMap("TranscodeTemplateList")]
            [Validation(Required=false)]
            public List<GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList> TranscodeTemplateList { get; set; }
            public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList : TeaModel {
                /// <summary>
                /// <para>The transcoding configurations of the audio stream. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Codec\&quot;:\&quot;AAC\&quot;,\&quot;Remove\&quot;:\&quot;false\&quot;,\&quot;Bitrate\&quot;:\&quot;44\&quot;,\&quot;Samplerate\&quot;:\&quot;32000\&quot;,\&quot;Channels\&quot;:\&quot;2\&quot;,\&quot;Profile\&quot;:\&quot;aac_low\&quot;}</para>
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public string Audio { get; set; }

                /// <summary>
                /// <para>The clipping configurations of the video. The value is a JSON string. For example, this parameter is returned if you extract 5 seconds of content from a video to generate a new video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;TimeSpan\&quot;:{\&quot;Seek\&quot;:\&quot;1\&quot;,\&quot;Duration\&quot;:\&quot;5\&quot;}</para>
                /// </summary>
                [NameInMap("Clip")]
                [Validation(Required=false)]
                public string Clip { get; set; }

                /// <summary>
                /// <para>The format of the container used to encapsulate audio and video streams. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Format&quot;:&quot;m3u8&quot;</para>
                /// </summary>
                [NameInMap("Container")]
                [Validation(Required=false)]
                public string Container { get; set; }

                /// <summary>
                /// <para>The content of the copyright watermark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;Content&quot;: &quot;test&quot;
                /// }</para>
                /// </summary>
                [NameInMap("CopyrightMark")]
                [Validation(Required=false)]
                public string CopyrightMark { get; set; }

                /// <summary>
                /// <para>Valid values for the definition of a common transcoding template:</para>
                /// <list type="bullet">
                /// <item><description><b>LD</b>: low definition.</description></item>
                /// <item><description><b>SD</b>: standard definition.</description></item>
                /// <item><description><b>HD</b>: high definition.</description></item>
                /// <item><description><b>FHD</b>: ultra high definition.</description></item>
                /// <item><description><b>OD</b>: original quality.</description></item>
                /// <item><description><b>2K</b></description></item>
                /// <item><description><b>4K</b></description></item>
                /// <item><description><b>SQ</b>: standard sound quality.</description></item>
                /// <item><description><b>HQ</b>: high sound quality.</description></item>
                /// </list>
                /// <para>Valid values for the definition of a Narrowband HD™ 1.0 transcoding template:</para>
                /// <list type="bullet">
                /// <item><description><b>LD-NBV1</b>: low definition.</description></item>
                /// <item><description><b>SD-NBV1</b>: standard definition.</description></item>
                /// <item><description><b>HD-NBV1</b>: high definition.</description></item>
                /// <item><description><b>FHD-NBV1</b>: ultra high definition.</description></item>
                /// <item><description><b>2K-NBV1</b></description></item>
                /// <item><description><b>4K-NBV1</b></description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>You cannot change the definition of a transcoding template.</description></item>
                /// <item><description>You cannot modify the system parameters, such as the video resolution, audio resolution, and bitrate, of Narrowband HD™ 1.0 transcoding templates.</description></item>
                /// <item><description>You can create only Narrowband HD™ 1.0 transcoding templates that support the FLV, M3U8 (HLS), and MP4 output formats.</description></item>
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
                /// <para>The encryption configuration for transcoding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;EncryptType&quot;:&quot;Private&quot;</para>
                /// </summary>
                [NameInMap("EncryptSetting")]
                [Validation(Required=false)]
                public string EncryptSetting { get; set; }

                /// <summary>
                /// <para>The transcoding segment configurations. This parameter must be returned if HTTP-Live-Streaming (HLS) encryption is used. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Segment&quot;: { &quot;Duration&quot;:&quot;6&quot; }</para>
                /// </summary>
                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public string MuxConfig { get; set; }

                /// <summary>
                /// <para>The packaging configuration. Only HLS packaging and DASH packaging are supported. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;PackageType&quot;:&quot;HLSPackage&quot;,&quot;PackageConfig&quot;:{   &quot;BandWidth&quot;:&quot;900000&quot;  }</para>
                /// </summary>
                [NameInMap("PackageSetting")]
                [Validation(Required=false)]
                public string PackageSetting { get; set; }

                /// <summary>
                /// <para>The video rotation identifier. It is used to control the image rotation angle. For example, if you set this parameter to 180, the video image is turned upside down. Valid values: <c>[0,360]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                /// <summary>
                /// <para>The subtitle configurations. The value is a JSON string.</para>
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
                /// <para>The content of the tracing watermark.</para>
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
                /// <para>The conditional transcoding configurations. This parameter can be used if you want to determine the basic logic based on the bitrate and resolution of the source file before the video is transcoded. The value is a JSON-formatted string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;IsCheckReso&quot;:&quot;true&quot;,&quot;IsCheckResoFail&quot;:&quot;false&quot;,&quot;IsCheckVideoBitrate&quot;:&quot;false&quot;,&quot;IsCheckVideoBitrateFail&quot;:&quot;false&quot;,&quot;IsCheckAudioBitrate&quot;:&quot;false&quot;,&quot;IsCheckAudioBitrateFail&quot;:&quot;false&quot;}</para>
                /// </summary>
                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public string TransConfig { get; set; }

                /// <summary>
                /// <para>The custom path used to store the output files.</para>
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
                /// <para>The type of the transcoding template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b> (default): a common transcoding template. The PackageSetting parameter cannot be set for this type of template.</description></item>
                /// <item><description><b>VideoPackage</b>: a video stream package template. If this type of template is used, ApsaraVideo VOD transcodes a video into video streams in different bitrates and packages these video streams with a file. The PackageSetting parameter must be set for this type of template.</description></item>
                /// <item><description><b>SubtitlePackage</b>: a subtitle package template. If this type of template is used, ApsaraVideo VOD adds the subtitle information to the output file generated by packaging the multi-bitrate video streams of the corresponding video without transcoding. You must set the PackageSetting parameter for a subtitle package template and associate the subtitle package template with a video stream package template. A template group can contain only one subtitle package template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The transcoding configurations of the video stream. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Bitrate&quot;:&quot;900&quot;,&quot;Width&quot;:&quot;960&quot;,&quot;Remove&quot;:&quot;false&quot;,&quot;Fps&quot;:&quot;30&quot;}</para>
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

                /// <summary>
                /// <para>The IDs of the associated watermarks.</para>
                /// </summary>
                [NameInMap("WatermarkIds")]
                [Validation(Required=false)]
                public List<string> WatermarkIds { get; set; }

            }

        }

    }

}
