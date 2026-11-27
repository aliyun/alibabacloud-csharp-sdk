// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaConvertTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transcoding template group information.</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroup")]
        [Validation(Required=false)]
        public GetMediaConvertTemplateGroupResponseBodyTranscodeTemplateGroup TranscodeTemplateGroup { get; set; }
        public class GetMediaConvertTemplateGroupResponseBodyTranscodeTemplateGroup : TeaModel {
            /// <summary>
            /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multiple applications</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The creation time. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T08:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The group-level configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AutoStreamName&quot;:&quot;{RunId}_master&quot;}</para>
            /// </summary>
            [NameInMap("GroupConfig")]
            [Validation(Required=false)]
            public string GroupConfig { get; set; }

            /// <summary>
            /// <para>The modification time. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T08:00:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcTemplateGroup</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the template group, which is determined by the purpose of the first template in the group. Valid values: <b>Normal</b>: normal transcoding template group. <b>VideoPackage</b>: video packaging template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4c71a339fe52b4fa6f4527****</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// <para>The list of transcoding template configurations.</para>
            /// </summary>
            [NameInMap("TranscodeTemplateList")]
            [Validation(Required=false)]
            public List<GetMediaConvertTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList> TranscodeTemplateList { get; set; }
            public class GetMediaConvertTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList : TeaModel {
                /// <summary>
                /// <para>The transcoding parameters for the audio stream. The value is a JSON string that includes Codec, Bitrate, Samplerate, and Channels. The default value of Codec is AAC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Codec&quot;:&quot;AAC&quot;,&quot;Bitrate&quot;:&quot;128&quot;,&quot;Samplerate&quot;:&quot;44100&quot;}</para>
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public string Audio { get; set; }

                /// <summary>
                /// <para>The container format configuration. The value is a JSON string that includes Format. Valid values for Format: mp4, m3u8, and mpd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Format&quot;:&quot;m3u8&quot;}</para>
                /// </summary>
                [NameInMap("Container")]
                [Validation(Required=false)]
                public string Container { get; set; }

                /// <summary>
                /// <para>The definition identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HD</para>
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                /// <summary>
                /// <para>The encryption configuration. The value is a JSON string that includes EncryptType and EncryptConfig.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;EncryptType&quot;:&quot;Private&quot;}</para>
                /// </summary>
                [NameInMap("EncryptSetting")]
                [Validation(Required=false)]
                public string EncryptSetting { get; set; }

                /// <summary>
                /// <para>The muxing parameters. The value is a JSON string. When you generate an m3u8 file, you can set Segment.Duration to specify the segment duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Segment&quot;:{&quot;Duration&quot;:&quot;10&quot;}}</para>
                /// </summary>
                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public string MuxConfig { get; set; }

                /// <summary>
                /// <para>The packaging configuration. The value is a JSON string that includes PackageType. This parameter is used for video and subtitle packaging templates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;PackageType&quot;:&quot;HLSPackage&quot;}</para>
                /// </summary>
                [NameInMap("PackageSetting")]
                [Validation(Required=false)]
                public string PackageSetting { get; set; }

                /// <summary>
                /// <para>The list of subtitle configurations. The value is a JSON string array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;Language&quot;:&quot;eng&quot;}]</para>
                /// </summary>
                [NameInMap("SubtitleList")]
                [Validation(Required=false)]
                public string SubtitleList { get; set; }

                /// <summary>
                /// <para>The name of the transcoding template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hd-720p</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The general transcoding configuration. The value is a JSON string that includes TransMode and other parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;TransMode&quot;:&quot;ONE&quot;}</para>
                /// </summary>
                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public string TransConfig { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4c71a339fe52b4fa6f4527****</para>
                /// </summary>
                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

                /// <summary>
                /// <para>The templatetype. Valid values: <b>Normal</b>: normal transcoding template. <b>VideoPackage</b>: video packaging template. <b>SubtitlePackage</b>: subtitle packaging template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The transcoding parameters for the video stream. The value is a JSON string that includes Codec, Bitrate, Width, Height, and Fps. The default value of Codec is H.264.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Bitrate&quot;:&quot;2000&quot;,&quot;Width&quot;:&quot;1280&quot;,&quot;Height&quot;:&quot;720&quot;}</para>
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

                /// <summary>
                /// <para>The list of watermark template IDs.</para>
                /// </summary>
                [NameInMap("WatermarkIds")]
                [Validation(Required=false)]
                public List<string> WatermarkIds { get; set; }

            }

        }

    }

}
