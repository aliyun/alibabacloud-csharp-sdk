// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the transcoding template group.
        /// </summary>
        [NameInMap("TranscodeTemplateGroup")]
        [Validation(Required=false)]
        public GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup TranscodeTemplateGroup { get; set; }
        public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The time when the transcoding template group was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Indicates whether the template group is the default one. Valid values:
            /// 
            /// *   **Default**
            /// *   **NotDefault**
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// Indicates whether the transcoding template group is locked. Valid values:
            /// 
            /// *   **Disabled**: The template group is not locked.
            /// *   **Enabled**: The template group is locked.
            /// </summary>
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            /// <summary>
            /// The time when the transcoding template group was last modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The name of the transcoding template group.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the transcoding template group.
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// The information about the transcoding templates.
            /// </summary>
            [NameInMap("TranscodeTemplateList")]
            [Validation(Required=false)]
            public List<GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList> TranscodeTemplateList { get; set; }
            public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList : TeaModel {
                /// <summary>
                /// The transcoding configurations of the audio stream. The value is a JSON string.
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public string Audio { get; set; }

                /// <summary>
                /// The clipping configurations of the video. The value is a JSON string. For example, this parameter is returned if you extract 5 seconds of content from a video to generate a new video.
                /// </summary>
                [NameInMap("Clip")]
                [Validation(Required=false)]
                public string Clip { get; set; }

                /// <summary>
                /// The format of the container used to encapsulate audio and video streams. The value is a JSON string.
                /// </summary>
                [NameInMap("Container")]
                [Validation(Required=false)]
                public string Container { get; set; }

                /// <summary>
                /// The content of the copyright watermark.
                /// </summary>
                [NameInMap("CopyrightMark")]
                [Validation(Required=false)]
                public string CopyrightMark { get; set; }

                /// <summary>
                /// Valid values for the definition of a common transcoding template:
                /// 
                /// *   **LD**: low definition.
                /// *   **SD**: standard definition.
                /// *   **HD**: high definition.
                /// *   **FHD**: ultra high definition.
                /// *   **OD**: original quality.
                /// *   **2K**
                /// *   **4K**
                /// *   **SQ**: standard sound quality.
                /// *   **HQ**: high sound quality.
                /// 
                /// Valid values for the definition of a Narrowband HD™ 1.0 transcoding template:
                /// 
                /// *   **LD-NBV1**: low definition.
                /// *   **SD-NBV1**: standard definition.
                /// *   **HD-NBV1**: high definition.
                /// *   **FHD-NBV1**: ultra high definition.
                /// *   **2K-NBV1**
                /// *   **4K-NBV1**
                /// 
                /// > *   You cannot change the definition of a transcoding template.
                /// >*   You cannot modify the system parameters, such as the video resolution, audio resolution, and bitrate, of Narrowband HD™ 1.0 transcoding templates.
                /// >*   You can create only Narrowband HD™ 1.0 transcoding templates that support the FLV, M3U8 (HLS), and MP4 output formats.
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                /// <summary>
                /// The encryption configuration for transcoding.
                /// </summary>
                [NameInMap("EncryptSetting")]
                [Validation(Required=false)]
                public string EncryptSetting { get; set; }

                /// <summary>
                /// The transcoding segment configurations. This parameter must be returned if HTTP-Live-Streaming (HLS) encryption is used. The value is a JSON string.
                /// </summary>
                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public string MuxConfig { get; set; }

                /// <summary>
                /// The packaging configuration. Only HLS packaging and DASH packaging are supported. The value is a JSON string.
                /// </summary>
                [NameInMap("PackageSetting")]
                [Validation(Required=false)]
                public string PackageSetting { get; set; }

                /// <summary>
                /// The video rotation identifier. It is used to control the image rotation angle. For example, if you set this parameter to 180, the video image is turned upside down. Valid values: `[0,360]`.
                /// </summary>
                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                /// <summary>
                /// The subtitle configurations. The value is a JSON string.
                /// </summary>
                [NameInMap("SubtitleList")]
                [Validation(Required=false)]
                public string SubtitleList { get; set; }

                /// <summary>
                /// The name of the transcoding template.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// The content of the tracing watermark.
                /// </summary>
                [NameInMap("TraceMark")]
                [Validation(Required=false)]
                public string TraceMark { get; set; }

                /// <summary>
                /// The conditional transcoding configurations. This parameter can be used if you want to determine the basic logic based on the bitrate and resolution of the source file before the video is transcoded. The value is a JSON-formatted string.
                /// </summary>
                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public string TransConfig { get; set; }

                /// <summary>
                /// The custom path used to store the output files.
                /// </summary>
                [NameInMap("TranscodeFileRegular")]
                [Validation(Required=false)]
                public string TranscodeFileRegular { get; set; }

                /// <summary>
                /// The transcoding template ID.
                /// </summary>
                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

                /// <summary>
                /// The type of the transcoding template. Valid values:
                /// 
                /// *   **Normal** (default): a common transcoding template. The PackageSetting parameter cannot be set for this type of template.
                /// *   **VideoPackage**: a video stream package template. If this type of template is used, ApsaraVideo VOD transcodes a video into video streams in different bitrates and packages these video streams with a file. The PackageSetting parameter must be set for this type of template.
                /// *   **SubtitlePackage**: a subtitle package template. If this type of template is used, ApsaraVideo VOD adds the subtitle information to the output file generated by packaging the multi-bitrate video streams of the corresponding video without transcoding. You must set the PackageSetting parameter for a subtitle package template and associate the subtitle package template with a video stream package template. A template group can contain only one subtitle package template.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The transcoding configurations of the video stream. The value is a JSON string.
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

                /// <summary>
                /// The IDs of the associated watermarks.
                /// </summary>
                [NameInMap("WatermarkIds")]
                [Validation(Required=false)]
                public List<string> WatermarkIds { get; set; }

            }

        }

    }

}
